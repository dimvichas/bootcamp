/*Advanced Queries*/
/*1o*/
select sum([Order Details Extended].ExtendedPrice) from [Order Details Extended]
join Orders	on Orders.OrderID = [Order Details Extended].OrderID
where year(OrderDate) = '1997'

/*2o*/
select sum([Order Subtotals].Subtotal), Customers.CompanyName from [Order Subtotals]
join Orders on Orders.OrderID = [Order Subtotals].OrderID
join Customers on Customers.CustomerID = Orders.CustomerID
group by Customers.CompanyName

/*3o*/
select top 10 sum([Order Details Extended].ExtendedPrice), Products.ProductName
from [Order Details Extended]
join Products on [Order Details Extended].ProductID = Products.ProductID
group by [Order Details Extended].ExtendedPrice, Products.ProductName
--order by sum([Order Details Extended].ExtendedPrice)

/*5o*/
select count([Order Details Extended].ExtendedPrice>1000) from [Order Details Extended]
where [Order Details Extended].OrderID in (select Orders.OrderID from Orders
join Customers on Customers.CustomerID = Orders.CustomerID
where Customers.Country='UK')