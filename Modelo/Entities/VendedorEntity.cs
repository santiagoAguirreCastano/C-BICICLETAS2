using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class VendedorEntity
    {
        public int idVendedor {  get; set; }

        public string nombreVendedor { get; set; }

        public string correoVendedor { get; set; }

        public int comision {  get; set; }

        public int telefonoVendedor { get; set; }
    }
}
