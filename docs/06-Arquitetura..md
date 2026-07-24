## 3. Arquitetura do Sistema

O projeto adota uma arquitetura REST API em Camadas (Layered Architecture), estruturada para o ecossistema .NET:

                  ┌──────────────────────────────┐
                  │   Frontend / Cliente Web    │
                  └──────────────┬───────────────┘
                                 │ HTTP / JSON
                                 ▼
                  ┌──────────────────────────────┐
                  │    Swagger / API Controllers │ (ASP.NET Core)
                  └──────────────┬───────────────┘
                                 │
                                 ▼
                  ┌──────────────────────────────┐
                  │      Regras de Negócio       │ (Services / Domain)
                  └──────────────┬───────────────┘
                                 │ Entity Framework
                                 ▼
                  ┌──────────────────────────────┐
                  │     Banco PostgreSQL         │
                  └└─────────────────────────────┘

    Camada de Apresentação / API (ASP.NET Core Controllers): Exposição dos endpoints REST e documentação automática pelo Swagger.

    Camada de Aplicação / Negócio (Services): Onde residem as regras como cálculo de médias, validações e autenticação.

    Camada de Acesso a Dados (Data / Persistence): Comunicação com o PostgreSQL usando ORM (Entity Framework Core) para gerenciamento de migrations e consultas SQL otimizadas.