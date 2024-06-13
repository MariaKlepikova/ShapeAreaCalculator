-- Создание таблицы Products
CREATE TABLE Products (
                          ProductID INT PRIMARY KEY,
                          ProductName VARCHAR(100),
                          ProductDescription VARCHAR(255),
                          Price DECIMAL(10, 2)
);

-- Создание таблицы Categories
CREATE TABLE Categories (
                            CategoryID INT PRIMARY KEY,
                            CategoryName VARCHAR(100)
);

-- Создание таблицы ProductCategory (связующая таблица)
CREATE TABLE ProductCategory (
                                 ProductID INT,
                                 CategoryID INT null,
                                 FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
                                 FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Добавление данных в таблицу Products
INSERT INTO Products (ProductID, ProductName, ProductDescription, Price)
VALUES (1, 'Singing in the rain', 'Gene Kelly, Stanley Donen', 123),
       (2, 'Fragments of a woman', 'Cornel Mundruzo, Katha Weber', 5576),
       (3, 'City of lost children', 'Marc Caro, Jean-Pierre-Genet', 456);

-- Добавление данных в таблицу Categories
INSERT INTO Categories (CategoryID, CategoryName)
VALUES (1, 'Michael Patrick King'),
       (2, 'Gene Kelly'),
       (3, 'Katha Weber');

-- Добавление данных в таблицу ProductCategory
INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES (1, 2),
       (2, 3),
       (3, null);

-- Запрос для выбора всех пар «Имя продукта – Имя категории»
SELECT
    products.ProductName,
    categories.CategoryName
FROM Products as products
         LEFT JOIN ProductCategory as pc
                   ON products.ProductID = pc.ProductID
         LEFT JOIN Categories as categories
                   ON pc.CategoryID = categories.CategoryID