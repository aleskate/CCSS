--- VALIDA SI EXISTE EL USUARIO
create procedure existUser @user nvarchar(255), @contrasenia nvarchar(255)
as
select * from usuarios 
where nombreUsuario = @user and contrasenia = @contrasenia
go
---exec existUser '123', '123'
-----------------------------------------------------------------------------
--- OBTIENE TODOS LOS PERFILES DE UN USUARIO ESPECÍFICO
create procedure getPerfiles @user nvarchar(255)
as
select idPerfil, nombre from usuarios_has_perfiles up
inner join perfiles p on p.idPerfil = up.perfiles_idPerfil
where up.usuarios_nombreUsuario = @user
go
---exec getPerfiles '123'
-----------------------------------------------------------------------------
--- CAMBIA LA CONTRASEÑA DEL USUARIO
create procedure updateContraseña @user nvarchar(255), @contra nvarchar(255)
as
update usuarios
set contrasenia = @contra
where nombreUsuario = @user
go
---exec updateContraseña '123', '456'
-----------------------------------------------------------------------------
