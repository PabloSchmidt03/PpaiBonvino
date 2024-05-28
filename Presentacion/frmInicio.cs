using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestor;
using Dominio;

namespace Presentacion
{
    public partial class frmInicio : Form
    {
 
        public frmInicio()
        {
            InitializeComponent();
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            HabilitarVentana();
            
        }

        private void HabilitarVentana()
        {
            frmBodegas ventana = new frmBodegas();
            ventana.ShowDialog();

        }
    }
}
