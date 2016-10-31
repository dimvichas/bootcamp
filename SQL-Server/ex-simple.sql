/*Simple SQL Queries*/
/*1o*/
select * from Orders
select * from Customers
select * from Suppliers

/*2o*/
select ContactName, Country from Customers
order by ContactName, Country

/*3o*/
select * from Orders
order by OrderDate

/*4o*/
select count(OrderDate) from Orders
where year(OrderDate)=1997

/*5o*/
select ContactName from Customers where ContactTitle like ('%manager%')

/*6o*/
select OrderDate from Orders
where year(OrderDate)=1997 and month(OrderDate)=5 and day(OrderDate)=19

