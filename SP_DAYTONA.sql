USE TALLER_DEYTONA
GO

CREATE PROCEDURE SP_INSERT_CARGO
@ESTADO     BIT,
@CARGO  VARCHAR(30)
AS
BEGIN
INSERT INTO TBL_CARGO VALUES(@ESTADO,@CARGO)
END
GO
------------ PROCEDIMIENTO ALMACENADO DE LA TABLA TBL_CARGO
CREATE PROCEDURE SP_MODIFIC_CARGO
@NUM_CARGO INT,
@ESTADO     BIT,
@CARGO  VARCHAR(30)
AS
BEGIN
UPDATE TBL_CARGO SET ESTADO = @ESTADO, CARGO = @CARGO
WHERE NUM_CARGO = @NUM_CARGO
END

GO
CREATE PROCEDURE SP_SELECT_CARGO
@NUM_CARGO INT
AS
BEGIN
SELECT * FROM TBL_CARGO
WHERE NUM_CARGO = @NUM_CARGO
END
GO
CREATE PROCEDURE SP_ELIMINAR_CARGO
@NUM_CARGO INT
AS
BEGIN
UPDATE TBL_CARGO SET
ESTADO = 0
WHERE NUM_CARGO = @NUM_CARGO
END
GO
----------------PROCEDIMIENTOS DE LA TABLA TBL_DOCUMENTACION
CREATE PROCEDURE SP_INSERT_DOCUMENTACION
@CARTA_COMPRA_VENTA  VARCHAR(20),
@CIRCULACION         VARCHAR(20),
@MATRICULA           VARCHAR(10)
AS 
BEGIN
INSERT INTO TBL_DOCUMENTACION VALUES(@CARTA_COMPRA_VENTA,@CIRCULACION,@MATRICULA)
END

GO
CREATE PROCEDURE SP_MODIFIC_DOCUMENTACION
@NUM_DOCUMENTACION    INT,
@CARTA_COMPRA_VENTA  VARCHAR(20),
@CIRCULACION         VARCHAR(20),
@MATRICULA           VARCHAR(10)
AS 
BEGIN
UPDATE TBL_DOCUMENTACION SET 
CARTA_COMPRA_VENTA=@CARTA_COMPRA_VENTA,
CIRCULACION = @CIRCULACION,
MATRICULA = @MATRICULA  
WHERE NUM_DOCUMENTACION = @NUM_DOCUMENTACION
END

GO
CREATE PROCEDURE SP_SELECT_DOCUMENTACION
@NUM_DOCUMENTACION    INT
AS 
BEGIN
SELECT * FROM TBL_DOCUMENTACION
WHERE NUM_DOCUMENTACION = @NUM_DOCUMENTACION
END

GO
-------------------- PROCEDIMIENTO ALMACENADO DE LA TABLA TBL_EQUIPOMECANICO
CREATE PROCEDURE SP_INSERT_EQUIPOMECANICO
@MOTOR        VARCHAR(30),
@CILINDROS    VARCHAR(30) ,
@TRANSMICION  VARCHAR(30) ,
@FRENOS       VARCHAR(30) 
AS
BEGIN
INSERT INTO TBL_EQUIPOMECANICO VALUES(@MOTOR,@CILINDROS,@TRANSMICION,@FRENOS)
END

GO
CREATE PROCEDURE SP_MODIFC_EQUIPOMECANICO
@NUM_EQUIPO    INT ,
@MOTOR        VARCHAR(30),
@CILINDROS    VARCHAR(30) ,
@TRANSMICION  VARCHAR(30) ,
@FRENOS       VARCHAR(30) 
AS
BEGIN
UPDATE TBL_EQUIPOMECANICO SET
MOTOR=@MOTOR,
CILINDROS=@CILINDROS,
TRANSMICION=@TRANSMICION,
FRENOS=@FRENOS
WHERE NUM_EQUIPO = @NUM_EQUIPO
END

GO
CREATE PROCEDURE SP_SELECT_EQUIPOMECANICO
@NUM_EQUIPO    INT 
AS
BEGIN
SELECT * FROM TBL_EQUIPOMECANICO 
WHERE NUM_EQUIPO = @NUM_EQUIPO
END

GO
-------------------- PROCEDIMIENTO ALMACENADO TBL_TIPO_MANTENIMIENTO
CREATE PROCEDURE SP_INSERT_TIPO_MANTENIMIENTO
@MANTENIMIENTO    VARCHAR(50),
@DESCRIPCION      VARCHAR(80)
AS
BEGIN
INSERT INTO TBL_TIPO_MANTENIMIENTO VALUES(@MANTENIMIENTO,@DESCRIPCION)
END

GO
CREATE PROCEDURE SP_MODIFIC_TIPO_MANTENIMIENTO
@ID_MANTENIMIENTO INT,
@MANTENIMIENTO    VARCHAR(50),
@DESCRIPCION      VARCHAR(80)
AS
BEGIN
UPDATE TBL_TIPO_MANTENIMIENTO SET
MANTENIMIENTO=@MANTENIMIENTO,
DESCRIPCION=@DESCRIPCION
WHERE ID_MANTENIMIENTO=@ID_MANTENIMIENTO
END

GO
CREATE PROCEDURE SP_SELECT_TIPO_MANTENIMIENTO
@ID_MANTENIMIENTO INT
AS
BEGIN
SELECT * FROM TBL_TIPO_MANTENIMIENTO
WHERE ID_MANTENIMIENTO=@ID_MANTENIMIENTO
END

GO
------------PROCEDIMIENTO ALMACENADO TBL_TIPO_CLIENTE

CREATE PROCEDURE SP_INSERT_TBL_TIPO_CLIENTE
@ESTADO        BIT,
@TIPO      VARCHAR(30),
@DESCUENTO FLOAT
AS
BEGIN
INSERT INTO TBL_TIPO_CLIENTE VALUES(@ESTADO,@TIPO,@DESCUENTO)
END

GO
CREATE PROCEDURE SP_MODIFC_TBL_TIPO_CLIENTE
@IDTIPO        INT,
@ESTADO        BIT,
@TIPO      VARCHAR(30),
@DESCUENTO FLOAT
AS
BEGIN
UPDATE TBL_TIPO_CLIENTE SET
ESTADO=@ESTADO,
TIPO=@TIPO,
DESCUENTO=@DESCUENTO
WHERE IDTIPO=@IDTIPO
END
GO
CREATE PROCEDURE SP_ELIMINAR_TBL_TIPO_CLIENTE
@IDTIPO        INT
AS
BEGIN
UPDATE TBL_TIPO_CLIENTE SET
ESTADO=0
WHERE IDTIPO=@IDTIPO
END
GO
CREATE PROCEDURE SP_SELECT_TBL_TIPO_CLIENTE
@IDTIPO        INT
AS
BEGIN
SELECT * FROM TBL_TIPO_CLIENTE
WHERE IDTIPO=@IDTIPO
END
-------------------PROCEDIMINETO ALMACENADO TBL_TIPO_PROVEEDOR
GO
CREATE PROCEDURE SP_INSERT_TBL_TIPO_PROVEEDOR
@ESTADO           BIT ,
@TIPO         VARCHAR(20) ,
@DESCRIPCION  VARCHAR(80) 
AS
BEGIN
INSERT INTO TBL_TIPO_PROVEEDOR VALUES(@ESTADO,@TIPO,@DESCRIPCION)
END

GO
CREATE PROCEDURE SP_MODIFIC_TBL_TIPO_PROVEEDOR
@IDTIPOPROVEEDOR  INT,
@ESTADO           BIT ,
@TIPO         VARCHAR(20) ,
@DESCRIPCION  VARCHAR(80) 
AS
BEGIN
UPDATE TBL_TIPO_PROVEEDOR SET
ESTADO=@ESTADO,
TIPO=@TIPO,
DESCRIPCION=@DESCRIPCION
WHERE IDTIPOPROVEEDOR = @IDTIPOPROVEEDOR
END

