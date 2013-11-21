--create database CCSS

CREATE TABLE medicos (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nombre VARCHAR (255) NOT NULL  ,
  primerApellido VARCHAR (255) NOT NULL  ,
  segundoApellido VARCHAR (255) NOT NULL    ,
PRIMARY KEY(codigo));
GO


CREATE TABLE patronos (
  id INTEGER  NOT NULL   IDENTITY ,
  nombre VARCHAR (255) NOT NULL  ,
  tipo bit  NOT NULL    ,
PRIMARY KEY(id));
GO

CREATE TABLE datosDemograficos (
  id INTEGER  NOT NULL   IDENTITY ,
  fallecido bit  NOT NULL  ,
  fechaDefuncion VARCHAR (255) NOT NULL  ,
  provincia VARCHAR (255) NOT NULL  ,
  canton VARCHAR (255) NOT NULL  ,
  distrito VARCHAR (255) NOT NULL  ,
  otrasSenas VARCHAR(255)  NOT NULL  ,
  tipoTelefono INTEGER  NOT NULL  ,
  telefono INTEGER  NOT NULL  ,
  descripcionOcupacion VARCHAR (255) NOT NULL    ,
PRIMARY KEY(id));
GO

CREATE TABLE estados (
  id INTEGER  NOT NULL   IDENTITY ,
  nombre VARCHAR  (255) NOT NULL    ,
PRIMARY KEY(id));
GO

CREATE TABLE resoluciones (
  id INTEGER  NOT NULL   IDENTITY ,
  numeroPoliza INTEGER  NOT NULL  ,
  numeroCasoAseguradora INTEGER  NOT NULL  ,
  denunciadoAAseguradora bit  NOT NULL  ,
  informeInspeccion VARCHAR (255) NOT NULL  ,
  tipo bit  NOT NULL    ,
PRIMARY KEY(id));
GO

CREATE TABLE situaciones (
  id INTEGER  NOT NULL   IDENTITY ,
  nombre VARCHAR (255) NOT NULL    ,
PRIMARY KEY(id));
GO

CREATE TABLE perfiles (
  idPerfil INTEGER  NOT NULL   IDENTITY ,
  nombre VARCHAR (255) NOT NULL    ,
PRIMARY KEY(idPerfil));
GO

CREATE TABLE propietarios (
  identificacion INTEGER  NOT NULL   IDENTITY ,
  tipoIdentificacion bit  NOT NULL  ,
  nombre VARCHAR  (255)NOT NULL  ,
  primerApellido VARCHAR (255) NOT NULL  ,
  segundoApellido VARCHAR (255) NOT NULL    ,
PRIMARY KEY(identificacion));
GO

CREATE TABLE aseguradoras (
  numeroPatronal INTEGER  NOT NULL ,
  razonSocial VARCHAR  (255)  ,
  fechaInicio VARCHAR (255)   ,
  fechaFin VARCHAR   (255) ,
  porcentajeGastosAdministrativos real  ,
  estado bit      ,
PRIMARY KEY(numeroPatronal));
GO

CREATE TABLE accidentes (
  id INTEGER  NOT NULL   IDENTITY ,
  fechaAccidente VARCHAR (255) NOT NULL  ,
  descripcion VARCHAR (255) NOT NULL  ,
  tipo bit  NOT NULL    ,
PRIMARY KEY(id));
GO

CREATE TABLE categorias (
  id INTEGER  NOT NULL   IDENTITY ,
  nombre VARCHAR (255) NOT NULL    ,
PRIMARY KEY(id));
GO

CREATE TABLE centrosMedicos (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nombre VARCHAR (255) NOT NULL    ,
PRIMARY KEY(codigo));
GO

CREATE TABLE tarifas (
  codigo INTEGER  NOT NULL   IDENTITY ,
  categorias_id INTEGER  NOT NULL  ,
  descripcion VARCHAR (255) NOT NULL  ,
  monto INTEGER  NOT NULL    ,
PRIMARY KEY(codigo)  ,
  FOREIGN KEY(categorias_id)
    REFERENCES categorias(id));
