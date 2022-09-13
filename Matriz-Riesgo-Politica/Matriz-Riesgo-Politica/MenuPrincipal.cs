using Matriz_Riesgo_Politica.Activos;
using Matriz_Riesgo_Politica.Amenazas;
using Matriz_Riesgo_Politica.Impacto;
using Matriz_Riesgo_Politica.Matriz;
using Matriz_Riesgo_Politica.Probabilidad;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica
{
    public partial class fmrMenu : Form
    {
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        int codigoMatriz;

        public fmrMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerActivos();
        }

        private void obtenerActivos()
        {
            var activos = DB.Activos.Select(c => new
            {
                c.codigoActivo,
                c.nombreActivo,
                c.costoActivo
            }).ToList();
            gridActivos.DataSource = activos;       

        }

        private void obtenerAmenazas()
        {
            var amenazas = DB.categoriasAmenazas.Select(c => new
            {
                c.codigoCategoria,
                c.nombreCategoriaRiesgo,
                c.descripcionCategoriaRiesgo
            }).ToList();
            gridAmenazas.DataSource = amenazas;

        }

        private void estableColor(string boton)
        {
            if (boton.Equals("Activos"))
            {
                btActivos.BackColor = Color.FromArgb(244, 81, 30);
                btAmenazas.BackColor = Color.FromArgb(51, 51, 76);
                btPosibilidad.BackColor = Color.FromArgb(51, 51, 76);
                btImpacto.BackColor = Color.FromArgb(51, 51, 76);
                btMatriz.BackColor = Color.FromArgb(51, 51, 76);
            }else if (boton.Equals("Amenazas"))
            {
                btActivos.BackColor = Color.FromArgb(51, 51, 76);
                btAmenazas.BackColor = Color.FromArgb(244, 81, 30);
                btPosibilidad.BackColor = Color.FromArgb(51, 51, 76);
                btImpacto.BackColor = Color.FromArgb(51, 51, 76);
                btMatriz.BackColor = Color.FromArgb(51, 51, 76);
            }
            else if (boton.Equals("Posibilidades"))
            {
                btActivos.BackColor = Color.FromArgb(51, 51, 76);
                btAmenazas.BackColor = Color.FromArgb(51, 51, 76);
                btPosibilidad.BackColor = Color.FromArgb(244, 81, 30); 
                btImpacto.BackColor = Color.FromArgb(51, 51, 76);
                btMatriz.BackColor = Color.FromArgb(51, 51, 76);
            }
            else if (boton.Equals("Impacto"))
            {
                btActivos.BackColor = Color.FromArgb(51, 51, 76);
                btAmenazas.BackColor = Color.FromArgb(51, 51, 76);
                btPosibilidad.BackColor = Color.FromArgb(51, 51, 76);
                btImpacto.BackColor = Color.FromArgb(244, 81, 30);
                btMatriz.BackColor = Color.FromArgb(51, 51, 76);
            }
            else if (boton.Equals("Matriz"))
            {
                btActivos.BackColor = Color.FromArgb(51, 51, 76);
                btAmenazas.BackColor = Color.FromArgb(51, 51, 76);
                btPosibilidad.BackColor = Color.FromArgb(51, 51, 76);
                btImpacto.BackColor = Color.FromArgb(51, 51, 76);
                btMatriz.BackColor = Color.FromArgb(244, 81, 30);  
            }
        }

        private void btActivos_Click(object sender, EventArgs e)
        {
            estableColor("Activos");
            obtenerActivos();
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[0];
        }

        private void btAmenazas_Click(object sender, EventArgs e)
        {
            estableColor("Amenazas");
            obtenerAmenazas();
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[1];
        }

        private void btPosibilidad_Click(object sender, EventArgs e)
        {
            estableColor("Posibilidades");
            obtenerPosibilidades();
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[2];
        }

        private void btImpacto_Click(object sender, EventArgs e)
        {
            estableColor("Impacto");
            obtenerImpacto();
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[3];
        }

        private void obtenerImpacto()
        {
            var impactos = DB.impactoRiesgoes.Select(c => new
            {
                c.codigoImpacto,
                c.nivelImpacto,
                c.puntajeImpacto
            }).ToList();
            impactGrid.DataSource = impactos;
        }

        private void obtenerPosibilidades()
        {
            var posibilidades = DB.posibilidadRiesgoes.Select(c => new
            {
                c.codigoPosibilidad,
                c.nivelPosibilidad,
                c.puntajePosibilidad
            }).ToList();

            grdPosibilidades.DataSource = posibilidades;
        }

        private void obtenerMatrices()
        {
            var cabecera = DB.cabeceraAnalisisRiesgoes.Select(c => new
            {
                c.codigoAnalisisRiesgo,
                c.fechaCreacion,
                c.nombreAuditor
            }).ToList();

            grdMatrices.DataSource = cabecera;
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

        private void button1_Click(object sender, EventArgs e)
        {
            estableColor("Matriz");
            obtenerMatrices();
            tabContenedorPrincipal.SelectedTab = tabContenedorPrincipal.TabPages[4];
        }

        private void gridActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CrearImpacto crearImpacto = new CrearImpacto();
            //crearImpacto.Show();
        }

        private void btAgregarMatriz_Click(object sender, EventArgs e)
        {
            AgregarMatriz agregar = new AgregarMatriz();
            agregar.Show();
        }

        private void grdMatrices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoMatriz = int.Parse(grdMatrices.Rows[e.RowIndex].Cells[0].Value.ToString());
            matriz mtr = new matriz();
            mtr.codigoMatriz = codigoMatriz.ToString();
            mtr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            crearprobabilidad crear = new crearprobabilidad();
            crear.Show();
        }

        private void btModificarMatriz_Click(object sender, EventArgs e)
        {
            modificarMatriz modificar = new modificarMatriz();
            modificar.codigoMatriz = codigoMatriz;
            modificar.Show();            
        }

        private void grdMatrices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoMatriz = int.Parse(grdMatrices.Rows[e.RowIndex].Cells[0].Value.ToString());            
        }

        private void txtBuscarActivo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btEliminarMatriz_Click(object sender, EventArgs e)
        {
            eliminarMatriz eliminar = new eliminarMatriz();
            eliminar.codigoMatriz = codigoMatriz;
            eliminar.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int codigoPosibilidad = int.Parse(grdPosibilidades.Rows[grdPosibilidades.CurrentRow.Index].Cells[0].Value.ToString());
            actualizarprobabilidad actualizar = new actualizarprobabilidad();
            actualizar.codigoPosibilidad = codigoPosibilidad;
            actualizar.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigoPosibilidad = int.Parse(impactGrid.Rows[impactGrid.CurrentRow.Index].Cells[0].Value.ToString());
            modificarImpacto modificar = new modificarImpacto();
            modificar.codigoPosibilidad = codigoPosibilidad;
            modificar.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int codigoPosibilidad = int.Parse(grdPosibilidades.Rows[grdPosibilidades.CurrentRow.Index].Cells[0].Value.ToString());
            eliminarprobabilidad eliminar = new eliminarprobabilidad();
            eliminar.codigoPosibilidad = codigoPosibilidad;
            eliminar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigoPosibilidad = int.Parse(impactGrid.Rows[impactGrid.CurrentRow.Index].Cells[0].Value.ToString());
            eliminarImpacto eliminar = new eliminarImpacto();
            eliminar.codigoPosibilidad = codigoPosibilidad;
            eliminar.Show();
        }
    }
}
