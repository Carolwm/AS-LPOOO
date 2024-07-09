using System.ComponentModel;

public class Empresa{
    public List<Funcionario> Funcionarios;

    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(string matricula)
    {
    for (int i = Funcionarios.Count - 1; i >= 0; i--)
    {
        if (Funcionarios[i].Matricula == matricula)
        {
            Funcionarios.RemoveAt(i);
        }
    }}

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
            Console.WriteLine("---------------------"); 
        }
    }


}