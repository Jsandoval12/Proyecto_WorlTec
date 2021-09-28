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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.SuspendLayout();
            // 
            // FormProductos
            // 
            this.ClientSize = new System.Drawing.Size(810, 397);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductos";
            this.Text = "Productos ";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.ResumeLayout(false);

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
