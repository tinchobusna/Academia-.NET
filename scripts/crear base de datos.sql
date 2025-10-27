personas-- Crea la base y las tablas para MySQL (compatible con MySQL / MariaDB)
CREATE DATABASE IF NOT EXISTS baseAcademia
  CHARACTER SET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;
USE baseAcademia;

-- Tabla Personas
CREATE TABLE IF NOT EXISTS Personas (
  IdPersona INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Apellido VARCHAR(100) NOT NULL,
  Direccion VARCHAR(200) NULL,
  Email VARCHAR(255) NULL,
  FechaNacimiento DATE NULL,
  IdPlan INT NULL,
  Legajo INT NULL,
  Telefono VARCHAR(50) NULL,
  TipoPersona VARCHAR(50) NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Tabla Usuarios
CREATE TABLE IF NOT EXISTS Usuarios (
  IdUsuario INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  NombreUsuario VARCHAR(100) NOT NULL,
  Clave VARCHAR(255) NOT NULL,
  Habilitado TINYINT(1) NOT NULL DEFAULT 1,
  Nombre VARCHAR(100) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,
  Email VARCHAR(255) NOT NULL,
  CambiaClave TINYINT(1) NOT NULL DEFAULT 0,
  IdPersona INT NULL,
  UNIQUE KEY UQ_Usuarios_Email (Email),
  UNIQUE KEY UQ_Usuarios_NombreUsuario (NombreUsuario),
  CONSTRAINT FK_Usuarios_Personas FOREIGN KEY (IdPersona) REFERENCES Personas(IdPersona) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Datos de ejemplo (opcional)
INSERT INTO Personas (Apellido, Direccion, Email, FechaNacimiento, IdPlan, Legajo, Telefono, TipoPersona)
VALUES ('Perez', 'Av. Siempre Viva 123', 'perez.persona@example.com', '1990-01-01', NULL, 12345, '555-1234', 'Alumno');

INSERT INTO Usuarios (NombreUsuario, Clave, Habilitado, Nombre, Apellido, Email, CambiaClave, IdPersona)
VALUES ('jperez', 'miClaveDePrueba', 1, 'Juan', 'Perez', 'jperez@example.com', 0, 1);