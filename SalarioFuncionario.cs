public class CalculoFuncionario
{
    public string Nome;
    public double salarioBruto;
    public int imposto;
    public double salarioLiquido;
    public double porcentagem;

    public double CalcularSalarioLiquido(int imposto, double salarioBruto)
    {
        double desconto = salarioBruto * imposto / 100;
        return salarioBruto - desconto;
    }

    public double AumentarSalario(double salarioLiquido, double porcentagem)
    {
        double aumento = salarioLiquido * (porcentagem / 100);
        double salarioTotal = salarioLiquido + aumento;
        return salarioTotal;
    }
}