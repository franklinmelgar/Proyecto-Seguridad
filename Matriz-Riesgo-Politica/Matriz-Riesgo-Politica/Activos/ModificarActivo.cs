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
    public partial class ModificarActivo : Form
    {
        public int CodigoActivo;
        Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

        public ModificarActivo()
        {
            InitializeComponent();
        }

        private void ModificarActivo_Load(object sender, EventArgs e)
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

        private void btCrear_Click(object sender, EventArgs e)
        {
            var activoEncontrado = BD.Activos.Where(a => a.codigoActivo.Equals(CodigoActivo)).FirstOrDefault();
            activoEncontrado.nombreActivo = txtNombreActivo.Text;
            activoEncontrado.costoActivo = decimal.Parse(txtCosto.Text);
            BD.SaveChanges();
            MessageBox.Show("Activo Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
