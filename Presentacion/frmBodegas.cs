using Dominio;
using Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmBodegas : Form
    {
        public frmBodegas()
        {
            InitializeComponent();
        }

        private void frmBodegas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor, ingrese la bodega a seleccionar ;)");
            BodegaNegocio negocio = new BodegaNegocio();
            List<Bodega> listaBodegas = negocio.listar();
            if (listaBodegas != null)
            {
                dgvBodegas.DataSource = listaBodegas;
                dgvBodegas.Columns.Clear();

                // Agregar una columna para mostrar solo el nombre de las bodegas
                DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
                columnaNombre.DataPropertyName = "nombre"; // Asignar el nombre de la propiedad que se mostrará en esta columna
                columnaNombre.HeaderText = "Nombre"; // Encabezado de la columna
                dgvBodegas.Columns.Add(columnaNombre);
                columnaNombre.Width = 200;

            }
            else
            {
                MessageBox.Show("No se encontraron bodegas con actualizaciones disponibles.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObtenerActu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obteniendo actualizaciones de vinos..");
        }
    }
    }

