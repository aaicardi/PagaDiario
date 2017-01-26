using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagaDiario
{
    /// <summary>
    /// Descripción: Clase Tipo pago
    /// Ingeniero: Alex Aicardi
    /// Fecha: 26/01/2017
    /// </summary>
    public class TipoPago
    {
        int codigo;     
        string nombre;

        public TipoPago()
        {

        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}