using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagaDiario
{
    /// <summary>
    /// Descripción: Clase Clientes
    /// Ingeniero: Alex Aicardi
    /// Fecha: 26/01/2017
    /// </summary>
    public class Clientes
    {
        int idCliente;
        string nombre;
        string primerApellido;
        string segundoApellido;
        string cedula;
        string telefono;
        string direccion;

        //Constructor
        public Clientes()
        {
            //Test
            this.Nombre = "Alex";
            this.PrimerApellido = "Aicardi";
            this.SegundoApellido = "Avila";          
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }


        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}