using Laboratorio_0.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_0.Models
{
    public class ClienteModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Descripcion { get; set; }

        public bool Save()
        {
            try
            {
                Storage.Instancia.ListaClientes.Add(this);
                return true;
            }
            catch
            {

                return false;
            }
        }

    }
}