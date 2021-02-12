using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LavaLipe.Models
{
    public class AgendaModel
    {
        public int Id { get; set; }
        public ClienteModel Cliente { get; set; }
        public DateTime DateScheduling { get; set; }
    }
}
