IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Region') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.Region;

CREATE TABLE Core.Region ( 
	CodigoPais varchar(10) NOT NULL,
	IdRegion int NOT NULL,
	Nombre varchar(100) NOT NULL,
	EsDefault bit NOT NULL
);

ALTER TABLE Core.Region ADD CONSTRAINT PK_Region 
	PRIMARY KEY CLUSTERED (CodigoPais, IdRegion);

ALTER TABLE Core.Region ADD CONSTRAINT FK_Region_Pais 
	FOREIGN KEY (CodigoPais) REFERENCES Core.Pais (CodigoPais)
	ON DELETE NO ACTION ON UPDATE CASCADE;





