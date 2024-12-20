-- ストアドプロシージャの作成例
DELIMITER //

CREATE PROCEDURE SearchCustomerByText(IN last_name VARCHAR(5), IN first_name VARCHAR(5))

BEGIN
    SELECT
        c.customer_num    AS  '顧客番号',
        c.last_name       AS  '姓',
        c.first_name      AS  '名'
    FROM
        CustomerMaster  AS c
    WHERE   c.last_name = last_name
        AND c.first_name = first_name;
END //

DELIMITER ;	

--使用例
CALL SearchCustomerByText('鈴木','花子');
    -- ※ストアドプロシージャのIN引数には必ず何かしら必要。使わないならNULLを入れること
    -- OUT引数にはセッション変数を与えて、値を入れてもらう。参照渡しみたいなもの
    -- @ ~ セッション変数

-- OUT有りのテスト用ストアドプロシージャ
DELIMITER //

CREATE PROCEDURE test1(
    IN num1 INT, 
    IN num2 INT,
    OUT res INT
)

BEGIN

    SET res = num1 * num2 * 3;

    SELECT customer_num AS '顧客番号'
    FROM CustomerMaster;

    select res;
END // 	
DELIMITER ;	



-- もうちょいテスト カウント数とかを同時に取る
DELIMITER //

CREATE PROCEDURE CountTest(
    IN last_name_text VARCHAR(5), 
    IN first_name_text VARCHAR(5)
)

BEGIN
    CREATE TEMPORARY TABLE temp AS
        SELECT 
            c.customer_num    AS      '顧客番号',
            c.last_name       AS      '姓',
            c.first_name      AS      '名',
            c.prefecture      AS      '都道府県',
            c.room_num        AS      '部屋番号',
            c.points          AS      'ポイント'
        FROM CustomerMaster AS  c
        WHERE   (last_name_text     IS NULL OR  c.last_name LIKE CONCAT('%',last_name_text,'%'))
            AND (first_name_text    IS NULL OR  c.first_name LIKE CONCAT('%',first_name_text,'%'));


        -- データ抽出
        SELECT * FROM temp;

        -- データ件数
        SELECT COUNT(*) AS '総件数'
        FROM temp;

        DROP TABLE temp;
END //

DELIMITER ;	



-- ページング用テスト
DELIMITER //

CREATE PROCEDURE PagingTest(
    IN last_name_text VARCHAR(5),
    IN first_name_text VARCHAR(5),
    IN num_index INT,
    IN DisplayLimitRowNum INT
)

BEGIN
    -- 変数のNULL判定と処理
    SET num_index = IFNULL((num_index * DisplayLimitRowNum), 0);
    SET DisplayLimitRowNum = IFNULL(DisplayLimitRowNum, 1000);

    CREATE TEMPORARY TABLE temp AS
    SELECT 
        c.customer_num    AS      '顧客番号',
        c.last_name       AS      '姓',
        c.first_name      AS      '名',
        c.prefecture      AS      '都道府県',
        c.room_num        AS      '部屋番号',
        c.points          AS      'ポイント'
    FROM CustomerMaster AS  c
    WHERE   (last_name_text     IS NULL OR  c.last_name LIKE CONCAT('%',last_name_text,'%'))
        AND (first_name_text    IS NULL OR  c.first_name LIKE CONCAT('%',first_name_text,'%'))
    ORDER BY c.customer_num ASC
    LIMIT num_index, DisplayLimitRowNum;

    -- データ抽出
    SELECT * FROM temp;

    -- データ件数
    SELECT COUNT(*) AS '総件数'
    FROM temp;

    -- 一時テーブル削除
    DROP TABLE temp;
END //

DELIMITER ;	


-- tempの再利用テスト
DELIMITER //

CREATE PROCEDURE temptest2(
    IN last_name_text VARCHAR(5),
    IN first_name_text VARCHAR(5),
    IN num_index INT,
    IN DisplayLimitRowNum INT
)

BEGIN
    DECLARE temp_count INT;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION
    BEGIN
    -- エラーが発生した場合にtemp_countを0に設定
        SET temp_count = 0;
    END;

    -- tempテーブルの存在確認（エラー発生時にhandlerで処理）
    SELECT COUNT(*) INTO temp_count
    FROM temp;
    
    -- 変数のNULL判定と処理
    SET num_index = IFNULL((num_index * DisplayLimitRowNum), 0);
    SET DisplayLimitRowNum = IFNULL(DisplayLimitRowNum, 1000);

    -- tempテーブルが存在していない(正確には0件)ならば抽出
    IF temp_count = 0 THEN
        CREATE TEMPORARY TABLE temp AS
        SELECT 
            ROW_NUMBER() OVER (ORDER BY c.customer_num) AS 行番号,
            c.customer_num    AS      '顧客番号',
            c.last_name       AS      '姓',
            c.first_name      AS      '名',
            c.prefecture      AS      '都道府県',
            c.room_num        AS      '部屋番号',
            c.points          AS      'ポイント'
        FROM CustomerMaster AS  c
        WHERE   (last_name_text     IS NULL OR  c.last_name LIKE CONCAT('%',last_name_text,'%'))
            AND (first_name_text    IS NULL OR  c.first_name LIKE CONCAT('%',first_name_text,'%'))
        ORDER BY c.customer_num ASC;
    END IF;

    -- データ抽出
    SELECT * FROM temp
    LIMIT DisplayLimitRowNum OFFSET num_index;

    -- データ件数
    SELECT COUNT(*) AS '総件数'
    FROM temp;
END //

DELIMITER ;	




customer_num
last_name
first_name
email
phone_num
prefecture
city
street_name
block_num
building_name
room_num
gender
points




-- テスト
DELIMITER //


CREATE PROCEDURE test(
    IN direction  CHAR(4)
)
BEGIN 
    -- 一時テーブル作成
    create TEMPORARY table temp AS 
        select *
        from CustomerMaster;

    -- 昇順、降順の切り替え
    IF direction = 'DESC' THEN
        select customer_num from temp
        ORDER by customer_num DESC;
    elseif direction = 'ASC' THEN
        select customer_num from temp
        ORDER by customer_num ASC;
    end IF;

    -- 一時テーブル削除
    drop table temp;
END //

DELIMITER ;

CALL test('ASC');
CALL test('DESC');
