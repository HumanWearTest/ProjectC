CREATE VIEW CustomerComboData AS
    SELECT CONCAT(customer_num,' ',last_name,' ',first_name) AS '顧客名' 
    FROM CustomerMaster;

CREATE VIEW ItemNameComboData AS
    SELECT CONCAT(item_num,' ',item_name) AS '商品名' 
    FROM ItemMaster;

CREATE VIEW BranchNameComboData AS
    SELECT CONCAT(Branch_num,' ',Branch_name) AS '支店名' 
    FROM Branch;

CREATE VIEW CategoryComboData AS
    SELECT CONCAT(category_num,' ',category_name) AS '大分類名称' 
    FROM Category;