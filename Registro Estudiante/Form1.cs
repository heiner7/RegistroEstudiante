using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructuras_de_datos.Clases;
using Validaciones;

namespace Registro_Estudiante
{
    public partial class Form1 : Form
    {
        ListaEnlazada listadatos = new ListaEnlazada();

        public Form1()
        {
            InitializeComponent();
            StreamReader leer = new StreamReader(@"..\..\Carreras.txt");
            string llenar;
            try
            {

                for (int i = 0; i < 5; i++)
                {
                    llenar = leer.ReadLine();
                    cbCarrera.Items.Add(llenar);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtApellido.Text == "" || cbCarrera.Text == "")
            {
                MessageBox.Show("Campos cedula, nombre, apellido o carrera sin llenar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listadatos.buscarCedula(txtCedula.Text) == txtCedula.Text)
            {
                MessageBox.Show("Cedula existente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                listadatos.insertarNodo(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtFechaNa.Text, txtTelefono.Text, txtDireccion.Text, txtEmail.Text, cbCarrera.Text);

                lbDatos.Text = listadatos.imprimirLista();
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                cbCarrera.SelectedIndex = 0;

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Ingrese dato en el campo de cedula", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listadatos.eliminarNodo(txtCedula.Text);

                lbDatos.Text = listadatos.imprimirLista();
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                cbCarrera.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" && txtNombre.Text =="")
            {
                MessageBox.Show("Ingrese dato en el campo de cedula o nombre", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                txtNombre.Text = listadatos.buscar(txtCedula.Text, txtNombre.Text);
                txtApellido.Text = listadatos.busca2(txtCedula.Text, txtNombre.Text);
                txtFechaNa.Text = listadatos.busca3(txtCedula.Text, txtNombre.Text);
                txtTelefono.Text = listadatos.busca4(txtCedula.Text, txtNombre.Text);
                txtDireccion.Text = listadatos.busca5(txtCedula.Text, txtNombre.Text);
                txtEmail.Text = listadatos.busca6(txtCedula.Text, txtNombre.Text);
                cbCarrera.Text = listadatos.busca7(txtCedula.Text, txtNombre.Text);
                txtCedula.Text = listadatos.busca8(txtCedula.Text, txtNombre.Text);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Ingrese dato en el campo de cedula", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listadatos.actualizar(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtFechaNa.Text, txtTelefono.Text, txtDireccion.Text, txtEmail.Text, cbCarrera.Text);
                lbDatos.Text = listadatos.imprimirLista();
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                cbCarrera.Text = "";
            }
        }



        private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            var txt = sender as TextBox; //Sender obtiene el objeto actual 
            try
            {
                int a = Int32.Parse(txt.Text); //Intentamos covertir el string a número 
            }
            catch (Exception exc)
            {
                txt.Text = ""; //En caso de error se limpia el Campo
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }
    }
}
