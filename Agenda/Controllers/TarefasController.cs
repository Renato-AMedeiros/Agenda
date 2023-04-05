using Agenda.Domain;
using Agenda.Models;
using Agenda.Repository;
using Agenda.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Agenda.Controllers
{

    [ApiController]
    [Route("API/[controller]")]
    public class TarefasController : ControllerBase

    {

        [HttpGet("ListarTodasAsTarefas")]


        public List<TarefaViewModel> TodasAsTarefaeController()
        {
           

            

            TarefaService tarefaService = new TarefaService();
            List<Tarefa> tarefas = tarefaService.ListarTodasTarefas();
            List<TarefaViewModel> tarefasConvertidas = new List<TarefaViewModel>();

            for (var i = 0; i < tarefas.Count; i++)
            {
                // pegar cada tarefa dentro da lista de tarefas
                Tarefa tarefa = tarefas[i];

                TarefaViewModel tarefaConvertida = new TarefaViewModel();

                tarefaConvertida.Titulo = tarefa.Titulo;
                tarefaConvertida.DataLimite = tarefa.DataLimite.ToString();
                tarefaConvertida.Executada = tarefa.Executada.ToString();

                // If pra tratar o valor de tarefa.Executada
                if (tarefa.Executada == false)
                {
                    tarefaConvertida.Executada = "Pendente";
                }
                else
                {
                    tarefaConvertida.Executada = "Executada";
                }

                tarefasConvertidas.Add(tarefaConvertida);
            }

            return tarefasConvertidas;
        }


        ////////////////////////////////////////////////



        [HttpGet("ListarTarefasExecutadas")]

        
        public List<TarefaViewModel> TarefaExecutasController()
        {
          
            
          
           TarefaService tarefaService= new TarefaService();
           List<Tarefa> tarefasRetornadas = tarefaService.ListarTarefasExecutadas();
           List<TarefaViewModel> tarefasExecutadas = new List<TarefaViewModel>();



            for (var i = 0; i < tarefasRetornadas.Count; i++)
            {
                Tarefa tarefa = tarefasRetornadas[i];

                TarefaViewModel tarefaExecutada= new TarefaViewModel();

                tarefaExecutada.Titulo = tarefa.Titulo;
                tarefaExecutada.DataLimite = tarefa.DataLimite.ToString();
                tarefaExecutada.Executada = tarefa.Executada.ToString();

                if( tarefa.Executada == true)
                {
                    tarefaExecutada.Executada = "Executada";

                }

                tarefasExecutadas.Add(tarefaExecutada); 
            }


           
            return tarefasExecutadas;

        }


        //////////////////////////////////////////////
       

        [HttpGet("ListarTarefasPendentes")]


        public List<TarefaViewModel> TarefaPendenteController()
        {
  
            TarefaService tarefaService = new TarefaService();
            List<Tarefa> tarefa = tarefaService.ListarTarefasPendentes();
            List<TarefaViewModel> tarefasPendentes = new List<TarefaViewModel>(); 

            for (var i = 0; i < tarefa.Count; i++)
            {
               Tarefa tarefas = tarefa[i];

                TarefaViewModel tarefaPendente = new TarefaViewModel();

                tarefaPendente.Titulo = tarefas.Titulo;
                tarefaPendente.DataLimite = tarefas.DataLimite.ToString();
                tarefaPendente.Executada = tarefas.Executada.ToString();

                if(tarefas.Executada == false)
                {
                    tarefaPendente.Executada = "Pendente";
                }
                tarefasPendentes.Add(tarefaPendente);
            }

           
            
            return tarefasPendentes;
        }


        //////////////////////////////////////////////



        [HttpGet("ListarTarefasFiltradas")]
        public List<Tarefa> TarefaFiltrada(string filtro)
        {
            // quando for pendente 

            List<Tarefa> tarefasRetornadas = new List<Tarefa>();


            TarefaService tarefaService = new TarefaService();


            tarefasRetornadas = tarefaService.ListarTarefasPendentes();


            return tarefasRetornadas;
        }

    }
}