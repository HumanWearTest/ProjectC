Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class OrderInput
    '接続文字列
    Dim connectionstring As String = "Server=172.17.145.21;Port=3306;Database=Kadai2;Uid=root;Pwd=musasiand;"
    Private cn As New MySqlConnection(connectionstring)     'Kadai2データベースへの接続用
    Private dtOrder As New DataTable()                      '受注入力の入力用データテーブル

    Private dttest As New DataTable()
    Private InputData As New DataTable()

    Private comCustomerName As New DataTable()
    Private comItemName As New DataTable()
    Private comBranchName As New DataTable()

    Private Sub OrderInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '=============  入力用DataGridViewの設定  =======================
        'ドロップダウンの列の設定変更用変数の定義
        Dim comboColumn As DataGridViewComboBoxColumn

        ''顧客名ドロップダウンのデータ作成
        Dim cmd As New MySqlCommand()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM CustomerComboData;"
        cmd.CommandType = CommandType.Text

        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(comCustomerName)
        End Using

        '顧客名の列にデータソースを指定
        comboColumn = CType(DataGridView1.Columns("顧客名"), DataGridViewComboBoxColumn)
        comboColumn.DisplayMember = "顧客名"
        comboColumn.ValueMember = "顧客名"
        comboColumn.DataSource = comCustomerName


        '商品名ドロップダウンのデータ作成
        cmd.CommandText = "SELECT * FROM ItemNameComboData;"
        cmd.CommandType = CommandType.Text

        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(comItemName)
        End Using

        '商品名の列にデータソースを指定
        comboColumn = CType(DataGridView1.Columns("商品名"), DataGridViewComboBoxColumn)
        comboColumn.DisplayMember = "商品名"
        comboColumn.ValueMember = "商品名"
        comboColumn.DataSource = comItemName


        '支店名ドロップダウンのデータ作成
        cmd.CommandText = "SELECT * FROM BranchNameComboData;"
        cmd.CommandType = CommandType.Text

        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(comBranchName)
        End Using

        '支店名の列にデータソースを指定
        comboColumn = CType(DataGridView1.Columns("支店名"), DataGridViewComboBoxColumn)
        comboColumn.DisplayMember = "支店名"
        comboColumn.ValueMember = "支店名"
        comboColumn.DataSource = comBranchName

        '10行分の番号を入れておく
        For i As Integer = 1 To 10
            Dim newIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(newIndex).Cells("行").Value = i
        Next




        '=======================================================================
    End Sub
    Private Sub btn_test1_Click(sender As Object, e As EventArgs) Handles btn_test1.Click
        'ドロップダウン選択してある値に対応したデータの出力
        Dim sql As String
        Dim cmd As New MySqlCommand()

        cmd.Connection = cn
        cmd.CommandType = CommandType.Text

        '単価
        If Not DataGridView1.Rows(0).Cells("商品名").Value Is Nothing Then
            Dim str As String = DataGridView1.Rows(0).Cells("商品名").Value
            sql = "SELECT unit_price FROM ItemMaster " & "WHERE item_num = '" & str.Substring(0, 5) & "';"

            cmd.CommandText = sql
            Dim price As New DataTable()
            Dim numRow As Integer
            Using adapter As New MySqlDataAdapter()
                adapter.SelectCommand = cmd
                numRow = adapter.Fill(price)
            End Using

            If numRow = 1 Then
                DataGridView1.Rows(0).Cells("単価").Value = price(0)(0)
            Else
                MsgBox("エラー：単価が一つに絞られていません")
            End If
        End If

        '金額
        If (DataGridView1.Rows(0).Cells("単価").Value IsNot Nothing) And (DataGridView1.Rows(0).Cells("数量").Value IsNot Nothing) Then
            Dim res As Integer
            res = DataGridView1.Rows(0).Cells("単価").Value * DataGridView1.Rows(0).Cells("数量").Value
            DataGridView1.Rows(0).Cells("金額").Value = res
        End If

        '付与ポイント
        If DataGridView1.Rows(0).Cells("金額").Value IsNot Nothing Then
            DataGridView1.Rows(0).Cells("付与ポイント").Value = Math.Floor(CDec(DataGridView1.Rows(0).Cells("金額").Value) * 0.01)
        End If


    End Sub

    Private Sub btn_test2_Click(sender As Object, e As EventArgs) Handles btn_test2.Click
        Dim test As New DataTable()

        '列データコピー
        For Each c As DataGridViewColumn In DataGridView1.Columns
            test.Columns.Add(c.Name)
        Next

        '行データコピー
        Dim newrow As DataRow
        For Each dgvRow As DataGridViewRow In DataGridView1.Rows
            newrow = test.NewRow()
            For i As Integer = 0 To DataGridView1.Columns.Count - 1
                newrow(i) = dgvRow.Cells(i).Value
            Next
            '作成した行データをデータテーブルへ追加
            test.Rows.Add(newrow)
        Next

        DataGridView2.DataSource = test

    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        'セルに値が手入力され、セルを離れようとする時点で入力値が正しいかを確認する。
        '不正値であればメッセージを出して移動させない

        Select Case DataGridView1.Columns(e.ColumnIndex).Name
            Case "行", "顧客名", "商品名", "単価", "金額", ""
                'なにもしない
                Return

            Case "年月日"
                msg(DataGridView1.Columns(e.ColumnIndex).Name.ToString())

            Case "数量"
                msg(DataGridView1.Columns(e.ColumnIndex).Name.ToString())

            Case Else
                msg("想定外エラー")

        End Select

    End Sub

    Private Sub msg(message As String)
        ListBox1.Items.Clear()
        ListBox1.Items.Add(message)
    End Sub





End Class

''挿入データ保存用のデータテーブル作成
'Dim newTable As New DataTable()

''列名をコピー
'For Each column As DataGridViewColumn In DataGridView1.Columns
'newTable.Columns.Add(column.Name)
'Next column

''行データコピー
'Dim newRow As DataRow
'For Each d As DataGridViewRow In DataGridView1.Rows
'newRow = newTable.NewRow()
'For i As Integer = 0 To DataGridView1.Columns.Count - 1
'newRow.Item(i) = d.Cells(i).Value
'Next i
'newTable.Rows.Add(newRow)
'Next d

'DataGridView2.DataSource = newTable

'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'    Dim cmd As New MySqlCommand()

'    cmd.Connection = cn
'    cmd.CommandType = CommandType.Text
'    cmd.CommandText = "SELECT * FROM OrderData"

'    Using adapter As New MySqlDataAdapter()
'        adapter.SelectCommand = cmd
'        adapter.Fill(dtOrder)
'    End Using
'    DataGridView1.DataSource = dtOrder

'    ' 顧客名ドロップダウン用データ選択
'    Dim customer_name As New DataTable()
'    cmd.CommandText =
'            "SELECT * FROM CustomerComboData;"
'    Using adapter As New MySqlDataAdapter()
'        adapter.SelectCommand = cmd
'        adapter.Fill(customer_name)
'    End Using

'End Sub

