-- �X�g�A�h�v���V�[�W���̍쐬��
DELIMITER //

CREATE PROCEDURE SearchCustomerByText(IN last_name VARCHAR(5), IN first_name VARCHAR(5))

BEGIN
    SELECT
        c.customer_num    AS  '�ڋq�ԍ�',
        c.last_name       AS  '��',
        c.first_name      AS  '��'
    FROM
        CustomerMaster  AS c
    WHERE   c.last_name = last_name
        AND c.first_name = first_name;
END //

DELIMITER ;	

--�g�p��
CALL SearchCustomerByText('���','�Ԏq');
    -- ���X�g�A�h�v���V�[�W����IN�����ɂ͕K����������K�v�B�g��Ȃ��Ȃ�NULL�����邱��
    -- OUT�����ɂ̓Z�b�V�����ϐ���^���āA�l�����Ă��炤�B�Q�Ɠn���݂����Ȃ���
    -- @ ~ �Z�b�V�����ϐ�

-- OUT�L��̃e�X�g�p�X�g�A�h�v���V�[�W��
DELIMITER //

CREATE PROCEDURE test1(
    IN num1 INT, 
    IN num2 INT,
    OUT res INT
)

BEGIN

    SET res = num1 * num2 * 3;

    SELECT customer_num AS '�ڋq�ԍ�'
    FROM CustomerMaster;

    select res;
END // 	
DELIMITER ;	



-- �������傢�e�X�g �J�E���g���Ƃ��𓯎��Ɏ��
DELIMITER //

CREATE PROCEDURE CountTest(
    IN last_name_text VARCHAR(5), 
    IN first_name_text VARCHAR(5)
)

BEGIN
    CREATE TEMPORARY TABLE temp AS
        SELECT 
            c.customer_num    AS      '�ڋq�ԍ�',
            c.last_name       AS      '��',
            c.first_name      AS      '��',
            c.prefecture      AS      '�s���{��',
            c.room_num        AS      '�����ԍ�',
            c.points          AS      '�|�C���g'
        FROM CustomerMaster AS  c
        WHERE   (last_name_text     IS NULL OR  c.last_name LIKE CONCAT('%',last_name_text,'%'))
            AND (first_name_text    IS NULL OR  c.first_name LIKE CONCAT('%',first_name_text,'%'));


        -- �f�[�^���o
        SELECT * FROM temp;

        -- �f�[�^����
        SELECT COUNT(*) AS '������'
        FROM temp;

        DROP TABLE temp;
END //

DELIMITER ;	



-- �y�[�W���O�p�e�X�g
DELIMITER //

CREATE PROCEDURE PagingTest(
    IN last_name_text VARCHAR(5),
    IN first_name_text VARCHAR(5),
    IN num_index INT,
    IN DisplayLimitRowNum INT
)

BEGIN
    -- �ϐ���NULL����Ə���
    SET num_index = IFNULL((num_index * DisplayLimitRowNum), 0);
    SET DisplayLimitRowNum = IFNULL(DisplayLimitRowNum, 1000);

    CREATE TEMPORARY TABLE temp AS
    SELECT 
        c.customer_num    AS      '�ڋq�ԍ�',
        c.last_name       AS      '��',
        c.first_name      AS      '��',
        c.prefecture      AS      '�s���{��',
        c.room_num        AS      '�����ԍ�',
        c.points          AS      '�|�C���g'
    FROM CustomerMaster AS  c
    WHERE   (last_name_text     IS NULL OR  c.last_name LIKE CONCAT('%',last_name_text,'%'))
        AND (first_name_text    IS NULL OR  c.first_name LIKE CONCAT('%',first_name_text,'%'))
    ORDER BY c.customer_num ASC
    LIMIT num_index, DisplayLimitRowNum;

    -- �f�[�^���o
    SELECT * FROM temp;

    -- �f�[�^����
    SELECT COUNT(*) AS '������'
    FROM temp;

    -- �ꎞ�e�[�u���폜
    DROP TABLE temp;
END //

DELIMITER ;	


-- temp�̍ė��p�e�X�g
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
    -- �G���[�����������ꍇ��temp_count��0�ɐݒ�
        SET temp_count = 0;
    END;

    -- temp�e�[�u���̑��݊m�F�i�G���[��������handler�ŏ����j
    SELECT COUNT(*) INTO temp_count
    FROM temp;
    
    -- �ϐ���NULL����Ə���
    SET num_index = IFNULL((num_index * DisplayLimitRowNum), 0);
    SET DisplayLimitRowNum = IFNULL(DisplayLimitRowNum, 1000);

    -- temp�e�[�u�������݂��Ă��Ȃ�(���m�ɂ�0��)�Ȃ�Β��o
    IF temp_count = 0 THEN
        CREATE TEMPORARY TABLE temp AS
        SELECT 
            ROW_NUMBER() OVER (ORDER BY c.customer_num) AS �s�ԍ�,
            c.customer_num    AS      '�ڋq�ԍ�',
            c.last_name       AS      '��',
            c.first_name      AS      '��',
            c.prefecture      AS      '�s���{��',
            c.room_num        AS      '�����ԍ�',
            c.points          AS      '�|�C���g'
        FROM CustomerMaster AS  c
        WHERE   (last_name_text     IS NULL OR  c.last_name LIKE CONCAT('%',last_name_text,'%'))
            AND (first_name_text    IS NULL OR  c.first_name LIKE CONCAT('%',first_name_text,'%'))
        ORDER BY c.customer_num ASC;
    END IF;

    -- �f�[�^���o
    SELECT * FROM temp
    LIMIT DisplayLimitRowNum OFFSET num_index;

    -- �f�[�^����
    SELECT COUNT(*) AS '������'
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




-- �e�X�g
DELIMITER //


CREATE PROCEDURE test(
    IN direction  CHAR(4)
)
BEGIN 
    -- �ꎞ�e�[�u���쐬
    create TEMPORARY table temp AS 
        select *
        from CustomerMaster;

    -- �����A�~���̐؂�ւ�
    IF direction = 'DESC' THEN
        select customer_num from temp
        ORDER by customer_num DESC;
    elseif direction = 'ASC' THEN
        select customer_num from temp
        ORDER by customer_num ASC;
    end IF;

    -- �ꎞ�e�[�u���폜
    drop table temp;
END //

DELIMITER ;

CALL test('ASC');
CALL test('DESC');
