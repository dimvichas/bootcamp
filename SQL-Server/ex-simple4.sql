/*Queries for JOINS*/
/*1o*/
select Orders.CustomerID, OrderID from Orders
join Customers on Orders.CustomerID = Customers.CustomerID
where year(OrderDate) = '1996'

/*2o*/
select Employees.City, Customers.City from Customers
right join Employees on Employees.City = Customers.City
where Employees.City != 'null'
group by Employees.City, Customers.City

/*3o*/
select Employees.City, Customers.City from Customers
left join Employees on Employees.City = Customers.City
where Customers.City != 'null'
group by Employees.City, Customers.City

/*4o*/
select Employees.City, Customers.City from Customers
full join Employees on Employees.City = Customers.City
group by Employees.City, Customers.City