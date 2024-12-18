DELIMITER //

CREATE PROCEDURE SalesDisplay(
    IN      A_offset                    DECIMAL,
    IN      A_Max_row                   INT,
    IN      A_date                      CHAR(7),
    IN      A_customer_num              CHAR(5),
    IN      phone_num                   VARCHAR(13),
    IN      branch_num                  CHAR(3)
)
BEGIN
    -- 抽出条件により抽出し,一時テーブルを作成する。
    CREATE TEMPORARY TABLE temp AS
        SELECT 
            ROW_NUMBER() OVER (ORDER BY od.order_num)   AS  '行',
            od.order_num                                AS  '受注番号',
            od.order_date                               AS  '年月日',
            od.customer_num                             AS  '顧客番号',
            CONCAT(cm.last_name,' ',cm.first_name)      AS  '顧客名',
            od.item_num                                 AS  '商品番号',
            ca.category_num                             AS  '大分類番号',
            ca.category_name                            AS  '大分類名称',
            im.item_name                                AS  '商品名',
            od.unit_price                               AS  '販売時単価',
            od.quantity                                 AS  '数量',
            od.unit_price * od.quantity                 AS  '金額',
            od.branch_num                               AS  '支店番号',
            br.branch_name                              AS  '支店名',
            ROUND(od.unit_price * od.quantity * 0.01 , 0) AS  '付与ポイント'
        FROM OrderData as od
        INNER JOIN  CustomerMaster AS cm
          ON od.customer_num = cm.customer_num
        INNER JOIN  ItemMaster  AS im
          ON od.item_num = im.item_num
        INNER JOIN  Category    AS ca
          ON im.category_num = ca.category_num
        INNER JOIN  Branch      AS br
          ON od.branch_num = br.branch_num;

      -- 抽出データの出力
      SELECT * FROM temp;

      -- データ件数の出力
      SELECT COUNT(*) AS '件数'
      FROM temp;

END //

DELIMITER ;

CALL SalesDisplay(NULL,NULL,NULL,NULL,NULL,NUll);