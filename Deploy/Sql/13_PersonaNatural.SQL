IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('PersonaNatural') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.PersonaNatural;

CREATE TABLE Core.PersonaNatural ( 
	NumeroPersona bigint NOT NULL,
	PrimerNombre varchar(100) NOT NULL,
	SegundoNombre varchar(100),
	ApellidoPaterno varchar(100) NOT NULL,
	ApellidoMaterno varchar(100)
);

ALTER TABLE Core.PersonaNatural ADD CONSTRAINT PK_PersonaNatural 
	PRIMARY KEY CLUSTERED (NumeroPersona);

ALTER TABLE Core.PersonaNatural ADD CONSTRAINT FK_PersonaNatural_Persona 
	FOREIGN KEY (NumeroPersona) REFERENCES Core.Persona (NumeroPersona)
	ON DELETE NO ACTION ON UPDATE NO ACTION;






