using System;

namespace ClassesCS1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 1
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            if (p1.Idade == p2.Idade)
                Console.Write($"\nMesma idade: {p1.Idade}");
            else if (p1.Idade > p2.Idade)
                Console.WriteLine($"\n{p1.Nome} é mais velho(a): {p1.Idade} anos");
            else Console.WriteLine($"\n{p2.Nome} é mais velho(a): {p2.Idade} anos");
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}