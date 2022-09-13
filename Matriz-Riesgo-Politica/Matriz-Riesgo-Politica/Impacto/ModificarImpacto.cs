using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica.Impacto
{
    public partial class modificarImpacto : Form
    {
        public int codigoPosibilidad;
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        public modificarImpacto()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            obtenerImpacto();
        }

        private void obtenerImpacto()
        {
            impactoRiesgo posibilidad = DB.impactoRiesgoes.Where(p => p.codigoImpacto == codigoPosibilidad).FirstOrDefault();

            txtNivelImpacto.Text = posibilidad.nivelImpacto;
            txtPuntaje.Text = posibilidad.puntajeImpacto.ToString();
            txtDescripcion.Text = posibilidad.descripcionImpacto;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            impactoRiesgo posibilidad = DB.impactoRiesgoes.Where(p => p.codigoImpacto == codigoPosibilidad).FirstOrDefault();

            posibilidad.nivelImpacto = txtNivelImpacto.Text;
            posibilidad.puntajeImpacto = int.Parse(txtPuntaje.Text);
            posibilidad.descripcionImpacto = txtDescripcion.Text;

            DB.SaveChanges();

            this.Close();
        }
    }
}
