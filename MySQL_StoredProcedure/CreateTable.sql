
-- 顧客マスター
CREATE TABLE CustomerMaster(
    customer_num            CHAR(5)     NOT NULL,
    last_name               VARCHAR(5)  NOT NULL,
    first_name              VARCHAR(5)  NOT NULL,
    email                   VARCHAR(40),
    phone_num               VARCHAR(13) NOT NULL,
    prefecture              VARCHAR(8)  NOT NULL,
    city                    VARCHAR(20) NOT NULL,
    street_name             VARCHAR(20) NOT NULL,
    block_num               VARCHAR(10) NOT NULL,
    building_name           VARCHAR(20) NOT NULL,
    room_num                VARCHAR(5)  NOT NULL,
    gender                  VARCHAR(2)  NOT NULL,
    points                  INT         NOT NULL,
    PRIMARY KEY(customer_num)
);

-- 支店
CREATE TABLE Branch(
    branch_num              CHAR(3),
    branch_name             VARCHAR(10),
    PRIMARY KEY(branch_num )
);

-- 大分類
CREATE TABLE Category(
    category_num            CHAR(2),
    category_name           VARCHAR(10),
    PRIMARY KEY(category_num)
);

-- 商品マスター
CREATE TABLE ItemMaster(
    item_num                CHAR(5)         NOT NULL,
    category_num            CHAR(2)         NOT NULL,
    manufacturer            VARCHAR(10)     NOT NULL,
    product_name            VARCHAR(12)     NOT NULL,
    unit_price              INT             NOT NULL,
    stock_quantity          INT             NOT NULL,
    PRIMARY KEY(item_num),
    FOREIGN KEY(category_num)
        REFERENCES Category(category_num)
);


-- 受注データ
CREATE TABLE OrderData(
    order_num               INT             NOT NULL,
    order_date              DATE            NOT NULL,
    customer_num            CHAR(5)         NOT NULL,
    item_num                CHAR(5)         NOT NULL,
    unit_price              INT             NOT NULL,
    quantity                INT             NOT NULL,
    branch_num              CHAR(3)         NOT NULL,
    PRIMARY KEY(order_num),
    FOREIGN KEY(customer_num)
        REFERENCES CustomerMaster(customer_num),
    FOREIGN KEY(item_num)
        REFERENCES  ItemMaster(item_num),
    FOREIGN KEY(branch_num)
        REFERENCES Branch(branch_num)
);



-- 列変更例
ALTER TABLE CustomerMaster
MODIFY points INT NOT NULL;

ALTER TABLE ItemMaster
MODIFY product_name  VARCHAR(12)     NOT NULL;