using System;

class Program
{
    static void Main(string[] args)
    {
        Empresa empresa = new Empresa();

        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("[1] - Adicionar funcionário de tempo integral");
            Console.WriteLine("[2] - Adicionar funcionário de meio período");
            Console.WriteLine("[3] - Remover funcionário");
            Console.WriteLine("[4] - Exibir informações de todos os funcionários");
            Console.WriteLine("[5] - Adicionar projeto(s) a um funcionário");
            Console.WriteLine("[6] - Sair do programa");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("ADICIONAR FUNCIONÁRIO DE TEMPO INTEGRAL");
                    Console.Write("Nome do funcionário: ");
                    string nome = Console.ReadLine();
                    Console.Write("Matrícula do funcionário: ");
                    string matricula = Console.ReadLine();
                    Console.Write("Salário mensal do funcionário: ");
                    double salarioMensal = Convert.ToDouble(Console.ReadLine());
                    FuncionarioTempoIntegral funcionarioTi = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
                    empresa.AdicionarFuncionario(funcionarioTi);
                    Console.WriteLine("Funcionário de tempo integral adicionado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("ADICIONAR FUNCIONÁRIO DE MEIO PERÍODO");
                    Console.Write("Nome do funcionário: ");
                    nome = Console.ReadLine();
                    Console.Write("Matrícula do funcionário: ");
                    matricula = Console.ReadLine();
                    Console.Write("Salário por hora do funcionário: ");
                    double salarioPorHora = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Horas trabalhadas do funcionário: ");
                    double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
                    FuncionarioMeioPeriodo funcionarioMp = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
                    empresa.AdicionarFuncionario(funcionarioMp);
                    Console.WriteLine("Funcionário de meio período adicionado com sucesso!");
                    break;

                case "3":
                    Console.WriteLine("REMOVER FUNCIONÁRIO");
                    Console.Write("Digite a matrícula do funcionário a ser removido: ");
                    matricula = Console.ReadLine();
                    empresa.RemoverFuncionario(matricula);
                    Console.WriteLine("Funcionário removido com sucesso!");
                    break;

                case "4":
                    Console.WriteLine("INFORMAÇÕES DE TODOS OS FUNCIONÁRIOS");
                    empresa.ExibirFuncionarios();
                    break;

                case "5":
                    Console.WriteLine("ADICIONAR PROJETOS A UM FUNCIONÁRIO");
                    Console.Write("Digite a matrícula do funcionário para adicionar projetos: ");
                    matricula = Console.ReadLine();
                    Funcionario funcionario = empresa.Funcionarios.Find(f => f.Matricula == matricula);
                    if (funcionario != null)
                    {
                        Console.Write("Digite o nome do projeto a ser adicionado: ");
                        string projeto = Console.ReadLine();
                        funcionario.AdicionarProjeto(projeto);
                        Console.WriteLine("Projeto adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não encontrado.");
                    }
                    break;

                case "6":
                    sair = true;
                    Console.WriteLine("SAINDO DO PROGRAMA");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
