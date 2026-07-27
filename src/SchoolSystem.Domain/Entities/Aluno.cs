namespace SchoolSystem.Domain.Entities;

public class Aluno
{
    public Guid IdAluno {get; set;}
    public string? Turma {get; set;}
    public string? SenhaAluno { get; set; }

}