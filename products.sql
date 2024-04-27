create TABLE ProductsCategory(
Category_ID NUMBER(5) PRIMARY KEY ,
Category_Name VARCHAR2(100)
);

create TABLE Products(
Product_ID NUMBER(10) PRIMARY KEY ,
Product_Name VARCHAR2(100),
Product_Price NUMBER(10,2),
Number_Of_Units NUMBER(10),
Expiary_Date DATE,
Category_ID NUMBER(10),
CONSTRAINT fk_Category_ID FOREIGN KEY (Category_ID) REFERENCES ProductsCategory(Category_ID)
);

create TABLE Supplies(
Order_ID NUMBER(10) PRIMARY KEY ,
Product_ID NUMBER(10),
Number_Of_Units_Ordered NUMBER(10),
Price_Paid NUMBER(10,2),
CONSTRAINT fk_Product_ID FOREIGN KEY (Product_ID) REFERENCES Products(Product_ID)
);

create TABLE Losses(
Loss_ID NUMBER(5) PRIMARY KEY ,
Total_Loss_Amount NUMBER(10),
Loss_Date DATE
);


INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (1, 'Dairy Products');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (2, 'Bakery');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (3, 'Frozen Foods');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (4, 'Snacks and Sweets');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (5, 'Canned Foods');


INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (1, 'Milk', 50, 150, TO_DATE('2024-06-21', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (2, 'Cheddar Cheese', 100, 50, TO_DATE('2024-06-12', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (3, ' Mozzarella Cheese', 130, 30, TO_DATE('2024-05-22', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (4, 'Feta Cheese', 95, 250, TO_DATE('2024-05-29', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (5, 'Eggs', 20, 250, TO_DATE('2024-05-14', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (6, 'Butter',110, 150, TO_DATE('2024-05-10', 'YYYY-MM-DD'), 1);

INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (7, 'White Bread', 15, 110, TO_DATE('2024-05-12', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (8, 'Whole Wheat Bread', 20, 50, TO_DATE('2024-05-28', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (9, 'Cookies', 80, 60, TO_DATE('2024-05-23', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (10, 'Croissants', 20 , 75, TO_DATE('2024-05-22', 'YYYY-MM-DD'), 2);

INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (11, 'Frozen Spinach', 20 , 230, TO_DATE('2024-05-12', 'YYYY-MM-DD'), 3);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (12, 'Frozen Peas', 25 , 190, TO_DATE('2024-05-19', 'YYYY-MM-DD'), 3);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (13, 'Frozen Green Beans', 140 , 150, TO_DATE('2024-05-25', 'YYYY-MM-DD'), 3);

INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (14, 'Chips', 10 , 150, TO_DATE('2024-05-28', 'YYYY-MM-DD'), 4);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (15, 'Popcorn', 20 , 120, TO_DATE('2024-05-13', 'YYYY-MM-DD'), 4);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (16, 'Chocolate Bar', 20 , 140, TO_DATE('2024-05-15', 'YYYY-MM-DD'), 4);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (17, 'Ice cream', 20 , 170, TO_DATE('2024-06-28', 'YYYY-MM-DD'), 4);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (18, 'Lollipop', 10 , 190, TO_DATE('2024-05-10', 'YYYY-MM-DD'), 4);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (19, 'Candy', 15 , 210, TO_DATE('2024-05-21', 'YYYY-MM-DD'), 4);

INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (20, 'Corn', 50 , 30, TO_DATE('2024-06-02', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (21, 'Tomato Paste', 55 , 90, TO_DATE('2024-05-02', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (22, 'Green beans', 70 , 80, TO_DATE('2024-06-21', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (23, 'Pineapple chunks', 80 , 78, TO_DATE('2024-05-22', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (24, 'Tuna', 55 , 53, TO_DATE('2024-05-24', 'YYYY-MM-DD'), 5);


INSERT INTO Supplies (Order_ID, Product_ID, Number_Of_Units_Ordered, Price_Paid) VALUES (1, 1, 20, 1234.25);
INSERT INTO Supplies (Order_ID, Product_ID, Number_Of_Units_Ordered, Price_Paid) VALUES (2, 3, 50, 1300.50);
INSERT INTO Supplies (Order_ID, Product_ID, Number_Of_Units_Ordered, Price_Paid) VALUES (3, 2, 40, 2500);
INSERT INTO Supplies (Order_ID, Product_ID, Number_Of_Units_Ordered, Price_Paid) VALUES (5, 4, 80, 2250);


INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (1, 1200, TO_DATE('2024-04-13', 'YYYY-MM-DD'));
INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (2, 1500, TO_DATE('2024-04-04', 'YYYY-MM-DD'));
INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (3, 400, TO_DATE('2024-04-23', 'YYYY-MM-DD'));
INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (5, 1280, TO_DATE('2024-04-01', 'YYYY-MM-DD'));
