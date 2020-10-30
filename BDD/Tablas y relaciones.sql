create database VirtualCashDb

use VirtualCashDb

create table Titular(
Id int primary key identity not null,
Apellido varchar(50) not null,
Nombre varchar(50) not null, 
CUIL int not null,
DNI int not null,
Contacto_1 int not null, 
Contacto_2 int null, 
Correo varchar(50) not null
)

create table Cuenta(
Id int primary key identity not null,
NroCuenta int not null,
CBU int not null,
Alias nvarchar(50) not null, 
TitularId int not null   ---foranea
)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

create table Movimiento(
ID int primary Key identity not null, 
Importe decimal(18, 2) not null,
TipoDeMovimientoId int not null, -- foranea
Fecha DateTime not null,
Descripcion nvarchar(100), 
TarjetaId int null, -- foranea
CuentaId int not null -- foranea
)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

create table Tarjeta(
Id int primary key identity not null, 
NroTarjeta int not null, 
clave int not null,
TitularId int not null, 
TipoTarjeta varchar(20) not null,
Estado varchar(15) not null
)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

create table TipoMovimiento(
Id int primary key identity not null,
TipoDeMovimiento varchar(10) not null
)

create table Inversion(
Id int primary Key identity not null,
TipoInversion nvarchar(30) not null,
TNA decimal not null,
TEA decimal not null,
Interes decimal not null,
FechaInicio DateTime not null,
FechaFin DateTime not null
)

create table CajaDeAhorro(
Id int primary Key identity not null,
Saldo decimal not null, 
CuentaId int not null,
)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

create table CuentaCorriente(
Id int primary Key identity not null,
Saldo decimal not null,
Descubierto decimal not null,
CuentaID int not null
)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

-- Asociar la cuenta con el mail


alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)

alter table TableFK
CONSTRAINT NombreFK FOREIGN KEY (FK) 
REFERENCES tablePK (PK)