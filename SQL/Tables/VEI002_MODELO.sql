/* VEI002_MODELO.sql

SCRIPT PARA DA TABELA VEI002_MODELO.
Deve ser executado após a criação do banco de dados.

*/

USE DBCONCESSIONARIA
GO

CREATE TABLE VEI002_MODELO (
    IdeModelo   INT             NOT NULL
        PRIMARY KEY IDENTITY(1,1)
,   IdeMarca    INT             NOT NULL
,   CodModelo   CHAR(8)         NOT NULL
,   NmeModelo   VARCHAR(50)     NOT NULL
)
GO

CREATE UNIQUE INDEX UNQ_VEI002_IdeMarca_NmeModelo
    ON VEI002_MODELO (IdeMarca, NmeModelo);
GO

CREATE UNIQUE INDEX UNQ_VEI002_CodModelo
    ON VEI002_MODELO (CodModelo);
GO
