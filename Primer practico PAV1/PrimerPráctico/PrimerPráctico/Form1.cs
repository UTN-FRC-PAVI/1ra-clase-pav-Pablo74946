using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPráctico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpiar_campos();
            txtUsuario.Text = "Ingrese nombre de usuario";
            txtContraseña.Text = "Ingrese la contraseña";
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + txtUsuario.Text  +" "+txtContraseña.Text) ;
        }

        private void btnpersona_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            { MessageBox.Show("Ingrese el nombre y apellido"); }
        
           else { 
                string nombreCompleto = "";
                nombreCompleto = txtUsuario.Text + " " + txtContraseña.Text;

                lstPersonas.Items.Add(nombreCompleto);
                MessageBox.Show("Persona agregada exitosamente.");
                limpiar_campos();

            }
           
        }
        private void limpiar_campos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
}
