using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_WorldTec
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            if (usuario == "Admin21" && contrasena == "unahvs" ||  (usuario == "Jona7" && contrasena == "jona123") || (usuario == "Carlos7" && contrasena == "carlos123"))
            {
                MessageBox.Show("Bienvenido al Sistema");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                textBox1.Text = "";
                textBox2.Text = "";
            }

          


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
