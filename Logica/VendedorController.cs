using System;
using System.Collections.Generic;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class VendedorController
    {
        
        public List<VendedorEntity> verEmpleados()
        {
           
            BaseDatos db = new BaseDatos();

            List<VendedorEntity> vendedor = db.ObtenerVendedores();
            
            return vendedor;

        }


    }
}
