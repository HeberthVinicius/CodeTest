/* MargemDaVenda.sql

SCRIPT DE CONSULTA AUXILIAR.
Deve ser executado após a população das tabelas.

*/

USE DBCONCESSIONARIA
GO

SELECT
    VND002.IdeVenda
,   VND002.IdeVendedor
,   VND002.IdeModeloVersao
,   VEI004.IdeModelo
,   VND002.StaValeCombustivel
,   VEI004.VlrPrecoTabelado
,   VND002.VlrPrecoVenda
,   PctMargem = (VND002.VlrPrecoVenda / VEI004.VlrPrecoTabelado - 1) * 100

    FROM VND002_VENDA VND002

    INNER JOIN VEI004_MODELO_VERSAO VEI004
        ON VEI004.IdeModeloVersao = VND002.IdeModeloVersao

        ORDER BY VlrPrecoVenda
