using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repository
{
    public class TarefaRepository
    {
       
        
        public List<Tarefa> ListarTarefasBancoDados()
        {
            Tarefa tarefa1 = new Tarefa();
            tarefa1.Titulo = "Reunião";
            tarefa1.Descricao = "De investimentos";
            tarefa1.Executada = true;
            tarefa1.DataLimite = DateTime.Parse("2023-04-10"); // Como transformar uma string em Datetime.


            Tarefa tarefa2 = new Tarefa();
            tarefa2.Titulo = "Reunião";
            tarefa2.Descricao = " Café da manhã com cliente";
            tarefa2.Executada = true;
            tarefa1.DataLimite = DateTime.Parse("2023-04-11");

            Tarefa tarefa3 = new Tarefa();
            tarefa3.Titulo = "Folga";
            tarefa3.Descricao = "Passear";
            tarefa3.Executada = true;
            tarefa1.DataLimite = DateTime.Parse("2023-04-12");

            Tarefa tarefa4 = new Tarefa();
            tarefa4.Titulo = "Viagem";
            tarefa4.Descricao = "Ir a Filial";
            tarefa4.Executada = false;
            tarefa1.DataLimite = DateTime.Parse("2023-04-13");

            Tarefa tarefa5 = new Tarefa();
            tarefa5.Titulo = "Reunião";
            tarefa5.Descricao = "com executivos";
            tarefa5.Executada = true;
            tarefa1.DataLimite = DateTime.Parse("2023-04-14");

            Tarefa tarefa6 = new Tarefa();
            tarefa6.Titulo = "Almoço de Reunião";
            tarefa6.Descricao = " com a equipe de RH";
            tarefa6.Executada = true;
            tarefa1.DataLimite = DateTime.Parse("2023-04-15");

            Tarefa tarefa7 = new Tarefa();
            tarefa7.Titulo = "Trabalho Importante";
            tarefa7.Descricao = "Investigar a concorrência";
            tarefa7.Executada = false;
            tarefa1.DataLimite = DateTime.Parse("2023-04-16");

            Tarefa tarefa8 = new Tarefa();
            tarefa8.Titulo = "Folga ";
            tarefa8.Descricao = "descançar";
            tarefa8.Executada = true;
            tarefa1.DataLimite = DateTime.Parse("2023-04-17");

            Tarefa tarefa9 = new Tarefa();
            tarefa9.Titulo = "Folga";
            tarefa9.Descricao = "ir ao parque";
            tarefa9.Executada = false;
            tarefa1.DataLimite = DateTime.Parse("2023-04-18");

            Tarefa tarefa10 = new Tarefa();
            tarefa10.Titulo = "Reunião";
            tarefa10.Descricao = "Com os Gestores unidade 2";
            tarefa10.Executada = true;
            tarefa1.DataLimite = DateTime.Parse("2023-04-19");





            List<Tarefa> ListaDeTarefas = new List<Tarefa>();

            ListaDeTarefas.Add(tarefa1);
            ListaDeTarefas.Add(tarefa2);
            ListaDeTarefas.Add(tarefa3);
            ListaDeTarefas.Add(tarefa4);
            ListaDeTarefas.Add(tarefa5);
            ListaDeTarefas.Add(tarefa6);
            ListaDeTarefas.Add(tarefa7);
            ListaDeTarefas.Add(tarefa8);
            ListaDeTarefas.Add(tarefa9);
            ListaDeTarefas.Add(tarefa10);


            return ListaDeTarefas;
        }
        
        

    }
}
