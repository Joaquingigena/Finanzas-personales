create database FinanzasPersonales
go
create table Categoria(
Id int not null primary key identity(1,1),
Nombre varchar (50)  not null 
)
go 
create table Tipo(
Id int not null primary key identity(1,1),
Nombre varchar(50) not null
)
go
create table Movimiento(
Id int not null primary key identity(1,1),
Tipo int not null foreign key references Tipo(Id),
Fecha datetime not null,
Descripcion varchar(100) null,
Categoria int not null foreign key references Categoria(Id),
Monto money not null,
Activo bit not null  default 1
)
go 
create table TipoDeCuenta(
Id int not null primary key identity(1,1),
Nombre varchar(50) not null 
)
go
create table Cuentas(
Id int not null primary key identity(1,1),
Nombre varchar(50) not null,
Saldo money not null,
TipoCuenta int not null foreign key references TipoDeCuenta(Id)
)