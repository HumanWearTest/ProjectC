Module args

    ' 受注入力画面の表データの日本語列名を定義した配列
    Public OrderTableColumn_JP As String() = {
        "行",
        "年月日",
        "顧客番号",
        "商品コード",
        "商品名",
        "単価",
        "数量",
        "金額",
        "大分類名称",
        "大分類番号",
        "支店名",
        "支店番号",
        "付与ポイント"
    }
    Public OrderTableColumn_Type As Type() = {
        GetType(Integer),
        GetType(String),
        GetType(String),
        GetType(String),
        GetType(String),
        GetType(String),
        GetType(Integer),
        GetType(Integer),
        GetType(Integer),
        GetType(String),
        GetType(String),
        GetType(String),
        GetType(String),
        GetType(Integer)
    }

End Module
