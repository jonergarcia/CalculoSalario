using System;

namespace AtividadeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoFuncionario funcionario = new CalculoFuncionario();

            Console.WriteLine("Digite o nome do Funcionário:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite o Salário Bruto:");
            double SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto:");
            int Imposto = int.Parse(Console.ReadLine());
            double salarioLiquido = funcionario.CalcularSalarioLiquido(Imposto, SalarioBruto);
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário Líquido: {salarioLiquido}");

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Informe a porcentagem de aumento:");
            int aumentoPorcentagem = int.Parse(Console.ReadLine());

            double aumento = SalarioBruto * aumentoPorcentagem / 100;
            SalarioBruto += aumento;
            salarioLiquido = funcionario.CalcularSalarioLiquido(Imposto, SalarioBruto);
            Console.WriteLine($"Novo Salário Líquido: {salarioLiquido}");
        }
    }
}
