using System.Globalization;
using Entities;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Calculations calculations = new Calculations();

        Console.WriteLine("=======================================");
        Console.WriteLine("   Bem-vindo(a) a minha calculadora!");
        Console.WriteLine("=======================================");
        Console.WriteLine();
        
        while(true)
        {
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Raiz Quadrada\n6 - Fechar");
            Console.WriteLine();
            Console.Write("Qual cálculo você gostaria de realizar? ");
            int n = int.Parse(Console.ReadLine());

            string[] s;
            double result;

            switch(n)
            {
                case 1:
                    Console.Write("Digite os números que deseja somar: ");
                    s = Console.ReadLine().Split(' ');
                    
                    result = calculations.Sum(ConvertToDouble(s));
                    break;
                case 2:
                    Console.Write("Digite os números que deseja subtrair: ");
                    s = Console.ReadLine().Split(' ');
                    
                    result = calculations.Subtract(ConvertToDouble(s));
                    break;
                case 3:
                    Console.Write("Digite os números que deseja multiplicar: ");
                    s = Console.ReadLine().Split(' ');

                    result = calculations.Multiply(ConvertToDouble(s));
                    break;
                case 4:
                    Console.Write("Digite os números que deseja dividir: ");
                    s = Console.ReadLine().Split(' ');

                    result = calculations.Division(ConvertToDouble(s));
                    break;
                case 5:
                    Console.Write("Digite o número que deseja saber a raiz quadrada: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    result = calculations.SquareRoot(value);
                    break;
                default:
                    Console.WriteLine("Fim do programa!");
                    return;
            }

            Console.WriteLine();
            Console.WriteLine($"O resultado foi: {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        
    }

    static double[] ConvertToDouble(string[] s)
    {
        double[] v = new double[s.Length];

        for(int i = 0; i < s.Length; i++)
        {
            v[i] = double.Parse(s[i]);
        }

        return v;
    }
}
