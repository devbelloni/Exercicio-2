using System;
using System.Globalization;

namespace Exercicio_2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo.");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto.");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (na mesma linha)");
            string[] st = Console.ReadLine().Split(' ');
            string nom = st[0];
            int idade = int.Parse(st[1]);
            double altura = double.Parse(st[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(n);
            Console.WriteLine(p.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nom);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
