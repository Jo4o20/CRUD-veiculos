using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculos.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public decimal ValorFipe { get; set; }
        public decimal ValorVenda { get; set; }
        public string Observacoes { get; set; }
    }
}
