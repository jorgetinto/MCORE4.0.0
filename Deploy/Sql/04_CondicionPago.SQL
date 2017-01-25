IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('CondicionPago') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.CondicionPago;

CREATE TABLE Core.CondicionPago ( 
	IdCondicionPago smallint NOT NULL,
	Nombre varchar(100) NOT NULL,
	Dias smallint
);

ALTER TABLE Core.CondicionPago ADD CONSTRAINT PK_CondicionPago 
	PRIMARY KEY CLUSTERED (IdCondicionPago);




