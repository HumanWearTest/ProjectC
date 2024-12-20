DROP PROCEDURE SalesDisplay;

DELIMITER //

CREATE PROCEDURE SalesDisplay(
    IN      A_offset                INT,
    IN      A_Max_row               INT,
    IN      A_start_date            CHAR(7),
    IN      A_end_date              CHAR(7),
    IN      A_customer_name         CHAR(5),
    IN      A_phone_num             CHAR(13),
    IN      A_category_num          CHAR(2),
    IN      A_branch_num            CHAR(3),
    IN      A_item_num              CHAR(5),
    IN      A_upper_points          INT,
    IN      A_lower_points          INT
)
BEGIN
    -- 引数がNULLの場合の変数処理
    DECLARE start_date DATE;
    DECLARE end_date DATE;  

    SET A_offset = IFNULL(A_offset,0);
    SET A_Max_row = IFNULL(A_Max_row,100);
    IF A_start_date IS NOT NULL THEN
      SET start_date = CAST(CONCAT(A_start_date,'/01') AS DATE);
    END IF;
    IF A_end_date IS NOT NULL THEN
      SET end_date = DATE_ADD(CAST(CONCAT(A_end_date,'/01') AS DATE),INTERVAL 1 MONTH);
    END IF;

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
          ON od.branch_num = br.branch_num
        WHERE (A_start_date IS NULl OR od.order_date >= start_date)
          AND (A_end_date IS NULl OR od.order_date < end_date)
          AND (A_customer_name IS NULL OR CONCAT(cm.last_name,' ',cm.first_name) LIKE CONCAT('%',A_customer_name,'%'))
          AND (A_phone_num IS NULL OR cm.phone_num = A_phone_num)
          AND (A_category_num IS NULL OR ca.category_num = A_category_num)
          AND (A_branch_num IS NULL OR od.branch_num = A_branch_num)
          AND (A_item_num  IS NULL OR od.item_num  = A_item_num )
          AND (A_upper_points  IS NULL OR ROUND(od.unit_price * od.quantity * 0.01 , 0) <= A_upper_points )
          AND (A_lower_points IS NULL OR ROUND(od.unit_price * od.quantity * 0.01 , 0) >= A_lower_points)

        ORDER BY od.order_num ;

      -- 抽出データの出力
      SELECT * FROM temp
      LIMIT A_Max_row OFFSET A_offset;

      -- データ件数の出力
      SELECT COUNT(*) AS '件数'
      FROM temp;

      -- 一時テーブルの破棄
      DROP TABLE temp;

END //

DELIMITER ;



CALL SalesDisplay(0,10,'2000/05','2050/06',NULL,NULL,NULL,NUll,NULL,1000,5000);

    IN      A_offset                INT,
    IN      A_Max_row               INT,
    IN      A_start_date            DATE,
    IN      A_end_date              DATE,
    IN      A_customer_num          CHAR(5),
    IN      A_phone_num             CHAR(13),
    IN      A_category_num          CHAR(2),
    IN      A_branch_num            CHAR(3),
    IN      A_item_num              CHAR(5),
    IN      A_upper_points          INT,
    IN      A_lower_points          INT