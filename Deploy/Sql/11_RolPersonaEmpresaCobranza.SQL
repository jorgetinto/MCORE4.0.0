IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('RolPersonaEmpresaCobranza') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.RolPersonaEmpresaCobranza;

CREATE TABLE Core.RolPersonaEmpresaCobranza ( 
	NumeroPersonaEmpresaCobranza bigint NOT NULL,
	NumeroPersonaDesempena bigint NOT NULL,
	NumeroPersonaMotivo bigint NOT NULL,
	IdRolPersonaDesempena int NOT NULL,
	FechaAsignacion datetime NOT NULL,
	EstaEliminado bit NOT NULL
);

ALTER TABLE Core.RolPersonaEmpresaCobranza ADD CONSTRAINT PK_RolPersonaEmpresaCobranza 
	PRIMARY KEY CLUSTERED (NumeroPersonaEmpresaCobranza, NumeroPersonaDesempena, NumeroPersonaMotivo, IdRolPersonaDesempena, FechaAsignacion);

ALTER TABLE Core.RolPersonaEmpresaCobranza ADD CONSTRAINT FK_RolPersonaEmpresaCobranza_PersonaEmpresaCobranza 
	FOREIGN KEY (NumeroPersonaEmpresaCobranza) REFERENCES Core.Persona (NumeroPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE Core.RolPersonaEmpresaCobranza ADD CONSTRAINT FK_RolPersonaEmpresaCobranza_RolPersona 
	FOREIGN KEY (IdRolPersonaDesempena) REFERENCES Core.RolPersona (IdRolPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE Core.RolPersonaEmpresaCobranza ADD CONSTRAINT FK_RolPersonaEmpresaCobranza_PersonaMotivo 
	FOREIGN KEY (NumeroPersonaMotivo) REFERENCES Core.Persona (NumeroPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE Core.RolPersonaEmpresaCobranza ADD CONSTRAINT FK_RolPersonaEmpresaCobranza_PersonaDesempena 
	FOREIGN KEY (NumeroPersonaDesempena) REFERENCES Core.Persona (NumeroPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;







