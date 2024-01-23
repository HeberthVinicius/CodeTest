/* ValorMedioDasVendas.sql

SCRIPT DE CONSULTA AUXILIAR.
Deve ser executado após a população das tabelas.

*/

USE DBCONCESSIONARIA
GO

/*

Se a instalação do banco de dados estiver correta,
esta consulta deve retornar os seguintes valores:

    VlrTotalVendas  VlrTotalTabeladoVendas  PctMargemVendas     QtdVendas   VlrMedioVendas
      214816853.00            214821686.00          -0.0023          5245         40956.50

*/

SELECT
    VlrTotalVendas          = SUM(VND002.VlrPrecoVenda)
,   VlrTotalTabeladoVendas  = SUM(VEI004.VlrPrecoTabelado)
,   PctMargemVendas         = CAST((SUM(VND002.VlrPrecoVenda) / SUM(VEI004.VlrPrecoTabelado) - 1) * 100 AS NUMERIC(6, 4))
,   QtdVendas               = COUNT(*)
,   VlrMedioVendas          = CAST(SUM(VND002.VlrPrecoVenda) / COUNT(*) AS DECIMAL(10,2))

    FROM VND002_VENDA VND002

    INNER JOIN VEI004_MODELO_VERSAO VEI004
        ON VEI004.IdeModeloVersao = VND002.IdeModeloVersao