GO
CREATE PROCEDURE SP_SELECT_TIPO_PROVEEDOR
@IDTIPOPROVEEDOR  INT
AS
BEGIN
SELECT * FROM TBL_TIPO_PROVEEDOR 
WHERE IDTIPOPROVEEDOR = @IDTIPOPROVEEDOR
END
GO
CREATE PROCEDURE SP_ELIMINAR_TBL_TIPO_PROVEEDOR
@IDTIPOPROVEEDOR  INT
AS
BEGIN
UPDATE TBL_TIPO_PROVEEDOR SET
ESTADO=0
WHERE IDTIPOPROVEEDOR = @IDTIPOPROVEEDOR
END
----------------PROCEDIMINETO ALMACENADO TBL_TIPO_SERVICIO
GO
CREATE PROCEDURE SP_INSERT_TIPO_SERVICIO
@ESTADO       BIT ,
@TIPO         VARCHAR(50) ,
@DESCRIPCION  VARCHAR(80)
AS
BEGIN
INSERT INTO TBL_TIPO_SERVICIO VALUES(@ESTADO,@TIPO,@DESCRIPCION)
END

GO
CREATE PROCEDURE SP_MODIFIC_TIPO_SERVICIO
@NUM_SERVICIO  INT,
@ESTADO       BIT ,
@TIPO         VARCHAR(50) ,
@DESCRIPCION  VARCHAR(80)
AS
BEGIN
UPDATE TBL_TIPO_SERVICIO SET
ESTADO=@ESTADO,
TIPO=@TIPO,
DESCRIPCION=@DESCRIPCION
WHERE  NUM_SERVICIO = @NUM_SERVICIO
END

GO
CREATE PROCEDURE SP_SELECT_TIPO_SERVICIO
@NUM_SERVICIO  INT
AS
BEGIN
SELECT * FROM TBL_TIPO_SERVICIO
WHERE  NUM_SERVICIO = @NUM_SERVICIO
END

GO
CREATE PROCEDURE SP_ELIMINAR_TIPO_SERVICIO
@NUM_SERVICIO  INT
AS
BEGIN
UPDATE TBL_TIPO_SERVICIO SET
ESTADO=0
WHERE  NUM_SERVICIO = @NUM_SERVICIO
END
-----------------PROCEDIMINETO ALMACENADO TBL_VEHICULO
GO
CREATE PROCEDURE SP_INSERT_TBL_VEHICULO
@NUM_DOCUMENTACION  INT,
@NUM_EQUIPOMECANICO INT,
@OBSERVACIONES      VARCHAR(30),
@PRECIO_COMPRA      MONEY,
@PRECIO_VENTA       MONEY,
@ESTADO            BIT
AS
BEGIN
INSERT INTO TBL_VEHICULO VALUES(@NUM_DOCUMENTACION,@NUM_EQUIPOMECANICO,@OBSERVACIONES,@PRECIO_COMPRA,@PRECIO_VENTA,@ESTADO)
END

GO
CREATE PROCEDURE SP_MODIFIC_TBL_VEHICULO
@NUM_VEHICULO       INT,
@NUM_DOCUMENTACION  INT,
@NUM_EQUIPOMECANICO INT,
@OBSERVACIONES      VARCHAR(30),
@PRECIO_COMPRA      MONEY,
@PRECIO_VENTA       MONEY,
@ESTADO            BIT
AS
BEGIN
UPDATE TBL_VEHICULO SET
NUM_DOCUMENTACION=@NUM_DOCUMENTACION,
NUM_EQUIPOMECANICO=@NUM_EQUIPOMECANICO,
OBSERVACIONES=@OBSERVACIONES,
PRECIO_COMPRA=@PRECIO_COMPRA,
PRECIO_VENTA=@PRECIO_VENTA,
ESTADO=@ESTADO
WHERE NUM_VEHICULO = @NUM_VEHICULO
END

GO
CREATE PROCEDURE SP_SELECT_TBL_VEHICULO
@NUM_VEHICULO       INT
AS
BEGIN
SELECT * FROM TBL_VEHICULO 
WHERE NUM_VEHICULO = @NUM_VEHICULO
END

GO
CREATE PROCEDURE SP_ELIMINAR_TBL_VEHICULO
@NUM_VEHICULO       INT
AS
BEGIN
UPDATE TBL_VEHICULO SET
ESTADO=0
WHERE NUM_VEHICULO = @NUM_VEHICULO
END
-----------------PROCEDIMINETO ALMACENADP TBL_VEHICULO_CLIENTE
GO
CREATE PROCEDURE SP_INSERT_TBL_VEHICULO_CLIENTE
@ESTADO        BIT,
@MARCA     VARCHAR(30) ,
@PLACA     VARCHAR(20) ,
@CATEGORIA VARCHAR(20)
AS
BEGIN
INSERT INTO TBL_VEHICULO_CLIENTE VALUES(@ESTADO,@MARCA,@PLACA,@CATEGORIA)
END

GO
CREATE PROCEDURE SP_MODIFIC_TBL_VEHICULO_CLIENTE
@NUM_VEHICULO    INT ,
@ESTADO        BIT,
@MARCA     VARCHAR(30) ,
@PLACA     VARCHAR(20) ,
@CATEGORIA VARCHAR(20)
AS
BEGIN
UPDATE TBL_VEHICULO_CLIENTE SET
ESTADO=@ESTADO,
MARCA=@MARCA,
PLACA=@PLACA,
CATEGORIA=@CATEGORIA
WHERE NUM_VEHICULO = @NUM_VEHICULO
END

GO
CREATE PROCEDURE SP_SELECT_TBL_VEHICULO_CLIENTE
@NUM_VEHICULO    INT 
AS
BEGIN
SELECT * FROM TBL_VEHICULO_CLIENTE
WHERE NUM_VEHICULO = @NUM_VEHICULO
END

GO
CREATE PROCEDURE SP_ELIMINAR_TBL_VEHICULO_CLIENTE
@NUM_VEHICULO    INT 
AS
BEGIN
UPDATE TBL_VEHICULO_CLIENTE SET
ESTADO=0
WHERE NUM_VEHICULO = @NUM_VEHICULO
END
----------------------PROCEDIMINETO ALMACENADO CAT_CATEGORIA
GO
CREATE PROCEDURE SP_INSERT_CAT_CATEGORIA
@ESTADO                BIT ,
@NOMBRE_CATEGORIA  VARCHAR(40) ,
@DESCRIPCION_CATEG VARCHAR(255)
AS
BEGIN
INSERT INTO CAT_CATEGORIA VALUES(@ESTADO,@NOMBRE_CATEGORIA,@DESCRIPCION_CATEG)
END

GO
CREATE PROCEDURE SP_MODIFIC_CAT_CATEGORIA
@NUM_CATEGORIA         INT ,
@ESTADO                BIT ,
@NOMBRE_CATEGORIA  VARCHAR(40) ,
@DESCRIPCION_CATEG VARCHAR(255)
AS
BEGIN
UPDATE CAT_CATEGORIA SET
ESTADO=@ESTADO,
NOMBRE_CATEGORIA=@NOMBRE_CATEGORIA,
DESCRIPCION_CATEG=@DESCRIPCION_CATEG
WHERE NUM_CATEGORIA = @NUM_CATEGORIA
END

GO
CREATE PROCEDURE SP_SELECT_CAT_CATEGORIA
@NUM_CATEGORIA         INT 
AS
BEGIN
SELECT * FROM CAT_CATEGORIA
WHERE NUM_CATEGORIA = @NUM_CATEGORIA
END

GO
CREATE PROCEDURE SP_ELIMINAR_CAT_CATEGORIA
@NUM_CATEGORIA         INT 
AS
BEGIN
UPDATE CAT_CATEGORIA SET
ESTADO=0
WHERE NUM_CATEGORIA = @NUM_CATEGORIA
END
------------------PROCEDIMIENTO ALMACENADO TBL_HISTORIAL_PRECIO
GO
CREATE PROCEDURE SP_INSERT_TBL_HISTORIAL_PRECIO
@CODIGO         VARCHAR(30),
@PRECIO         MONEY ,
@FECHA          DATE ,
@DESCRIPCION    VARCHAR(255) ,
@NOMBRE_PRODUCTO VARCHAR(20) 
AS
BEGIN
INSERT INTO TBL_HISTORIAL_PRECIO VALUES(@CODIGO,@PRECIO,@FECHA,@DESCRIPCION,@NOMBRE_PRODUCTO)
END

