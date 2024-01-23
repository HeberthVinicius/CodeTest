/* VEI004_MODELO_VERSAO.sql

SCRIPT PARA DA TABELA VEI004_MODELO_VERSAO.
Deve ser executado após a criação do banco de dados.

*/

USE DBCONCESSIONARIA
GO

CREATE TABLE VEI004_MODELO_VERSAO (
    IdeModeloVersao     INT             NOT NULL
        PRIMARY KEY IDENTITY(1,1)
,   IdeModelo           INT             NOT NULL
,   IdeCombustivel      TINYINT         NOT NULL
,   NroAno              SMALLINT        NULL
,   VlrPrecoTabelado    NUMERIC(10,2)   NOT NULL
)
GO

CREATE UNIQUE INDEX UNQ_VEI004_IdeModelo_IdeCombustivel_NroAno
    ON VEI004_MODELO_VERSAO (IdeModelo, IdeCombustivel, NroAno);
GO
