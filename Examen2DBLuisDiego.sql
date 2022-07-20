use Examen2DB
go

create table Cliente (
cedula varchar (15) primary key,
nombre varchar (150) not null,
telefono varchar (12) not null,
direccion varchar (50) not null,
Costo money,
Descuento money,
Subtotal money,
IVA money,
Total money,
)
go
