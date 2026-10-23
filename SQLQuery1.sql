--SELECT
Select ContactName As Isım, CompanyName, City from Customers 

Select *from Customers where City ='Berlin'

-- case insensitive search
sEleCt * from Products where CategoryID= 1 or CategoryID= 3

sEleCt * from Products where CategoryID= 1 and UnitPrice >= 10 -- <>10 dan farklı olanları getirir

select * from Products where CategoryID= 1 order by UnitPrice desc-- asc dsc

select count (*) as Adet from Products where CategoryID= 2

--distinct select CategoryID from Products

--insert into Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) values ('New Product', 1, 1, '10 boxes', 15.00, 100, 0, 10, 0)

--delete Products where ProductID = 1

--update Products set UnitPrice = 20 where ProductID = 2

select count (*) Adet from Products

select categoryID, count(*)  from Products where UnitPrice >20 group by categoryID having count(*)<10

--select Products.ProductID, Products.ProductName, Products.ProductName from Products inner join Categories on Products.CategoryID=Categories.CategoryID
--from Products inner join Categories
--on Products.CategoryID=Categories.CategoryID
--where Products.UnitPrice>20
--DTO

select * from Products as p inner join [Order Details] as od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
where o.CustomerID is null