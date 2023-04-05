using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.Domain
{
    public class Tarefa
    {
        public  string Titulo { get; set; }
      
        public string Descricao { get; set; }
        public DateTime DataLimite { get; set; }
        public bool Executada { get; set; }

       

    }

    
}
