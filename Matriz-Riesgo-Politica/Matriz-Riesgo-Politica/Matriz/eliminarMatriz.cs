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
    public partial class eliminarMatriz : Form
    {
        public int codigoMatriz;
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        public eliminarMatriz()
        {
            InitializeComponent();
        }

        private void eliminarMatriz_Load(object sender, EventArgs e)
        {
            obtenerMatriz();
        }

        private void obtenerMatriz()
        {
            cabeceraAnalisisRiesgo cabecera = DB.cabeceraAnalisisRiesgoes.Where(C => C.codigoAnalisisRiesgo.Equals(codigoMatriz)).FirstOrDefault();
            Activo activo = DB.Activos.Where(a => a.codigoActivo == cabecera.codigoActivo).FirstOrDefault();

            txtActivo.Text = activo.nombreActivo;
            txtFechaCreacion.Text = cabecera.fechaCreacion.ToString();
            txtNombreResponsable.Text = cabecera.nombreAuditor;
            txtxNombreAprobador.Text = cabecera.nombreAprobador;
            txtConfidencialidad.Text = cabecera.nivelConfidencialidad;
            txtObjetivos.Text = cabecera.objetivosAnalisisRiesgo;
            txtAlcance.Text = cabecera.alcanceAnalisisRiesgo;

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta seguro de eliminar el activo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<detalleAnalisisRiesgo> detalle = DB.detalleAnalisisRiesgoes.Where(d => d.codigoAnalisisRiesgo == codigoMatriz).ToList();

                if (detalle != null)
                {

                    foreach (detalleAnalisisRiesgo item in detalle)
                    {
                        DB.detalleAnalisisRiesgoes.Remove(item);
                        DB.SaveChanges();
                    }

                }

                cabeceraAnalisisRiesgo cabecera = DB.cabeceraAnalisisRiesgoes.Where(c => c.codigoAnalisisRiesgo == codigoMatriz).FirstOrDefault();
                if (cabecera != null)
                {
                    DB.cabeceraAnalisisRiesgoes.Remove(cabecera);
                    DB.SaveChanges();
                }

                MessageBox.Show("Matriz Eliminada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            

        }
    }
}
