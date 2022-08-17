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
    public partial class EliminarAmenaza : Form
    {
        public int CodigoAmenaza;
        Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

        public EliminarAmenaza()
        {
            InitializeComponent();
        }

        private void EliminarAmenaza_Load(object sender, EventArgs e)
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

            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar la amenaza?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var amenazaEncontrada = BD.categoriasAmenazas.Where(a => a.codigoCategoria.Equals(CodigoAmenaza)).FirstOrDefault();
                BD.categoriasAmenazas.Remove(amenazaEncontrada);
                BD.SaveChanges();
                MessageBox.Show("Amenaza Eliminada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
