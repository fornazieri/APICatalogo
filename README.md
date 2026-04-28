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
- Métodos Action assíncronos (async e await) retorando Task
- Model Binding
  - [BindRequired] para obrigar o binding do nome dos atributos
  - [BindNever] utilizado no atributo no modelo, para ignorar o binding do atributo
  - Outros exemplos de anotações de model binding
    - FromForm - Utilize somente os dados recebidos do formulário enviado.
    - FromRoute - Vincula apenas os dados que são oriundos da rota de dados.
    - FromQuery - Recebe apenas os dados da cadeia de consulta (querystring).
    - FromHeader - Vincula os valores que vêm no cabeçalho da requisição HTTP.
    - FromBody - Vincula os dados a partir do Body do request.
    - FromServices - Vincula o valor especificado à implementação que foi configurada no seu container de injeção de dependência.
  - Injeção de dependencia nos controllers do [FromServices] antes e depois do .net 7
- Data Annotations
  - Validação de atributos do Modelo por Data Annotations
- Validação personalizada
  - Anotação personalizada utilizando Validations com uma classe sendo usada como Attribute
  - Validação com IValidatableObject
- Modelos de Configuração e leitura dos mesmos
  - Possibilidade de varios arquivos appsetting.json para diversos ambientes, como produção, development, staging... Sendo manipulado pela variavel ASPNETCORE_ENVIRONMENT
  - Utilização da interface IConfiguration para leitura de configurações
  - Leitura de configurações no Program.cs atraves do builder
- Middleware
  - Utilização de Middleware para tratamento global de exceptions
- Filtros no conceito de uma aplicação .net core, para executar codigos personalizados antes ou depois de métodos Action
  - Exemplo de implementação de classe com IActionFilter para implementar ILogger e gerar Logs da aplicação antes e depois das Actions executarem