GO
CREATE PROCEDURE SP_MODIFIC_TBL_HISTORIAL_PRECIO
@NUM_HISTORIAL  INT,
@CODIGO         VARCHAR(30),
@PRECIO         MONEY ,
@FECHA          DATE ,
@DESCRIPCION    VARCHAR(255) ,
@NOMBRE_PRODUCTO VARCHAR(20) 
AS
BEGIN
UPDATE TBL_HISTORIAL_PRECIO SET
CODIGO=@CODIGO,
PRECIO=@PRECIO,
FECHA=@FECHA,
DESCRIPCION=@DESCRIPCION,
NOMBRE_PRODUCTO=@NOMBRE_PRODUCTO
WHERE NUM_HISTORIAL = @NUM_HISTORIAL
END

GO
CREATE PROCEDURE SP_SELECT_TBL_HISTORIAL_PRECIO
@NUM_HISTORIAL  INT
AS
BEGIN
SELECT * FROM TBL_HISTORIAL_PRECIO
WHERE NUM_HISTORIAL = @NUM_HISTORIAL
END
GO
---------------------PROCEDIMIENTO ALMACENADO SELECT POR FECHA
CREATE PROCEDURE SP_SELECT_FECHA_TBL_HISTORIAL_PRECIO
@FECHA DATE
AS
BEGIN
SELECT * FROM TBL_HISTORIAL_PRECIO
WHERE MONTH(FECHA) = MONTH(@FECHA)
END

--------------------- PROCEDIMIENTO ALMACENADO INSERTAR CLIENTE
GO
CREATE PROCEDURE SP_INSERT_CAT_CLIENTE
@ESTADO               BIT ,
@NOMBRE_CLIENTE   VARCHAR(40),
@APELLIDO_CLIENTE VARCHAR(40),
@CEDULA_CLIENTE   VARCHAR(25),
@GENERO           CHAR(1),
@FECHA_NAC        DATE,
@ESTADO_CIVIL     CHAR(1),
@DOMICILIO        VARCHAR(100),
@NUM_TELEFONO         INT ,
@WEB              VARCHAR(40),
@CORREO           VARCHAR(40),
@TIPO_CLIENTE     VARCHAR(40),
@VEHICULO         VARCHAR(40)
AS
BEGIN
INSERT INTO CAT_CLIENTE VALUES(@ESTADO,@NOMBRE_CLIENTE,@APELLIDO_CLIENTE,@CEDULA_CLIENTE,@GENERO,@FECHA_NAC,@ESTADO_CIVIL,@DOMICILIO,
@NUM_TELEFONO,@WEB,@CORREO,@TIPO_CLIENTE,@VEHICULO)
END

-- PROCEDIMIENTO ALMACENADO MODIFICAR CLIENTE
GO
CREATE PROCEDURE SP_MODIFIC_CAT_CLIENTE
@NUM_CLIENTE          INT,
@ESTADO               BIT ,
@NOMBRE_CLIENTE   VARCHAR(40),
@APELLIDO_CLIENTE VARCHAR(40),
@CEDULA_CLIENTE   VARCHAR(25),
@GENERO           CHAR(1),
@FECHA_NAC        DATE,
@ESTADO_CIVIL     CHAR(1),
@DOMICILIO        VARCHAR(100),
@NUM_TELEFONO         INT ,
@WEB              VARCHAR(40),
@CORREO           VARCHAR(40),
@TIPO_CLIENTE     VARCHAR(40),
@VEHICULO         VARCHAR(40)
AS
BEGIN
UPDATE CAT_CLIENTE SET
ESTADO=@ESTADO,
NOMBRE_CLIENTE=@NOMBRE_CLIENTE,
APELLIDO_CLIENTE=@APELLIDO_CLIENTE,
CEDULA_CLIENTE=@CEDULA_CLIENTE,
GENERO=@GENERO,
FECHA_NAC=@FECHA_NAC,
ESTADO_CIVIL=@ESTADO_CIVIL,
DOMICILIO=@DOMICILIO,
NUM_TELEFONO=@NUM_TELEFONO,
WEB=@WEB,
CORREO=@CORREO,
TIPO_CLIENTE=@TIPO_CLIENTE,
VEHICULO=@VEHICULO
WHERE NUM_CLIENTE = @NUM_CLIENTE
END

GO

-- PROCEDIMIENTO ALMACENADO SELECCIONAR CLIENTE
CREATE PROCEDURE SP_SELECT_CAT_CLIENTE
@NUM_CLIENTE          INT
AS
BEGIN
SELECT * FROM CAT_CLIENTE 
WHERE NUM_CLIENTE = @NUM_CLIENTE AND ESTADO = 1
END

GO

-- PROCEDIMIENTO ALMACENADO ELIMINAR CLIENTE
CREATE PROCEDURE SP_ELIMINAR_CAT_CLIENTE
@NUM_CLIENTE          INT
AS
BEGIN
UPDATE CAT_CLIENTE SET
ESTADO=0
WHERE NUM_CLIENTE = @NUM_CLIENTE
END
-------------PROCEDIMIENTO ALMACENADO INSERTAR EMPLEADO CAT_EMPLEADO
GO
CREATE PROCEDURE SP_INSERT_CAT_EMPLEADO
@ESTADO           BIT ,
@NO_CEDULA        VARCHAR(25) ,
@NO_INSS          VARCHAR(20),
@NOMBRE       VARCHAR(40) ,
@APELLIDO     VARCHAR(40) ,
@DAT_FECHA_NAC    DATE,
@CARGO        INT ,
@GENERO       CHAR(1) ,
@ESTADO_CIVIL CHAR(1) ,
@DIRECCION    VARCHAR(100),
@NUM_TELEFONO     INT,
@CORREO       VARCHAR(40),
@WEB          VARCHAR(80)
AS
BEGIN
INSERT INTO CAT_EMPLEADO VALUES(@ESTADO ,@NO_CEDULA,@NO_INSS,@NOMBRE,@APELLIDO,@DAT_FECHA_NAC,@CARGO,@GENERO,@ESTADO_CIVIL,
@DIRECCION,@NUM_TELEFONO,@CORREO,@WEB)
END
---------------------PROCEDIMINETO ALMACENADO MODIFICAR EMPLEADO CAT_EMPLEADO
GO
CREATE PROCEDURE SP_MODIFIC_CAT_EMPLEADO
@NUM_EMPLEADO     INT,
@ESTADO           BIT ,
@NO_CEDULA        VARCHAR(25) ,
@NO_INSS          VARCHAR(20),
@NOMBRE       VARCHAR(40) ,
@APELLIDO     VARCHAR(40) ,
@DAT_FECHA_NAC    DATE,
@CARGO        INT ,
@GENERO       CHAR(1) ,
@ESTADO_CIVIL CHAR(1) ,
@DIRECCION    VARCHAR(100),
@NUM_TELEFONO     INT,
@CORREO       VARCHAR(40),
@WEB          VARCHAR(80)
AS
BEGIN
UPDATE CAT_EMPLEADO SET
ESTADO=@ESTADO ,
NO_CEDULA=@NO_CEDULA,
NO_INSS=@NO_INSS,
NOMBRE=@NOMBRE,
APELLIDO=@APELLIDO,
DAT_FECHA_NAC=@DAT_FECHA_NAC,
CARGO=@CARGO,
GENERO=@GENERO,
ESTADO_CIVIL=@ESTADO_CIVIL,
DIRECCION=@DIRECCION,
NUM_TELEFONO=@NUM_TELEFONO,
CORREO=@CORREO,
WEB=@WEB
WHERE NUM_EMPLEADO = @NUM_EMPLEADO
END

