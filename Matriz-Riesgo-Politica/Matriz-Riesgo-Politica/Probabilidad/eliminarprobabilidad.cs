using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica.Probabilidad
{
    public partial class eliminarprobabilidad : Form
    {
        public int codigoPosibilidad;
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();

        public eliminarprobabilidad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerPosibilidad();
        }

        private void obtenerPosibilidad()
        {
            posibilidadRiesgo posibilidad = DB.posibilidadRiesgoes.Where(p => p.codigoPosibilidad == codigoPosibilidad).FirstOrDefault();

            txtNivelPosibilidad.Text = posibilidad.nivelPosibilidad;
            txtPuntaje.Text = posibilidad.puntajePosibilidad.ToString();
            txtDescripcion.Text = posibilidad.descripcionPosibilidad;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            posibilidadRiesgo posibilidad = DB.posibilidadRiesgoes.Where(p => p.codigoPosibilidad == codigoPosibilidad).FirstOrDefault();
            DB.posibilidadRiesgoes.Remove(posibilidad);
            MessageBox.Show("Se elmino correctamente la posibilidad", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
