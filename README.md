# APICatalogo
Projeto para colocar em pratica os ensinamentos do curso [Web API ASP .NET Core Essencial (.NET 8 / .NET 9)](https://www.udemy.com/course/curso-web-api-asp-net-core-essencial/ "Web API ASP .NET Core Essencial (.NET 8 / .NET 9") do instrutor Jose Carlos Macoratti

## Implementação
Após baixar o repositório, entrar na pasta APICatalogo que está dentro da pasta da solução e rodar o comando, para executar as migrations:

`$ dotnet ef database update`

## Aprendizado em ordem cronológica
- Swagger
- Data Annotations
- Controllers
- Implementação dos principais verbos HTTP, **com e sem parâmetros**
	- GET
	- POST
	- PUT
	- DELETE
- Serialização de JSON
- Tratamento de erros com try-catch
- Postman
- Roteamento e Padrões de Roteamento
	- Nomenclatura de rotas utilizadas para versionamento de API como ./api/v1 ou mesmo funcionalidades para ignorar o caminho total do roteamento para Actions que precisam ser expostas diretamente, por exemplo:
	> mudar a rota de um endpoint que precisa ser chamado em /api/v1/ConsultarProduto para /ConsultarProduto ignorando todo o caminho até a identificação do método
- Restrição de rotas
	- Utilizado para permitir apenas valores esperados nos parâmetros, evitando a responsabilidade do método em ter que tratar a validade dos dados recebidos
  >(OBS.: Não é recomendado fazer a validação dos dados utilizando este recurso, pois esta responsabilidade não é do método. Ela serve apenas para evitar exceptions causadas por dados recebidos de maneira inválida)

- Tipos de retorno
	- Entendimento sobre retornos ActionResult ou IActionResult para pemitir retornos especificos de uma API Rest, mas tambem permitir retornar Tipos proprios como os tipos dos Models definidos na aplicação, facilitando assim a serialização dos dados

- Métodos Action Assíncronos
