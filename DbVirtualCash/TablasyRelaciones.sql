create table Titular(
Id int primary key identity not null,
Titular varchar(2) not null, -- Si es falso, entonces puede ser un adicional.
Apellido varchar(50) not null,
Nombre varchar(50) not null, 
CUIL int not null,
DNI int not null,
Contacto int not null, 
ContactoAlternativo int null, -- Este contacto, puede no tenerlo.
Correo varchar(50) not null
)
go

-- Vamos a utilizar solo 1 tabla de Cuenta. 
-- Acá vamos a tener 2 saldos. 1 de la cta cte y el otro de la Caja de Ahorro.
create table Cuenta(
Id int primary key identity not null,
NroCuenta int not null,
CVU int not null,
Alias nvarchar(50) not null, 
TitularId int not null,
SaldoCC decimal null,
SaldoCH decimal null,
LimiteDescubierto decimal not null,
CONSTRAINT fk_cuenta_titular FOREIGN KEY (TitularId) REFERENCES Titular (Id)
)

go
-- Hay que insertar los tipos manualmente
-- código de 3 letras para la identificación
-- Ejemplo si es una extracción el código será EXT

-- El campo "Suma" va a ser un campo "Booleano" para identificar si es 
-- Un Ingreso o Egreso y de ahí realizar el cálculo correspondiente.
create table TipoMovimiento(
Id int primary key identity not null, 
Codigo varchar(3) not null, 
Suma varchar(2) not null, 
Descripcion varchar(100) null
)
go
create table Tarjeta(
Id int primary key identity not null, 
NroTarjeta int not null, 
clave int not null,
TitularId int not null, 
TipoTarjeta varchar(20) not null,
LimiteCompra decimal null,
MaxCuotas int not null,
InteresMensual decimal(2,2) not null,
CONSTRAINT fk_tarjeta_titular FOREIGN KEY (TitularId) REFERENCES Titular (Id)
)

go
-- Se agregan varios campos. El "CodMovimiento" vamos a utilizarlo para relacionar
-- los movimientos en más de 1 cuota. Por ejemplo: Ese va a ser el campo que relacione
-- el pago N°2 con el N°1(´Refiriéndonos a un gasto hecho en más de 1 cuota).

-- // Si no se comprende, pregunten.

create table Movimiento(
Id int primary Key identity not null, 
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