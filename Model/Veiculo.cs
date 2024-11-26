using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveManager.Model
{
    public class Veiculo
    {
        public long id_veiculo { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public long id_motorista { get; set; }

    }
}
