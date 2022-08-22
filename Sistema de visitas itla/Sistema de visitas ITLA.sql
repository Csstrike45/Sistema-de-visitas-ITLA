create database sistema_visitas_itla

use sistema_visitas_itla

---------TABLAS-----------------------------

create table tabla_visitantes(
id int idenTity(1,1) primary key not null,
codigo_visitas as ('VS'+right('00'+CONVERT(varchar,id),(2))),
nombre varchar(40) not null,
apellido varchar(40) not null,
edificio varchar(40) not null,
aula varchar(40) not null,
telefono nvarchar(30) not null,
tipo_visita nvarchar(30) not null,
hora_entrada datetime not null,
hora_salida datetime not null,
carrera varchar(40) null,
correo nvarchar(40) unique null,
matricula varchar(10) unique null,
motivo_visita nvarchar(max) null,
foto image null
) 
select * from tabla_visitantes
------------------------------------------------
create table tabla_usuarios(
id int identity(1,1) primary key not null,
codigo_usuarios as ('US'+right('00'+CONVERT(varchar,id),(2))),
_user nvarchar(100) not null,
_pass nvarchar(100) not null,
Nombre nvarchar(100) not null,
Apellido nvarchar(100) not null,
Cargo varchar(40) not null,
Fecha datetime not null,
)

insert into tabla_usuarios values ('lromero', 'l12345','LUIS', 'ROMERO', 'Administrador', '2022-08-15')

------------STORED PROCEDURES(VISITANTES)------------------------------------------------------------------------------

create procedure sp_guardar_visitantes
@nombre varchar(50),
@apellido varchar(50),
@edificio varchar(50),
@aula varchar(50),
@telefono nvarchar(20),
@tipo_visita nvarchar(20),
@hora_entrada datetime,
@hora_salida datetime,
@carrera varchar(50) null,
@correo nvarchar(50) null,
@matricula varchar(10) null,
@motivo_visita nvarchar(max),
@foto image null
as
insert into tabla_visitantes ( nombre, apellido, edificio, aula, telefono, tipo_visita, hora_entrada, hora_salida, carrera, correo, matricula, motivo_visita, foto) 
values (@nombre,@apellido,@edificio,@aula,@telefono,@tipo_visita,@hora_entrada,@hora_salida,@carrera,@correo,@matricula,@motivo_visita,@foto)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure sp_editar_visitantes
@id int,
@nombre varchar(50),
@apellido varchar(50),
@edificio varchar(50),
@aula varchar(50),
@telefono nvarchar(20),
@tipo_visita nvarchar(20),
@hora_entrada datetime,
@hora_salida datetime,
@carrera varchar(50),
@correo nvarchar(50),
@matricula varchar(10),
@motivo_visita nvarchar(max),
@foto image null
as
update tabla_visitantes set  nombre = @nombre, 
apellido = @apellido, edificio = @edificio, aula = @aula, telefono = @telefono, tipo_visita = @tipo_visita, hora_entrada = @hora_entrada, hora_salida = @hora_salida, 
carrera = @carrera, correo = @correo, motivo_visita = @motivo_visita, foto = @foto 
where id = @id or matricula = @matricula
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create proc sp_buscar_visitantes
@buscar nvarchar(max)
as
select * from tabla_visitantes
where nombre like @buscar + '%'

-------------------------------------------------------------
create or alter proc sp_borrar_visitantes
@id int
as
delete from tabla_visitantes
where id = @id

----------------------STORED PROCEDURES(USUARIOS)----------------------------------------

create procedure sp_guardar_usuarios
@_user nvarchar(100),
@_pass nvarchar(100),
@nombre varchar(50),
@apellido varchar(50),
@cargo varchar(50),
@fecha datetime
as
insert into tabla_usuarios ( _user, _pass, nombre, apellido, cargo, fecha)
values (@_user,@_pass,@nombre,@apellido,@cargo,@fecha)
-----------------------------------------------------------------------------------------
create procedure sp_editar_usuarios
@id int,
@_user nvarchar(100),
@_pass nvarchar(100),
@nombre varchar(50),
@apellido varchar(50),
@cargo varchar(50),
@fecha datetime
as
update tabla_usuarios set  _user = @_user,
_pass = @_pass, nombre = @nombre, apellido = @apellido, cargo = @cargo, fecha = @fecha 
where  id = @id
------------------------------------------------------------------------------------------
create proc sp_buscar_usuarios
@id int,
@_user nvarchar(100)
as
select * from tabla_usuarios
where id = @id and
_user like  @_user + '%'
------------------------------------------------------------------------------------------
create proc sp_borrar_usuarios
@id int
as
delete from tabla_usuarios
where id = @id
------------------------------------------------------------------------------------------
create proc SP_Loging
@_user nvarchar(100),
@_pass nvarchar(100)
as
select * from tabla_usuarios 
where _user = @_user and _pass = @_pass

------------------------VISTA---------------------------------------------------------------------------------------------------------------
create view vw_visitante 
as select v.codigo_visitas 'Codigo Visitas', 
v.nombre 'Nombre', v.apellido 'Apellido', v.edificio 'Edificio', v.aula 'Aula', v.telefono 'Telefono', v.tipo_visita 'Tipo de visita', 
v.hora_entrada 'Hora entrada', v.hora_salida 'Hora salida', v.carrera 'Carrera', v.correo 'Correo', v.matricula 'Matricula', 
v.motivo_visita 'Motivo de visita',v.foto 'Imagen' 
from tabla_visitantes v
--------------------------------------------------------------------------------------------------------------------------------------------
create view vw_usuarios
as
select u.codigo_usuarios 'Codigo usuario', u.Nombre, u.Apellido, u._user 'Usuario', u._pass 'Contraseña', u.Cargo 'Cargo', u.Fecha 'Fecha'
from tabla_usuarios u