using System.Globalization;
namespace Exercicio1___udemy
{
    public class Program
    {
        static void Main()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            
            Console.WriteLine("Dados da primeira pessoa: ");

            p1.name = Console.ReadLine();
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados da segunda pessoa: ");

            p2.name = Console.ReadLine();
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double media = (p1.salario + p2.salario) / 2;
            
            System.Console.WriteLine();
            System.Console.WriteLine("Nome: " + p1.name);
            System.Console.WriteLine("Salário: " + p1.salario);

            System.Console.WriteLine();

            System.Console.WriteLine("Nome: " + p2.name);
            System.Console.WriteLine("Salário: " + p2.salario);
            System.Console.WriteLine();
            Console.WriteLine("Média de salários" +media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}