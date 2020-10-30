use VirtualCashDb

create table Titular(
Id int primary key identity(1, 1) not null,
Apellido varchar(50) not null,
Nombre varchar(50) not null, 
CUIL int not null,
DNI int not null,
Contacto_1 int not null, 
Contacto_2 int null, 
Correo varchar(50) not null
 )

create table Cuenta(
Id int primary key identity(1, 1) not null,
NroCuenta int not null,
CBU int not null,
Alias nvarchar(50) not null, 
TitularId int not null   ---foranea
)

create table Movimiento(
ID int primary Key identity(1,1) not null, 
Importe decimal(18, 2) not null,
TipoDeMovimiento int not null, -- foranea
Fecha DateTime not null,
Descripcion nvarchar(100), 
TarjetaId int null, -- foranea
CuentaId int not null -- foranea
)

