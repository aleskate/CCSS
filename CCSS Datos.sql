
--- SE INSERTAN LOS PERFILES EXISTENTES
insert into perfiles (nombre) values ('Consultador Servicios Médicos')
insert into perfiles (nombre) values ('Facturador Patrono Moroso')
insert into perfiles (nombre) values ('Administrador Riesgos Excluidos')
insert into perfiles (nombre) values ('Supervisor Riesgos Excluidos')
insert into perfiles (nombre) values ('Facturador Riesgos Excluidos')
insert into perfiles (nombre) values ('Director')
insert into perfiles (nombre) values ('Administrador de Usuarios')

--- CENTROS MEDICOS DE PRUEBA
insert into centrosmedicos (nombre) values ('Centro Médico #1')
insert into centrosmedicos (nombre) values ('Centro Médico #2')
delete
from usuarios
--- SE INSERTAN VARIOS USUARIOS DE PRUEBA
insert into usuarios (nombreUsuario, contrasenia,centrosMedicos_codigo,estado ,identificacion,nombre,primerApellido, segundoApellido, tipoIdentificacion)
values ('abc', 'abc',1,1,402200829,'Julian','Oviedo', 'Briceño', 0)
insert into usuarios (nombreUsuario,  contrasenia,centrosMedicos_codigo,estado,identificacion,nombre,primerApellido, segundoApellido, tipoIdentificacion)
values ('123', '123',2,1,701230123,'Marcos','Ramirez', 'Vargas', 0)
insert into usuarios (nombreUsuario, contrasenia,centrosMedicos_codigo,estado,identificacion,nombre,primerApellido, segundoApellido, tipoIdentificacion)
values ('patito', 'patito',1,2,102340567,'Maria','Venegas', 'Chavarria', 0)

--- SE INSERTAN LOS PERFILES DE CADA USUARIO, EL USUARIO {PATITO} NO CUENTA CON NINGÚN PERFIL
insert into usuarios_has_perfiles (perfiles_idPerfil, usuarios_nombreUsuario) values (1,'abc')
insert into usuarios_has_perfiles (perfiles_idPerfil, usuarios_nombreUsuario) values (2,'abc')
insert into usuarios_has_perfiles (perfiles_idPerfil, usuarios_nombreUsuario) values (5,'abc')
insert into usuarios_has_perfiles (perfiles_idPerfil, usuarios_nombreUsuario) values (3,'123')
insert into usuarios_has_perfiles (perfiles_idPerfil, usuarios_nombreUsuario) values (6,'123')

--- SE INSERTAN LAS SITUACIONES DE LAS FACTURAS
insert into situaciones(nombre) values ('Procesada')
insert into situaciones(nombre) values ('Facturada')
insert into situaciones(nombre) values ('Cancelada')
insert into situaciones(nombre) values ('Cancelada Parcialmente')
insert into situaciones(nombre) values ('Devuelta')
insert into situaciones(nombre) values ('Poliza Agotada')
insert into situaciones(nombre) values ('Anulada')
insert into situaciones(nombre) values ('Ajustada')
insert into situaciones(nombre) values ('Descargada')

--- SE INSERTAN LOS ESTADOS DE LAS FACTURAS
insert into estados(nombre) values ('Caso Frontera')
insert into estados(nombre) values ('Poliza Agotada')
insert into estados(nombre) values ('Caso Abierto')
insert into estados(nombre) values ('Caso Declinado')
insert into estados(nombre) values ('Error Confección RT')
insert into estados(nombre) values ('Error Confección SOA')

--- SE INSERTA LA ASEGURADARA
insert into aseguradoras (numeroPatronal,razonSocial,fechaInicio,fechaFin,porcentajeGastosAdministrativos,estado) values
(240190200, 'Instituto Nacional de Seguros', 19.66, '01/01/2001','', 0)