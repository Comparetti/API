# Thunders API

## Descrição do Projeto

O projeto Thunders API é uma aplicação ASP.NET Core que gerencia consumidores e produtores de energia. A API permite listar, buscar, criar, editar e excluir consumidores e produtores. Desenvolvida com Entity Framework Core e SQL Server em um contêiner Docker para facilitar a configuração do ambiente de desenvolvimento e produção.

## Funcionalidades

- **Consumidor**
  - Listar todos os consumidores.
  - Buscar consumidor por ID.
  - Criar novo consumidor.
  - Editar consumidor existente.
  - Excluir consumidor.

- **Produtor**
  - Listar todos os produtores.
  - Buscar produtor por ID.
  - Criar novo produtor.
  - Editar produtor existente.
  - Excluir produtor.

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server (Docker)
- Swagger (API Documentation)

## Estrutura do Projeto

- **Data**: Contém o contexto do banco de dados `AppDbContext` e configurações do Entity Framework Core.
- **Domain**: Modelos de dados, DTOs e interfaces de serviços.
- **Service**: Implementações de serviços com a lógica de negócios.
- **Controllers**: Controladores da API que gerenciam requisições HTTP.

## Configuração do Ambiente

### Pré-requisitos

- .NET 8.0 SDK
- Docker Desktop (para execução em contêineres)
- Visual Studio ou Visual Studio Code

### Configuração e Execução com Docker

Para facilitar a configuração e execução do projeto, utilizamos Docker. Abaixo estão as instruções para executar o projeto dentro de contêineres Docker.

1. **Construir e Rodar com Docker Compose**
   - Abra um terminal na pasta raiz do projeto.
   - Execute o seguinte comando para construir e iniciar os contêineres:
   - Isso irá iniciar os serviços definidos no docker-compose.yml, incluindo o SQL Server e a aplicação Thunders API
   ```bash
   docker-compose up --build

   
### Acesso ao Swagger

Uma vez que a aplicação estiver em execução, você pode acessar a documentação da API gerada pelo Swagger

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






