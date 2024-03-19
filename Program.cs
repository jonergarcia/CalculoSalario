using System;

namespace AtividadeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoFuncionario funcionario = new CalculoFuncionario();

            Console.WriteLine("Digite o nome do Funcionário:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Salário Bruto:");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto:");
            funcionario.imposto = int.Parse(Console.ReadLine());

            funcionario.salarioLiquido = funcionario.CalcularSalarioLiquido(funcionario.imposto, funcionario.salarioBruto);

            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Salário Líquido: {funcionario.salarioLiquido:C}");

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Informe a porcentagem de aumento:");
            funcionario.porcentagem = double.Parse(Console.ReadLine());
            double novoSalario = funcionario.AumentarSalario(funcionario.salarioLiquido, funcionario.porcentagem);

            Console.WriteLine($"Novo Salário Líquido: {novoSalario:C}");
        }
    }

}