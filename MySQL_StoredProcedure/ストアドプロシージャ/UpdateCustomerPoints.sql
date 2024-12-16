   
DELIMITER //
   
CREATE PROCEDURE UpdateCustomerPoints(
    IN  A_customer_num      CHAR(5),
    IN  A_points            INT
)
BEGIN
    UPDATE CustomerMaster as c
    SET c.points = points + A_points
    WHERE c.customer_num = A_customer_num;
END//

DELIMITER ;
   