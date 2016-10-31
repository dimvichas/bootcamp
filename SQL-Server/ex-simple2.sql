/*EX-Simple Queries*/
select * from Customers
select * from Orders
select * from [Order Details]

/*2o*/
select * from Customers
join Orders on Customers.CustomerID = Orders.CustomerID
left join [Order Details] on Orders.OrderID = [Order Details].OrderID
where [Order Details].OrderID is NULL

/*3o*/
select CompanyName, count(Orders.OrderID) as Παραγγελια from Customers
left join Orders on Customers.CustomerID = Orders.CustomerID
group by Customers.CompanyName
having count(Orders.OrderID) = 0