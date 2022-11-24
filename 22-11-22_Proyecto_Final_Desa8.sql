--drop database Proyecto_Final_Desa8
--create database Proyecto_Final_Desa8

/*INTEGRANTES:
-Michelle Anaya 8-963-2234
-Celia Barrios 8-938-2130
-Luis González 3-755-368
-Guillermo Gordon 8-959-2011
-Bryan Sánchez 8-941-880
-Alicia Saucedo 7-713-1234
-Leonel Vargas 8-971-1210*/
 
use Proyecto_Final_Desa8

------------------------------------------------------------------------------------------------
------------------------ELIMINACION DE LAS TABLAS-------------------------------------------------
------------------------------------------------------------------------------------------------
drop table Sustancia_Proveedor  
drop table Farmacia_Proveedor
drop table Proveedor
drop table Farmacia_Sustancia  
drop table Receta_Sustancia 
drop table Sustancia 
drop table Receta
--drop table Farmacia_Paciente   
drop table Paciente 
drop table Usuario 
drop table Farmacia
drop table Seguro_Social

------------------------------------------------------------------------------------------------
------------------------CREACION DE LAS TABLAS--------------------------------------------------
------------------------------------------------------------------------------------------------

create table Seguro_Social(
cod_seguro int identity 
	constraint Seguro_Social_cod_seguro_pk primary key,
	nombre varchar(25),
)

