Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class SearchFilterSubForm

    'データベース接続文字列
    Private ConnectionString As String = "Server=172.17.145.21;Port=3306;Database=Kadai2;Uid=root;Pwd=musasiand;"
    'データベース接続準備
    Private cn As New MySqlConnection(ConnectionString)     'Kadai2データベースへの接続用
    Private cmd As New MySqlCommand()

    'メインフォームとのデータ受け渡し用
    Private _FilterText As List(Of String)
    Private Sub SearchFilterSubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '全選択ボタンを押す
        btnCheckAll_Click(sender, e)

        '=============== コンボボックス作成 ====================
        'コンボボックスのデータ取得
        Dim dtCategory As New DataTable()
        Dim dtItemCombo As New DataTable()
        Dim dtBranchCombo As New DataTable()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM CategoryComboData"
        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(dtCategory)
        End Using

        cmd.CommandText = "SELECT * FROM ItemNameComboData"
        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(dtItemCombo)
        End Using

        cmd.CommandText = "SELECT * FROM BranchNameComboData"
        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(dtBranchCombo)
        End Using


        'コンボボックスの設定
        comCategory.DataSource = dtCategory
        comCategory.DisplayMember = "大分類名称"
        comCategory.ValueMember = "大分類名称"
        comCategory.SelectedValue = -1

        comItem.DataSource = dtItemCombo
        comItem.DisplayMember = "商品名"
        comItem.ValueMember = "商品名"
        comItem.SelectedValue = -1

        comBranch.DataSource = dtBranchCombo
        comBranch.DisplayMember = "支店名"
        comBranch.ValueMember = "支店名"
        comBranch.SelectedValue = -1
        '========================================================
    End Sub

    Public Sub New(FilterText As List(Of String))

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '文字列の配列(フィルターの受け皿)の参照を受け取り、値を挿入して初期化する。
        _FilterText = FilterText


    End Sub

    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click
        'グループボックス内のチェックボックスにすべてチェックを入れる
        For Each con As Control In gbxCheckBox.Controls
            If TypeOf con Is CheckBox Then
                CType(con, CheckBox).Checked = True
            End If
        Next
    End Sub

    Private Sub btnUnCheckAll_Click(sender As Object, e As EventArgs) Handles btnUnCheckAll.Click
        'グループボックス内のチェックボックスの全チェックを外す
        For Each con As Control In gbxCheckBox.Controls
            If TypeOf con Is CheckBox Then
                CType(con, CheckBox).Checked = False
            End If
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '初期化
        _FilterText.Clear()

        'テキストフィルター1　年月【自】
        If chb1.Checked = False OrElse txtStartDate.Text = "" Then
            _FilterText.Add("NULL")
        Else
            _FilterText.Add(txtStartDate.Text)
        End If
        'テキストフィルター2　年月【至】
        If chb2.Checked = False OrElse txtEndDate.Text = "" Then
            _FilterText.Add("NULL")
        Else
            _FilterText.Add(txtEndDate.Text)
        End If
        'テキストフィルター3　顧客名
        If chb3.Checked = False OrElse txtCustomerName.Text = "" Then
            _FilterText.Add("NULL")
        Else
            _FilterText.Add(txtCustomerName.Text)
        End If
        'テキストフィルター4　電話番号
        If chb4.Checked = False OrElse txtPhoneNum.Text = "" Then
            _FilterText.Add("NULL")
        Else
            _FilterText.Add(txtPhoneNum.Text)
        End If
        'テキストフィルター5 大分類名称
        If chb5.Checked = False OrElse comCategory.SelectedIndex = -1 Then
            _FilterText.Add("NULL")
        Else
            'コンボボックスの大分類番号部分(先頭２文字)だけ取り出す
            _FilterText.Add(comCategory.SelectedValue.ToString().Substring(0, 2))
        End If
        'テキストフィルター6 支店名
        If chb6.Checked = False OrElse comBranch.SelectedIndex = -1 Then
            _FilterText.Add("NULL")
        Else
            'コンボボックスの支店番号部分(先頭3文字)だけ取り出す
            _FilterText.Add(comBranch.SelectedValue.ToString().Substring(0, 2))
        End If
        'テキストフィルター7 商品番号
        If chb7.Checked = False OrElse comItem.SelectedIndex = -1 Then
            _FilterText.Add("NULL")
        Else
            'コンボボックスの商品番号部分(先頭5文字)だけ取り出す
            _FilterText.Add(comItem.SelectedValue.ToString().Substring(0, 5))
        End If
        'テキストフィルター8　ポイント上限
        If chb8.Checked = False OrElse txtUpperLimit.Text = "" Then
            _FilterText.Add("NULL")
        Else
            _FilterText.Add(txtUpperLimit.Text)
        End If
        'テキストフィルター9　ポイント下限
        If chb9.Checked = False OrElse txtLowerLimit.Text = "" Then
            _FilterText.Add("NULL")
        Else
            _FilterText.Add(txtLowerLimit.Text)
        End If
        'テキストフィルター10  未設定
        'If chb10.Checked = False OrElse TextBox10.Text = "" Then
        '    _FilterText.Add("NULL")
        'Else
        '    _FilterText.Add(TextBox10.Text)
        'End If

        '親フォームにデータ取得させる。
        My.Forms.SalesManagementForm.GetDipslayData()

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtStartDate.Validating
        '入力されているか確認  入力されていなければ処理終了
        If txtStartDate.Text = "" Then
            Exit Sub
        End If

        '入力されていれば、内容の検証
        Dim input As String = txtStartDate.Text
        Dim pattern As String
        '入力範囲 1900/01 ～ 2200/12 としておく 区切りは/か-を許可する
        pattern = "^(19[0-9]{2}|2[0-1][0-9]{2}|2200)([/-])(0?[1-9]|1[0-2])$"
        Dim res As Boolean = Regex.IsMatch(input, pattern)

        If res = False Then
            '再度入力促す
            MsgBox("不正な入力形式です。" & vbCrLf & "2000-01 か 2000/01 の形式で入力してください。")
            e.Cancel = True
        End If
    End Sub

    Private Sub TextBox9_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEndDate.Validating
        '入力されているか確認  入力されていなければ処理終了
        If txtEndDate.Text = "" Then
            Exit Sub
        End If

        '入力されていれば、内容の検証
        Dim input As String = txtEndDate.Text
        Dim pattern As String
        '入力範囲 1900/01 ～ 2200/12 としておく 区切りは/か-を許可する
        pattern = "^(19[0-9]{2}|2[0-1][0-9]{2}|2200)([/-])(0?[1-9]|1[0-2])$"
        Dim res As Boolean = Regex.IsMatch(input, pattern)

        If res = False Then
            '再度入力促す
            MsgBox("不正な入力形式です。" & vbCrLf & "2000-01 か 2000/01 の形式で入力してください。")
            e.Cancel = True
        End If

    End Sub
    Private Sub btnTextReset_Click(sender As Object, e As EventArgs) Handles btnTextReset.Click

        '全項目リセット
        For Each control As Control In gbxFilterText.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Text = ""
            ElseIf TypeOf control Is ComboBox Then
                CType(control, ComboBox).SelectedIndex = -1
            End If
        Next

        '全選択ボタンを押すのと同じ
        btnCheckAll_Click(sender, e)
    End Sub
    Private Sub txtStartDate_Validated(sender As Object, e As EventArgs) Handles txtStartDate.Validated
        '入力されているか確認  入力されていなければ処理終了
        If txtEndDate.Text = "" Then
            Exit Sub
        End If

        '入力されていれば,区切り文字が-かどうかを確認して、-なら/に置き換える
        Dim input As String = txtStartDate.Text
        txtStartDate.Text = Regex.Replace(input, "-", "/")


    End Sub

    Private Sub SearchFilterSubForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '×ボタン押したら、閉じるのをやめて隠す
        e.Cancel = True
        Me.Hide()
    End Sub
End Class