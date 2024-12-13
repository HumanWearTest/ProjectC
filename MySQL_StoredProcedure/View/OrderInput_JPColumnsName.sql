
SELECT
    o.order_num                       AS  '受注番号',
    o.order_date                      AS  '年月日',
    o.customer_num                    AS  '顧客番号', 
    CONCAT(c.last_name,c.first_name)  AS  '顧客名',
    o.item_num                        AS  '商品番号',
    i.product_name                    AS  '商品名'
    i.unit_price                      AS  '販売時単価',
    o.quantity                        AS  '数量',




    o.branch_num      AS  '支店番号',


FROM OrderData  As o
INNER JOIN CustomerMaster AS  c
  ON o.customer_num = c.customer_num
INNER JOIN ItemMaster  as i
  ON o.item_num = i.item_num
INNER JOIN Branch as b
  on o.branch_num = b.branch_num
ORDER BY o.order_num
LIMIT 1 OFFSET 0;



顧客番号	customer_num
姓	last_name
名	first_name
メールアドレス	email
電話番号	phone_num
都道府県	prefecture
市区町村	city
町名	street_name
丁目番地	block_num
建物名	building_name
号室	room_num
性別	gender
ポイント	points


--OrderData					
order_num
order_date
customer_num
item_num
unit_price
quantity
branch_num
受注番号
年月日
顧客番号
商品番号
販売時単価
数量
支店番号

-- ItemMaster		
item_num
category_num
manufacturer
product_name商品名
unit_price
stock_quantity
商品番号
大分類番号
メーカー
商品名
販売単価
在庫数

-- Branch					
branch_num
branch_name
支店番号
支店名

-- Category					
category_num
category_name
