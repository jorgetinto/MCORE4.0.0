IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Parametro') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.Parametro;

CREATE TABLE Core.Parametro ( 
	IdParametro int NOT NULL,
	Nombre varchar(100) NOT NULL,
	IdElementoUI varchar(100) NOT NULL,
	UrlIndex varchar(1000) NOT NULL
);

ALTER TABLE Core.Parametro ADD CONSTRAINT PK_Parametro 
	PRIMARY KEY CLUSTERED (IdParametro);





