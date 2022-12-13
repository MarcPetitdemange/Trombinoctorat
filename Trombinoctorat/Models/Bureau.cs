namespace Trombinoctorat.Models
{
    public class Bureau
    {
        private string numero;
        private string etage;

        public Bureau(string numero, string etage)
        {
            this.numero = numero;
            this.etage = etage;
        }

        public string Numero { get => numero; set => numero = value; }
        public string Etage { get => etage; set => etage = value; }
    }
}
