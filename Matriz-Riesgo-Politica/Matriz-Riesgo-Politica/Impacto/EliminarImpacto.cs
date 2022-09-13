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
    public partial class eliminarImpacto : Form
    {
        public int codigoPosibilidad;
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        public eliminarImpacto()
        {
            InitializeComponent();
        }

        private void eliminarImpacto_Load(object sender, EventArgs e)
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
            DB.impactoRiesgoes.Remove(posibilidad);
            this.Close();

        }
    }
}
