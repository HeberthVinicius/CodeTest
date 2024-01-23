﻿/* VEI003_COMBUSTIVEL.sql

SCRIPT PARA DA TABELA VEI003_COMBUSTIVEL.
Deve ser executado após a criação do banco de dados.

*/

USE DBCONCESSIONARIA
GO

CREATE TABLE VEI003_COMBUSTIVEL (
    IdeCombustivel      TINYINT         NOT NULL PRIMARY KEY
,   NmeCombustivel      VARCHAR(15)     NOT NULL
)
GO

CREATE UNIQUE INDEX UNQ_VEI003_NmeCombustivel
    ON VEI003_COMBUSTIVEL (NmeCombustivel);
GO
