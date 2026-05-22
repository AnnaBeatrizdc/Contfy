-- Criar banco
CREATE DATABASE Contfy;
USE Contfy;



-- Tabela Usuario

CREATE TABLE Usuario (
	cd_codigo INT PRIMARY KEY IDENTITY(1,1),
	nm_nome VARCHAR(100) NOT NULL,
	nm_tipoUsuario VARCHAR(50) NOT NULL,
	ds_email VARCHAR(100) NOT NULL UNIQUE,
	ds_senha VARCHAR(255) NOT NULL, -- preparado para hash
	cd_telefone VARCHAR(15) NOT NULL,
	cd_CEP VARCHAR(10) NULL,
	nm_logradouro VARCHAR(200) NOT NULL,
	nm_bairro VARCHAR(100) NOT NULL,
	nm_localidade VARCHAR(100) NOT NULL,
	sg_uf CHAR(2) NOT NULL
);

-- Tabela Container
CREATE TABLE Container (
	cd_codigo VARCHAR(10) PRIMARY KEY,
	nm_nome VARCHAR(100) NOT NULL,
	nm_status VARCHAR(50) NOT NULL,
	ds_localizacao VARCHAR(200) NOT NULL,
	cd_usuario INT NULL, 

	FOREIGN KEY (cd_usuario) REFERENCES Usuario(cd_codigo)
);

SELECT * FROM Usuario;
SELECT * FROM Container;


-- JOIN

SELECT 
	c.cd_codigo AS ContainerCodigo,
	c.nm_nome AS ContainerNome,
	c.nm_status AS ContainerStatus,
	c.ds_localizacao AS ContainerLocalizacao,
	u.nm_nome AS UsuarioNome,
	u.nm_tipoUsuario AS UsuarioTipo,
	u.ds_email AS UsuarioEmail
FROM Container c
LEFT JOIN Usuario u ON c.cd_usuario = u.cd_codigo;