CREATE DATABASE  Ventas

USE Ventas 

CREATE TABLE Productos
(
Product_Id INT PRIMARY KEY IDENTITY(1,1),
Product_Size varchar(10),
Product_Color varchar(10),
Product_Model varchar(100),
Product_Type varchar(50),
Product_Img nvarchar,
Product_Price smallmoney
)

CREATE TABLE Clientes
(
Client_Id INT PRIMARY KEY IDENTITY(1,1),
Client_Phone varchar(50),
Client_Email varchar(50),
Client_Name varchar(50),
Client_Location bit,
)

CREATE TABLE Proovedores
(
Prov_Id INT PRIMARY KEY IDENTITY(1,1),
Prov_Phone varchar(50),
Prov_Email varchar(50),
Prov_Name varchar(50),
Prov_Adress varchar(50)
)

CREATE TABLE Pedidos
(
Order_Id INT PRIMARY KEY IDENTITY(1,1),
Order_Prod int,
Order_Cli int,
Order_Prov int DEFAULT null,
Order_Date date,
Order_Status bit DEFAULT 0
)

select * from Clientes