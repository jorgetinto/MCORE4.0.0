IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('PersonaJuridica') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.PersonaJuridica;

CREATE TABLE Core.PersonaJuridica ( 
	NumeroPersona bigint NOT NULL,
	RazonSocial varchar(300) NOT NULL,
	NombreFantasia varchar(300)
);

ALTER TABLE Core.PersonaJuridica ADD CONSTRAINT PK_PersonaJuridica 
	PRIMARY KEY CLUSTERED (NumeroPersona);

ALTER TABLE Core.PersonaJuridica ADD CONSTRAINT FK_PersonaJuridica_Persona 
	FOREIGN KEY (NumeroPersona) REFERENCES Core.Persona (NumeroPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;




