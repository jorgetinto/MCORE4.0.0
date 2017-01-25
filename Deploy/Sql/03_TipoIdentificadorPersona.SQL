IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TipoIdentificadorPersona') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.TipoIdentificadorPersona;

CREATE TABLE Core.TipoIdentificadorPersona ( 
	CodigoPais varchar(10) NOT NULL,
	IdTipoIdentificadorPersona int NOT NULL,
	Nombre varchar(100) NOT NULL,
	Descripcion varchar(300)
);

ALTER TABLE Core.TipoIdentificadorPersona ADD CONSTRAINT PK_TipoIdentificadorPersona 
	PRIMARY KEY CLUSTERED (CodigoPais, IdTipoIdentificadorPersona);

ALTER TABLE Core.TipoIdentificadorPersona ADD CONSTRAINT FK_TipoIdentificadorPersona_Pais 
	FOREIGN KEY (CodigoPais) REFERENCES Core.Pais (CodigoPais)
	ON DELETE NO ACTION ON UPDATE CASCADE;





