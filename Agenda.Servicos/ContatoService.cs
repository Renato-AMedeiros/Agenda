using Agenda.Domain;
using Agenda.Repository;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Agenda.Servicos
{
    public class ContatoService
    {
        public Contato ConsultarContato()
        {
            var renato = new Contato();

            renato.Nome = "Renato";
            renato.Telefone = "1187898582";
            renato.Tipo = 1;
            return renato;

            ContatoRepository lista = new ContatoRepository();
            lista.ListContatosFromDatabase();
        }

        public List<Contato> ListarContatos()
        {
            ContatoRepository repositorio = new ContatoRepository();

            var listaContatos = repositorio.ListContatosFromDatabase();

            return listaContatos;
        }








    }




}
