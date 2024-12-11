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

ALTER TABLE CustomerMaster
MODIFY points INT NOT NULL;
