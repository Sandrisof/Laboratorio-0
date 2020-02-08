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

        //Intentamos ordenar la lista alfabaticamente con este codigo pero no nos funciono
        /*public void Ordenalfabetico(ClienteModel[] vector, int n)
        {

           ClienteModel aux;

           for (int i = 0; i < n-1; i++)
           {
               for (int j = i; j < n; j++)
               {
                   if (vector[i].Nombre.CompareTo(vector[j].Nombre))
                   {
                       aux = vector[i];
                       vector[i] = vector[j];
                       vector[j] = aux; 
                   }

               }

           }
        }*/


    }
}