GO

CREATE INDEX tarifas_FKIndex1 ON tarifas (categorias_id);
GO

CREATE INDEX IFK_ ON tarifas (categorias_id);
GO

CREATE TABLE accidenteRiesgosTrabajo (
  accidentes_id INTEGER  NOT NULL  ,
  direccionExacta INTEGER  NOT NULL   IDENTITY   ,
PRIMARY KEY(accidentes_id)  ,
  FOREIGN KEY(accidentes_id)
    REFERENCES accidentes(id));
GO

CREATE INDEX accidenteRiesgosTrabajo_FKIndex1 ON accidenteRiesgosTrabajo (accidentes_id);
GO

CREATE INDEX IFK_0 ON accidenteRiesgosTrabajo (accidentes_id);
GO

CREATE TABLE resolucionesRiesgosTrabajo (
  resoluciones_id INTEGER  NOT NULL  ,
  fechaDenuncia VARCHAR (255) NOT NULL ,
  responsabilidadCivil bit      ,
PRIMARY KEY(resoluciones_id)  ,
  FOREIGN KEY(resoluciones_id)
    REFERENCES resoluciones(id));
GO

CREATE INDEX resolucionesRiesgosTrabajo_FKIndex1 ON resolucionesRiesgosTrabajo (resoluciones_id);
GO

CREATE INDEX IFK_0 ON resolucionesRiesgosTrabajo (resoluciones_id);
GO

CREATE TABLE resolucionesAutoMotor (
  resoluciones_id INTEGER  NOT NULL  ,
  casoAdministrativo bit  NOT NULL,
PRIMARY KEY(resoluciones_id)  ,
  FOREIGN KEY(resoluciones_id)
    REFERENCES resoluciones(id));
GO

CREATE INDEX resolucionesAutoMotor_FKIndex1 ON resolucionesAutoMotor (resoluciones_id);
GO

CREATE INDEX IFK_0 ON resolucionesAutoMotor (resoluciones_id);
GO

CREATE TABLE patronesJuridicos (
  numeroPatronal INTEGER  NOT NULL   IDENTITY ,
  patronos_id INTEGER  NOT NULL    ,
PRIMARY KEY(numeroPatronal)  ,
  FOREIGN KEY(patronos_id)
    REFERENCES patronos(id));
GO

CREATE INDEX patronesJuridicos_FKIndex1 ON patronesJuridicos (patronos_id);
GO

CREATE INDEX IFK_0 ON patronesJuridicos (patronos_id);
GO

CREATE TABLE usuarios (
  nombreUsuario VARCHAR (255) NOT NULL,
  contrasenia VARCHAR  (255)NOT NULL  ,
  centrosMedicos_codigo int,
  estado bit  NOT NULL  ,
  identificacion INTEGER  NOT NULL  ,
  nombre VARCHAR   (255) ,
  primerApellido VARCHAR  (255)  ,
  segundoApellido VARCHAR (255)   ,
  tipoIdentificacion bit      ,
PRIMARY KEY(nombreUsuario),
FOREIGN KEY(centrosMedicos_codigo)
    REFERENCES centrosMedicos(codigo));
GO


CREATE TABLE patronosFisicos (
  patronos_id INTEGER  NOT NULL  ,
  primerApellido VARCHAR (255) NOT NULL   ,
  segundoApellido VARCHAR (255) NOT NULL  ,
  cedula INTEGER  NOT NULL    ,
PRIMARY KEY(cedula)  ,
  FOREIGN KEY(patronos_id)
    REFERENCES patronos(id));
GO

CREATE INDEX patronosFisicos_FKIndex1 ON patronosFisicos (patronos_id);
GO

CREATE INDEX IFK_0 ON patronosFisicos (patronos_id);
GO

