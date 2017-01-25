IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Pais') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.Pais;

CREATE TABLE Core.Pais ( 
	CodigoPais varchar(10) NOT NULL,
	Nombre varchar(100) NOT NULL,
	Nacionalidad varchar(100) NOT NULL,
	EsDefault bit NOT NULL
);

ALTER TABLE Core.Pais ADD CONSTRAINT PK_Pais 
	PRIMARY KEY CLUSTERED (CodigoPais);





