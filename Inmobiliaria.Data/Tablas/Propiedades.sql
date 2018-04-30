﻿CREATE TABLE [dbo].[Propiedades]
(
	[ID_PROPIEDADES] INT NOT NULL PRIMARY KEY, 
    [DIRECCION] VARCHAR(50) NOT NULL, 
    [ID_PROPIETARIO] NCHAR(10) NOT NULL, 
    [PRECIO_BASE] INT NOT NULL, 
    [SUPERFICIE] INT NOT NULL, 
    [TIENE_PATIO] BIT NULL, 
    [PISO] INT NULL, 
    [LETRA] CHAR(1) NULL, 
    [ES_CASA] BIT NOT NULL
)
