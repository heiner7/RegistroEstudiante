/*
 * Created by SharpDevelop.
 * User: Heiner
 * Date: 18/4/2018
 * Time: 2:30 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using Registro_Estudiante;

namespace Estructuras_de_datos.Clases
{
	/// <summary>
	/// Description of ListaEnlazada.
	/// </summary>
	public class ListaEnlazada
	{
       // Form1 form =new Form1();
		private Nodo primero = new Nodo(); //Creamos un Nodo que presenta el primero
        private Nodo ultimo = new Nodo();

        public ListaEnlazada()
		{
			primero = null;
            ultimo = null;
		}
		
	
		
		public void insertarNodo(string cedula, string nombre, string ape, string fe, string tele, string dire, string ema, string ca){
			Nodo temporal = new Nodo();
			//Nodo nuevo = new Nodo();
			temporal.Cedula = cedula ;
            temporal.Nombre = nombre;
            temporal.Apellido = ape;
            temporal.Fecha = fe;
            temporal.Telefono = tele;
            temporal.Direccion = dire;
            temporal.Email = ema;
            temporal.Carrera = ca;

            //Si esta vacio el primero es el nuevo nodo
            if (primero==null){
				primero=temporal;
                primero.Siguiente = null;
                ultimo = temporal;
			}else{
                //El ultimo ya no apunte al null
                ultimo.Siguiente = temporal;
                //El nuevo apunte al null
                temporal.Siguiente = null;
                ultimo = temporal;
			}
			//temporal.setSiguiente(nuevo);
		}
		
		
		public string imprimirLista(){
			Nodo temporal = primero;
			string datos = "";
			
			//Recorremos la lista e imprimido dato por dato en string concatenado
			while(temporal!=null){
				datos += "Cedula: "+temporal.Cedula+ "\r\n" + "Nombre: " + temporal.Nombre + "\r\n" + "Apellido: " + temporal.Apellido + "\r\n"
                    + "Fecha: "+ temporal.Fecha + "\r\n" + "Telefono: "+ temporal.Telefono + "\r\n"
                   + "Dirección: "  + temporal.Direccion + "\r\n" + "E-Mail: "+ temporal.Email + "\r\n" + "Carrera: "+ temporal.Carrera + "\r\n"+ "\r\n";
				temporal = temporal.Siguiente;
			}
			return datos;
			
		}


        //Hice estos metodos pq no sé como mostrarlo en los campos y tenía poco tiempo
        public string buscar(string cedula, string nombre)
        {

            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        nombre = temporal.Nombre;
                        MessageBox.Show("La lista si tiene el dato", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        encontrado = true;
                    }
                    // datos += "Cedula: " + temporal.Cedula + "\r\n" + "Nombre: " + temporal.Nombre + "\r\n";
                    temporal = temporal.Siguiente;
                }
                if (encontrado==false)
                {
                    MessageBox.Show("Nodo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombre; 
        }

        public string busca2(string cedula, string nombre)
        {
            string ape="";
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        ape = temporal.Apellido;

                        encontrado = true;
                    }
                    // datos += "Cedula: " + temporal.Cedula + "\r\n" + "Nombre: " + temporal.Nombre + "\r\n";
                    temporal = temporal.Siguiente;
                }
            }
            return ape;
        }

        public string busca3(string cedula, string nombre)
        {
            string fecha = "";
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        fecha = temporal.Fecha;

                        encontrado = true;
                    }
                    // datos += "Cedula: " + temporal.Cedula + "\r\n" + "Nombre: " + temporal.Nombre + "\r\n";
                    temporal = temporal.Siguiente;
                }
            }
           
            return fecha;
        }

        public string busca4(string cedula, string nombre)
        {
            string telefono = "";
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        telefono = temporal.Telefono;

                        encontrado = true;
                    }
                   
                    temporal = temporal.Siguiente;
                }
            }
            return telefono;
        }

        public string busca5(string cedula, string nombre)
        {
            string direccion = "";
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        direccion = temporal.Direccion;

                        encontrado = true;
                    }
                
                    temporal = temporal.Siguiente;
                }
            }
            return direccion;
        }

        public string busca6(string cedula, string nombre)
        {
            string email = "";
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        email = temporal.Email;

                        encontrado = true;
                    }

                    temporal = temporal.Siguiente;
                }
            }
            return email;
        }

        public string busca7(string cedula, string nombre)
        {
            string carrera = "";
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        carrera = temporal.Carrera;

                        encontrado = true;
                    }

                    temporal = temporal.Siguiente;
                }
            }
            return carrera;
        }

        public string busca8(string cedula, string nombre)
        {
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        cedula = temporal.Cedula;

                        encontrado = true;
                    }

                    temporal = temporal.Siguiente;
                }
            }
            return cedula;
        }

        //Aquí termina

        public void eliminarNodo(string cedula)
        {
            Nodo temporal = primero;
            //Este apuntador almacena el valor actual ante q cambie su valor
            Nodo ante = new Nodo();
            ante = null;
            //Variable para romper el ciclo de while 
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula)
                    {
                        //Son los tres tipos de situaciones en donde se puede encontrar el nodo a eliminar
                        if (temporal == primero)
                        {
                            primero = primero.Siguiente;
                        }else if (temporal == ultimo)
                        {
                            ante.Siguiente = null;
                            ultimo = ante;
                        }
                        else
                        {
                            ante.Siguiente = temporal.Siguiente;
                        }
                        MessageBox.Show("Nodo eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        encontrado = true;
                    }
                    ante = temporal;
                    temporal = temporal.Siguiente;
                }
                if (encontrado == false)
                {
                    MessageBox.Show("Nodo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizar(string cedula, string nombre,string ape, string fe, string tele, string dire, string ema, string ca)
        {
            Nodo temporal = primero;
            bool encontrado = false;

            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula || temporal.Nombre == nombre)
                    {
                        temporal.Cedula = cedula;
                        temporal.Nombre = nombre;
                        temporal.Apellido = ape;
                        temporal.Fecha = fe;
                        temporal.Telefono = tele;
                        temporal.Direccion = dire;
                        temporal.Email = ema;
                        temporal.Carrera = ca;
                        MessageBox.Show("Nodo modificado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        encontrado = true;
                    }
                    // datos += "Cedula: " + temporal.Cedula + "\r\n" + "Nombre: " + temporal.Nombre + "\r\n";
                    temporal = temporal.Siguiente;
                }
                if (encontrado == false)
                {
                    MessageBox.Show("Nodo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string buscarCedula(string cedula)
        {
            Nodo temporal = primero;
            bool encontrado = false;
            string cedu="";
            if (temporal != null)
            {

                //Recorremos la lista e imprimido dato por dato en string concatenado
                while (temporal != null && encontrado != true)
                {
                    if (temporal.Cedula == cedula)
                    {
                        cedu = temporal.Cedula;
                        encontrado = true;
                    }
                    // datos += "Cedula: " + temporal.Cedula + "\r\n" + "Nombre: " + temporal.Nombre + "\r\n";
                    temporal = temporal.Siguiente;
                }
            }
            return cedu;
        }
    }
}
