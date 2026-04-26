# APICatalogo

Projeto para colocar em prática os ensinamentos do curso [Web API ASP .NET Core Essencial (.NET 8 / .NET 9)](https://www.udemy.com/course/curso-web-api-asp-net-core-essencial/ "Web API ASP .NET Core Essencial (.NET 8 / .NET 9)") do instrutor Jose Carlos Macoratti.

## Implementação

Após baixar o repositório, entre na pasta `APICatalogo` (dentro da pasta da solução) e execute o comando abaixo para rodar as migrations:

```bash
dotnet ef database update
```

## Aprendizado em ordem cronológica

- Swagger
- Data Annotations
- Controllers
- Implementação dos principais verbos HTTP, com e sem parâmetros
  - GET
  - POST
  - PUT
  - DELETE
- Serialização de JSON
- Tratamento de erros com try-catch
- Postman
- Roteamento e padrões de roteamento
  - Nomenclatura de rotas utilizadas para versionamento de API, como `./api/v1`
  - Funcionalidades para ignorar o caminho total do roteamento em Actions que precisam ser expostas diretamente
    Exemplo: mudar a rota de um endpoint de `/api/v1/ConsultarProduto` para `/ConsultarProduto`, ignorando todo o caminho até a identificação do método
- Restrição de rotas
  - Utilizado para permitir apenas valores esperados nos parâmetros, evitando que o método precise tratar dados inválidos
  - Observação: não é recomendado fazer validação de dados com este recurso, pois essa não é a responsabilidade do método. Ele deve apenas evitar exceptions causadas por entradas inválidas
- Tipos de retorno
  - Entendimento sobre retornos `ActionResult` e `IActionResult`
  - Permitem retornos específicos de uma API REST, mas também possibilitam retornar tipos próprios (como Models da aplicação), facilitando a serialização dos dados
- Métodos Action assíncronos
