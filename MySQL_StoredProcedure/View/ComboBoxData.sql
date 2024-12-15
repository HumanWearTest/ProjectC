CREATE VIEW CustomerComboData AS
    SELECT CONCAT(customer_num,' ',last_name,' ',first_name) AS '顧客名' 
    FROM CustomerMaster;

CREATE VIEW ItemNameComboData AS
    SELECT CONCAT(item_num,' ',item_name) AS '商品名' 
    FROM ItemMaster;