-----------------PROCEDIMIENTO ALMACENADO SELECCIONAR EMPLEADO CAR_EMPLEADO
GO
CREATE PROCEDURE SP_SELECT_CAT_EMPLEADO
@NUM_EMPLEADO     INT
AS
BEGIN
SELECT * FROM CAT_EMPLEADO
WHERE NUM_EMPLEADO = @NUM_EMPLEADO
END
-------------------PROCEDIMIENTO ALMACENADO ELIMINAR EMPLEADO CAT_EMPLEADO
GO
CREATE PROCEDURE SP_ELIMINAR_CAT_EMPLEADO
@NUM_EMPLEADO     INT
AS
BEGIN
UPDATE CAT_EMPLEADO SET
ESTADO=0
WHERE NUM_EMPLEADO = @NUM_EMPLEADO
END
-------------------PROCEDIMINETO ALMACENADO INSERTAR SALIDA TBL_SALIDA
GO
CREATE PROCEDURE SP_INSERT_TBL_SALIDA
@NUM_REPUESTO  INT,
@NUM_EMPLEADO  INT ,
@DAT_FECHA     DATETIME ,
@TIPO_SALIDA   VARCHAR(30) ,
@OBSERVACIONES VARCHAR(80) ,
@CANTIDAD      FLOAT
AS
BEGIN
INSERT INTO TBL_SALIDA VALUES(@NUM_REPUESTO,@NUM_EMPLEADO,@DAT_FECHA,@TIPO_SALIDA,
@OBSERVACIONES,@CANTIDAD)
END
----------------------PROCEDIMINETO ALMACENADO MODIFICAR SALIDA TBL_SALIDA
GO
CREATE PROCEDURE SP_MODIFIC_TBL_SALIDA
(
@NUM_REPUESTO  INT,
@NUM_SALIDA    INT,
@NUM_EMPLEADO  INT ,
@DAT_FECHA     DATETIME ,
@TIPO_SALIDA   VARCHAR(30) ,
@OBSERVACIONES VARCHAR(80) ,
@CANTIDAD      FLOAT
)
AS
BEGIN
UPDATE TBL_SALIDA SET
NUM_REPUESTO=@NUM_REPUESTO,
NUM_EMPLEADO=@NUM_EMPLEADO,
DAT_FECHA=@DAT_FECHA,
TIPO_SALIDA=@TIPO_SALIDA,
OBSERVACIONES=@OBSERVACIONES,
CANTIDAD=@CANTIDAD
WHERE NUM_SALIDA = @NUM_SALIDA
END
-----------------------PROCEDIMIENTO ALMACENADO SELECCIONAR SALIDA TBL_SALIDA
GO
CREATE PROCEDURE SP_SELECT_TBL_SALIDA
@NUM_SALIDA    INT
AS
BEGIN
SELECT * FROM TBL_SALIDA
WHERE NUM_SALIDA = @NUM_SALIDA
END
-----------------------PROCEDIMIENTO ALMACENADO SELECCIONAR POR FECHA SALIDA TBL_SALIDA
GO
CREATE PROCEDURE SP_SELECT_FEHCA_TBL_SALIDA
@DAT_FECHA    DATE
AS
BEGIN
SELECT * FROM TBL_SALIDA
WHERE MONTH(DAT_FECHA) = MONTH(@DAT_FECHA)
END
------------------PROCEDIMINETO ALMACENADO INSERTAR TBL_MANTENIMIENTO
GO
CREATE PROCEDURE  SP_INSERT_TBL_MANTENIMIENTO
@VEHICULO             INT ,
@TIPO_MANTENIMIENTO   INT ,
@OBSERVACIONES        VARCHAR(MAX),
@REGISTRADO_POR       INT,
@FECHA_MANTENIMIENTO  DATE
AS
BEGIN
INSERT INTO TBL_MANTENIMIENTO VALUES(@VEHICULO,@TIPO_MANTENIMIENTO,@OBSERVACIONES,@REGISTRADO_POR,@FECHA_MANTENIMIENTO)
END
---------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_MANTENIMINETO
GO
CREATE PROCEDURE  SP_MODIFIC_TBL_MANTENIMIENTO
@NUM_MANTENIMIENTO    INT ,
@VEHICULO             INT ,
@TIPO_MANTENIMIENTO   INT ,
@OBSERVACIONES        VARCHAR(MAX),
@REGISTRADO_POR       INT,
@FECHA_MANTENIMIENTO  DATE
AS
BEGIN
UPDATE TBL_MANTENIMIENTO SET
VEHICULO=@VEHICULO,
TIPO_MANTENIMIENTO=@TIPO_MANTENIMIENTO,
OBSERVACIONES=@OBSERVACIONES,
REGISTRADO_POR=@REGISTRADO_POR,
FECHA_MANTENIMIENTO=@FECHA_MANTENIMIENTO
WHERE NUM_MANTENIMIENTO = @NUM_MANTENIMIENTO
END
----------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_MANTENIMIENTO
GO
CREATE PROCEDURE  SP_SELECT_TBL_MANTENIMIENTO
@NUM_MANTENIMIENTO    INT 
AS
BEGIN
SELECT * FROM TBL_MANTENIMIENTO 
WHERE NUM_MANTENIMIENTO = @NUM_MANTENIMIENTO
END
-----------------------PROCEDIMINETO ALMACENADO INSERTAR TBL_REGISTRO_MANTENIMIENTO
GO
CREATE PROCEDURE SP_INSERT_TBL_REGISTRO_MANTENIMIENTO
@MANTENIMIENTO   INT ,
@FECHA_DATE      DATETIME
AS
BEGIN
INSERT INTO TBL_REGISTRO_MANTENIMIENTO VALUES(@MANTENIMIENTO,@FECHA_DATE)
END

-----------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_REGISTRO_MANTENIMINETO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_REGISTRO_MANTENIMIENTO
@IDREGISTROM     INT ,
@MANTENIMIENTO   INT ,
@FECHA_DATE      DATETIME
AS
BEGIN
UPDATE TBL_REGISTRO_MANTENIMIENTO SET
MANTENIMIENTO=@MANTENIMIENTO,
FECHA_DATE=@FECHA_DATE
WHERE IDREGISTROM = @IDREGISTROM
END

