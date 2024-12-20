Imports MySql.Data.MySqlClient


Public Class SalesManagementForm

    'サブフォームの詳細検索から検索用テキストデータの受取用辞書
    Public FilterTextList As New List(Of String)()
    'サブフォームの初期化、インスタンス生成
    Private FilterSubForm As Form = New SearchFilterSubForm(FilterTextList)

    'データベース接続文字列
    Private ConnectionString As String = "Server=172.17.145.21;Port=3306;Database=Kadai2;Uid=root;Pwd=musasiand;"
    'データベース接続準備
    Private cn As New MySqlConnection(ConnectionString)     'Kadai2データベースへの接続用
    Private cmd As New MySqlCommand()

    '====   ページング用   =======
    'Private dsDataAndCount As New DataSet()
    Private dtDisplayData As DataTable
    Private dtCount As DataTable            '抽出したデータのレコード数を記録したテーブル
    Private current_index As Integer = 0    '現在表示しているページのindex(0:1ページ目) 
    Private db_count As Integer             '抽出したデータの件数

    '表示用
    Private max_page As Integer             '表示できる最大ページ数
    Private current_page_num As Integer = 1 'current_index + 1
    '=============================


    Private Sub SalesManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FilterSubForm.Show()
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

        'パラメータ設定
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@A_offset", current_index * MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_Max_row", MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_start_date", If(FilterTextList(0) = "NULL", DBNull.Value, FilterTextList(0)))
        cmd.Parameters.AddWithValue("@A_end_date", If(FilterTextList(1) = "NULL", DBNull.Value, FilterTextList(1)))
        cmd.Parameters.AddWithValue("@A_customer_name", If(FilterTextList(2) = "NULL", DBNull.Value, FilterTextList(2)))
        cmd.Parameters.AddWithValue("@A_phone_num", If(FilterTextList(3) = "NULL", DBNull.Value, FilterTextList(3)))
        cmd.Parameters.AddWithValue("@A_category_num", If(FilterTextList(4) = "NULL", DBNull.Value, FilterTextList(4)))
        cmd.Parameters.AddWithValue("@A_branch_num", If(FilterTextList(5) = "NULL", DBNull.Value, FilterTextList(5)))
        cmd.Parameters.AddWithValue("@A_item_num", If(FilterTextList(6) = "NULL", DBNull.Value, FilterTextList(6)))
        cmd.Parameters.AddWithValue("@A_upper_points", If(FilterTextList(7) = "NULL", DBNull.Value, FilterTextList(7)))
        cmd.Parameters.AddWithValue("@A_lower_points", If(FilterTextList(8) = "NULL", DBNull.Value, FilterTextList(8)))

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

        '列の見た目調整
        adjustColumnsFilterdData()
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

        'パラメータ設定
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@A_offset", current_index * MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_Max_row", MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_start_date", If(FilterTextList(0) = "NULL", DBNull.Value, FilterTextList(0)))
        cmd.Parameters.AddWithValue("@A_end_date", If(FilterTextList(1) = "NULL", DBNull.Value, FilterTextList(1)))
        cmd.Parameters.AddWithValue("@A_customer_name", If(FilterTextList(2) = "NULL", DBNull.Value, FilterTextList(2)))
        cmd.Parameters.AddWithValue("@A_phone_num", If(FilterTextList(3) = "NULL", DBNull.Value, FilterTextList(3)))
        cmd.Parameters.AddWithValue("@A_category_num", If(FilterTextList(4) = "NULL", DBNull.Value, FilterTextList(4)))
        cmd.Parameters.AddWithValue("@A_branch_num", If(FilterTextList(5) = "NULL", DBNull.Value, FilterTextList(5)))
        cmd.Parameters.AddWithValue("@A_item_num", If(FilterTextList(6) = "NULL", DBNull.Value, FilterTextList(6)))
        cmd.Parameters.AddWithValue("@A_upper_points", If(FilterTextList(7) = "NULL", DBNull.Value, FilterTextList(7)))
        cmd.Parameters.AddWithValue("@A_lower_points", If(FilterTextList(8) = "NULL", DBNull.Value, FilterTextList(8)))

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

        '列の見た目調整
        adjustColumnsFilterdData()
    End Sub


    Public Sub GetDipslayData()
        '現在のページ数を初期化
        current_index = 0

        'データを取得
        '接続準備
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SalesDisplay"

        'パラメータ設定
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@A_offset", current_index * MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_Max_row", MaxRowNum_SalesManagement)
        cmd.Parameters.AddWithValue("@A_start_date", If(FilterTextList(0) = "NULL", DBNull.Value, FilterTextList(0)))
        cmd.Parameters.AddWithValue("@A_end_date", If(FilterTextList(1) = "NULL", DBNull.Value, FilterTextList(1)))
        cmd.Parameters.AddWithValue("@A_customer_name", If(FilterTextList(2) = "NULL", DBNull.Value, FilterTextList(2)))
        cmd.Parameters.AddWithValue("@A_phone_num", If(FilterTextList(3) = "NULL", DBNull.Value, FilterTextList(3)))
        cmd.Parameters.AddWithValue("@A_category_num", If(FilterTextList(4) = "NULL", DBNull.Value, FilterTextList(4)))
        cmd.Parameters.AddWithValue("@A_branch_num", If(FilterTextList(5) = "NULL", DBNull.Value, FilterTextList(5)))
        cmd.Parameters.AddWithValue("@A_item_num", If(FilterTextList(6) = "NULL", DBNull.Value, FilterTextList(6)))
        cmd.Parameters.AddWithValue("@A_upper_points", If(FilterTextList(7) = "NULL", DBNull.Value, FilterTextList(7)))
        cmd.Parameters.AddWithValue("@A_lower_points", If(FilterTextList(8) = "NULL", DBNull.Value, FilterTextList(8)))

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

        '列の見た目調整
        adjustColumnsFilterdData()
    End Sub

    Private Sub adjustColumnsFilterdData()
        '列ヘッダーの高さ調整
        DataGridView1.ColumnHeadersHeight = 40

        '行の列　調整
        DataGridView1.Columns("行").Width = 40
        DataGridView1.Columns("行").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        '受注番号の列
        DataGridView1.Columns("受注番号").Width = 120
        DataGridView1.Columns("受注番号").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("受注番号").DefaultCellStyle.Format = "000000"

        '年月日の列
        DataGridView1.Columns("年月日").Width = 150
        DataGridView1.Columns("年月日").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        '顧客番号の列
        DataGridView1.Columns("顧客番号").Width = 120
        DataGridView1.Columns("顧客番号").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '顧客名の列
        DataGridView1.Columns("顧客名").Width = 140
        DataGridView1.Columns("顧客名").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        '商品番号の列
        DataGridView1.Columns("商品番号").Width = 120
        DataGridView1.Columns("商品番号").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '大分類番号の列
        DataGridView1.Columns("大分類番号").Width = 140
        DataGridView1.Columns("大分類番号").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '大分類名称の列
        DataGridView1.Columns("大分類名称").Width = 160
        DataGridView1.Columns("大分類名称").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        '商品名の列
        DataGridView1.Columns("商品名").Width = 235
        DataGridView1.Columns("商品名").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        '販売時単価の列
        DataGridView1.Columns("販売時単価").Width = 140
        DataGridView1.Columns("販売時単価").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("販売時単価").DefaultCellStyle.Format = "\\ #,##0"


        '数量の列
        DataGridView1.Columns("数量").Width = 80
        DataGridView1.Columns("数量").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("数量").DefaultCellStyle.Format = "#,##0"

        '金額の列
        DataGridView1.Columns("金額").Width = 140
        DataGridView1.Columns("金額").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("金額").DefaultCellStyle.Format = "\\ #,##0"


        '支店番号の列
        DataGridView1.Columns("支店番号").Width = 110
        DataGridView1.Columns("支店番号").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '支店名の列
        DataGridView1.Columns("支店名").Width = 130
        DataGridView1.Columns("支店名").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        '付与ポイントの列
        DataGridView1.Columns("付与ポイント").Width = 130
        DataGridView1.Columns("付与ポイント").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("付与ポイント").DefaultCellStyle.Format = "#,##0"

    End Sub

End Class