IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TipoPersona') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.TipoPersona;

CREATE TABLE Core.TipoPersona ( 
	IdTipoPersona tinyint NOT NULL,
	Nombre varchar(100) NOT NULL
);

ALTER TABLE Core.TipoPersona ADD CONSTRAINT PK_TipoPersona 
	PRIMARY KEY CLUSTERED (IdTipoPersona);



