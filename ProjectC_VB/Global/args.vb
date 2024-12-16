Module args

    Public pointRate As Double = 0.01 'ポイント還元率 1%

    Public InsertOrderDataColumns As String() =
        {"年月日", "顧客番号", "商品番号", "販売時単価", "数量", "支店番号", "付与ポイント"}

    '挿入するデータの列名と表示列のindexとの組合わせ辞書
    Public dicInsertOrderDataColumnsNum As New Dictionary(Of String, Integer) From
        {{"年月日", 1}, {"顧客番号", 2}, {"商品番号", 3}, {"販売時単価", 4}, {"数量", 5}, {"支店番号", 7}, {"付与ポイント", 8}}
    '表示データをDataTableへ挿入後、加工が必要となる列番号の配列
    Public editColumnNum As Integer() = {1, 2, 5}
End Module
