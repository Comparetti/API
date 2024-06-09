# Thunders API

## Descrição do Projeto

O projeto Thunders API é uma aplicação ASP.NET Core para gerenciar consumidores e produtores de energia. Este repositório inclui uma API que permite listar, buscar, criar, editar e excluir consumidores e produtores. A API foi desenvolvida com Entity Framework Core, utilizando um banco de dados em memória para facilitar o desenvolvimento e testes.

## Funcionalidades

- **Consumidor**
  - Listar todos os consumidores
  - Buscar consumidor por ID
  - Criar novo consumidor
  - Editar consumidor existente
  - Excluir consumidor

- **Produtor**
  - Listar todos os produtores
  - Buscar produtor por ID
  - Criar novo produtor
  - Editar produtor existente
  - Excluir produtor

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- In-memory Database
- Swagger para documentação da API

## Estrutura do Projeto

- **Data**: Contém o contexto do banco de dados `AppDbContext` e configurações relacionadas ao Entity Framework Core.
- **Domain**: Contém os modelos de dados, DTOs e interfaces dos serviços.
- **Service**: Implementações dos serviços que contêm a lógica de negócios.
- **Controllers**: Controladores da API que lidam com as requisições HTTP.

## Configuração do Ambiente

### Dependências

- .NET 8.0 SDK
- Visual Studio ou Visual Studio Code


### Acesso ao Swagger

Uma vez que a aplicação estiver em execução, você pode acessar a documentação da API gerada pelo Swagger em:

http://localhost:<porta>/swagger

## Endpoints da API

### Consumidor

- **Listar Consumidores**: `GET /api/Consumidor/ListarConsumidores`
- **Buscar Consumidor por ID**: `GET /api/Consumidor/BuscarConsumidorPorId/{id}`
- **Criar Consumidor**: `POST /api/Consumidor/CriarConsumidor`
- **Editar Consumidor**: `PUT /api/Consumidor/EditarConsumidor`
- **Excluir Consumidor**: `DELETE /api/Consumidor/ExcluirConsumidor/{id}`

### Produtor

- **Listar Produtores**: `GET /api/Produtor/ListarProdutores`
- **Buscar Produtor por ID**: `GET /api/Produtor/BuscarProdutorPorId/{id}`
- **Criar Produtor**: `POST /api/Produtor/CriarProdutor`
- **Editar Produtor**: `PUT /api/Produtor/EditarProdutor`
- **Excluir Produtor**: `DELETE /api/Produtor/ExcluirProdutor/{id}`

## Tratamento de Erros

Os controladores foram configurados para retornar códigos de status HTTP adequados em caso de erros:

- **404 Not Found**: Quando um recurso não é encontrado.
- **201 Created**: Quando um novo recurso é criado com sucesso.
- **204 No Content**: Quando um recurso é excluído com sucesso.

### Configuração do Banco de Dados

O projeto está configurado para usar um banco de dados em memória durante o desenvolvimento e testes. Para garantir que o banco de dados em memória seja utilizado, verifique a configuração no arquivo `appsettings.json`:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=yourserver.com;Database=DemoDB;User Id=yourUser;Password=yourPassword;"
  },
  "AllowedHosts": "*",
  "FeatureToggles": {
    "UseInMemoryDatabase": true
  }
}

```
### Atualizar o banco de dados (caso não use o banco de dados em memória):

```bash
dotnet ef database update




