IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Rubro') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.Rubro;

CREATE TABLE Core.Rubro ( 
	IdRubro smallint NOT NULL,
	Nombre varchar(100) NOT NULL
);

ALTER TABLE Core.Rubro ADD CONSTRAINT PK_Rubro 
	PRIMARY KEY CLUSTERED (IdRubro);



