# 📌 Documentação do Sistema de Gestão Escolar

---

## ⬜ Casos de Uso (UC)

### Casos de Uso Principais por Ator

* **Aluno / Responsável**
  * `UC01` - Efetuar Login / Logout
  * `UC02` - Consultar Notas por Disciplina
  * `UC03` - Visualizar Boletim Escolar com Média

* **Professor**
  * `UC04` - Consultar Turmas e Disciplinas Vinculadas
  * `UC05` - Lançar / Atualizar Notas do Aluno

* **Coordenador / Admin**
  * `UC06` - Gerenciar (CRUD) Alunos e Professores
  * `UC07` - Gerenciar (CRUD) Turmas e Disciplinas
  * `UC08` - Associar Professor à Turma e Aluno ao Responsável

---

### Especificação Detalhada de Exemplo

#### **UC05 - Lançar / Atualizar Notas**
* **Ator Principal:** Professor.
* **Pré-condições:** Professor estar autenticado e vinculado à disciplina/turma escolhida.
* **Fluxo Principal:**
  1. O professor seleciona a turma e a disciplina.
  2. O sistema exibe a lista de alunos matriculados.
  3. O professor digita/atualiza a nota da avaliação/bimestre.
  4. O professor clica em "Salvar".
  5. O sistema recalcula a média parcial e atualiza os registros no PostgreSQL via API.
* **Fluxo Exceção:**
  * Se o valor inserido for inválido (ex: nota negativa ou acima de 10), o ASP.NET Core retorna um erro de validação (`400 Bad Request`) e avisa o usuário.

---

## ⬜ Modelo de Domínio (Entidades)

Estruturação das entidades do sistema (voltada para o Entity Framework Core com PostgreSQL):

```text
[ Usuario ] (Base para Autenticação)
   ├── Atributos: Id, Nome, Email, SenhaHash, Perfil (Enum: Admin, Prof, Aluno, Resp)
   │
   ├──> [ Aluno ]
   │       Atributos: Id, RA, DataNascimento, ResponsavelId (FK)
   │
   └──> [ Professor ]
           Atributos: Id, RegistroFuncional

[ Turma ]
   Atributos: Id, Nome (ex: 3º Ano A), AnoLetivo

[ Disciplina ]
   Atributos: Id, Nome, CargaHoraria

[ TurmaDisciplina ] (Tabela Intermediária)
   Atributos: TurmaId, DisciplinaId, ProfessorId

[ Nota ]
   Atributos: Id, AlunoId, DisciplinaId, Bimestre, ValorNota (decimal)