using System.Runtime.CompilerServices;

public abstract class Funcionario{
    public string Nome {get; set;}
    public string Matricula {get; set;}
    public List<string> Projetos {get; set;}

    public Funcionario(string nome, string matricula){
        this.Nome = nome;
        this.Matricula = matricula;
        this.Projetos = new List<string>();
    }

     public abstract double CalcularSalario();
     public abstract void ExibirInformacoes();

     public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }

     public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }
} 