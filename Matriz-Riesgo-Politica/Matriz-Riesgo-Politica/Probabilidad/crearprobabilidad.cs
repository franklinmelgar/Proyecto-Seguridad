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
    public partial class crearprobabilidad : Form
    {
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        public crearprobabilidad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            posibilidadRiesgo posibilidad = new posibilidadRiesgo();
            posibilidad.nivelPosibilidad = txtNivelPosibilidad.Text;
            posibilidad.puntajePosibilidad = int.Parse(txtPuntaje.Text);
            posibilidad.descripcionPosibilidad = txtDescripcion.Text;

            MessageBox.Show("Se creo correctamente la posibilidad", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNivelPosibilidad.Clear();
            txtPuntaje.Clear();
            txtDescripcion.Clear();

            txtNivelPosibilidad.Focus();

        }
    }
}
