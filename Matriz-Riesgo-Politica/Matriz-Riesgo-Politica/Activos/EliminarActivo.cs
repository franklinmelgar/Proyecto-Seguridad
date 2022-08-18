using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica.Activos
{
    public partial class EliminarActivo : Form
    {
        public int CodigoActivo;
        Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

        public EliminarActivo()
        {
            InitializeComponent();
        }

        private void EliminarActivo_Load(object sender, EventArgs e)
        {
            if (CodigoActivo == null)
            {
                this.Close();
            }
            else
            {
                var activoEncontrado = BD.Activos.Where(a => a.codigoActivo.Equals(CodigoActivo)).FirstOrDefault();

                txtNombreActivo.Text = activoEncontrado.nombreActivo;
                txtCosto.Text = activoEncontrado.costoActivo.ToString();
                txtNombreActivo.Focus();

            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de eliminar el activo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var activoEncontrado = BD.Activos.Where(a => a.codigoActivo.Equals(CodigoActivo)).FirstOrDefault();
                BD.Activos.Remove(activoEncontrado);
                BD.SaveChanges();
                MessageBox.Show("Activo Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
