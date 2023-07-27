create database FinanzasPersonales2
go
use FinanzasPersonales2
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

select *from cuentas

--inserts de Tipo de cuenta ( a revisar)-----------------------------------------
insert into TipoDeCuenta values('Efectivo')
insert into TipoDeCuenta values('Bancaria')

--insert de posibles cuentas (a revisar)-------------------------------------------
insert into Cuentas values('Efectivo',100.000,1)
insert into Cuentas values('Cuenta bancaria',100.000,2)
insert into Cuentas values('Mercado Pago',100.000,2)

--insert de tipos de movimiento
insert into Tipo values('Ingreso')
insert into Tipo values ('Gasto')
insert into Tipo values ('Transferencia')


alter table Categoria
add TipoMovimiento varchar(50) not null
--inserts de categorias
--Ingreso
insert into Categoria values('Sueldo','Ingreso')
insert into Categoria values('Inversion','Ingreso')
insert into Categoria values('Otros','Ingreso')

--Gasto
insert into Categoria values('Alquiler','Gasto')
insert into Categoria values('Alimentos','Gasto')
insert into Categoria values('Entretenimiento','Gasto')
insert into Categoria values('Educacion','Gasto')
insert into Categoria values('Otros','Gasto')