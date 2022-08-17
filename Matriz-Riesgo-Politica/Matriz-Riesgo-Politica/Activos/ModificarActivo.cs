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
        public ModificarActivo()
        {
            InitializeComponent();
        }

        private void ModificarActivo_Load(object sender, EventArgs e)
        {
            Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

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
    }
}
