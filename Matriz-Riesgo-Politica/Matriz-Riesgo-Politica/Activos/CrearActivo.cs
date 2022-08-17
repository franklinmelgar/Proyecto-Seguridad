using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica
{
    public partial class CrearActivo : Form
    {
        public CrearActivo()
        {
            InitializeComponent();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

            Activo nuevoActivo = new Activo();
            nuevoActivo.nombreActivo = txtNombreActivo.Text;
            nuevoActivo.costoActivo = Convert.ToDecimal(txtCosto.Text);

            BD.Activos.Add(nuevoActivo);
            BD.SaveChanges();

            MessageBox.Show("Activo Creado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
