/* VEI001_MARCA.sql

SCRIPT PARA DA TABELA VEI001_MARCA.
Deve ser executado após a criação do banco de dados.

*/

USE DBCONCESSIONARIA
GO

CREATE TABLE VEI001_MARCA (
    IdeMarca    INT             NOT NULL
        PRIMARY KEY IDENTITY(1,1)
,   NmeMarca    VARCHAR(35)     NOT NULL
)
GO

CREATE UNIQUE INDEX UNQ_VEI001_NmeMarca
    ON VEI001_MARCA (NmeMarca);
GO