using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matriz_Riesgo_Politica;

namespace Matriz_Riesgo_Politica.Matriz
{
    public partial class agregarAmenaza : Form
    {
        Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();
        public int codigoMatriz;
        private string amenaza;
        private int posibilidad;
        private int impacto;
        private string codigo;

        public agregarAmenaza()
        {
            InitializeComponent();
        }

        private void agregarAmenaza_Load(object sender, EventArgs e)
        {
            obtenerAmenazas();
            obtenerPosibilidad();
            obtenerImpacto();
        }

        private void obtenerAmenazas()
        {
            List<categoriasAmenaza> listadoAmenazas = new List<categoriasAmenaza>();
            listadoAmenazas = BD.categoriasAmenazas.ToList();

            cmbAmenaza.DataSource = listadoAmenazas;
            cmbAmenaza.DisplayMember = "nombreCategoriaRiesgo";
            cmbAmenaza.ValueMember = "codigoCategoria";
        }

        private void obtenerPosibilidad()
        {
            List<posibilidadRiesgo> listadoPosibilidad = new List<posibilidadRiesgo>();
            listadoPosibilidad = BD.posibilidadRiesgoes.ToList();

            cmbPosibilidad.DataSource = listadoPosibilidad;
            cmbPosibilidad.DisplayMember = "nivelPosibilidad";
            cmbPosibilidad.ValueMember = "puntajePosibilidad";
        }

        private void obtenerImpacto()
        {
            List<impactoRiesgo> listadoImpacto = new List<impactoRiesgo>();
            listadoImpacto = BD.impactoRiesgoes.ToList();

            cmbImpacto.DataSource = listadoImpacto;
            cmbImpacto.DisplayMember = "nivelImpacto";
            cmbImpacto.ValueMember = "puntajeImpacto";
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            matriz frmMatriz = Owner as matriz;

            if (frmMatriz != null)
            {
                codigo = cmbAmenaza.SelectedValue.ToString();
                amenaza = cmbAmenaza.Text;
                posibilidad = int.Parse(cmbPosibilidad.SelectedValue.ToString());
                impacto = int.Parse(cmbImpacto.SelectedValue.ToString());
                frmMatriz.Parametros(codigo, amenaza, posibilidad, impacto);

                detalleAnalisisRiesgo detalle = new detalleAnalisisRiesgo();
                detalle.codigoAnalisisRiesgo = codigoMatriz;
                detalle.codigoCategoriaAmenza = int.Parse(cmbAmenaza.SelectedValue.ToString());
                detalle.codigoImpacto = int.Parse(cmbImpacto.SelectedValue.ToString());
                detalle.codigoPosibilidad = int.Parse(cmbPosibilidad.SelectedValue.ToString());
                detalle.codigoAccionRiesgo = 1;
                BD.detalleAnalisisRiesgoes.Add(detalle);
                BD.SaveChanges();
                this.Close();
            }
        }
    }
}
