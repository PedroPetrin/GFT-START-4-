using System;

namespace Teste_3
{
    class Program
    {
        static void Main(string[] args)

        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Informe o seu nome:");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Informe o seu sexo:");
            Console.WriteLine("MASCULINO = M | FEMININO = F");
            pessoa.Sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua idade");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine(pessoa.ImprimeTempoVidaRestante()); 
        }
    }
}

