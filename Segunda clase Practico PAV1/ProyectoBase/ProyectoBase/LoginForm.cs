using ProyectoBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtUsuario.Text, txtContraseña.Text);

            string usuCorrecto = "Pablo";
            string passCorrecto = "123456";
            MessageBox.Show("Hola "+usu.NombreDeUsuario+" "+usu.Password);

            if (txtUsuario.Text.Equals(usuCorrecto) && txtContraseña.Text.Equals(passCorrecto))
            {
                MessageBox.Show("Datos Correctos");
                Principal ventana = new Principal();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese valores correctos");
            }
        }
    }
}