-------------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_REGISTRO_MANTENIMIENTO
GO
CREATE PROCEDURE SP_SELECT_TBL_REGISTRO_MANTENIMIENTO
@IDREGISTROM     INT 
AS
BEGIN
SELECT * FROM TBL_REGISTRO_MANTENIMIENTO
WHERE IDREGISTROM = @IDREGISTROM
END
-----------------------PROCEDIMIENTO ALMACENADO INSERTAR CAT_PROVEEDOR
GO
CREATE PROCEDURE SP_INSERT_CAT_PROVEEDOR
@ESTADO                      BIT,
@NUM_IDENTIFICACION          VARCHAR(30),
@TIPO_PROVEEDOR          INT  ,
@NOMBRE                  VARCHAR(100),
@APELLIDO_RAZON_SOCIAL   VARCHAR(100) ,
@FECHA_NAC_CONSTITUCION  DATETIME,
@DIRECCION               VARCHAR(100),
@TELEFONO                INT,
@CORREO                  VARCHAR(40),
@PAGWEB                  VARCHAR(100),
@REGISTRADO_POR          VARCHAR(70),
@AUTORIZADO_POR          VARCHAR(70),
@FECHAINGRESOSISTEM      DATETIME
AS
BEGIN
INSERT INTO CAT_PROVEEDOR VALUES(@ESTADO,@NUM_IDENTIFICACION,@TIPO_PROVEEDOR,@NOMBRE,@APELLIDO_RAZON_SOCIAL,@FECHA_NAC_CONSTITUCION,
@DIRECCION,@TELEFONO,@CORREO,@PAGWEB,@REGISTRADO_POR,@AUTORIZADO_POR,@FECHAINGRESOSISTEM)
END
--------------------PROCEDIMIENTO ALMACENADO MODIFICAR CAT_PROVEEDOR
GO
CREATE PROCEDURE SP_MODIFIC_CAT_PROVEEDOR
@NUM_PROVEEDOR               INT ,
@ESTADO                      BIT,
@NUM_IDENTIFICACION          VARCHAR(30),
@TIPO_PROVEEDOR          INT  ,
@NOMBRE                  VARCHAR(100),
@APELLIDO_RAZON_SOCIAL   VARCHAR(100) ,
@FECHA_NAC_CONSTITUCION  DATETIME,
@DIRECCION               VARCHAR(100),
@TELEFONO                INT,
@CORREO                  VARCHAR(40),
@PAGWEB                  VARCHAR(100),
@REGISTRADO_POR          VARCHAR(70),
@AUTORIZADO_POR          VARCHAR(70),
@FECHAINGRESOSISTEM      DATETIME
AS
BEGIN
UPDATE CAT_PROVEEDOR SET
ESTADO=@ESTADO,
NUM_IDENTIFICACION=@NUM_IDENTIFICACION,
TIPO_PROVEEDOR=@TIPO_PROVEEDOR,
NOMBRE=@NOMBRE,
APELLIDO_RAZON_SOCIAL=@APELLIDO_RAZON_SOCIAL,
FECHA_NAC_CONSTITUCION=@FECHA_NAC_CONSTITUCION,
DIRECCION=@DIRECCION,
TELEFONO=@TELEFONO,
CORREO=@CORREO,
PAGWEB=@PAGWEB,
REGISTRADO_POR=@REGISTRADO_POR,
AUTORIZADO_POR=@AUTORIZADO_POR,
FECHAINGRESOSISTEM=@FECHAINGRESOSISTEM
WHERE NUM_PROVEEDOR= @NUM_PROVEEDOR
END
---------------PROCEDIMINETO ALMACENADO SELECCIONAR CAT_PROVEEDOR
GO
CREATE PROCEDURE SP_SELECT_CAT_PROVEEDOR
@NUM_PROVEEDOR               INT 
AS
BEGIN
SELECT * FROM CAT_PROVEEDOR
WHERE NUM_PROVEEDOR= @NUM_PROVEEDOR
END
---------------PROCEDIMIENTO ALMACENADO ELIMINAR CAT_PROVEEDOR
GO
CREATE PROCEDURE SP_ELIMINAR_CAT_PROVEEDOR
@NUM_PROVEEDOR               INT 
AS
BEGIN
UPDATE CAT_PROVEEDOR SET
ESTADO=0
WHERE NUM_PROVEEDOR= @NUM_PROVEEDOR
END
-----------------PROCEDIMINETO ALMACENADO INSERTAR TBL_LOTE
GO
CREATE PROCEDURE SP_INSERT_TBL_LOTE
@EMPLEADO      INT ,
@DISTRIBUIDOR  INT ,
@FECHA_INGRESO DATE
AS 
BEGIN
INSERT INTO TBL_LOTE VALUES(@EMPLEADO,@DISTRIBUIDOR,@FECHA_INGRESO)
END
----------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_LOTE
GO
CREATE PROCEDURE SP_MODIFIC_TBL_LOTE
@IDLOTE        INT,
@EMPLEADO      INT ,
@DISTRIBUIDOR  INT ,
@FECHA_INGRESO DATE
AS 
BEGIN
UPDATE TBL_LOTE SET
EMPLEADO=@EMPLEADO,
DISTRIBUIDOR=@DISTRIBUIDOR,
FECHA_INGRESO=@FECHA_INGRESO
WHERE IDLOTE = @IDLOTE
END
--------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_LOTE
GO
CREATE PROCEDURE SP_SELECT_TBL_LOTE
@IDLOTE        INT
AS 
BEGIN
SELECT * FROM TBL_LOTE
WHERE IDLOTE = @IDLOTE
END
----------------PROCEDIMIENTO ALMACENADO INSERTAR CAT_RESPUESTO
GO
CREATE PROCEDURE SP_INSERT_CAT_REPUESTO
@ESTADO                     BIT ,
@NUM_CATEGORIA              INT,
@NOMBRE_REPUESTO        VARCHAR(30) ,
@DESCRIPCION_REPUESTO   VARCHAR(100),
@UNIDAD_MEDIDA          VARCHAR(20) ,
@NUM_SERIE              VARCHAR(70),
@CODIGO_BARRA           VARCHAR(100),
@PRECIO_COMPRA          DECIMAL(18,2),
@REGISTRADO_POR         VARCHAR(70),
@FECHA_REGISTRO         DATE
AS
BEGIN
INSERT INTO CAT_REPUESTO VALUES(@ESTADO,@NUM_CATEGORIA,@NOMBRE_REPUESTO,@DESCRIPCION_REPUESTO,@UNIDAD_MEDIDA,@NUM_SERIE,@CODIGO_BARRA,
@PRECIO_COMPRA,@REGISTRADO_POR,@FECHA_REGISTRO)
END
--------------PROCEDIMIENTO ALMACENADO MODIFICAR CAT_RESPUESTO
GO
CREATE PROCEDURE SP_MODIFIC_CAT_REPUESTO
@NUM_REPUESTO               INT ,
@ESTADO                     BIT ,
@NUM_CATEGORIA              INT,
@NOMBRE_REPUESTO        VARCHAR(30) ,
@DESCRIPCION_REPUESTO   VARCHAR(100),
@UNIDAD_MEDIDA          VARCHAR(20) ,
@NUM_SERIE              VARCHAR(70),
@CODIGO_BARRA           VARCHAR(100),
@PRECIO_COMPRA          DECIMAL(18,2),
@REGISTRADO_POR         VARCHAR(70),
@FECHA_REGISTRO         DATE
AS
BEGIN
UPDATE CAT_REPUESTO SET
ESTADO=@ESTADO,
NUM_CATEGORIA=@NUM_CATEGORIA,
NOMBRE_REPUESTO=@NOMBRE_REPUESTO,
DESCRIPCION_REPUESTO=@DESCRIPCION_REPUESTO,
UNIDAD_MEDIDA=@UNIDAD_MEDIDA,
NUM_SERIE=@NUM_SERIE,
CODIGO_BARRA=@CODIGO_BARRA,
PRECIO_COMPRA=@PRECIO_COMPRA,
REGISTRADO_POR=@REGISTRADO_POR,
FECHA_REGISTRO=@FECHA_REGISTRO
WHERE NUM_REPUESTO = @NUM_REPUESTO
END
--------------PROCEDIMIENTO ALMACENADO SELECCIONAR CAT_REPUESTO
GO
CREATE PROCEDURE SP_SELECT_CAT_REPUESTO
@NUM_REPUESTO               INT 
AS
BEGIN
SELECT * FROM CAT_REPUESTO 
WHERE NUM_REPUESTO = @NUM_REPUESTO
END
-------------PROCEDIMIENTO ALMACENADO ELIMINAR CAT_REPUESTO
GO
CREATE PROCEDURE SP_ELIMINAR_CAT_REPUESTO
@NUM_REPUESTO               INT 
AS
BEGIN
UPDATE CAT_REPUESTO SET
ESTADO=0
WHERE NUM_REPUESTO = @NUM_REPUESTO
END
----------------PROCEDIMIENTO ALMACENADO INSERTAR CAT_FORMA_PAGO
GO
CREATE PROCEDURE SP_INSERT_CAT_FORMA_PAGO
@ESTADO   BIT ,
@NOMBRE   VARCHAR(20)
AS
BEGIN
INSERT INTO CAT_FORMA_PAGO VALUES(@ESTADO,@NOMBRE)
END
---------------PROCEDIMIENTO ALMACENADO MODIFICAR CAT_FORMA_PAGO
GO
CREATE PROCEDURE SP_MODIFIC_CAT_FORMA_PAGO
@NUM_PAGO INT,
@ESTADO   BIT ,
@NOMBRE   VARCHAR(20)
AS
BEGIN
UPDATE CAT_FORMA_PAGO SET
@ESTADO=@ESTADO,
NOMBRE=@NOMBRE
WHERE NUM_PAGO = @NUM_PAGO
END
------------------PROCEDIMIENTO ALMACENADO SELECCIONAR CAT_FORMA_PAGO
GO
CREATE PROCEDURE SP_SELECT_CAT_FORMA_PAGO
@NUM_PAGO INT
AS
BEGIN
SELECT * FROM  CAT_FORMA_PAGO
WHERE ESTADO = 1 AND NUM_PAGO = @NUM_PAGO 
END
--------------PROCEDIMIENTO ALMACENADO ELIMINAR CAT_FORMA_PAGO
GO
CREATE PROCEDURE SP_ELIMINAR_CAT_FORMA_PAGO
@NUM_PAGO INT
AS
BEGIN
UPDATE  CAT_FORMA_PAGO SET ESTADO = 0
WHERE  NUM_PAGO = @NUM_PAGO 
END
---------------PROCEDIMIENTO ALMACENADO INSERTAR CAT_MONEDA
GO
CREATE PROCEDURE SP_INSERT_CAT_MONEDA
@ESTADO BIT ,
@NOMBRE  VARCHAR(20)
AS
BEGIN
INSERT INTO CAT_MONEDA VALUES(@ESTADO,@NOMBRE)
END
-------------PROCEDIMIENTO ALMACENADO MODIFICAR CAT_MONEDA
GO
CREATE PROCEDURE SP_MODIFIC_CAT_MONEDA
@NUM_MONEDA INT,
@ESTADO BIT ,
@NOMBRE  VARCHAR(20)
AS
BEGIN
UPDATE CAT_MONEDA SET
ESTADO=@ESTADO,
NOMBRE=@NOMBRE
WHERE NUM_MONEDA = @NUM_MONEDA
END
------------PROCEDIMIENTO ALMACENADO SELECCIONAR CAT_MONEDA
GO
CREATE PROCEDURE SP_SELECT_CAT_MONEDA
@NUM_MONEDA INT
AS
BEGIN
SELECT * FROM CAT_MONEDA
WHERE NUM_MONEDA = @NUM_MONEDA AND ESTADO = 1
END
----------------PROCEDIMIENTO ALMACENDADO ELIMINAR CAT_MONEDA
GO
CREATE PROCEDURE SP_ELIMINAR_CAT_MONEDA
@NUM_MONEDA INT
AS
BEGIN
UPDATE CAT_MONEDA SET
ESTADO=0
WHERE NUM_MONEDA = @NUM_MONEDA
END
---------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_FACTURA_REPUESTO
GO
CREATE PROCEDURE SP_INSERT_TBL_FACTURA_REPUESTO
@ESTADO INT,
@NUM_REPUESTO INT ,
@DESCRIPCION_REPUESTO VARCHAR(100),
@UNIDAD    DECIMAL(10,2),
@NUM_EMPLEADO INT ,
@CLIENTE INT ,
@FORMA_PAGO INT ,
@MONEDA INT ,
@FECHA DATETIME ,
@CANTIDAD DECIMAL(10,2) ,
@PRECIO_UNIDAD DECIMAL(18,2) ,
@IVA  DECIMAL(10,2),
@TOTAL       DECIMAL(18,2)
AS
BEGIN
INSERT INTO TBL_FACTURA_REPUESTO VALUES(@ESTADO,@NUM_REPUESTO,@DESCRIPCION_REPUESTO,@UNIDAD,@NUM_EMPLEADO,@CLIENTE,@FORMA_PAGO,@MONEDA,
@FECHA,@CANTIDAD,@PRECIO_UNIDAD,@IVA,@TOTAL)
END
------------------PROCEDIMIENTO ALMACENADO TBL_FACTURA_REPUESTO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_FACTURA_REPUESTO
@NUM_FACT_REPUESTO INT,
@ESTADO INT,
@NUM_REPUESTO INT ,
@DESCRIPCION_REPUESTO VARCHAR(100),
@UNIDAD    DECIMAL(10,2),
@NUM_EMPLEADO INT ,
@CLIENTE INT ,
@FORMA_PAGO INT ,
@MONEDA INT ,
@FECHA DATETIME ,
@CANTIDAD DECIMAL(10,2) ,
@PRECIO_UNIDAD DECIMAL(18,2) ,
@IVA  DECIMAL(10,2),
@TOTAL       DECIMAL(18,2)
AS
BEGIN
UPDATE TBL_FACTURA_REPUESTO SET
NUM_REPUESTO=@NUM_REPUESTO,
ESTADO = @ESTADO,
DESCRIPCION_REPUESTO=@DESCRIPCION_REPUESTO,
UNIDAD=@UNIDAD,
NUM_EMPLEADO=@NUM_EMPLEADO,
CLIENTE=@CLIENTE,
FORMA_PAGO=@FORMA_PAGO,
MONEDA=@MONEDA,
FECHA=@FECHA,
CANTIDAD=@CANTIDAD,
PRECIO_UNIDAD=@PRECIO_UNIDAD,
IVA=@IVA,
TOTAL=@TOTAL
WHERE NUM_FACT_REPUESTO = @NUM_FACT_REPUESTO
END
-----------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_FACTURA_REPUESTO
GO
CREATE PROCEDURE SP_SELECT_TBL_FACTURA_REPUESTO
@NUM_FACT_REPUESTO INT
AS
BEGIN
SELECT * FROM TBL_FACTURA_REPUESTO 
WHERE NUM_FACT_REPUESTO = @NUM_FACT_REPUESTO AND ESTADO = 1
END
--------------PROCEDIMIENTO ALMACENADO ELIMINAR TBL_FACTURA_REPUESTO
GO
CREATE PROCEDURE SP_ELIMINAR_TBL_FACTURA_REPUESTO
@NUM_FACT_REPUESTO INT
AS
BEGIN
UPDATE TBL_FACTURA_REPUESTO SET
ESTADO = 0
WHERE NUM_FACT_REPUESTO = @NUM_FACT_REPUESTO
END
--------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_INVENTARIO
GO
CREATE PROCEDURE SP_INSERT_TBL_INVENTARIO
@ESTADO               BIT,
@NUM_REPUESTO         INT,
@CANTIDAD             FLOAT,
@CANT_MIN             FLOAT,
@DAT_FECHA_INVENTARIO DATE
AS
BEGIN
INSERT INTO TBL_INVENTARIO VALUES(@ESTADO,@NUM_REPUESTO,@CANTIDAD,@CANT_MIN,@DAT_FECHA_INVENTARIO)
END
------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_INVENTARIO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_INVENTARIO
@ID_INVENTARIO        INT,
@ESTADO               BIT,
@NUM_REPUESTO         INT,
@CANTIDAD             FLOAT,
@CANT_MIN             FLOAT,
@DAT_FECHA_INVENTARIO DATE
AS
BEGIN
UPDATE TBL_INVENTARIO SET
ESTADO=@ESTADO,
NUM_REPUESTO=@NUM_REPUESTO,
CANTIDAD=@CANTIDAD,
CANT_MIN=@CANT_MIN,
DAT_FECHA_INVENTARIO=@DAT_FECHA_INVENTARIO
WHERE ID_INVENTARIO = @ID_INVENTARIO
END
---------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_INVENTARIO
GO
CREATE PROCEDURE SP_SELECT_TBL_INVENTARIO
@ID_INVENTARIO        INT
AS
BEGIN
SELECT * FROM TBL_INVENTARIO 
WHERE ID_INVENTARIO = @ID_INVENTARIO AND ESTADO = 1
END
-----------PROCEDIMIENTO ALMACENADO ELIMINAR TBL_INVENTARIO
GO
CREATE PROCEDURE SP_ELIMINAR_TBL_INVENTARIO
@ID_INVENTARIO        INT
AS
BEGIN
UPDATE TBL_INVENTARIO SET
ESTADO = 0
WHERE ID_INVENTARIO = @ID_INVENTARIO
END
----------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_ENTRADA
GO
CREATE PROCEDURE SP_INSERT_TBL_ENTRADA
@NUM_REPUESTO      INT,
@NUM_DISTRIBUIDOR  INT,
@NUM_EMPLEADO      INT,
@DAT_FECHA         DATETIME ,
@OBSERVACIONES     VARCHAR(80) ,
@CANTIDAD          FLOAT,
@SUBTOTAL          FLOAT,
@DESCUENTO         FLOAT,
@IMPUESTO          FLOAT,
@TOTAL             FLOAT 
AS
BEGIN
INSERT INTO TBL_ENTRADA VALUES(@NUM_REPUESTO,@NUM_DISTRIBUIDOR,@NUM_EMPLEADO,@DAT_FECHA,@OBSERVACIONES,
@CANTIDAD,@SUBTOTAL,@DESCUENTO,@IMPUESTO,@TOTAL)
END
------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_ENTRADA
GO
CREATE PROCEDURE SP_MODIFIC_TBL_ENTRADA
@NUM_ENTRADA       INT,
@NUM_DISTRIBUIDOR  INT,
@NUM_EMPLEADO      INT,
@DAT_FECHA         DATETIME ,
@OBSERVACIONES     VARCHAR(80) ,
@CANTIDAD          FLOAT,
@SUBTOTAL          FLOAT,
@DESCUENTO         FLOAT,
@IMPUESTO          FLOAT,
@TOTAL             FLOAT 
AS
BEGIN
UPDATE TBL_ENTRADA SET
NUM_DISTRIBUIDOR=@NUM_DISTRIBUIDOR,
NUM_EMPLEADO=@NUM_EMPLEADO,
DAT_FECHA=@DAT_FECHA,
OBSERVACIONES=@OBSERVACIONES,
CANTIDAD=@CANTIDAD,
SUBTOTAL=@SUBTOTAL,
DESCUENTO=@DESCUENTO,
IMPUESTO=@IMPUESTO,
TOTAL=@TOTAL
WHERE NUM_ENTRADA = @NUM_ENTRADA
END
-------------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_ENTRADA
GO
CREATE PROCEDURE SP_SELECT_TBL_ENTRADA
@NUM_ENTRADA       INT
AS
BEGIN
SELECT * FROM TBL_ENTRADA
WHERE NUM_ENTRADA = @NUM_ENTRADA
END
-----------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_FACTURA_SERVICIO
GO
CREATE PROCEDURE SP_INSERT_TBL_FACTURA_SERVICIO
@CLIENTE              INT ,
@EMPLEADO             INT ,
@FECHA                DATE ,
@NUM_DETALLE_SERVICIO INT ,
@NUM_VEHICULO INT ,
@TIPO_SERVICIO INT ,
@MONEDA       INT,
@FORMA_PAGO   INT,
@PRECIO MONEY ,
@IMPUESTO FLOAT,
@TOTAL    MONEY
AS
BEGIN
INSERT INTO TBL_FACTURA_SERVICIO VALUES(@CLIENTE  ,@EMPLEADO,@FECHA ,@NUM_DETALLE_SERVICIO,@NUM_VEHICULO,@TIPO_SERVICIO,
@MONEDA,@FORMA_PAGO,@PRECIO,@IMPUESTO,@TOTAL)
END
----------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_FACTURA_SERVICIO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_FACTURA_SERVICIO
@NUM_FACTURA_SERVICIO INT ,
@CLIENTE              INT ,
@EMPLEADO             INT ,
@FECHA                DATE ,
@NUM_DETALLE_SERVICIO INT ,
@NUM_VEHICULO INT ,
@MONEDA       INT,
@FORMA_PAGO   INT,
@TIPO_SERVICIO INT ,
@PRECIO MONEY ,
@IMPUESTO FLOAT,
@TOTAL    MONEY
AS
BEGIN
UPDATE TBL_FACTURA_SERVICIO SET
CLIENTE=@CLIENTE  ,
EMPLEADO=@EMPLEADO,
FECHA=@FECHA ,
NUM_DETALLE_SERVICIO=@NUM_DETALLE_SERVICIO,
NUM_VEHICULO=@NUM_VEHICULO,
SERVICIO=@TIPO_SERVICIO,
MONEDA = @MONEDA      ,
FORMA_PAGO = @FORMA_PAGO  ,
PRECIO=@PRECIO,
IMPUESTO=@IMPUESTO,
TOTAL=@TOTAL
WHERE NUM_FACTURA_SERVICIO = @NUM_FACTURA_SERVICIO
END
-------------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_FACTURA_SERVICIO
GO
CREATE PROCEDURE SP_SELECT_TBL_FACTURA_SERVICIO
@NUM_FACTURA_SERVICIO INT 
AS
BEGIN
SELECT * FROM TBL_FACTURA_SERVICIO
WHERE NUM_FACTURA_SERVICIO = @NUM_FACTURA_SERVICIO
END
----------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_DETALLE_FACTURA_SERVICIO
GO
CREATE PROCEDURE SP_INSERT_TBL_DETALLE_FACTURA_SERVICIO
@SERVICIO     INT ,
@MECANICO     INT ,
@FACTURA      INT 
AS
BEGIN
INSERT INTO TBL_DETALLE_FACTURA_SERVICIO VALUES(@SERVICIO,@MECANICO,@FACTURA)
END
------------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_DETALLE_FACTURA_SERVICIO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_DETALLE_FACTURA_SERVICIO
@NUM_DETALLEF INT ,
@SERVICIO     INT ,
@MECANICO     INT ,
@FACTURA      INT 
AS
BEGIN
UPDATE TBL_DETALLE_FACTURA_SERVICIO SET
SERVICIO=@SERVICIO,
MECANICO=@MECANICO,
FACTURA=@FACTURA
WHERE NUM_DETALLEF = @NUM_DETALLEF
END
-------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_DETALLE_FACTURA_SERVICIO
GO
CREATE PROCEDURE SP_SELECT_TBL_DETALLE_FACTURA_SERVICIO
@NUM_DETALLEF INT 
AS
BEGIN
SELECT * FROM TBL_DETALLE_FACTURA_SERVICIO
WHERE NUM_DETALLEF = @NUM_DETALLEF
END
---------------------PROCEDIMIENTO ALMACENADO INSERTAR CAT_SERVICIO
GO
CREATE PROCEDURE SP_INSERT_CAT_SERVICIOS
@NUM_DETALLE_SERVICIO INT,
@ESTADO       BIT ,
@SERVICIO     VARCHAR(20) ,
@TIPO         INT ,
@PRECIO       MONEY
AS
BEGIN
INSERT INTO CAT_SERVICIOS VALUES(@NUM_DETALLE_SERVICIO,@ESTADO,@SERVICIO,@TIPO,@PRECIO)
END
---------------------PROCEDIMIENTO ALMACENADO MODIFICAR CAT_SERVICIO
GO
CREATE PROCEDURE SP_MODIFIC_CAT_SERVICIOS
@NUM_SERVICIO INT ,
@NUM_DETALLE_SERVICIO INT,
@ESTADO       BIT ,
@SERVICIO     VARCHAR(20) ,
@TIPO         INT ,
@PRECIO       MONEY
AS
BEGIN
UPDATE CAT_SERVICIOS SET 
NUM_DETALLE_SERVICIO=@NUM_DETALLE_SERVICIO,
ESTADO=@ESTADO,
SERVICIO=@SERVICIO,
TIPO=@TIPO,
PRECIO=@PRECIO
WHERE NUM_SERVICIO = @NUM_SERVICIO
END
----------------PROCEDIMIENTO ALMACENADO SELECCIONAR CAT_SERVICIO
GO
CREATE PROCEDURE SP_SELECT_CAT_SERVICIOS
@NUM_SERVICIO INT
AS
BEGIN
SELECT * FROM CAT_SERVICIOS
WHERE NUM_SERVICIO = @NUM_SERVICIO AND ESTADO = 1
END
--------------PROCEDIMIENTO ALMACENADO ELIMINAR CAT_SERVICIO
GO 
CREATE PROCEDURE SP_ELIMINAR_CAT_SERVICIOS
@NUM_SERVICIO INT 
AS
BEGIN
UPDATE CAT_SERVICIOS SET 
ESTADO=1
WHERE NUM_SERVICIO = @NUM_SERVICIO
END
------------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_PRECIO_REPUESTO
GO
CREATE PROCEDURE SP_INSERT_TBL_PRECIO_REPUESTO
@NUM_REPUESTO INT ,
@ESTADO  BIT,
@FECHA   DATE,
@PRECIO_COMPRA FLOAT,
@IVA FLOAT,
@TOTAL FLOAT
AS
BEGIN
INSERT INTO TBL_PRECIO_REPUESTO VALUES(@NUM_REPUESTO,@ESTADO,GETDATE(),@PRECIO_COMPRA,@IVA,@TOTAL)
END
------------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_PRECIO_REPUESTO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_PRECIO_REPUESTO
@NUM_PRECIO_REPUESTO INT,
@NUM_REPUESTO INT ,
@ESTADO  BIT,
@FECHA   DATE,
@PRECIO_COMPRA FLOAT,
@IVA FLOAT,
@TOTAL FLOAT
AS
BEGIN
UPDATE TBL_PRECIO_REPUESTO SET
NUM_REPUESTO=@NUM_REPUESTO,
ESTADO=@ESTADO,
@FECHA=GETDATE(),
PRECIO_COMPRA=@PRECIO_COMPRA,
IVA=@IVA,
TOTAL=@TOTAL
WHERE NUM_PRECIO_REPUESTO = @NUM_PRECIO_REPUESTO
END
-----------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_PRECIO_REPUESTO
GO
CREATE PROCEDURE SP_SELECT_TBL_PRECIO_REPUESTO
@NUM_PRECIO_REPUESTO INT
AS
BEGIN
SELECT * FROM TBL_PRECIO_REPUESTO 
WHERE NUM_PRECIO_REPUESTO = @NUM_PRECIO_REPUESTO AND ESTADO = 1
END
---------------PROCEDIMIENTO ALMACENADO ELIMINAR TBL_PRECIO_REPUESTO
GO
CREATE PROCEDURE SP_ELIMINAR_TBL_PRECIO_REPUESTO
@NUM_PRECIO_REPUESTO INT
AS
BEGIN
UPDATE TBL_PRECIO_REPUESTO SET
ESTADO=0
WHERE NUM_PRECIO_REPUESTO = @NUM_PRECIO_REPUESTO
END
------------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_USUARIO
GO
CREATE PROCEDURE SP_INSERT_TBL_USUARIO
@ESTADO       BIT ,
@EMPLEADO     INT ,
@USUARIO      VARCHAR(20) ,
@CONTRASENA    VARCHAR(40) ,
@FECHA_CUENTA  DATE  
AS
BEGIN
INSERT INTO TBL_USUARIO VALUES(@ESTADO,@EMPLEADO,@USUARIO,CONVERT(varbinary(800),ENCRYPTBYPASSPHRASE('password',@CONTRASENA)),@FECHA_CUENTA)
END
--------------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_USUARIO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_USUARIO
@NUM_USUARIO  INT ,
@ESTADO       BIT ,
@EMPLEADO     INT ,
@USUARIO      VARCHAR(20) ,
@CONTRASENA   VARCHAR(40) ,
@FECHA_CUENTA DATE
AS
BEGIN
UPDATE TBL_USUARIO SET
ESTADO=@ESTADO,
EMPLEADO=@EMPLEADO,
USUARIO=@USUARIO,
CONTRASENA=CONVERT(VARBINARY(800),ENCRYPTBYPASSPHRASE('password',@CONTRASENA)),
FECHA_CUENTA=GETDATE()
WHERE NUM_USUARIO = @NUM_USUARIO
END