CREATE TABLE atencionesMedicas (
  id INTEGER  NOT NULL   IDENTITY ,
  medicos_codigo INTEGER  NOT NULL  ,
  asegurado bit  NOT NULL  ,
  fechaInicioPrestacionServicios VARCHAR(255)  NOT NULL  ,
  fechaFinPrestacionServicios VARCHAR(255)  NOT NULL  ,
  descripcionLesiones VARCHAR  (255)NOT NULL    ,
PRIMARY KEY(id)  ,
  FOREIGN KEY(medicos_codigo)
    REFERENCES medicos(codigo));
GO

CREATE INDEX atencionesMedicas_FKIndex1 ON atencionesMedicas (medicos_codigo);
GO

CREATE INDEX IFK_1 ON atencionesMedicas (medicos_codigo);
GO

CREATE TABLE usuarios_has_perfiles (
  perfiles_idPerfil INTEGER  NOT NULL  ,
  usuarios_nombreUsuario VARCHAR (255) NOT NULL  ,
PRIMARY KEY(perfiles_idPerfil, usuarios_nombreUsuario)    ,
  FOREIGN KEY(perfiles_idPerfil)
    REFERENCES perfiles(idPerfil),
	FOREIGN KEY(usuarios_nombreUsuario)
    REFERENCES usuarios(nombreUsuario));
GO

CREATE INDEX usuarios_has_perfiles_FKIndex2 ON usuarios_has_perfiles (perfiles_idPerfil);
GO

CREATE INDEX IFK_ ON usuarios_has_perfiles (perfiles_idPerfil);
GO

CREATE TABLE accidentesAutoMotores (
  accidentes_id INTEGER  NOT NULL  ,
  propietarios_identificacion INTEGER  NOT NULL  ,
  numeroPlaca INTEGER  NOT NULL   IDENTITY ,
  numeroParte INTEGER  NOT NULL    ,
PRIMARY KEY(accidentes_id, propietarios_identificacion)    ,
  FOREIGN KEY(accidentes_id)
    REFERENCES accidentes(id),
  FOREIGN KEY(propietarios_identificacion)
    REFERENCES propietarios(identificacion));
GO

CREATE INDEX accidentesAutoMotores_FKIndex1 ON accidentesAutoMotores (accidentes_id);
GO
CREATE INDEX accidentesAutoMotores_FKIndex2 ON accidentesAutoMotores (propietarios_identificacion);
GO

CREATE INDEX IFK_0 ON accidentesAutoMotores (accidentes_id);
GO
CREATE INDEX IFK_1 ON accidentesAutoMotores (propietarios_identificacion);
GO

CREATE TABLE centrosMedicos_has_tarifas (
  centrosMedicos_codigo INTEGER  NOT NULL  ,
  tarifas_codigo INTEGER  NOT NULL    ,
PRIMARY KEY(centrosMedicos_codigo,tarifas_codigo)    ,
  FOREIGN KEY(centrosMedicos_codigo)
    REFERENCES centrosMedicos(codigo),
  FOREIGN KEY(tarifas_codigo)
    REFERENCES tarifas(codigo));
GO

CREATE INDEX centrosMedicos_has_tarifas_FKIndex1 ON centrosMedicos_has_tarifas (centrosMedicos_codigo);
GO
CREATE INDEX centrosMedicos_has_tarifas_FKIndex2 ON centrosMedicos_has_tarifas (tarifas_codigo);
GO

CREATE INDEX IFK_1 ON centrosMedicos_has_tarifas (centrosMedicos_codigo);
GO
CREATE INDEX IFK_ ON centrosMedicos_has_tarifas (tarifas_codigo);
GO

