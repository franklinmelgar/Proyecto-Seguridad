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
    public partial class detalleAmenaza : Form
    {
        public int codigoAmenza;
        public int codigoAnalisisRiesgo;
        Gestion_RiesgosEntities DB = new Gestion_RiesgosEntities();
        public detalleAmenaza()
        {
            InitializeComponent();
        }

        private void obtenerAceptacion()
        {
            List<configuracionRiesgo> listadoConfiguracion = new List<configuracionRiesgo>();
            listadoConfiguracion = DB.configuracionRiesgoes.ToList();

            cmbAceptacion.DataSource = listadoConfiguracion;
            cmbAceptacion.DisplayMember = "descripcionAccionRiesgo";
            cmbAceptacion.ValueMember = "codigoAccionRiesgo";
        }

        private void obtenerInformacionAmenaza()
        {

            detalleAnalisisRiesgo detalle = DB.detalleAnalisisRiesgoes.Where(d => d.codigoAnalisisRiesgo == codigoAnalisisRiesgo && d.codigoCategoriaAmenza == codigoAmenza ).FirstOrDefault();
            categoriasAmenaza amenaza = DB.categoriasAmenazas.Where(c => c.codigoCategoria.Equals(codigoAmenza)).FirstOrDefault();
            impactoRiesgo impacto = DB.impactoRiesgoes.Where(i => i.codigoImpacto == detalle.codigoImpacto).FirstOrDefault();
            posibilidadRiesgo posibilidad = DB.posibilidadRiesgoes.Where(p => p.codigoPosibilidad == detalle.codigoPosibilidad).FirstOrDefault();

            txtAmenaza.Text = amenaza.nombreCategoriaRiesgo;
            txtDescripcionAmenaza.Text = amenaza.descripcionCategoriaRiesgo;
            txtPosibilidad.Text = posibilidad.nivelPosibilidad;
            txtImpacto.Text = impacto.nivelImpacto;
            cmbAceptacion.SelectedValue = detalle.codigoAccionRiesgo;
          
        }

        private void detalleAmenaza_Load(object sender, EventArgs e)
        {
            obtenerAceptacion();
            obtenerInformacionAmenaza();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            detalleAnalisisRiesgo detalle = DB.detalleAnalisisRiesgoes.Where(d => d.codigoAnalisisRiesgo == codigoAnalisisRiesgo && d.codigoCategoriaAmenza == codigoAmenza).FirstOrDefault();
            detalle.codigoAccionRiesgo = int.Parse(cmbAceptacion.SelectedValue.ToString());
            DB.SaveChanges();
            this.Close();

        }
    }
}
