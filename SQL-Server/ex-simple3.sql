/*1o. Updating Records*/
update Employees
set HomePhone=2108645482
where EmployeeID=10
select * from Employees

/*2o*/
update [Order Details]
set Quantity=Quantity*2
where [Order Details].OrderID=11078
select * from [Order Details]

/*3o*/
update [Order Details]
set Quantity=2*Quantity
from [Order Details]
full outer join Orders on [Order Details].OrderID = Orders.OrderID
full outer join Employees on Orders.EmployeeID = Employees.EmployeeID
where Employees.EmployeeID=10
select * from [Order Details]

/*Deleting Records*/
delete from [Order Details]
where [Order Details].OrderID=11078
select * from [Order Details]

delete Orders
where OrderID=11078
select * from Orders

delete Employees
where Employees.LastName='Vichas'
select * from Employees