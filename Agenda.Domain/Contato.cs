namespace Agenda.Domain
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        // tipo 1 ira ser pessoal
        // tipo 2 ira ser comercial
        // tipo 3 ira ser empresarial
        public int Tipo { get; set; }

        public Contato()
        {

        }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public Contato(string nome, string telefone, int tipo)
        {
            Nome = nome;
            Telefone = telefone;
            Tipo = tipo;
        }
    }
}