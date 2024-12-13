CREATE VIEW CustomerComboData AS
    SELECT CONCAT(customer_num,'  ',last_name,first_name) AS '顧客名' 
    FROM CustomerMaster;