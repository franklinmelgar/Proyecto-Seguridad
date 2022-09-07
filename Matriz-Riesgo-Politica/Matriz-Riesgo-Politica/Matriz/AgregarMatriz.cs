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
    public partial class AgregarMatriz : Form
    {
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        public AgregarMatriz()
        {
            InitializeComponent();
        }

        private void AgregarMatriz_Load(object sender, EventArgs e)
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

            cmbActivo.DataSource = activos;
            cmbActivo.DisplayMember = "nombreActivo";
            cmbActivo.ValueMember = "codigoActivo";
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            cabeceraAnalisisRiesgo matriz = new cabeceraAnalisisRiesgo();
            matriz.fechaCreacion = txtFechaCreacion.Value;
            matriz.codigoActivo = int.Parse(cmbActivo.SelectedValue.ToString());
            matriz.nombreAuditor = txtNombreResponsable.Text;
            matriz.nombreAprobador = txtxNombreAprobador.Text;
            matriz.nivelConfidencialidad = cmbNivelConfidencialidad.Text;
            matriz.objetivosAnalisisRiesgo = txtObjetivos.Text;
            matriz.alcanceAnalisisRiesgo = txtAlcance.Text;

            DB.cabeceraAnalisisRiesgoes.Add(matriz);
            DB.SaveChanges();

            MessageBox.Show("Matriz creada", "Matriz", MessageBoxButtons.OK);
            this.Close();

        }
    }
}