CREATE TABLE casosEstudio (
  numeroCaso INTEGER  NOT NULL   IDENTITY ,
  aseguradoras_numeroPatronal INTEGER  NOT NULL  ,
  atencionesMedicas_id INTEGER  NOT NULL  ,
  atencionesMedicas_medicos_codigo INTEGER  NOT NULL  ,
  resoluciones_id INTEGER  NOT NULL  ,
  datosDemograficos_id INTEGER  NOT NULL  ,
  accidentes_id INTEGER  NOT NULL  ,
  centrosMedicos_codigo INTEGER  NOT NULL  ,
  patronos_id INTEGER  NOT NULL  ,
  fechaInicio VARCHAR  (255)  ,
  fechaFin VARCHAR  (255)  ,
  estado INTEGER      ,
PRIMARY KEY(numeroCaso), 
  FOREIGN KEY(aseguradoras_numeroPatronal)
    REFERENCES aseguradoras(numeroPatronal),
  FOREIGN KEY(atencionesMedicas_id)
    REFERENCES atencionesMedicas(id),
  FOREIGN KEY(resoluciones_id)
    REFERENCES resoluciones(id),
  FOREIGN KEY(datosDemograficos_id)
    REFERENCES datosDemograficos(id),
  FOREIGN KEY(accidentes_id)
    REFERENCES accidentes(id),
  FOREIGN KEY(centrosMedicos_codigo)
    REFERENCES centrosMedicos(codigo),
  FOREIGN KEY(patronos_id)
    REFERENCES patronos(id));
GO

CREATE INDEX casosEstudio_FKIndex1 ON casosEstudio (aseguradoras_numeroPatronal);
GO
CREATE INDEX casosEstudio_FKIndex2 ON casosEstudio (atencionesMedicas_id);
GO
CREATE INDEX casosEstudio_FKIndex3 ON casosEstudio (resoluciones_id);
GO
CREATE INDEX casosEstudio_FKIndex4 ON casosEstudio (datosDemograficos_id);
GO
CREATE INDEX casosEstudio_FKIndex6 ON casosEstudio (accidentes_id);
GO
CREATE INDEX casosEstudio_FKIndex7 ON casosEstudio (centrosMedicos_codigo);
GO
CREATE INDEX casosEstudio_FKIndex8 ON casosEstudio (patronos_id);
GO

CREATE INDEX IFK_ ON casosEstudio (aseguradoras_numeroPatronal);
GO
CREATE INDEX IFK_1 ON casosEstudio (atencionesMedicas_id);
GO
CREATE INDEX IFK_8 ON casosEstudio (resoluciones_id);
GO
CREATE INDEX IFK_11 ON casosEstudio (datosDemograficos_id);
GO
CREATE INDEX IFK_17 ON casosEstudio (accidentes_id);
GO
CREATE INDEX IFK_15 ON casosEstudio (centrosMedicos_codigo);
GO
CREATE INDEX IFK_14 ON casosEstudio (patronos_id);
GO

CREATE TABLE facturas (
  numeroFactura INTEGER  NOT NULL   IDENTITY ,
  casosEstudio_numeroCaso INTEGER  NOT NULL  ,
  situaciones_id INTEGER  NOT NULL  ,
  estados_id INTEGER  NOT NULL  ,
  monto INTEGER  NOT NULL  ,
  fecha VARCHAR (255) NOT NULL  ,
  casoAbierto bit  NOT NULL  ,
  observaciones VARCHAR (255) NOT NULL    ,
PRIMARY KEY(numeroFactura)      ,
  FOREIGN KEY(casosEstudio_numeroCaso)
    REFERENCES casosEstudio(numeroCaso),
  FOREIGN KEY(situaciones_id)
    REFERENCES situaciones(id),
  FOREIGN KEY(estados_id)
    REFERENCES estados(id));
GO

CREATE INDEX facturas_FKIndex2 ON facturas (casosEstudio_numeroCaso);
GO
CREATE INDEX facturas_FKIndex3 ON facturas (situaciones_id);
GO
CREATE INDEX facturas_FKIndex4 ON facturas (estados_id);
GO

CREATE INDEX IFK_1 ON facturas (casosEstudio_numeroCaso);
GO
CREATE INDEX IFK_12 ON facturas (situaciones_id);
GO
CREATE INDEX IFK_13 ON facturas (estados_id);
GO