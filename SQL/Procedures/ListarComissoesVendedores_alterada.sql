/* ListarComissoesVendedores.sql

SCRIPT PARA DA PROCEDURE ListarComissoesVendedores.
Deve ser executado após a criação das tabelas.

*/

USE DBCONCESSIONARIA

CREATE OR ALTER PROCEDURE ListarComissoesVendedores
AS
BEGIN
    SELECT 
        VND001_VENDEDOR.NmeVendedor,
        COUNT(VND002_VENDA.IdeVenda) AS QtdVeiculosVendidos,
        SUM(CASE WHEN VND002_VENDA.StaValeCombustivel = 1 THEN 1 ELSE 0 END) AS QtdValesCombustiveis,
        SUM(VND002_VENDA.VlrPrecoVenda) AS TotalVendas,
        SUM(
            CASE 
                WHEN VND002_VENDA.StaValeCombustivel = 1 THEN
                    0.01 * VND002_VENDA.VlrPrecoVenda - 
                    CASE 
                        WHEN VEI003_COMBUSTIVEL.NmeCombustivel = 'Gasolina' THEN 200.00
                        WHEN VEI003_COMBUSTIVEL.NmeCombustivel = 'Álcool' THEN 180.00
                        WHEN VEI003_COMBUSTIVEL.NmeCombustivel = 'Diesel' THEN 150.00
                        ELSE 0.00
                    END
                ELSE
                    0.01 * VND002_VENDA.VlrPrecoVenda
            END
        ) AS TotalComissao
    FROM 
        VND001_VENDEDOR
    LEFT JOIN 
        VND002_VENDA ON VND001_VENDEDOR.IdeVendedor = VND002_VENDA.IdeVendedor
    LEFT JOIN 
        VEI004_MODELO_VERSAO ON VND002_VENDA.IdeModeloVersao = VEI004_MODELO_VERSAO.IdeModeloVersao
    LEFT JOIN 
        VEI003_COMBUSTIVEL ON VEI004_MODELO_VERSAO.IdeCombustivel = VEI003_COMBUSTIVEL.IdeCombustivel
    GROUP BY 
        VND001_VENDEDOR.NmeVendedor
END

GO
