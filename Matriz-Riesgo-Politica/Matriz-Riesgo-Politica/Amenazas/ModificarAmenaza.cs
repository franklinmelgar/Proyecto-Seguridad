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
    public partial class ModificarAmenaza : Form
    {
        public int CodigoAmenaza;
        Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();
        public ModificarAmenaza()
        {
            InitializeComponent();
        }

        private void ModificarAmenaza_Load(object sender, EventArgs e)
        {
            if (CodigoAmenaza == null)
            {
                this.Close();
            }
            else
            {
                var amenazaEncontrada = BD.categoriasAmenazas.Where(a => a.codigoCategoria.Equals(CodigoAmenaza)).FirstOrDefault();

                txtNombreAmenaza.Text = amenazaEncontrada.nombreCategoriaRiesgo;
                txtDescripcion.Text = amenazaEncontrada.descripcionCategoriaRiesgo;
                txtNombreAmenaza.Focus();

            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            var amenazaEncontrada = BD.categoriasAmenazas.Where(a => a.codigoCategoria.Equals(CodigoAmenaza)).FirstOrDefault();
            amenazaEncontrada.nombreCategoriaRiesgo = txtNombreAmenaza.Text;
            amenazaEncontrada.descripcionCategoriaRiesgo = txtDescripcion.Text;
            BD.SaveChanges();
            MessageBox.Show("Amenaza Actualizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
