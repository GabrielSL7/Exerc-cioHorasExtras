using System;

class Program
{
    static void Main(string[] args)
    {
        decimal decimalHoraBase, salario;
        int horasTrabalhadas, numeroHorasExtras;

        Console.Write("Digite o valor do salário-hora base: ");
        decimalHoraBase = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o total de horas trabalhadas: ");
        horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o número de horas extras realizadas: ");
        numeroHorasExtras = Convert.ToInt32(Console.ReadLine());

        salario = CalculaSalario(decimalHoraBase, horasTrabalhadas, numeroHorasExtras);

        Console.WriteLine($"O salário é {salario:C2}");
    }

    static decimal CalculaSalario(decimal valorHora, int horas, int extras)
    {
        return (valorHora * horas) + (valorHora * 1.4m * extras);
    }
}
