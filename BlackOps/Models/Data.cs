using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Data
    {
        public Guid Id { get; set; }
        public string Cuenta { get; set; }
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Inicial { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public decimal Final { get; set; }
    }
}
