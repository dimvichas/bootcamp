use master;
IF EXISTS(select * from sys.databases where name='Exercise_Library')
drop database Exercise_Library;
go
create database Exercise_Library;
go
use Exercise_Library;

IF EXISTS(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME='Authors')
drop database Authors;
create table Authors(ID int NOT NULL IDENTITY (1,1) PRIMARY KEY, Name varchar(128) NOT NULL);

IF EXISTS(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME='Books')
drop database Books;
create table Books(ISBN int NOT NULL IDENTITY (1,1) PRIMARY KEY, Title varchar(128) NOT NULL);

create table BookAuthors(BookISBN int NOT NULL FOREIGN KEY REFERENCES Books(ISBN),AuthorID int NOT NULL FOREIGN KEY REFERENCES Authors(ID),
CONSTRAINT BookAuthorsID PRIMARY KEY (BookISBN, AuthorID));

create table Libraries(ID int NOT NULL IDENTITY(1,1) PRIMARY KEY);

create table LibraryBooks(LibraryID int NOT NULL FOREIGN KEY REFERENCES Libraries(ID),
						  BookISBN int NOT NULL FOREIGN KEY REFERENCES Books(ISBN),
						  PhysicalCopies int NOT NULL DEFAULT 0, AvailableCopies int NOT NULL DEFAULT 0,
						  CONSTRAINT LibraryBooksID PRIMARY KEY (LibraryID, BookISBN));

create table Users(ID int NOT NULL IDENTITY(1,1) PRIMARY KEY, Name varchar(128) NOT NULL);

create table LibraryUsers(LibraryID int NOT NULL FOREIGN KEY REFERENCES Libraries(ID),
						  UserID int NOT NULL FOREIGN KEY REFERENCES Users(ID),
						  CONSTRAINT LibraryUsersID PRIMARY KEY (LibraryID, UserID));

INSERT INTO Authors (Name) VALUES ('Ton Robbins');
INSERT INTO Authors (Name) VALUES ('Fyodor Dostoyevsky');

INSERT INTO Books (Title) VALUES ('Even Cowgirls Get the Blues');
INSERT INTO Books (Title) VALUES ('Half Asleep in Frog Pajamas');
INSERT INTO Books (Title) VALUES ('The idiot');
INSERT INTO Books (Title) VALUES ('The Gambler');
INSERT INTO Books (Title) VALUES ('Crime and Punishment');