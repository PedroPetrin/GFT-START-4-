using System;

namespace Teste_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal papagaio = new Papagaio();

            papagaio.Alimentar();
            papagaio.Locomover();
        }
    }
}