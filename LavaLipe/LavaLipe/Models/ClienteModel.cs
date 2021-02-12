using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LavaLipe.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPFCNPJ { get; set; }
        public string Phone { get; set; }
        public int Excluido { get; set; }

    }
}
