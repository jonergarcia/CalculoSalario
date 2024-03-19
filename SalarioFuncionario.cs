namespace AtividadeSalario
{
    class CalculoFuncionario
    {
        public double CalcularSalarioLiquido(int imposto, double salario)
        {
            double desconto = salario * imposto / 100;
            return salario - desconto;
        }

        public double AumentarSalario(double salario, double aumentoPorcentagem)
        {
            double aumento = salario * aumentoPorcentagem / 100;
            return salario + aumento;
        }
    }
}
