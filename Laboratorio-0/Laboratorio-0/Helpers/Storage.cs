using Laboratorio_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_0.Helpers
{
    public class Storage
    {
        private static Storage _instancia = null;
        public static Storage Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Storage();
                }
                return _instancia;
            }
        }

        public List<ClienteModel> ListaClientes = new List<ClienteModel>();
    }
}