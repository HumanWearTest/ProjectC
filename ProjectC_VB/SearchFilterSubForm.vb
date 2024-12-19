Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class SearchFilterSubForm
    Dim numFilter As Integer = 10       'フィルターの項目数
    Private _FilterTextList As List(Of String)


    Public Sub New(FilterTextList As List(Of String))


        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '文字列の配列(フィルターの受け皿)の参照を受け取る
        _FilterTextList = FilterTextList

        For i As Integer = 1 To numFilter
            _FilterTextList.Add("")
        Next

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

        ''チェックボックスのチェック状態を配列として取得
        'Dim cfkList As New List(Of Boolean)
        'For Each cfkCon As Control In gbxCheckBox.Controls
        '    cfkList.Add(CType(cfkCon, CheckBox).Checked)
        'Next

        ''テキストボックスの文字列を配列として取得
        'Dim textList As New List(Of String)
        'For Each con As Control In gbxFilterText.Controls
        '    textList.Add(CType(con, TextBox).Text)
        'Next

        ''チェックボックスのチェック状況に応じて、trueならば_FilterTextListに入れる
        'For i As Integer = 0 To cfkList.Count - 1
        '    If cfkList(i) = True Then
        '        _FilterTextList(i) = textList(i)
        '    Else
        '        _FilterTextList(i) = "NULL"
        '    End If
        'Next

        'チェックボックスとテキストボックスのペア決め辞書
        Dim dicChecedTextBox As New Dictionary(Of CheckBox, Object) From
            {{chb1, txtStartDate},
            {chb2, txtEndDate},
            {chb3, txtCustomerName},
            {chb4, txtPhoneNum},
            {chb5, txtCategory},
            {chb6, TextBox5},
            {chb7, TextBox6},
            {chb8, txtUpperLimit},
            {chb9, txtLowerLimit},
            {chb10, TextBox10}}


        'Dim cfkList As New List(Of Boolean)
        For Each kvp As KeyValuePair(Of CheckBox, Object) In dicChecedTextBox
            'MsgBox(cfkCon.Name)
            'cfkList.Add(CType(cfkCon, CheckBox).Checked)

            If kvp.Key.Checked = True Then

            End If




        Next









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

        If res = True Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add(res.ToString())
        Else
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

        If res = True Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add(res.ToString())
        Else
            '再度入力促す
            MsgBox("不正な入力形式です。" & vbCrLf & "2000-01 か 2000/01 の形式で入力してください。")
            e.Cancel = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        For Each data As String In _FilterTextList
            ListBox1.Items.Add(data.ToString())
        Next
    End Sub
End Class