CREATE DATABASE TIENDA
GO
USE TIENDA
GO
CREATE TABLE TBL_CARGO
(
NUM_CARGO  INT IDENTITY PRIMARY KEY,
ESTADO     BIT,
CARGO      VARCHAR(40)
)
CREATE TABLE CAT_EMPLEADO
(
NUM_EMPLEADO INT IDENTITY PRIMARY KEY,
ESTADO        BIT,
DOC_IDENTIDAD VARCHAR(30),
NOMBRE        VARCHAR(80),
APELLIDO      VARCHAR(80),
CARGO         INT REFERENCES TBL_CARGO(NUM_CARGO),
TELEFONO      CHAR(15),
DIRECCION     VARCHAR(MAX),
CORREO        NCHAR(80)
)
CREATE TABLE CAT_CLIENTE
(
NUM_CLIENTE INT IDENTITY PRIMARY KEY,
ESTADO        BIT,
DOC_IDENTIDAD VARCHAR(30),
NOMBRE        VARCHAR(80),
APELLIDO      VARCHAR(80),
TELEFONO      CHAR(15),
DIRECCION     VARCHAR(MAX),
CORREO        NCHAR(80)
)
CREATE TABLE CAT_CATEGORIA
(
NUM_CATEGORIA    INT IDENTITY PRIMARY KEY,
ESTADO           BIT,
CATEGORIA        CHAR(20),
DESCRIPCION      VARCHAR(MAX)
)
CREATE TABLE CAT_PRODUCTO
(
NUM_PRODUCTO INT IDENTITY PRIMARY KEY,
ESTADO       BIT,
CATEGORIA    INT REFERENCES CAT_CATEGORIA(NUM_CATEGORIA),
PRODUCTO     VARCHAR(40),
MARCA         CHAR(20),
UNIDAD_MEDIDA VARCHAR(40),
NUM_SERIE     VARCHAR(80)
)

CREATE TABLE TBL_STOCK   
(
NUM_STOCK   INT IDENTITY PRIMARY KEY,
NUM_PRODCUTO    INT REFERENCES CAT_PRODUCTO(NUM_PRODUCTO),
CANTIDAD     FLOAT,
)
--CREATE TABLE TBL_SALIDA
--(
--NUM_SALIDA INT IDENTITY PRIMARY KEY,
--NUM_PRODUCTO  INT REFERENCES CAT_PRODUCTO(NUM_PRODUCTO),
--NUM_EMPLEADO  INT REFERENCES CAT_EMPLEADO(NUM_EMPLEADO),
--CANTIDAD      FLOAT
--)
CREATE TABLE TBL_ENTRADA
(
NUM_ENTRADA INT IDENTITY PRIMARY KEY,
NUM_PRODUCTO  INT REFERENCES CAT_PRODUCTO(NUM_PRODUCTO),
NUM_EMPLEADO  INT REFERENCES CAT_EMPLEADO(NUM_EMPLEADO),
CANTIDAD      FLOAT,
SUBTOTAL      FLOAT,
IVA           FLOAT,
TOTAL         FLOAT
)
CREATE TABLE TBL_VENTA   
(
NUM_VENTA    INT IDENTITY PRIMARY KEY,
NUM_PRODUCTO     INT REFERENCES CAT_PRODUCTO(NUM_PRODUCTO),
NUM_EMPLEADO     INT REFERENCES CAT_EMPLEADO(NUM_EMPLEADO),
NUM_CLIENTE      INT REFERENCES CAT_CLIENTE(NUM_CLIENTE),
CAMTIDAD         FLOAT,
SUBTOTAL         FLOAT,
IVA              FLOAT,
TOTAL            FLOAT
)  
----------------------------------------------------------------------------
GO
CREATE TRIGGER TR_ESTADO_PRODUCTO
ON TBL_STOCK FOR UPDATE 
AS
BEGIN
SET NOCOUNT ON
UPDATE CAT_PRODUCTO   SET ESTADO = 0 FROM inserted
INNER JOIN TBL_STOCK AS S ON S.NUM_PRODCUTO = inserted.NUM_PRODCUTO
WHERE S.CANTIDAD < 1 AND CAT_PRODUCTO.NUM_PRODUCTO = inserted.NUM_PRODCUTO
END 
GO
CREATE TRIGGER TR_ESTADO_PRODUCTO2
ON TBL_STOCK FOR UPDATE 
AS
BEGIN
SET NOCOUNT ON
UPDATE CAT_PRODUCTO   SET ESTADO = 1 FROM inserted
INNER JOIN TBL_STOCK AS S ON S.NUM_PRODCUTO = inserted.NUM_PRODCUTO
WHERE S.CANTIDAD > 0 AND CAT_PRODUCTO.NUM_PRODUCTO = inserted.NUM_PRODCUTO
END 
GO
CREATE TRIGGER TR_VENTA
ON TBL_VENTA FOR insert 
AS
BEGIN
SET NOCOUNT ON
UPDATE TBL_STOCK   SET CANTIDAD = CANTIDAD - inserted.CAMTIDAD FROM inserted
END 
GO
UPDATE  TBL_STOCK  SET   CANTIDAD = 8 WHERE NUM_PRODCUTO = 2

SELECT * FROM TBL_STOCK
SELECT * FROM CAT_PRODUCTO
SELECT * FROM TBL_ENTRADA

EXECUTE SP_VENTA 2,2,1,2,600.19,90.0285,690.2185
GO
EXECUTE SP_INSERT_STOCK 3,2,18,2500,375,2875
GO

CREATE PROCEDURE SP_VENTA
@NUM_PRODUCTO     INT ,
@NUM_EMPLEADO     INT ,
@NUM_CLIENTE      INT ,
@CAMTIDAD         FLOAT,
@SUBTOTAL         FLOAT,
@IVA              FLOAT,
@TOTAL            FLOAT
AS
BEGIN
INSERT INTO TBL_VENTA VALUES(@NUM_PRODUCTO,@NUM_EMPLEADO,@NUM_CLIENTE,@CAMTIDAD,@SUBTOTAL,
@IVA,@TOTAL)
END
GO
CREATE PROCEDURE SP_INSERT_STOCK
@NUM_PRODUCTO  INT,
@NUM_EMPLEADO  INT,
@CANTIDAD      FLOAT,
@SUBTOTAL      FLOAT,
@IVA           FLOAT,
@TOTAL         FLOAT
AS
BEGIN
INSERT INTO TBL_ENTRADA VALUES(@NUM_PRODUCTO,@NUM_EMPLEADO,@CANTIDAD,@SUBTOTAL,@IVA,@TOTAL)
END
GO
CREATE TRIGGER TR_STOCK_INCREMENTO
ON TBL_ENTRADA FOR insert 
AS
BEGIN
SET NOCOUNT ON
UPDATE TBL_STOCK   SET TBL_STOCK.CANTIDAD = TBL_STOCK.CANTIDAD + inserted.CANTIDAD FROM inserted
WHERE  TBL_STOCK.NUM_PRODCUTO = inserted.NUM_PRODUCTO
END 
GO