using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ClienteEntity
    {
        public int IdCliente { get; set; }

        public string NombreCliente { get; set; }

        public string CorreoCliente {  get; set; }

        public int TelefonoCliente { get; set; }

        public string DireccionCliente {  get; set; }

        public string GeneroCliente { get; set; }

    }
}
