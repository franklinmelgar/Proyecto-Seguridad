using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica.Amenazas
{
    public partial class CrearAmenaza : Form
    {
        public CrearAmenaza()
        {
            InitializeComponent();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();
            categoriasAmenaza amenaza = new categoriasAmenaza();
            amenaza.nombreCategoriaRiesgo = txtNombreAmenaza.Text;
            amenaza.descripcionCategoriaRiesgo = txtDescripcion.Text;
            amenaza.tipoCreacionAmenaza = "UDC";

            BD.categoriasAmenazas.Add(amenaza);
            BD.SaveChanges();

            MessageBox.Show("Se creo correctamente la amenaza", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
