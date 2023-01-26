/*
 * Created by SharpDevelop.
 * User: Heiner
 * Date: 18/4/2018
 * Time: 2:30 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Estructuras_de_datos.Clases
{
	/// <summary>
	/// Description of Nodo.
	/// </summary>
	public class Nodo
	{
		private string cedula; //Dato del nodo
        private string nombre;
        private string apellido;
        private string fecha;
        private string telefono;
        private string direccion;
        private string email;
        private string carrera;

        private Nodo siguiente; //Establece el siguiente nodo
		 
		public string Cedula
        {
             get { return	cedula; }
            set { cedula = value; }
		}

        public string Nombre
        {
            get { return nombre; }
            set{ nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public Nodo Siguiente
        {
			get { return siguiente; }
            set { siguiente = value; }

		}
		

		
	}
}
