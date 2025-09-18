using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escolha a operação (+, -, *, /): ");
        var operacao = Console.ReadLine();

        double resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Divisão por zero não é válido.");
                break;
            default:
                Console.WriteLine("Calculo inválido!");
                break;
        }

        Console.WriteLine($"Resultado: {resultado}");
        Console.ReadKey();
    }
}
