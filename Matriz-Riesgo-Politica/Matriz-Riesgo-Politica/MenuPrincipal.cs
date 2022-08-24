using Matriz_Riesgo_Politica.Activos;
using Matriz_Riesgo_Politica.Amenazas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica
{
    public partial class fmrMenu : Form
    {
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void obtenerActivos()
        {            
            var activos = DB.Activos.ToList();
            gridActivos.DataSource = activos;       

        }

        private void obtenerAmenazas()
        {
            var amenazas = DB.categoriasAmenazas.ToList();
            gridAmenazas.DataSource = amenazas;

        }

        private void btActivos_Click(object sender, EventArgs e)
        {
            obtenerActivos();
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[0];
        }

        private void btAmenazas_Click(object sender, EventArgs e)
        {
            obtenerAmenazas();
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
            int codigoActivo = int.Parse(gridActivos.Rows[gridActivos.CurrentRow.Index].Cells[0].Value.ToString());
            ModificarActivo modificar = new ModificarActivo();
            modificar.CodigoActivo = codigoActivo;
            modificar.Show();

        }

        private void btEliminarActivo_Click(object sender, EventArgs e)
        {
            int codigoActivo = int.Parse(gridActivos.Rows[gridActivos.CurrentRow.Index].Cells[0].Value.ToString());
            EliminarActivo eliminarActivo = new EliminarActivo();
            eliminarActivo.CodigoActivo = codigoActivo;
            eliminarActivo.Show();
        }

        private void btAgregarAmenaza_Click(object sender, EventArgs e)
        {
            CrearAmenaza crearAmenaza = new CrearAmenaza();
            crearAmenaza.Show();
        }

        private void btModificarAmenaza_Click(object sender, EventArgs e)
        {
            int codigoAmenaza = int.Parse(gridAmenazas.Rows[gridAmenazas.CurrentRow.Index].Cells[0].Value.ToString());
            ModificarAmenaza modificar = new ModificarAmenaza();
            modificar.CodigoAmenaza = codigoAmenaza;
            modificar.Show();
        }

        private void btEliminarAmenaza_Click(object sender, EventArgs e)
        {
            int codigoAmenaza = int.Parse(gridAmenazas.Rows[gridAmenazas.CurrentRow.Index].Cells[0].Value.ToString());
            EliminarAmenaza eliminarAmenaza = new EliminarAmenaza();
            eliminarAmenaza.CodigoAmenaza = codigoAmenaza;
            eliminarAmenaza.Show();
        }
    }
}
