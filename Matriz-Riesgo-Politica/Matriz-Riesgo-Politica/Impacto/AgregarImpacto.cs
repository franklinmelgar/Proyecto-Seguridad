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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            impactoRiesgo impacto = new impactoRiesgo();
            impacto.nivelImpacto = txtNivelImpacto.Text;
            impacto.puntajeImpacto = int.Parse(txtPuntaje.Text);
            impacto.descripcionImpacto = txtDescripcion.Text;

            MessageBox.Show("Se agrego correctamente el impacto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
