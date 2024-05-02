DROP TABLE Losses;
DROP TABLE Supplies;
DROP TABLE Products;
DROP TABLE ProductsCategory;

create TABLE ProductsCategory(
Category_ID NUMBER(5) PRIMARY KEY ,
Category_Name VARCHAR2(100)
);

create TABLE Products(
Product_ID NUMBER(5),
Product_Name VARCHAR2(100),
Product_Price NUMBER(10,2),
Number_Of_Units NUMBER(10),
Expiary_Date DATE,
Category_ID NUMBER(5),
CONSTRAINT pk_ProductID_ProductName PRIMARY KEY (Product_ID,Product_Name),
CONSTRAINT fk_Category_ID FOREIGN KEY (Category_ID) REFERENCES ProductsCategory(Category_ID)
);

create TABLE Supplies(
Order_ID NUMBER(5) PRIMARY KEY ,
Product_ID NUMBER(5),
Product_Name VARCHAR2(100),
Number_Of_Units_Ordered NUMBER(10),
Price_Paid NUMBER(10,2),
CONSTRAINT fk_Product_ID_Name FOREIGN KEY (Product_ID,Product_Name) REFERENCES Products(Product_ID,Product_Name)
);

create TABLE Losses(
Loss_ID NUMBER(5) PRIMARY KEY ,
Total_Loss_Amount NUMBER(10),
Loss_Date DATE
);


INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (1, 'Dairy Products');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (2, 'Beverages');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (3, 'Frozen Foods');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (4, 'Snacks and Sweets');
INSERT INTO ProductsCategory (Category_ID, Category_Name) VALUES (5, 'Canned Foods');


INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (1, 'Milk-AlMarai', 50, 8, TO_DATE('2024-05-21', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (2, 'Milk-juhayna', 45, 50, TO_DATE('2024-03-21', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (3, 'Mozzarella Cheese-domty', 85, 13, TO_DATE('2024-05-22', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (4, 'Mozzarella Cheese-panda', 70, 30, TO_DATE('2024-06-12', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (5, 'Feta Cheese-domty', 30, 25, TO_DATE('2024-05-29', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (6, 'Feta Cheese-panda', 35, 15, TO_DATE('2024-05-14', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (7, 'Yoghurt-AlMarai',26, 4, TO_DATE('2024-04-10', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (8, 'Yoghurt-juhayna',24, 30, TO_DATE('2024-06-10', 'YYYY-MM-DD'), 1);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (9, 'Yoghurt-Danone',25, 20, TO_DATE('2024-02-10', 'YYYY-MM-DD'), 1);

INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (10, 'Juice-juhayna', 20, 10, TO_DATE('2024-05-12', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (11, 'Juice-AlMarai', 25, 50, TO_DATE('2024-05-28', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (12, 'Soda drink-V7', 20, 60, TO_DATE('2024-02-23', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (13, 'Soda drink-Spiro Spathis', 10, 30, TO_DATE('2024-06-13', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (14, 'Bottled Water-Elano', 15 , 75, TO_DATE('2024-05-25', 'YYYY-MM-DD'), 2);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (15, 'Bottled Water-Aqua Delta', 13 , 5, TO_DATE('2024-04-22', 'YYYY-MM-DD'), 2);


INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (16, 'Frozen Spinach-basma', 35 , 23, TO_DATE('2024-05-12', 'YYYY-MM-DD'), 3); 
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (17, 'Frozen Peas-basma', 40 , 20, TO_DATE('2024-01-19', 'YYYY-MM-DD'), 3);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (18, 'Frozen Green Beans-basma', 40 , 50, TO_DATE('2024-05-25', 'YYYY-MM-DD'), 3);

INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (19, 'Chips-big chips', 10 , 50, TO_DATE('2024-05-28', 'YYYY-MM-DD'), 4);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (20, 'Chips-tiger', 10 , 20, TO_DATE('2024-04-13', 'YYYY-MM-DD'), 4);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (21, 'Chocolate-Corona', 30 , 14, TO_DATE('2024-05-15', 'YYYY-MM-DD'), 4);

INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (22, 'Corn-Rose Garden', 50 , 30, TO_DATE('2024-06-02', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (23, 'Tomato Paste-Rose Garden', 55 , 18, TO_DATE('2024-02-02', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (24, 'Tomato Paste-harvest', 55 , 4, TO_DATE('2024-05-12', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (25, 'Tuna-Rose Garden', 100 , 50, TO_DATE('2024-03-24', 'YYYY-MM-DD'), 5);
INSERT INTO Products (Product_ID, Product_Name, Product_Price, Number_Of_Units, Expiary_Date, Category_ID) VALUES (26, 'Tuna-Dolphin', 85 , 5, TO_DATE('2024-06-24', 'YYYY-MM-DD'), 5);

INSERT INTO Supplies (Order_ID, Product_ID, Product_Name, Number_Of_Units_Ordered, Price_Paid) VALUES (1, 1, 'Milk-AlMarai', 30, 1500);
INSERT INTO Supplies (Order_ID, Product_ID, Product_Name, Number_Of_Units_Ordered, Price_Paid) VALUES (2, 3, 'Mozzarella Cheese-domty', 50, 4250);
INSERT INTO Supplies (Order_ID, Product_ID, Product_Name, Number_Of_Units_Ordered, Price_Paid) VALUES (3, 7, 'Yoghurt-AlMarai', 40, 1040);
INSERT INTO Supplies (Order_ID, Product_ID, Product_Name, Number_Of_Units_Ordered, Price_Paid) VALUES (4, 10, 'Juice-juhayna', 80, 1600);


INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (1, 1200, TO_DATE('2024-04-13', 'YYYY-MM-DD'));
INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (2, 1500, TO_DATE('2024-02-04', 'YYYY-MM-DD'));
INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (3, 400, TO_DATE('2024-03-23', 'YYYY-MM-DD'));
INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (5, 1280, TO_DATE('2024-04-01', 'YYYY-MM-DD'));
