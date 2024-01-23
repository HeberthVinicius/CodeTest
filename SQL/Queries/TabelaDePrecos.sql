/* TabelaDePrecos.sql

SCRIPT DE CONSULTA AUXILIAR.
Deve ser executado após a população das tabelas.

*/

USE DBCONCESSIONARIA
GO

SELECT
    VEI001.IdeMarca
,   VEI002.IdeModelo
,   VEI004.IdeModeloVersao
,   VEI001.NmeMarca
,   VEI002.NmeModelo
,   VEI004.NroAno
,   VEI003.NmeCombustivel
,   VEI004.VlrPrecoTabelado

    FROM VEI001_MARCA VEI001
    
    INNER JOIN VEI002_MODELO VEI002
        ON VEI002.IdeMarca = VEI001.IdeMarca

    INNER JOIN VEI004_MODELO_VERSAO VEI004
        ON VEI004.IdeModelo = VEI002.IdeModelo

    INNER JOIN VEI003_COMBUSTIVEL VEI003
        ON VEI003.IdeCombustivel = VEI004.IdeCombustivel

    ORDER BY VEI001.IdeMarca, VEI002.IdeModelo, VEI004.NroAno, VEI003.IdeCombustivel
