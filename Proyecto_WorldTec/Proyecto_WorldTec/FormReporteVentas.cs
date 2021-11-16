using BL.Tecnologia;
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
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();
            var _facturasBL = new FacturaBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturasBL.ObtenerFacturas();

            var reporte = new ReporteVentas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
