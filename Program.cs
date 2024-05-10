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

            string[] s;
            double result;

            try
            {
                int n = int.Parse(Console.ReadLine());

                switch(n)
                {
                    case 1:
                        Console.Write("Digite dois ou mais números que deseja somar(ex: 2 2): ");
                        s = Console.ReadLine().Split(' ');
                        
                        result = calculations.Sum(ConvertToDouble(s));
                        break;
                    case 2:
                        Console.Write("Digite dois ou mais números que deseja subtrair(ex: 2 2): ");
                        s = Console.ReadLine().Split(' ');
                        
                        result = calculations.Subtract(ConvertToDouble(s));
                        break;
                    case 3:
                        Console.Write("Digite dois ou mais números que deseja multiplicar(ex: 2 2): ");
                        s = Console.ReadLine().Split(' ');

                        result = calculations.Multiply(ConvertToDouble(s));
                        break;
                    case 4:
                        Console.Write("Digite dois ou mais números que deseja dividir(ex: 2 2): ");
                        s = Console.ReadLine().Split(' ');

                        result = calculations.Division(ConvertToDouble(s));
                        break;
                    case 5:
                        Console.Write("Digite o número que deseja saber a raiz quadrada (ex: 25): ");
                        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        result = calculations.SquareRoot(value);
                        break;
                    default:
                        Console.WriteLine("Fim do programa!");
                        Console.WriteLine();
                        return;
                }

                Console.WriteLine();
                Console.WriteLine($"O resultado foi: {result.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
                Console.Write("Deseja fazer um novo cálculo? (s/n) ");
                char c = char.Parse(Console.ReadLine());

                if(c == 's' || c == 'S')
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Fim do programa!");
                    Console.WriteLine();
                    return;
                }
            }
            
            catch(FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Informações faltando ou incorretas!");
                Console.WriteLine();
            }

            catch(DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível dividir por zero!");
                Console.WriteLine();
            }
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
