Imports MySql.Data.MySqlClient


Public Class SalesManagementForm

    'サブフォームの詳細検索から検索用テキストデータの受取用辞書
    Public FilterTextList As New List(Of String)

    'データベース接続文字列
    Private ConnectionString As String = "Server=172.17.145.21;Port=3306;Database=Kadai2;Uid=root;Pwd=musasiand;"
    'データベース接続準備
    Private cn As New MySqlConnection(ConnectionString)     'Kadai2データベースへの接続用
    Private cmd As New MySqlCommand()

    '====   ページング用   =======
    'Private dsDataAndCount As New DataSet()
    Private dtDisplayData As DataTable
    Private dtCount As DataTable            '抽出したデータのレコード数を記録したテーブル
    Private current_index As Integer = 0     '現在表示しているページのindex(0:1ページ目) 
    Private db_count As Integer             '抽出したデータの件数

    '表示用
    Private max_page As Integer             '表示できる最大ページ数
    Private current_page_num As Integer = 1 'current_index + 1
    '=============================
    Private Sub SalesManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FilterSubForm As Form = New SearchFilterSubForm(FilterTextList)
        FilterSubForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '現在のページ数を初期化
        current_index = 0

        'データを取得
        '接続準備
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SalesDisplay"

        'パラメータ設定
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@A_offset", current_index)
        cmd.Parameters.AddWithValue("@A_Max_row", MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_date", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_customer_num", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_phone_num", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_branch_num", DBNull.Value)

        'データ取得
        Dim ds As New DataSet()
        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
        End Using

        'ページングのページ数、最大ページの計算、初期化
        dtCount = ds.Tables(1)
        Dim Count As Integer = dtCount.Rows(0)(0)        'データ件数
        max_page = Math.Ceiling(Count / MaxRowNum_SalesManagement)      '最大ページ数を初期化
        current_page_num = 1                                            '現在のページ数を初期化
        'ページング数表示
        txtCurrentPageNum.Text = current_page_num
        txtMaxPage.Text = max_page


        'データの表示設定
        dtDisplayData = ds.Tables(0)
        DataGridView1.DataSource = dtDisplayData





    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'current_indexが0より大きければ(1ページ目じゃなければ)現在のページをデクリメントする
        '違ったら何も処理しない
        If current_index > 0 Then
            current_index -= 1
            current_page_num = current_index + 1
        Else
            Exit Sub
        End If
        '現在のページ数表示
        txtCurrentPageNum.Text = current_page_num

        '接続準備
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SalesDisplay"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@A_offset", current_index * MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_Max_row", MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_date", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_customer_num", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_phone_num", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_branch_num", DBNull.Value)

        'データ取得
        Dim ds As New DataSet()
        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
        End Using

        'ページングのページ数、最大ページの計算、初期化
        dtCount = ds.Tables(1)
        Dim Count As Integer = dtCount.Rows(0)(0)                       'データ件数取得
        max_page = Math.Ceiling(Count / MaxRowNum_SalesManagement)      '最大ページ数を初期化
        txtMaxPage.Text = max_page                                      '最大ページ数表示の更新

        'データの表示設定
        dtDisplayData = ds.Tables(0)
        DataGridView1.DataSource = dtDisplayData

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'current_indexがmax_page -1 未満であれば現在のページをインクリメントする
        If current_index < max_page - 1 Then
            current_index += 1
            current_page_num = current_index + 1
        Else
            Exit Sub
        End If
        '現在のページ数表示
        txtCurrentPageNum.Text = current_page_num

        '接続準備
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SalesDisplay"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@A_offset", current_index * MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_Max_row", MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_date", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_customer_num", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_phone_num", DBNull.Value)
        cmd.Parameters.AddWithValue("@A_branch_num", DBNull.Value)

        'データ取得
        Dim ds As New DataSet()
        Using adapter As New MySqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
        End Using

        'ページングのページ数、最大ページの計算、初期化
        dtCount = ds.Tables(1)
        Dim Count As Integer = dtCount.Rows(0)(0)                       'データ件数取得
        max_page = Math.Ceiling(Count / MaxRowNum_SalesManagement)      '最大ページ数を初期化
        txtMaxPage.Text = max_page                                      '最大ページ数表示の更新

        'データの表示設定
        dtDisplayData = ds.Tables(0)
        DataGridView1.DataSource = dtDisplayData

    End Sub
End Class