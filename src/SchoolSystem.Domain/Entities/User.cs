using System.Numerics;
using SchoolSystem.Domain.Enums;
namespace SchoolSystem.Domain.Entities;

public class User
{
    public Guid Id {get; private set; } // Id: cada aluno, professor ou coordenador terá apenas um 
    public string? Email {get; private set; } // email único para cada aluno, professores e coordenadores tambem
    public string? Nome {get; private set;} // Nomes dos usuarios
    public CargoUsuario Cargo {get; private set;} // Cargo exemplos: Aluno, Professor e Coordenador
    public bool IsAtivo {get; private set;} // identificador para saber se a conta esta ativa ou nao 
    public string? SenhaHash {get; private set;} // senha de cada perfil
    public DateTime DataCriacao {get; private set;} = DateTime.Now;

    public void AtivarConta()
    {
        this.IsAtivo = true;
    }

    public void DesativarConta()
    {
        this.IsAtivo = false;
    }

    public User(string nome, string email, CargoUsuario cargo) // construtor para o User
    {
        this.Email = email;
        this.Nome = nome;
        this.Cargo = cargo;
        this.Id = Guid.NewGuid();
        this.IsAtivo = true;
    }

    private bool ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            return false;
        }

        if (nome.Length < 3 || nome.Length > 100)
        {
            return false;
        }
        foreach (char c in nome)
        {
            if (!char.IsLetter(c) && c != ' ')
                return false;
        }   
        return true;
        
    }
}