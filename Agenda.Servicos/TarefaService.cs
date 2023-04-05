using Agenda.Domain;
using Agenda.Repository;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


namespace Agenda.Services

/* Criar um método na classe TarefaService, chamado ListarTarefasPendentes
          que retorna todas as tarefas que Executada for igual a false.*/

/* Criar um método na classe TarefaService, chamado ListarTarefasExecutadas
 * que retorna todas as tarefas que Executada for igual a true.*/

{
    public class TarefaService
    {

        public List<Tarefa> ListarTodasTarefas()
        {
            TarefaRepository repositorio = new TarefaRepository();
            List<Tarefa> tarefas = repositorio.ListarTarefasBancoDados();

            return tarefas;

            // return repositorio.ListarTarefasBancoDados();
            // return new TarefaRepository().ListarTarefasBancoDados();
        }

        public List<Tarefa> ListarTarefasPendentes() //criei um metodo para guardar o conteudo da lista de tarefas
        {

            TarefaRepository naoExecutadasConsultada = new TarefaRepository(); // instacio uma variável "ConsultarFalse" para ter acesso ao dados da classe "TarefaRepository

       

       

            List<Tarefa> listaDeTarefasCompleta = naoExecutadasConsultada.ListarTarefasBancoDados();
            // 1 - Criar uma caixa para receber só as bolinhas azuis (uma variavel do tipo List<Tarefa> para guardar só as tarefas pendentes)

            List<Tarefa> tarefasPendentes = new List<Tarefa>();

            


            for (int i = 0; i < listaDeTarefasCompleta.Count; i++)
            {

                Tarefa tarefa;
                tarefa = listaDeTarefasCompleta[i];

                // 2 - Olhar pra bolinha e ver se ela é azul. (Testar se essa tarefa é pendente ou não)

                // 2.1 - Se Tarefa.Executada == false, eu vou colocar a tarefa dentro da Lista de tarefas pendentes.

                if (tarefa.Executada == false)
                {

                   {
                        tarefasPendentes.Add(tarefa);
                   }
                }
                    
  
            }

            // 3 - Retornar a lista de tarefas pendentes.

            // return listaDeTarefasCompleta;
            return tarefasPendentes;
        }



        public List<Tarefa> ListarTarefasExecutadas()
        {
            TarefaRepository TarefaExecutada = new TarefaRepository();
           

            List<Tarefa> listaCompleta = TarefaExecutada.ListarTarefasBancoDados();

            List<Tarefa> tarefasExecutadas = new List<Tarefa>();

            for (int i = 0; i < listaCompleta.Count; i++)
            {
                Tarefa tarefa;
               
                 tarefa = listaCompleta [i];

                

                if (tarefa.Executada == true)
                {
                   
                    {
                        tarefasExecutadas.Add(tarefa);
                    }

                }
                

            }
            return tarefasExecutadas;
            
        }
        
    }
    
}
