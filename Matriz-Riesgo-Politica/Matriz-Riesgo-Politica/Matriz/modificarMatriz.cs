using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Riesgo_Politica.Matriz
{
    public partial class modificarMatriz : Form
    {
        public int codigoMatriz;
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();

        public modificarMatriz()
        {
            InitializeComponent();
        }

        private void modificarMatriz_Load(object sender, EventArgs e)
        {
            obtenerActivos();
            obtenerMatriz();
        }

        private void obtenerActivos()
        {
            var activos = DB.Activos.Select(c => new
            {
                c.codigoActivo,
                c.nombreActivo,
                c.costoActivo
            }).ToList();

            cmbActivo.DataSource = activos;
            cmbActivo.DisplayMember = "nombreActivo";
            cmbActivo.ValueMember = "codigoActivo";
        }

        private void obtenerMatriz()
        {
            cabeceraAnalisisRiesgo cabecera;
            cabecera = DB.cabeceraAnalisisRiesgoes.Where(C => C.codigoAnalisisRiesgo.Equals(codigoMatriz)).FirstOrDefault();

            cmbActivo.SelectedValue = cabecera.codigoActivo; 
            txtFechaCreacion.Text = cabecera.fechaCreacion.ToString();
            txtNombreResponsable.Text = cabecera.nombreAuditor;
            txtxNombreAprobador.Text = cabecera.nombreAprobador;
            cmbNivelConfidencialidad.Text = cabecera.nivelConfidencialidad;
            txtObjetivos.Text = cabecera.objetivosAnalisisRiesgo;
            txtAlcance.Text = cabecera.alcanceAnalisisRiesgo;


        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            cabeceraAnalisisRiesgo cabecera;
            cabecera = DB.cabeceraAnalisisRiesgoes.Where(C => C.codigoAnalisisRiesgo.Equals(codigoMatriz)).FirstOrDefault();

            cabecera.codigoActivo = int.Parse(cmbActivo.SelectedValue.ToString());
            cabecera.fechaCreacion = txtFechaCreacion.Value;
            cabecera.nombreAuditor = txtNombreResponsable.Text;
            cabecera.nombreAprobador = txtxNombreAprobador.Text;
            cabecera.nivelConfidencialidad = cmbNivelConfidencialidad.Text;
            cabecera.objetivosAnalisisRiesgo = txtObjetivos.Text;
            cabecera.alcanceAnalisisRiesgo = txtAlcance.Text;

            DB.SaveChanges();

            MessageBox.Show("Datos actualizados de matriz", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
