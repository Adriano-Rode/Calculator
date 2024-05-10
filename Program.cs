namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("   Bem-vindo(a) a minha calculadora!");
        Console.WriteLine("=======================================");
        Console.WriteLine();
        Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Raiz Quadrada\n6 - Fechar");
        Console.WriteLine();
        Console.Write("Qual cálculo você gostaria de realizar? ");
        int n = int.Parse(Console.ReadLine());

        string[] s;

        switch(n)
        {
            case 1: //Soma
                Console.Write("Digite os números que deseja somar: ");
                s = Console.ReadLine().Split(' ');
                
                break;
            case 2: //Subtração\
                Console.Write("Digite os números que deseja subtrair: ");
                s = Console.ReadLine().Split(' ');

                break;
            case 3: //Multiplicação
                Console.Write("Digite os números que deseja multiplicar: ");
                s = Console.ReadLine().Split(' ');

                break;
            case 4: //Divisão
                Console.Write("Digite os números que deseja dividir: ");
                s = Console.ReadLine().Split(' ');

                break;
            case 5: //Raiz Quadrada
                break;
            default:
                return;
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