------------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_USUARIO
GO
CREATE PROCEDURE SP_SELECT_TBL_USUARIO
@NUM_USUARIO  INT 
AS
BEGIN
SELECT * FROM TBL_USUARIO 
WHERE NUM_USUARIO = @NUM_USUARIO AND ESTADO = 1
END
----------------PROCEDIMIENTO ALMACENADO ELIMINAR TBL_USUARIO
GO
CREATE PROCEDURE SP_ELIMINAR_TBL_USUARIO
@NUM_USUARIO  INT
AS
BEGIN
UPDATE TBL_USUARIO SET
ESTADO=0
WHERE NUM_USUARIO = @NUM_USUARIO
END
---------------------PROCEDIMIENTO ALMACENADO INICIO_SESION TBL_USUARIO
GO
CREATE PROCEDURE SP_INICIAR_SESION
@USUARIO      VARCHAR(20) ,
@CONTRASENA    VARCHAR(40) 
AS
BEGIN
SELECT E.NOMBRE,E.APELLIDO,C.CARGO FROM TBL_USUARIO AS U
INNER JOIN CAT_EMPLEADO AS E ON E.NUM_EMPLEADO = U.EMPLEADO
INNER JOIN TBL_CARGO AS C ON E.CARGO = C.NUM_CARGO 
WHERE U.USUARIO = @USUARIO AND CONVERT(VARCHAR(40),DECRYPTBYPASSPHRASE('password',U.CONTRASENA)) = @CONTRASENA AND E.ESTADO = 1 AND C.ESTADO = 1
END

