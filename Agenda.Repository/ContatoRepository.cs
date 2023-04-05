using Agenda.Domain;

namespace Agenda.Repository
{
    public class ContatoRepository
    {
        public List<Contato> ListContatosFromDatabase()
        {
            Contato contato1 = new Contato("Pessoa1", "11966323534", 2);
            Contato contato2 = new Contato("Pessoa2", "1187451236", 3);
            Contato contato3 = new Contato("Pessoa3", "11238662112", 1);


            List<Contato> listaContatos = new List<Contato>();
            listaContatos.Add(contato1);
            listaContatos.Add(contato2);
            listaContatos.Add(contato3);


            return listaContatos;
        }
    }
}