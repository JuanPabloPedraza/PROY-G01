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

go

create table Cuenta(
Id int primary key identity not null,
NroCuenta int not null,
CVU int not null,
Alias nvarchar(50) not null, 
TitularId int not null,
DebitoId int not null,
Credito_1_Id int not null,
Credito_2_Id int not null,
CONSTRAINT fk_cuenta_titular FOREIGN KEY (TitularId) REFERENCES Titular (Id)
)

go

create table Movimiento(
ID int primary Key identity not null, 
Importe decimal(18, 2) not null,
Fecha DateTime not null,
Descripcion nvarchar(100),
CuotasTotales int not null,
CuotasPagas int not null,
CodMovimiento int null,
TipoMovimientoId int not null, 
TarjetaId int null, 
CuentaId int not null, 
CONSTRAINT fk_Movimiento_TipoMovimiento FOREIGN KEY (TipoMovimientoId) REFERENCES TipoMovimiento (Id),
CONSTRAINT fk_movimiento_tarjeta FOREIGN KEY (TarjetaId) REFERENCES Titular (Id),
CONSTRAINT fk_Movimiento_Cuenta FOREIGN KEY (CuentaId) REFERENCES Cuenta (Id)
)

go

create table TipoMovimiento(
Id int primary key identity not null,
TipoDeMovimiento varchar(10) not null
)

create table Tarjeta(
Id int primary key identity not null, 
NroTarjeta int not null, 
clave int not null,
TitularId int not null, 
TipoTarjeta varchar(20) not null,
Estado varchar(15) not null,
LimiteCompra decimal null,
CONSTRAINT fk_tarjeta_titular FOREIGN KEY (TitularId) REFERENCES Titular (Id)
)

go

create table Inversion(
Id int primary Key identity not null,
TipoInversion nvarchar(30) not null,
TNA decimal not null,
TEA decimal not null,
Interes decimal not null,
FechaInicio DateTime not null,
FechaFin DateTime not null
)

go
create table CajaDeAhorro(
Id int primary Key identity not null,
Saldo decimal not null, 
CuentaId int not null,
CONSTRAINT fk_cuenta_titular FOREIGN KEY (CuentaId) 
REFERENCES Cuenta (Id)
)
go

create table CuentaCorriente(
Id int primary Key identity not null,
Saldo decimal not null,
Descubierto decimal not null,
CuentaID int not null,
CONSTRAINT fk_CuentaCorriente_ FOREIGN KEY (CuentaId) 
REFERENCES Cuenta (Id)
)