----------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_FACTURA
GO
CREATE PROCEDURE SP_INSERT_TBL_FACTURA
@NUM_CLIENTE   INT,
@NUM_EMPLEADO  INT,
@ESTADO        BIT,
@FORMA_PAGO    INT,
@MONEDA        INT,
@FECHA_FACTURA DATE,
@CANTIDAD      FLOAT,
@SUB_TOTAL     MONEY,
@IMPUESTO      FLOAT,
@TOTAL         MONEY
AS
BEGIN
INSERT INTO  TBL_FACTURA VALUES(@NUM_CLIENTE,@NUM_VEHICULO,@NUM_EMPLEADO,
@ESTADO,@FORMA_PAGO,@MONEDA,@FECHA_FACTURA,@CANTIDAD,@SUB_TOTAL,@IMPUESTO,@TOTAL)
END
-------------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_FACTURA
GO
CREATE PROCEDURE SP_MODIFIC_TBL_FACTURA
@NUM_FACTURA   INT,
@NUM_CLIENTE   INT,
@NUM_EMPLEADO  INT,
@ESTADO        BIT,
@FORMA_PAGO    INT,
@MONEDA        INT,
@FECHA_FACTURA DATE,
@CANTIDAD      FLOAT,
@SUB_TOTAL     MONEY,
@IMPUESTO      FLOAT,
@TOTAL         MONEY
AS
BEGIN
UPDATE  TBL_FACTURA SET
NUM_CLIENTE=@NUM_CLIENTE,
NUM_EMPLEADO=@NUM_EMPLEADO,
ESTADO = @ESTADO ,
FORMA_PAGO = @FORMA_PAGO ,
MONEDA = @MONEDA ,
FECHA_FACTURA=@FECHA_FACTURA,
CANTIDAD=@CANTIDAD,
SUB_TOTAL=@SUB_TOTAL,
IMPUESTO=@IMPUESTO,
TOTAL=@TOTAL
WHERE NUM_FACTURA = @NUM_FACTURA
END
-----------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_FACTURA
GO
CREATE PROCEDURE SP_SELECT_TBL_FACTURA
@NUM_FACTURA   INT
AS
BEGIN
SELECT * FROM TBL_FACTURA
WHERE NUM_FACTURA = @NUM_FACTURA
END
----------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_DETALLE_FACTURA_VEHICULO
GO
CREATE PROCEDURE SP_INSERT_TBL_DETALLE_FACTURA_VEHICULO
@VEHICULO     INT,
@FACTURA      INT
AS
BEGIN
INSERT INTO TBL_DETALLE_FACTURA_VEHICULO VALUES(@VEHICULO,@FACTURA)
END
----------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_DETALLE_FACTURA_SERVICIO
GO
CREATE PROCEDURE SP_MODIFIC_TBL_DETALLE_FACTURA_VEHICULO
@NUM_DETALLEF INT,
@VEHICULO     INT,
@FACTURA      INT
AS
BEGIN
UPDATE TBL_DETALLE_FACTURA_VEHICULO SET
VEHICULO=@VEHICULO,
FACTURA=@FACTURA
WHERE NUM_DETALLEF = @NUM_DETALLEF
END
----------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_DETALLE_FACTURA_VEHICULO
GO
CREATE PROCEDURE SP_SELECT_TBL_DETALLE_FACTURA_VEHICULO
@NUM_DETALLEF INT
AS
BEGIN
SELECT * FROM TBL_DETALLE_FACTURA_VEHICULO 
WHERE NUM_DETALLEF = @NUM_DETALLEF
END
----------------PROCEDIMIENTO ALMACENADO INSERTAR TBL_DETALLE_LOTE
GO
CREATE PROCEDURE SP_INSERT_TBL_DETALLE_LOTE
@VEHICULO    INT,
@LOTE        INT
AS
BEGIN
INSERT INTO TBL_DETALLE_LOTE VALUES(@VEHICULO,@LOTE)
END
------------PROCEDIMIENTO ALMACENADO MODIFICAR TBL_DETALLE_LOTE
GO
CREATE PROCEDURE SP_MODIFIC_TBL_DETALLE_LOTE
@NUMDETALLE  INT ,
@VEHICULO    INT,
@LOTE        INT
AS
BEGIN
UPDATE TBL_DETALLE_LOTE SET
VEHICULO=@VEHICULO,
LOTE=@LOTE
WHERE NUMDETALLE = @NUMDETALLE
END
--------------PROCEDIMIENTO ALMACENADO SELECCIONAR TBL_DETALLE_LOTE
GO
CREATE PROCEDURE SP_SELECT_TBL_DETALLE_LOTE
@NUMDETALLE  INT 
AS
BEGIN
SELECT * FROM TBL_DETALLE_LOTE
WHERE NUMDETALLE = @NUMDETALLE
END

GO