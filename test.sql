CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL
);


CREATE TABLE IF NOT EXISTS PER (
	PER_ID SERIAL PRIMARY KEY,
    PER_CODIGO VARCHAR(255),
    PER_NOMBRE VARCHAR(255),
    PER_DESCRIPCION VARCHAR(255),
    CREADO_POR VARCHAR(255),
    FECHA_CREACION TIMESTAMP,
    MODIFICADO_POR VARCHAR(255),
    FECHA_MODIFICADO TIMESTAMP
);