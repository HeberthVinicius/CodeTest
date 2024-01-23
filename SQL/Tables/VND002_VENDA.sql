/* VEI002_MODELO.sql

SCRIPT PARA DA TABELA VEI002_MODELO.
Deve ser executado após a criação do banco de dados.

*/

USE DBCONCESSIONARIA
GO

CREATE TABLE VND002_VENDA (
    IdeVenda            INT             NOT NULL
        PRIMARY KEY IDENTITY(1,1)
,   IdeVendedor         INT             NOT NULL
,   IdeModeloVersao     INT             NOT NULL
,   VlrPrecoVenda       NUMERIC(10,2)   NOT NULL
,   StaValeCombustivel  BIT             NOT NULL
)
GO
