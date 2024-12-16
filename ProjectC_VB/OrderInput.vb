Imports System.Transactions
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

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        'セルに値が手入力され、セルを離れようとする時点で入力値が正しいかを確認する。
        '不正値であればメッセージを出して移動させない
        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)

        'MsgBox(cell.Value.ToString())

        Select Case DataGridView1.Columns(e.ColumnIndex).Name
            Case "行", "顧客名", "商品名", "単価", "金額", "支店名", "付与ポイント"
                'なにもしない
                Exit Sub

            Case "年月日"
                Dim Input As String = e.FormattedValue

                '入力されてるかのチェック
                If Input = "" Then
                    Exit Sub
                End If

                '形式チェック

                If System.Text.RegularExpressions.Regex.IsMatch(Input,
                                            "^(1[8-9][0-9]{2}|2[0-1][0-9]{2})(/|-)(0?[0-9]|1[0-2])\2([0-2]?[0-9]|3[0-1])$") Then
                    'MsgBox("形式OK")
                Else
                    MsgBox("不正な形式,不正な日付、範囲外の日付が入力されています" & vbCr & "形式有効例：" & vbCr & " 2020-01-01" & vbCr & " 2020-1-1" &
                         vbCr & " 2020/01/01" & vbCr & " 2020/1/1" & vbCr & " のように入力してください.", MsgBoxStyle.Critical, "形式エラー")
                    e.Cancel = True
                    Exit Sub
                End If

                '日付有効チェック
                Dim res As New Date()
                Dim format As String() = {"yyyy/M/d", "yyyy-M-d"}
                If DateTime.TryParseExact(Input, format, Nothing, Globalization.DateTimeStyles.None, res) Then
                    'MsgBox("有効な日付です" & res)
                    Exit Sub
                Else
                    MsgBox("無効な日付です")
                    e.Cancel = True
                    Exit Sub
                End If
            Case "数量"
                '入力値が無かったら処理終了
                If e.FormattedValue = "" Then
                    Exit Sub
                End If

                '入力値が整数か確認
                Dim res As Integer
                If Not Integer.TryParse(e.FormattedValue.ToString(), res) Then
                    MsgBox("正の整数を入力してください")
                    e.Cancel = True
                    Exit Sub
                End If

                '入力値が正の整数か確認する( >0 )
                If res <= 0 Then
                    MsgBox("0より大きい整数を入力してください")
                    e.Cancel = True
                    Exit Sub
                End If

            Case Else
                MsgBox("想定外のエラーです")

        End Select

    End Sub
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

        '列作成時に処理を抜ける
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)

        Select Case DataGridView1.Columns(e.ColumnIndex).Name
            Case "行", "顧客名", "単価", "金額", "支店名", "付与ポイント"
                'なにもしない
                Exit Sub

            Case "年月日"
                '入力されてるかのチェック
                If cell.Value = "" Then
                    Exit Sub
                End If

                '表示形式を統一させる
                cell.Value = CDate(cell.Value).ToString("yyyy/MM/dd")

            Case "数量"
                '入力値が無ければ金額,付与ポイントリセットして処理終了
                If cell.Value = "" Then
                    DataGridView1.Rows(e.RowIndex).Cells("金額").Value = ""
                    DataGridView1.Rows(e.RowIndex).Cells("付与ポイント").Value = ""
                    Exit Sub
                End If

                Dim price As Object = cell.Value
                '単価が入力されていれば金額を計算して金額,付与ポイント更新
                If DataGridView1.Rows(e.RowIndex).Cells("単価").Value IsNot Nothing Then
                    DataGridView1.Rows(e.RowIndex).Cells("金額").Value = price * DataGridView1.Rows(e.RowIndex).Cells("単価").Value
                    DataGridView1.Rows(e.RowIndex).Cells("付与ポイント").Value =
                        CInt(System.Math.Floor(DataGridView1.Rows(e.RowIndex).Cells("金額").Value * pointRate))
                Else
                    Exit Sub
                End If

            Case "商品名"
                'ドロップダウン選択してある値に対応したデータの出力
                Dim sql As String
                Dim cmd As New MySqlCommand()

                cmd.Connection = cn
                cmd.CommandType = CommandType.Text

                '選択された商品の単価を抽出
                If DataGridView1.Rows(e.RowIndex).Cells("商品名").Value IsNot Nothing Then
                    Dim str As String = DataGridView1.Rows(e.RowIndex).Cells("商品名").Value
                    sql = "SELECT unit_price FROM ItemMaster " & "WHERE item_num = '" & str.Substring(0, 5) & "';"

                    cmd.CommandText = sql
                    Dim price As New DataTable()
                    Dim numRow As Integer
                    Using adapter As New MySqlDataAdapter()
                        adapter.SelectCommand = cmd
                        numRow = adapter.Fill(price)
                    End Using

                    If numRow = 1 Then
                        DataGridView1.Rows(e.RowIndex).Cells("単価").Value = price(0)(0)
                    Else
                        MsgBox("エラー：単価が一つに絞られていません")
                    End If
                End If

                '数量が入力されていれば金額を計算して金額,付与ポイント更新
                Dim quantity As Object = DataGridView1.Rows(e.RowIndex).Cells("数量").Value
                If Not (quantity Is Nothing OrElse quantity = "") Then
                    DataGridView1.Rows(e.RowIndex).Cells("金額").Value = quantity * DataGridView1.Rows(e.RowIndex).Cells("単価").Value
                    DataGridView1.Rows(e.RowIndex).Cells("付与ポイント").Value =
                        CInt(System.Math.Floor(DataGridView1.Rows(e.RowIndex).Cells("金額").Value * pointRate))
                Else
                    Exit Sub
                End If

            Case Else
                MsgBox("想定外のエラーです")

        End Select

    End Sub
    Private Sub DataGridView1_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating
        '行から抜けるときにも検証する
        '項目が一つでも入力されていたら項目未入力チェックを実行

        '空行チェック
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        '0列目("行")だけ飛ばして確認
        Dim rowEmptyFlag As Boolean = True
        For i As Integer = 1 To DataGridView1.Columns.Count - 1
            If Not (row.Cells(i) Is Nothing OrElse row.Cells(i).Value = "") Then
                '空ではない項目が一つでもあればフラグをfalseに変えてforを抜ける
                rowEmptyFlag = False
                Exit For
            End If
        Next

        '空行ならば背景色を変えて検証を終える
        If rowEmptyFlag = True Then
            '全セルの背景色変更
            For Each cell As DataGridViewCell In DataGridView1.Rows(e.RowIndex).Cells
                cell.Style.BackColor = System.Drawing.Color.White
            Next
            'メッセージ初期化
            msg("", False)
            Exit Sub
        End If

        '空行でない時の入力チェック
        Dim cellEmptyFlag As Boolean = True
        For Each cell As DataGridViewCell In DataGridView1.Rows(e.RowIndex).Cells
            If cell.Value Is Nothing OrElse cell.Value.ToString() = "" Then
                '入力されてない項目の背景色を変更して行選択から抜けるのをキャンセルさせる
                cell.Style.BackColor = System.Drawing.Color.Yellow
                e.Cancel = True
                cellEmptyFlag = False
            Else
                '入力されていたら背景色を白に戻す
                cell.Style.BackColor = System.Drawing.Color.White
            End If
        Next

        msg("入力されていない項目があります", True)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '挿入用データ取り出し

        Dim InsertData As New DataTable()

        '列データコピー処理
        For Each Name As String In InsertOrderDataColumns
            InsertData.Columns.Add(Name)
        Next


        '行データコピー処理【項目に空のデータが有るとその行は入力しない】
        Dim newrow As DataRow
        For Each row As DataGridViewRow In DataGridView1.Rows

            '表示行データが空っぽだったらforの処理を終了する
            Dim emptyflag As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value Is Nothing OrElse cell.Value.ToString() = "" Then
                    emptyflag = True
                    Exit For
                End If
            Next

            '空行フラグがtrue: その行の確認をスキップ
            If emptyflag = True Then
                Continue For
            End If

            '空行フラグがfalse: 行のコピーを実行
            newrow = InsertData.NewRow()
            For Each indexKeyPair As KeyValuePair(Of String, Integer) In dicInsertOrderDataColumnsNum
                newrow(indexKeyPair.Key) = row.Cells(indexKeyPair.Value).Value
            Next
            InsertData.Rows.Add(newrow)
        Next

        '加工が必要な列のデータを全修正
        For Each cNum As Integer In editColumnNum
            Select Case InsertData.Columns(cNum).ColumnName

                Case "顧客番号", "商品番号"

                    For i As Integer = 0 To InsertData.Rows.Count - 1
                        '先頭5文字取り出し
                        InsertData.Rows(i)(cNum) = InsertData.Rows(i)(cNum).ToString().Substring(0, 5)
                    Next

                Case "支店番号"

                    For i As Integer = 0 To InsertData.Rows.Count - 1
                        '先頭2文字取り出し
                        InsertData.Rows(i)(cNum) = InsertData.Rows(i)(cNum).ToString().Substring(0, 2)
                    Next
            End Select

        Next


        '挿入用データが0行の場合はメッセージを出して挿入作業をキャンセル
        If InsertData.Rows.Count <= 0 Then
            MsgBox("挿入するデータがありません")
            msg("挿入するデータがありません", True)
            Exit Sub
        End If

        'データ挿入準備
        Dim order_date As Date
        Dim customer_num As String
        Dim item_num As String
        Dim unit_price As Integer
        Dim quantity As Integer
        Dim branch_num As String
        Dim points As Integer


        Dim count As Integer() = {0, 0}        '挿入できた件数のカウント用
        Using cmd As New MySqlCommand()
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "InputOrderData"

            'トランザクション開始
            cn.Open()
            Dim transaction As MySqlTransaction = cn.BeginTransaction()


            Try
                '挿入用データを行ごとに変数へ代入
                For r As Integer = 0 To InsertData.Rows.Count - 1
                    'パラメータ初期化
                    cmd.Parameters.Clear()
                    For c As Integer = 0 To InsertData.Columns.Count - 1
                        Select Case InsertData.Columns(c).ColumnName
                            Case "年月日"
                                order_date = CDate(InsertData.Rows(r)(c).ToString())
                                'パラメータ設定
                                cmd.Parameters.AddWithValue("@A_order_date", order_date)

                            Case "顧客番号"
                                customer_num = InsertData.Rows(r)(c).ToString()
                                'パラメータ設定
                                cmd.Parameters.AddWithValue("@A_customer_num", customer_num)

                            Case "商品番号"
                                item_num = InsertData.Rows(r)(c).ToString()
                                'パラメータ設定
                                cmd.Parameters.AddWithValue("@A_item_num", item_num)

                            Case "販売時単価"
                                unit_price = CInt(InsertData.Rows(r)(c))
                                'パラメータ設定
                                cmd.Parameters.AddWithValue("@A_unit_price", unit_price)

                            Case "数量"
                                quantity = CInt(InsertData.Rows(r)(c))
                                'パラメータ設定
                                cmd.Parameters.AddWithValue("@A_quantity", quantity)

                            Case "支店番号"
                                branch_num = InsertData.Rows(r)(c).ToString()
                                'パラメータ設定
                                cmd.Parameters.AddWithValue("@A_branch_num", branch_num)

                        End Select
                    Next

                    count(0) += cmd.ExecuteNonQuery()

                Next


                '付与ポイントの更新
                'ストアドプロシージャ指定
                cmd.CommandText = "UpdateCustomerPoints"

                For r As Integer = 0 To InsertData.Rows.Count - 1
                    customer_num = InsertData.Rows(r)("顧客番号").ToString()
                    points = CInt(InsertData.Rows(r)("付与ポイント"))

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@A_customer_num", customer_num)
                    cmd.Parameters.AddWithValue("@A_points", points)

                    count(1) += cmd.ExecuteNonQuery()
                Next
                '↑この書き方のほうがネストが浅くて楽かも。問題は列数が増えたときの修正


                'データ挿入とポイントの更新の件数が同じ件数ならコミット,違ってればロールバックする
                If count(0) = count(1) Then
                    transaction.Commit()
                    'データ挿入件数の表示
                    msg(String.Format("{0} 件を登録しました。", count(0)), True)
                    MsgBox(String.Format("{0} 件を登録しました。", count(0)), Title:="登録完了")

                    '表示データをリセットする
                    DataGridView1.Rows.Clear()
                    '再度行追加して行番号も追加しておく
                    For i As Integer = 1 To 10
                        Dim newIndex As Integer = DataGridView1.Rows.Add()
                        DataGridView1.Rows(newIndex).Cells("行").Value = i
                    Next

                Else
                    transaction.Rollback()
                    MsgBox("登録に失敗しました")
                End If
            Catch ex As Exception
                transaction.Rollback()
                MsgBox("登録に失敗しました")
            End Try

            'トランザクション終了
            cn.Close()
        End Using
    End Sub

    Private Sub msg(message As String, displayFlag As Boolean)
        'flag: trueでメッセージ表示、falseでリセット
        If displayFlag = True Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add(message)
        ElseIf displayFlag = False Then
            ListBox1.Items.Clear()
        End If

    End Sub

End Class