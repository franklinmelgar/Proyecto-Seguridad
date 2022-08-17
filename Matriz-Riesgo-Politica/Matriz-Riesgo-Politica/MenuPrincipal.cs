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
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void obtenerActivos()
        {
            Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
            var activos = DB.Activos.ToList();
            gridActivos.DataSource = activos;
           

        }

        private void btActivos_Click(object sender, EventArgs e)
        {
            obtenerActivos();
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[0];
        }

        private void btAmenazas_Click(object sender, EventArgs e)
        {
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[1];
        }

        private void btPosibilidad_Click(object sender, EventArgs e)
        {
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[2];
        }

        private void btImpacto_Click(object sender, EventArgs e)
        {
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[3];
        }

        private void btAgregarActivos_Click(object sender, EventArgs e)
        {
            CrearActivo crearActivo = new CrearActivo();
            crearActivo.Show();
        }

        private void btModificarActivo_Click(object sender, EventArgs e)
        {
           
        }
    }
}
