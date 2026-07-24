## 1. Requisitos Funcionais (RF)

O que o sistema deve FAZER.
Autenticação e Perfis

    RF01: O sistema deve permitir o cadastro de usuários via e-mail e senha.

    RF02: O sistema deve oferecer a funcionalidade "Esqueci minha senha", enviando um link de redefinição para o e-mail cadastrado.

    RF03: O sistema deve possuir interfaces (páginas/dashboards) distintas e personalizadas para cada perfil: Aluno, Professor e Coordenador.

    RF04: O sistema deve gerar um Registro Acadêmico (RA) único e individual para cada aluno no momento da matrícula.

## Gestão Acadêmica

    RF05: O sistema deve ter uma área dedicada ao lançamento e consulta de Notas.

    RF06: O sistema deve disponibilizar o Boletim Escolar em uma seção separada das notas parciais, permitindo o download em PDF.

    RF07: O sistema deve permitir que os professores lancem frequência/faltas dos alunos.

    RF08: O sistema deve permitir que os coordenadores cadastrem disciplinas, turmas e vinculem professores a essas turmas.

## Comunicação

    RF09: O sistema deve disponibilizar um módulo de Chat interno para comunicação direta entre professores, alunos e coordenação.

    RF10: O sistema deve possuir um mural de avisos gerais gerenciado pela coordenação.

## 2. Requisitos Não-Funcionais (RNF)

Como o sistema deve SER ou se COMPORTAR.
Usabilidade e Interface

    RNF01 (Usabilidade): A interface deve ser intuitiva, amigável e adaptada para o público jovem (UI/UX limpo e responsivo para celulares e computadores).

    RNF02 (Acessibilidade): O sistema deve seguir diretrizes básicas de acessibilidade (ex: bom contraste de cores e suporte a leitores de tela).

## Desempenho e Segurança

    RNF03 (Segurança): As senhas dos usuários devem ser salvas no banco de dados utilizando criptografia forte (ex: Bcrypt).

    RNF04 (Privacidade): O sistema deve garantir a privacidade dos dados conforme a LGPD (Lei Geral de Proteção de Dados), garantindo que um aluno não veja os dados de outro.

    RNF05 (Desempenho): O tempo de carregamento das páginas não deve ultrapassar 3 segundos em conexões estáveis de internet.

    RNF06 (Disponibilidade): O sistema deve estar disponível 99% do tempo durante os dias letivos.

## 3. Regras de Negócio (RN)

As diretrizes, limites e lógicas operacionais da escola.
Acesso e Cadastro

    RN01 (Unicidade do RA): O número de RA é estritamente único. Não podem existir dois alunos com o mesmo RA no banco de dados, mesmo em anos letivos diferentes.

    RN02 (Permissão de Lançamento): Apenas o professor vinculado àquela disciplina/turma (ou o coordenador) pode alterar notas e faltas dos alunos.

# Avaliação e Aprovação

    RN03 (Média de Aprovação): A média final para aprovação direta na disciplina é 7.0. Alunos com média entre 5.0 e 6.9 entram em recuperação.

    RN04 (Limite de Faltas): O aluno deve ter no mínimo 75% de frequência na disciplina para ser aprovado, independentemente da nota.

    RN05 (Fechamento de Bimestre): O lançamento de notas no boletim é bloqueado para os professores após 5 dias úteis do término de cada bimestre. Alterações após esse prazo exigem autorização do coordenador.

## Comunicação

    RN06 (Horário do Chat): O chat entre alunos e professores só aceitará o envio de mensagens em dias úteis, das 07h às 18h, para respeitar o horário de trabalho dos docentes.