/* VND001_VENDEDOR.sql

SCRIPT PARA DA TABELA VND001_VENDEDOR.
Deve ser executado após a criação do banco de dados.

*/

USE DBCONCESSIONARIA
GO

CREATE TABLE VND001_VENDEDOR (
    IdeVendedor         INT             NOT NULL
        PRIMARY KEY IDENTITY(1,1)
,   NmeVendedor         VARCHAR(50)     NOT NULL
)
GO