create table Farmacia(
cod_farm int identity 
	constraint Farmacia_cod_farm_pk primary key,
nombre varchar(100),
ubicacion varchar(100), --constraint 2 farmacias de 2 areas posibles namas
	constraint farmacia_tipo_ck check (ubicacion like '%Plaza Concordia%' or ubicacion like '%San Fransisco%' ),
telefono varchar(9)
	constraint farmacia_telefono_ck check (telefono like '[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
cod_seguro int
constraint Farmacia_cod_seguro_fk foreign key(cod_seguro) references Seguro_Social(cod_seguro)
)

--RECORDAR BUSCAR COMO PARSEAR CONTRASEÑA QUE VIENE DE VISUAL STUDIO
--trigger que manda contraseña nueva al correo registrado, luego comparar la contraseña nueva ingresada con la enviada(Nose)
--talves para recuperar contraseña
--https://www.youtube.com/watch?v=H0046BJidiE&list=PLqjdFmR_HdQT-XPcjkyyRkEYZLwL6oUwa&index=3
create table Usuario(
cedula varchar(11) 
	constraint usuario_cedula_pk primary key,
	constraint usuario_cedula_ck check (cedula like '[0][1-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'
												 or cedula like '[1][0-3][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
nombre varchar(20),
apellido varchar(20),
telefono varchar(9)
	constraint usuario_telefono_ck check (telefono like '[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
correo_e varchar(25) 
constraint usuario_correo_e_ck check(correo_e like '%@%'), 
contraseña varchar(8) 
	constraint usuario_contraseña_ck check (contraseña like '[0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z]'),												
tipo varchar(100) 
	constraint usuario_tipo_ck check (tipo like '%administrador%' or tipo like '%encargado_inventario%' or tipo like '%farmaceuta%'),
cod_farm int,
constraint Usuario_cod_farm_fk foreign key(cod_farm) references Farmacia(cod_farm)
)

--trigger que manda contraseña nueva al correo registrado, luego comparar la contraseña nueva ingresada con la enviada(Nose)
--talves para recuperar contraseña
--trigger que valide que el carné_salud sea igual a la cédula (carné_salud: cedula o cedula+LETRA)
--trigger que valide que el fvence_cs esté válido (estudiantes valido durante semestre)
--trigger que valida que el beneficiario sea de acuerdo a la letra o cedula de carné_salud
--trigger que valida que f_principal sea otra cedula (inclusive podemos anotar quien es el familiar principal 
--como atributo de la tabla y validar con trigger)
--trigger que manda contraseña nueva al correo registrado, luego comparar la contraseña nueva ingresada con la enviada(Nose)
--talves para recuperar contraseña
create table Paciente(--probar null 
--https://www.webucator.com/article/how-to-change-a-column-to-allow-null-in-sql-server/
--Trigger que valida beneficiario se hace a nivel de pantalla
cedula varchar(11) 
	constraint paciente_cedula_pk primary key,
	constraint paciente_cedula_ck check (cedula like '[0][1-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'
												 or cedula like '[1][0-3][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
nombre varchar(20),
apellido varchar(20),
carne_salud varchar(12)
	constraint paciente_carne_salud_ck check (carne_salud like '[0][1-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'--igual a cedula
											or carne_salud like '[1][0-3][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'--igual a cedula
											or carne_salud like '[0][1-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9][H]'--igual a cedula con LETRA
											or carne_salud like '[1][0-3][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9][H]'),--igual a cedula con LETRA
fvence_cs varchar(10) null,
beneficiario varchar(2) null
	constraint paciente_beneficiario_ck check(beneficiario like '%[Si]%' or beneficiario like '%[No]%'),
f_principal varchar(11) null, --(si se puede repetir, una persona puede tener varios beneficiarios (?))
	--constraint paciente_f_principal_ck check (f_principal like '[0][1-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'
												-- or f_principal like '[1][0-3][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
correo_e varchar(25) 
constraint paciente_correo_e_ck check(correo_e like '%@%'), 
contraseña varchar(8) 
	constraint paciente_contraseña_ck check (contraseña like '[0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z][0-9,a-z]'),
telefono varchar(9)
	constraint paciente_telefono_ck check (telefono like '[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
)

/*create table Farmacia_Paciente(
cod_farm int, 
	constraint Farmacia_Paciente_cod_farm_fk foreign key(cod_farm) references Farmacia(cod_farm),
cedula varchar(11) 
	constraint farmacia_Paciente_cedula_ck check (cedula like '[0][1-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'
												 or cedula like '[1][0-3][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
	constraint Farmacia_Paciente_cod_farm_cedula_pk primary key(cod_farm,cedula)
)*/

create table Receta(
cod_receta int identity--generar codigo con letra
	constraint Receta_cod_receta_pk primary key,
medico varchar(25),
fecha varchar(10),
cedula varchar(11) 
	constraint receta_cedula_ck check (cedula like '[0][1-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'
												 or cedula like '[1][0-3][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
	constraint receta_cod_farm_fk foreign key(cedula) references Paciente(cedula)
)

--trigger que verifique que el la fecha_expira es minimo 2 años despues del lote_fabricacion
--trigger que valide que cant_disp no sea menor a 5, si es, sumale 5 a cant_disp
--trigger que valide que dosis sea deacuerdo a tipo tableta = mg, jarabe = ml, inyectable = ml
create table Sustancia(--Medicamento
cod_sustancia int identity--generar codigo con letra
constraint  Sustancia_cod_sustancia_pk primary key,
nombre varchar(35),
tipo varchar(35)	
	constraint Sustancia_tipo_ck check(tipo like '%[tableta]%' or tipo like '%[jarabe]%' or tipo like '%[inyectable]%'),
lote_fabricacion varchar(6), --2017-3: 2017 año y 3:3er lote de ese año) (hasta 12 lotes, 1 lote x mes) 
	--constraint Medicamento_lote_fabricacion_ck check (lote_fabricacion like '[0-2][0-9][0-9][0-9][-][1-12]'),--verificar esto
fecha_expira date,--verificar esto
dosis varchar(5) --dosis que le mandan en la receta al cliente --verificar esto
	--constraint Medicamento_dosis_ck check(dosis like '[1-9][0-9][0-9][mg]' or dosis like '[1-9][0-9][ml]' ),
)

create table Farmacia_Sustancia(
cod_farmacia int
	constraint Farmacia_Sustancia_cod_farmacia_fk foreign key(cod_farmacia) references Farmacia(cod_farm),
cod_sustancia int
	constraint Receta_Medicamento_cod_receta_fk foreign key(cod_sustancia) references Sustancia(cod_sustancia),
	constraint Farmacia_Sustanciao_cod_farmacia_cod_sustancia_pk primary key(cod_farmacia,cod_sustancia),
cant_disp int
)

create table Receta_Sustancia(
cod_receta int --generar codigo con letra
	constraint Receta_Sustancia_cod_receta_fk foreign key(cod_receta) references Receta(cod_receta),
cod_sustancia int --generar codigo con letra
	constraint Receta_Sustancia_cod_sustancia_fk foreign key(cod_sustancia) references Sustancia(cod_sustancia),
	constraint Receta_Sustancia_cod_receta_cod_sustancia_pk primary key(cod_receta,cod_sustancia),
cant_pedida int,
cod_farmacia int
	constraint Receta_Sustancia_cod_farmacia_fk foreign key(cod_farmacia) references Farmacia(cod_farm)
)

create table Proveedor(
cod_proveedor int identity--generar codigo con letra
	constraint Proveedor_cod_proveedor_pk primary key,
nombre varchar(20),
correo varchar(25) 
	constraint Proveedor_correo_ck check(correo like '%@%'), --si es gmail, outlook etc (me da pereza)
telefono varchar(9)
	constraint Proveedor_telefono_ck check (telefono like '[0-2][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
)

create table Farmacia_Proveedor(
cod_farmacia int
	constraint Farmacia_Proveedor_cod_farmacia_fk foreign key(cod_farmacia) references Farmacia(cod_farm),
cod_proveedor int
constraint Farmacia_Proveedor_cod_proveedor_fk foreign key(cod_proveedor) references Proveedor(cod_proveedor),
constraint Farmacia_Proveedor_cod_farmacia_cod_proveedor_pk primary key(cod_farmacia,cod_proveedor)
)

create table Sustancia_Proveedor(
cod_sustancia int --generar codigo con letra
	constraint Sustancia_Proveedor_cod_medicamento_fk foreign key(cod_sustancia) references Sustancia(cod_sustancia),
cod_proveedor int --generar codigo con letra
	constraint Sustancia_Proveedor_cod_proveedor_fk foreign key(cod_proveedor) references Proveedor(cod_proveedor),
constraint Sustancia_Proveedor_cod_sustancia_cod_proveedor_pk primary key(cod_sustancia,cod_proveedor)
)


------------------------------------------------------------------------------------------------
------------------------INSERTAR DATOS A LAS TABLAS---------------------------------------------
------------------------------------------------------------------------------------------------
-----TABLA Seguro_Social-----
insert into Seguro_Social values ('SEGURO_SOCIAL_AREA1XD')
select * from Seguro_Social

-----TABLA Farmacia-----
insert into Farmacia values ('FARMACIA1','Plaza Concordia','6145-5111',1)
insert into Farmacia values ('FARMACIA2','San Fransisco','6515-6789',1)
select * from Farmacia

-----TABLA Usuario-----
--Cada farmacia tiene 1 admin, 1 encargado_inventario y 1 farmaceuta
insert into Usuario values ('08-963-2236','Julio','Torres','6789-1234','julio123@gmail.com','12m456k8','administrador',1)
insert into Usuario values ('04-444-4444','José','Sánchez','6891-2456','jose567@gmail.com','ochoxd12',' encargado_inventario',1)
insert into Usuario values ('06-666-6666','Sol','Gutiérrez','6741-6712','solg128@gmail.com','solcielo','farmaceuta',1)

insert into Usuario values ('07-777-7777','Maria','Madrid','6123-5211','mariam@gmail.com','1230Mao2','administrador',2)
insert into Usuario values ('04-131-5690','Angélica','Arenas','6841-1923','angelicaa567@gmail.com','Blanco12',' encargado_inventario',2)
insert into Usuario values ('08-888-8888','Paloma','Hernández','6741-6712','Paloma@gmail.com','paloma23','farmaceuta',2)
select * from Usuario order by cod_farm 

-----TABLA Paciente-----
--Cada farmacia tiene 1 Paciente
insert into Paciente values ('08-576-3359','Juan','Pérez','08-576-3359','2024-12-4',null,null,'juanp@gmail.com','farmACIA','6666-6666')--fechas randoms sin logica de carne_salud
insert into Paciente values ('09-999-9999','María','Caicedo','09-999-9999','2025-11-11',null,null,'mariac@gmail.com','farmacia','6121-6412')--fechas randoms sin logica de carne_salud

select * from Paciente

/*-----TABLA Farmacia_Paciente----
--Cada farmacia tiene 1 Paciente
insert into Farmacia_Paciente values (1,'08-576-3359')
insert into Farmacia_Paciente values (2,'09-999-9999')
select * from Farmacia
select * from Paciente
select * from Farmacia_Paciente*/

-----TABLA Receta----
--Cada paciente tiene 1 receta
insert into Receta values ('Dra. Gracia Villas','2008-11-11','09-999-9999') --fechas randoms
insert into Receta values ('Dr. Francisco Pedro','2010-12-4','08-576-3359')--fechas randoms
select * from Paciente
select * from Receta

-----TABLA Sustancia----
insert into Sustancia values ('Panadol','tableta','2017-4','2019-11-11','200mg')
insert into Sustancia values ('Tylenol','tableta','2021-4','2023-11-11','200mg')
insert into Sustancia values ('Amikacina','inyectable','2020-4','2022-11-11','2ml')

select * from Sustancia 

-----TABLA Farmacia_Sustancia 
--En las 2 farmacias están las 3 sustancias ya registradas
insert into Farmacia_Sustancia values (1,1,200)
insert into Farmacia_Sustancia values (1,2,150)
insert into Farmacia_Sustancia values (1,3,100)
insert into Farmacia_Sustancia values (2,1,90)
insert into Farmacia_Sustancia values (2,2,300)
insert into Farmacia_Sustancia values (2,3,56)

select * from Farmacia
select * from Sustancia
select * from Farmacia_Sustancia

-----TABLA Receta_Sustancia----
create trigger t_disminuye_cant_disp
on receta_sustancia 
instead of insert
as 
declare @cod_receta_inserted int,
		@cod_sustancia_inserted int,
		@cant_pedida_inserted  int,
		@cant_disp int,
		@cod_farmacia_inserted int,
		@cedula varchar(11)

--carga el codigo sustancia de la tabla receta_sustancia
select @cod_sustancia_inserted = inserted.cod_sustancia,
	   @cant_pedida_inserted = inserted.cant_pedida,
	   @cod_receta_inserted = inserted.cod_receta,
	   @cod_farmacia_inserted = inserted.cod_farmacia
from inserted 

/*--busca la farmacia 
select @cod_farmacia = fp.cod_farm
from Farmacia_Paciente  as fp join paciente as p on fp.cedula= p.cedula
join Receta as r on p.cedula = r.cedula
where cod_receta = @cod_receta_inserted*/

--busca cant_disp de la sustancia que estoy pidiendo
select @cant_disp = cant_disp
from Farmacia_Sustancia 
where cod_sustancia = @cod_sustancia_inserted and cod_farmacia=@cod_farmacia_inserted


if(@cant_pedida_inserted <= @cant_disp)
	begin 
		insert into Receta_Sustancia values(@cod_receta_inserted,@cod_sustancia_inserted,@cant_pedida_inserted,@cod_farmacia_inserted)

		update Farmacia_Sustancia set cant_disp = @cant_disp - @cant_pedida_inserted
		where cod_farmacia = @cod_farmacia_inserted and cod_sustancia = @cod_sustancia_inserted
		select  @cant_disp as cant_disp
		select @cant_pedida_inserted as cant_pedida_inserted
		select  @cod_farmacia_inserted as cod_farmacia
		select @cod_sustancia_inserted as cod_sustancia_inserted

		select 'La cantidad disponible fue restada'
	end
else
	begin
		select 'La cantidad disponible no es suficiente'
	end


select * from Farmacia_Sustancia
select * from Receta_Sustancia

--Cada receta tiene 2 sustancia porque cada receta puede tener varios medicamentos 
insert into Receta_Sustancia values (1,1,10,1)
insert into Receta_Sustancia values (1,3,15,1)
--insert into Receta_Sustancia values (2,2,15,2)
--insert into Receta_Sustancia values (2,3,10,2)

select * from Receta
select * from Sustancia
select * from Receta_Sustancia


-----TABLA Proveedor----
--https://www.paginasamarillas.com.pa/b/distribuidores-de-productos-farmaceuticos
insert into Proveedor values ('Bayer S.A', 'Bayer@gmail.com','271-6100')
insert into Proveedor values ('Unipharm', 'Unipharm@gmail.com','261-1600')

select * from Proveedor

-----TABLA Farmacia_Proveedor----
--Cada farmacia tiene al menos 1 proveedor
--pero farmacia 1 tiene los 2 proveedores registrados
insert into Farmacia_Proveedor values(1,1)
insert into Farmacia_Proveedor values(1,2)
insert into Farmacia_Proveedor values(2,1)

select * from Proveedor
select * from farmacia
select * from Farmacia_Proveedor
-----TABLA Sustancia_Proveedor----
--Una sustancia puede ser proveído x varios proveedores distintos (?)
insert into Sustancia_Proveedor values (1,1)
insert into Sustancia_Proveedor values (1,2)
insert into Sustancia_Proveedor values (2,2)

select * from Sustancia
select * from Proveedor
select * from Sustancia_Proveedor


------------------------------------------------------------------------------------------------
------------------------RECORDAR:GENERAR DIAGRAMA-----------------------------------------------
------------------------------------------------------------------------------------------------

-------------------
--Crear triggers--
-------------------
--Saber cuantas y cuales sustancias tiene una farmacia
select * from Sustancia
select * from Farmacia
select * from Farmacia_Sustancia

select s.cod_sustancia,s.nombre,s.tipo,s.lote_fabricacion,s.fecha_expira,fs.cant_disp,s.dosis,f.cod_farm,f.nombre
from Sustancia as s join Farmacia_Sustancia as fs on s.cod_sustancia = fs.cod_sustancia
					join Farmacia as f on fs.cod_farmacia = f.cod_farm

--pero que tal si en farmacia1 tengo 3 panadol y en farmacia2 tengo 4 panadol?


--Saber que paciente pertenece a que farmacia
select * from Paciente 
select * from Farmacia
select * from Farmacia_Paciente

select p.cedula,p.carne_salud,p.fvence_cs,p.nombre,p.apellido,f.cod_farm,f.nombre,f.ubicacion
from Paciente as p join Farmacia_Paciente as fp on p.cedula = fp.cedula
				   join Farmacia as f on fp.cod_farm = f.cod_farm


--Saber las recetas de un paciente de una farmacia y qué pidió
select * from Paciente 
select * from Receta 
select * from Sustancia
select * from Receta_Sustancia 
--select * from Farmacia_Paciente
select * from Farmacia 

select p.cedula,p.nombre,p.apellido,r.cod_receta,r.medico,r.fecha,s.nombre,s.dosis,
s.tipo,rs.cant_pedida,s.fecha_expira
from Paciente as p join Receta as r on p.cedula = r.cedula
				   join Receta_Sustancia as rs on rs.cod_receta = r.cod_receta
				   join Sustancia as s on s.cod_sustancia = rs.cod_sustancia
				   where p.cedula = '08-576-3359'
				   --join Farmacia_Paciente as fp on fp.cedula = p.cedula
				  -- join Farmacia as f on f.cod_farm = fp.cod_farm


--trigger para que las sustancias pedidas en las recetas disminuyan la cant_disp pero que no bajen de 5 --debería ser en tabla Sustancia
select * from Sustancia
select * from Receta 
select * from Receta_Sustancia


--Sustancia->Receta->Paciente->Farmacia


--Saber todas las recetas con sustancias de los pacientes de las farmacias o de una farmacia en específico
select * from Farmacia
select * from Receta
select * from Receta_Sustancia
select * from Paciente
select * from Farmacia_Paciente

select fp.cod_farm, f.nombre,f.ubicacion,p.cedula,p.nombre,p.apellido,r.cod_receta,r.medico,r.fecha,s.cod_sustancia,s.nombre,s.lote_fabricacion,rs.cant_pedida
	from Paciente as p join Farmacia_Paciente as fp on p.cedula = fp.cedula
						join Farmacia as f on fp.cod_farm = f.cod_farm
						join Receta as r on r.cedula = p.cedula
						join Receta_Sustancia as rs on rs.cod_receta = r.cod_receta
						join Sustancia as s on s.cod_sustancia = rs.cod_sustancia
--where p.cedula= '09-999-9999'

--Saber los proveedores y qué sustancias proveen a qué farmacia
select * from Proveedor
select * from Sustancia
select * from Sustancia_Proveedor
select * from Farmacia_Proveedor

select p.cod_proveedor,p.nombre,p.correo, fp.cod_farmacia,f.nombre,sp.cod_sustancia,s.nombre,s.tipo,s.lote_fabricacion,s.fecha_expira
from Proveedor as p join Farmacia_Proveedor as fp on p.cod_proveedor = fp.cod_proveedor
					join Farmacia as f on fp.cod_farmacia = f.cod_farm
					join Sustancia_Proveedor as sp on sp.cod_proveedor = p.cod_proveedor
					join Sustancia as s on s.cod_sustancia = sp.cod_sustancia

------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS ALMACENADOS-------------------------------------
------------------------------------------------------------------------------------------------
-----------------------
--Dividir x pantallas--
-----------------------
--Pantalla: Inicio Sesión 
create procedure inicio_sesion
@CORREO_E varchar(25),
@CONTRASEÑA varchar(30)
as
select * from usuario
where correo_e = @CORREO_E and contraseña = @CONTRASEÑA

------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS INICIO-------------------------------------
------------------------------------------------------------------------------------------------
create procedure inicio_sesionB
@CORREO_E varchar(25),
@CONTRASEÑA varchar(30),
@TIPO varchar(30)
as

select * from Usuario   --@CORREO_E @CONTRASEÑA 
where correo_e = @CORREO_E  and contraseña =  @CONTRASEÑA and tipo=@TIPO



--Pantalla: Consultar Inventario
create procedure Pa_ListarTablaSustanciaPorNombreFarmacia
as
select f.cod_farm,f.nombre,s.cod_sustancia,s.nombre,s.tipo,s.lote_fabricacion,s.fecha_expira,fs.cant_disp,s.dosis
from sustancia as s join Farmacia_Sustancia as fs on s.cod_sustancia = fs.cod_sustancia
					join Farmacia as f on fs.cod_farmacia = f.cod_farm


--Pantalla: Historial de Recetas x paciente
create procedure Pa_ListarTablaSustanciaPorCodFarmacia
/*create procedure Pa_ListarSustanciaPorNombreFarmacia
@CODFARM int
as
select s.cod_sustancia,s.nombre,s.tipo,s.lote_fabricacion,s.fecha_expira,s.cant_disp,s.dosis,f.cod_farm,f.nombre
from Sustancia as s join Farmacia_Sustancia as fs on s.cod_sustancia = fs.cod_sustancia
					join Farmacia as f on fs.cod_farmacia = f.cod_farm
where f.cod_farm = @CODFARM*/

------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS Actualizar-------------------------------------
------------------------------------------------------------------------------------------------

create procedure Pa_Actualizar
  @Cedula   varchar(20), @nombre  varchar(20),  @apellido  Varchar(20) ,  @telefono  Varchar(20) ,  @correo  Varchar(20) ,  @farma Varchar(20)
as
begin
UPDATE [dbo].[Usuario] SET [nombre] = @nombre  ,[apellido] = @apellido, telefono =@telefono ,[correo_e] =@correo,[cod_farm] =  @farma 
 WHERE cedula=@Cedula 
 end


------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS Lista de usaurio-------------------------------------
------------------------------------------------------------------------------------------------
create procedure Pa_ListarDatosDeUsuario
as
select u.cedula, u.correo_e, u.nombre as nombre , u.apellido as apellido, u.telefono, u.tipo, f.nombre as farmacia
from Usuario as u join Farmacia as f  on u.cod_farm = f.cod_farm

------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS FARMACIA-------------------------------------
------------------------------------------------------------------------------------------------
Create procedure Pa_Farmacia
as
Select * from Farmacia

------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS ProveedoresPorFarmacia-------------------------------------
------------------------------------------------------------------------------------------------
Create procedure Pa_ProveedoresPorFarmacia
as 
Select p.nombre as nproveedor, fp.cod_farmacia, f.nombre as nfarmacia, s.nombre as nsustancia, s.cod_sustancia
from Proveedor as p join Farmacia_Proveedor as fp on p.cod_proveedor = fp.cod_proveedor
join farmacia as f on f.cod_farm = fp.cod_farmacia
join Sustancia_Proveedor as sp on p.cod_proveedor = sp.cod_proveedor
join Sustancia as s on sp.cod_sustancia = s.cod_sustancia 

------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS PROVEDOR-------------------------------------
------------------------------------------------------------------------------------------------

Create Procedure Pa_Proveedor 
As 
Select p.nombre as nproveedor, p.cod_proveedor, fp.cod_farmacia
from Proveedor as p join Farmacia_Proveedor as fp on p.cod_proveedor = fp.cod_proveedor
------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS RE-STOCK-------------------------------------
------------------------------------------------------------------------------------------------
Create procedure Pa_ReStock

@cf int,
@cs int,
@cants int

as
declare
@cant_anterior int
Select @cant_anterior = cant_disp from Farmacia_Sustancia where cod_farmacia = @cf and cod_sustancia = @cs
update Farmacia_Sustancia set cant_disp = @cant_anterior + @cants where cod_farmacia = @cf and cod_sustancia = @cs


create procedure Pa_Registro_paciente
@cedula varchar(11),
@nombre varchar(20),
@apellido varchar(20),
@carne_salud varchar(12),
@fvence_cs varchar(10),
@beneficiario varchar(2),
@f_principal varchar(11),
@correo_e varchar(25),
@contraseña varchar(8),
@telefono varchar(9)
as
insert into Paciente values 
(@cedula,@nombre,@apellido,@carne_salud,@fvence_cs,@beneficiario,@f_principal,@correo_e,@contraseña,@telefono)


create procedure Pa_Login_paciente
@CORREO_E varchar(20),
@CONTRASEÑA varchar(20)
as 
select * from paciente 
where correo_e = @CORREO_E and contraseña = @CONTRASEÑA 


------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS TRIGGER INSERT RECETA-------------------------------------
------------------------------------------------------------------------------------------------
use Proyecto_Final_Desa8
create trigger TriggerPrueba
on Receta
for Insert 
as 
begin
	select * from Receta
end
------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS INSERCCION REGISTRO RECETA-------------------------------------
------------------------------------------------------------------------------------------------
create procedure Pa_Registro_paciente
@cedula varchar(11),
@nombre varchar(20),
@apellido varchar(20),
@carne_salud varchar(12),
@fvence_cs varchar(10),
@beneficiario varchar(2),
@f_principal varchar(11),
@correo_e varchar(25),
@contraseña varchar(8),
@telefono varchar(9)
as
insert into Paciente values 
(@cedula,@nombre,@apellido,@carne_salud,@fvence_cs,@beneficiario,@f_principal,@correo_e,@contraseña,@telefono)


create procedure Pa_HistorialR_paciente
@CORREO_E varchar(20)
as 
select r.cod_receta, r.medico, r.fecha,s.nombre,rs.cant_pedida,s.dosis
from Receta as r join Receta_Sustancia as rs on r.cod_receta = rs.cod_receta
join Sustancia as s on rs.cod_sustancia= s.cod_sustancia
join Paciente as p on p.cedula = r.cedula
where p.correo_e = @CORREO_E



------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS  INSERCION RECETA-------------------------------------
------------------------------------------------------------------------------------------------

create procedure Pa_InsertarReceta
@med varchar (25),
@fecha varchar (10),
@cedula varchar (11),
@cod int output
as
begin
insert into Receta(medico,fecha,cedula) values (@med, @fecha, @cedula)
set @cod = SCOPE_IDENTITY()
select @cod
end 
------------------------------------------------------------------------------------------------
------------------------CREACION PROCEDIMIENTOS Pa_InsertarSustanciasPedidas-------------------------------------
------------------------------------------------------------------------------------------------
create procedure Pa_InsertarSustanciasPedidas
@codr int,
@cods int,
@cantp int,
@codf int
as
insert into Receta_Sustancia values(@codr,@cods,@cantp,@codf)


create procedure Pa_busca_correo_usuario
@CORREO varchar(30)
as
select correo_e from Usuario where correo_e = @CORREO

create procedure Pa_busca_correo_paciente
@CORREO varchar(30)
as
select correo_e from paciente where correo_e = @CORREO


select * from paciente
select * from receta
select * from usuario
select * from farmacia


--update Paciente set correo_e= 'michia0378@gmail.com' where nombre ='Juan'