namespace Teste_3  
{
    class Pessoa  
    {
        public string Nome;
        public char Sexo;
        public int Idade;

        public string ImprimeTempoVidaRestante()
        {
            var total = "";
            if (Sexo == 'M')
            {
                total = "Sua estimativa de vida é de: " + (73 - Idade);
            }
            else if (Sexo == 'F')
            {
                total = "Sua estimativa de vida é de: " + (80 - Idade);
            }

            return total;
        }
    }
}