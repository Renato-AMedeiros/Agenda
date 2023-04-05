using Microsoft.AspNetCore.Mvc;
using Agenda.Servicos;
using Agenda.Models;
using Agenda.Domain;


namespace Agenda.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class ContatosController : ControllerBase
    {


        // Endpoint que pode ser chamado por outros aplicativos
        [HttpGet("Consultar")]
        public ContatoModel Consultar()
        {
            // Instancia um objeto do tipo Serviço.
            ContatoService servico = new ContatoService();
         
            // Atribui a variavel resultado o retorno do método ConsultarContato dentro da classe ContatoService.
            Contato resultado = servico.ConsultarContato();

            // Instancia um objeto do tipo ContatoModel para servir como retorno do Endpoint.
            // Se faz isso porque a classe "Contato" não tem propriedades tão amigáveis para o consumidor da API,
            // então eu transformo o objeto do tipo Contato para um objeto do tipo ContatoModel que é mais legível.

            // Instancia um objeto do tipo ContatoModel
            ContatoModel retorno = new ContatoModel();

            // Atribui um valor para cada propriedade do objeto
            retorno.Nome= resultado.Nome;
            retorno.Telefone= resultado.Telefone;

            // Antes de atribuir o valor do Tipo, eu faço um tratamento para definir o nome do tipo em "string".
            string tipocontato;

            // Console
            Console.WriteLine("Tipo = " + resultado.Tipo);

            if (resultado.Tipo == 1)
            {
                tipocontato = "Pessoal";
            }
            else if (resultado.Tipo == 2)
            {
                tipocontato = "Comercial";
            }
            else 
            {
                tipocontato = "Empresarial";
            }
            
            // Agora eu atribuo o valor do Tipo
            retorno.Tipo = tipocontato;

            // Retorna o objeto do tipo ContatoModel
            return retorno;
        }

        // Criar um endpoint para Listar os contatos.


        [HttpGet("ListaDeContatos")]
        public List<ContatoModel> ListaDeContatos()
        {
            // Instancio a classe ServicoContato para que eu possa retornar os contatos do método ListarContatos
            ContatoService servicoContato = new ContatoService();

            // Crio uma variável listaContatos para guardar o que o método ListarContatos retornar.
            List<Contato> listaContatos = servicoContato.ListarContatos();

            // Criar uma lista de ContatoModel, pois só isso que eu posso retornar no método da Controller.
            List<ContatoModel> listaContatosModel = new List<ContatoModel>();

            // Fazer um "for" pra transformar cada objeto do tipo Contato em um objeto do tipo ContatoModel.
            for (int i = 0; i < listaContatos.Count; i++)
            {
                Contato contatoQueEuPegueiDaLista;
                contatoQueEuPegueiDaLista = listaContatos[i];

                ContatoModel contatoQueEuTransformei = new ContatoModel();
                contatoQueEuTransformei.Nome = contatoQueEuPegueiDaLista.Nome;
                // Fazer a mesma coisa com as outras propriedades.

                // Fazer else if com os outros tipos
                if (contatoQueEuPegueiDaLista.Tipo == 1)
                {
                    contatoQueEuTransformei.Tipo = "Pessoal";
                }

                listaContatosModel.Add(contatoQueEuTransformei);
            }
            // Retorno a lista de ContatosModel.
            return listaContatosModel;
        }

    }
}
 