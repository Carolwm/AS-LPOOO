public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double salarioMensal;

    public FuncionarioTempoIntegral(string nome, string matricula, double salarioMensal) : base(nome, matricula)
    {
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return salarioMensal;
    }

    public double CalcularBonus(){
        return salarioMensal * 0.10;
    } 

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Salário Mensal: {salarioMensal}");
        foreach (var projeto in Projetos)
    {
        Console.WriteLine($"¬{projeto}");
    }
    }
}
