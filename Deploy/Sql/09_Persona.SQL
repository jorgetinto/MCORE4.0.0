IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Persona') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.Persona;

CREATE TABLE Core.Persona ( 
	NumeroPersona bigint identity(1,1)  NOT NULL,
	Giro varchar(300),
	Observaciones varchar(300),
	IdCondicionPago smallint,
	IdRubro smallint,
	CodigoPaisResidencia varchar(10) NOT NULL,
	IdTipoPersona tinyint NOT NULL
);

ALTER TABLE Core.Persona ADD CONSTRAINT PK_Persona 
	PRIMARY KEY CLUSTERED (NumeroPersona);

ALTER TABLE Core.Persona ADD CONSTRAINT FK_Persona_CondicionPago 
	FOREIGN KEY (IdCondicionPago) REFERENCES Core.CondicionPago (IdCondicionPago)
	ON DELETE SET NULL ON UPDATE CASCADE;

ALTER TABLE Core.Persona ADD CONSTRAINT FK_Persona_Pais 
	FOREIGN KEY (CodigoPaisResidencia) REFERENCES Core.Pais (CodigoPais)
	ON DELETE NO ACTION ON UPDATE CASCADE;

ALTER TABLE Core.Persona ADD CONSTRAINT FK_Persona_Rubro 
	FOREIGN KEY (IdRubro) REFERENCES Core.Rubro (IdRubro)
	ON DELETE SET NULL ON UPDATE CASCADE;

ALTER TABLE Core.Persona ADD CONSTRAINT FK_Persona_TipoPersona 
	FOREIGN KEY (IdTipoPersona) REFERENCES Core.TipoPersona (IdTipoPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;








