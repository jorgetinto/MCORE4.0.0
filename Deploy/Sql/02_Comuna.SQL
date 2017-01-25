IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Comuna') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.Comuna;

CREATE TABLE Core.Comuna ( 
	CodigoPais varchar(10) NOT NULL,
	IdRegion int NOT NULL,
	IdComuna int NOT NULL,
	Nombre varchar(100) NOT NULL,
	EsDefault bit NOT NULL
);

ALTER TABLE Core.Comuna ADD CONSTRAINT PK_Comuna 
	PRIMARY KEY CLUSTERED (CodigoPais, IdRegion, IdComuna);

ALTER TABLE Core.Comuna ADD CONSTRAINT FK_Comuna_Region 
	FOREIGN KEY (CodigoPais, IdRegion) REFERENCES Core.Region (CodigoPais, IdRegion)
	ON DELETE NO ACTION ON UPDATE CASCADE;






