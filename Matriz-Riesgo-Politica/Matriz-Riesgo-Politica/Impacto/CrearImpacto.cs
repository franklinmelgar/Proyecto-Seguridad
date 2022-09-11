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
    public partial class CrearImpacto : Form
    {
        public CrearImpacto()
        {
            InitializeComponent();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

            impactoRiesgo impact = new impactoRiesgo();
            impact.nivelImpacto = textBox1.Text;
            impact.puntajeImpacto = Convert.ToInt32(textBox2.Text);

            BD.impactoRiesgoes.Add(impact);
            BD.SaveChanges();

            MessageBox.Show("Activo Creado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CrearImpacto_Load(object sender, EventArgs e)
        {

        }
    }
}
