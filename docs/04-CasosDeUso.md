## 1. Casos de Uso (UC)
Casos de Uso Principais por Ator

    Aluno / Responsável

        UC01 - Efetuar Login / Logout

        UC02 - Consultar Notas por Disciplina

        UC03 - Visualizar Boletim Escolar com Média

    Professor

        UC04 - Consultar Turmas e Disciplinas Vinculadas

        UC05 - Lançar / Atualizar Notas do Aluno

    Coordenador / Admin

        UC06 - Gerenciar (CRUD) Alunos e Professores

        UC07 - Gerenciar (CRUD) Turmas e Disciplinas

        UC08 - Associar Professor à Turma e Aluno ao Responsável

## Especificação Detalhada de Exemplo
UC05 - Lançar / Atualizar Notas

    Ator Principal: Professor.

    Pré-condições: Professor estar autenticado e vinculado à disciplina/turma escolhida.

    Fluxo Principal:

        O professor seleciona a turma e a disciplina.

        O sistema exibe a lista de alunos matriculados.

        O professor digita/atualiza a nota da avaliação/bimestre.

        O professor clica em "Salvar".

        O sistema recalcula a média parcial (RN01) e atualiza os registros no PostgreSQL via API.

    Fluxo Exceção:

        Se o valor inserido for inválido (ex: nota negativa ou acima de 10), o ASP.NET Core retorna um erro de validação (400 Bad Request) e avisa o usuário.