DELIMITER //

CREATE PROCEDURE InputOrderData(
    IN  A_order_date        DATE,
    IN  A_customer_num      CHAR(5),
    IN  A_item_num          CHAR(5),
    IN  A_unit_price        INT,
    IN  A_quantity          INT,
    IN  A_branch_num        CHAR(3)
)
BEGIN 
    INSERT INTO OrderData(
        order_date,
        customer_num,
        item_num,
        unit_price,
        quantity,
        branch_num
    )
    VALUES(
        A_order_date,
        A_customer_num,
        A_item_num,
        A_unit_price,
        A_quantity,
        A_branch_num
    );
END//

DELIMITER ;

CALL InputOrderData('2024/11/8','00030','c0030','1700','7','02');
