Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class OrderInput
    '接続文字列
    Dim connectionstring As String = "Server=172.17.145.21;Port=3306;Database=Kadai2;Uid=root;Pwd=musasiand;"
    Private cn As New MySqlConnection(connectionstring)
    Private cmd_Order As New MySqlCommand()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dtOrder As New DataTable()

        cmd_Order.Connection = cn
        cmd_Order.CommandType = CommandType.Text
        cmd_Order.CommandText = "SELECT * FROM OrderData"

        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd_Order
            adapter.Fill(dtOrder)
        End Using
        DataGridView1.DataSource = dtOrder

        ' ドロップダウン用データ選択
        Dim customer_name As New DataTable()
        cmd_Order.CommandText =
            "SELECT 
                customer_num,
                last_name,
                first_name
             FROM CustomerMaster"
        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd_Order
            adapter.Fill(customer_name)
        End Using




    End Sub
    Private Sub InputForm()
        '入力用データテーブル作成関数
        Dim comColumn As New DataGridViewComboBoxColumn()

        comColumn.Name = "test1"
        comColumn.HeaderText = "選択test"

    End Sub




    Private dttest As New DataTable()
    Private InputData As New DataTable()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim i As Integer = 0
        For Each Cname As String In OrderTableColumn_JP
            dttest.Columns.Add(Cname, OrderTableColumn_Type(i))
            i += 1
        Next

        DataGridView1.DataSource = dttest


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim newrow As DataRow
        For i = 1 To 10
            newrow = dttest.NewRow
            newrow("行") = i
            dttest.Rows.Add(newrow)
        Next

        Dim comboColumn As New DataGridViewComboBoxColumn
        comboColumn.Name = "顧客名"
        comboColumn.HeaderText = "顧客名【選択】"

        comboColumn.DataSource = New String() {"A", "B", "C"}
        comboColumn.ValueType = GetType(String)

        'DataGridView1.Columns.Add(comboColumn)
        DataGridView1.Columns.Insert(2, comboColumn)



        'DataGridView1.DataSource = dttest
        'DataGridView2.DataSource = dttest

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '挿入データ保存用のデータテーブル作成
        Dim newTable As New DataTable()

        '列名をコピー
        For Each column As DataGridViewColumn In DataGridView1.Columns
            newTable.Columns.Add(column.Name)
        Next column

        '行データコピー
        Dim newRow As DataRow
        For Each d As DataGridViewRow In DataGridView1.Rows
            newRow = newTable.NewRow()
            For i As Integer = 0 To DataGridView1.Columns.Count - 1
                newRow.Item(i) = d.Cells(i).Value
            Next i
            newTable.Rows.Add(newRow)
        Next d

        DataGridView2.DataSource = newTable


    End Sub
End Class


'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'    Dim a As Integer = 10
'    For i As Integer = 1 To a
'        TextBox2.Text += i.ToString()
'    Next

'    Dim b As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
'    Dim c As New List(Of Integer)

'    Dim num As Integer = 9
'    For i As Integer = 0 To num
'        c.Add(i)
'    Next

'    TextBox2.Clear()
'    For Each N As Integer In c
'        TextBox2.Text += N.ToString()
'    Next


'End Sub