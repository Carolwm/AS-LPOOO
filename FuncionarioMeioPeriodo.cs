public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double SalarioPorHora;
    private double HorasTrabalhadas;

    public FuncionarioMeioPeriodo(string Nome, string Matricula, double salarioPorHora, double horasTrabalhadas) : base(Nome, Matricula){
        this.SalarioPorHora = salarioPorHora;
        this.HorasTrabalhadas = horasTrabalhadas;
    }

     public override double CalcularSalario()
    {
        return SalarioPorHora * HorasTrabalhadas;
    }

    public double CalcularBonus(){
        return SalarioPorHora * 0.05;
    } 

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Salário por hora: {SalarioPorHora}");
        Console.WriteLine($"Horas trabalhadas: {HorasTrabalhadas}");
        foreach (var projeto in Projetos)
    {
        Console.WriteLine($"¬{projeto}");
    }}
}