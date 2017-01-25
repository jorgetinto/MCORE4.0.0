IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('RolPersona') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Core.RolPersona;

CREATE TABLE Core.RolPersona ( 
	IdRolPersona int NOT NULL,
	Nombre varchar(100) NOT NULL
);

ALTER TABLE Core.RolPersona ADD CONSTRAINT PK_RolPersona 
	PRIMARY KEY CLUSTERED (IdRolPersona);



