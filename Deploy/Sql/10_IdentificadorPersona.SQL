IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('IdentificadorPersona') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.IdentificadorPersona;

CREATE TABLE Core.IdentificadorPersona ( 
	NumeroPersona bigint NOT NULL,
	CodigoPais varchar(10) NOT NULL,
	IdTipoIdentificadorPersona int NOT NULL,
	Valor varchar(50) NOT NULL,
	Fecha datetime NOT NULL
);

ALTER TABLE Core.IdentificadorPersona ADD CONSTRAINT PK_IdentificadorPersona 
	PRIMARY KEY CLUSTERED (NumeroPersona, CodigoPais, IdTipoIdentificadorPersona);

ALTER TABLE Core.IdentificadorPersona ADD CONSTRAINT FK_IdentificadorPersona_Persona 
	FOREIGN KEY (NumeroPersona) REFERENCES Core.Persona (NumeroPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE Core.IdentificadorPersona ADD CONSTRAINT FK_IdentificadorPersona_TipoIdentificadorPersona 
	FOREIGN KEY (CodigoPais, IdTipoIdentificadorPersona) REFERENCES Core.TipoIdentificadorPersona (CodigoPais, IdTipoIdentificadorPersona)
	ON DELETE NO ACTION ON UPDATE CASCADE;






