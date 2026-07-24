## 2. Modelo de Domínio (Entidades)

Estruturação voltada para o ORM (ex: Entity Framework Core com PostgreSQL):

[ Usuario ] (Base para Auth)
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