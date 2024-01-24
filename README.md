# CodeTest

Este projeto é uma aplicação ASP.NET Core MVC que calcula e exibe comissões para vendedores com base em dados de vendas.

## Configuração Inicial

1. **Pré-requisitos:**
   - Efetue a instação do banco de dados e rode scripts de acordo com as orientações presentes no arquivo [README_DO_DESAFIO.md](README_DO_DESAFIO.md)
   - Utilize o script [SQL/Procedures/ListarComissoesVendedores_alterada.sql](SQL/Procedures/ListarComissoesVendedores_alterada.sql) para retornar dados na tela.
   - Certifique-se de ter o .NET SDK na versão 6 instalado. [Download .NET SDK](https://dotnet.microsoft.com/download)

2. **Intale os pactoes necessários:**
   - Abra o terminal na raiz do projeto e execute os comandos:
     ```bash
     dotnet tool install --global dotnet-ef --version 6.0.26
	 ```
	 
	 ```bash
	 dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.26
     ```
     
     ```bash
     dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.26
     ```
     
     ```bash
     dotnet tool install --global dotnet-ef --version 6.0.26
     ```
     
     ```bash
     dotnet add package Dapper
     ```
     
3. **Configuração do Banco de Dados:**
   - Configure sua string de conexão no arquivo `appsettings.json` sob a chave `"ConnectionStrings": {
    "StandardConnection": "sua_conexao_aqui"
  }`.

## Como Executar

1. **Executando a Aplicação:**
   - No terminal, vá para a pasta do projeto e execute:
     ```bash
     dotnet run
     ```
   - Acesse a aplicação em [http://localhost:5053](http://localhost:5053) no seu navegador.

## Uso da Aplicação

- Acesse a página inicial para visualizar as comissões dos vendedores.
- A tabela exibirá as informações sobre os vendedores, incluindo quantidade de veículos vendidos, vales combustíveis emitidos, total em vendas e total da comissão.

## Contribuição

1. Faça um fork do projeto.
2. Crie uma nova branch com sua contribuição: `git checkout -b feature/nova-feature`.
3. Faça commit das suas alterações: `git commit -m 'Adiciona nova feature'`.
4. Faça push para a branch: `git push origin feature/nova-feature`.
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o link [LICENSE - MIT](https://www.mit.edu/~amini/LICENSE.md) para detalhes.