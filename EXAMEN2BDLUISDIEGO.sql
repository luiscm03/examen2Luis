
Create table Cliente
(
Nombre varchar(50) Not null,
Cedula varchar(30) Not null,
Telefono varchar(12) Not null,
Direccion varchar(50) Not null,
MontoPagar money,
Descuento money,
SubTotal money,
IVA money,
Total money
)
go
create procedure Guardar_Info
@nombre varchar(50)='',
@cedula varchar(30)='',
@telefono varchar(12)='',
@direccion varchar(50)='',
@montoPagar money='',
@descuento money='',
@subTotal money='',
@iva money='',
@total money=''
as
  begin
  insert into Cliente (Nombre,Cedula,Telefono,Direccion,MontoPagar,Descuento,SubTotal,IVA,Total) values (@nombre,@cedula,@telefono,@direccion,@montoPagar,@descuento,@subTotal,@iva,@total)
  end