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
    public partial class matriz : Form
    {
        public string codigoMatriz;
        Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

        public void Parametros(string Amenaza, int posibilidad, int impacto)
        {
            evaluarParametros(Amenaza, posibilidad, impacto);
        }

        private void evaluarParametros(string Amenaza, int posibilidad, int impacto)
        {
            string nombreControl;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is ListBox)
                {
                    nombreControl = control.Name;
                    if (nombreControl.Equals("lst" + posibilidad.ToString() + impacto.ToString()))
                    {
                        ListBox lst = control as ListBox;
                        lst.Items.Add(Amenaza);
                    }
                }
            }
        }

        public matriz()
        {
            InitializeComponent();
        }

        private void matriz_Load(object sender, EventArgs e)
        {
            obtenerAmenazas(int.Parse(codigoMatriz));
        }

        private void obtenerAmenazas(int codigoMatriz)
        {
            var amenazas = BD.detalleAnalisisRiesgoes.Where(s => s.codigoAnalisisRiesgo.Equals(codigoMatriz)).Join(BD.categoriasAmenazas, 
                x => x.codigoCategoriaAmenza,
                c => c.codigoCategoria,
                (x,c) =>
                new {
                     c.nombreCategoriaRiesgo,
                     x.codigoImpacto,
                     x.codigoPosibilidad
                }).ToList();

            foreach(var amenaza in amenazas)
            {
                evaluarParametros(amenaza.nombreCategoriaRiesgo, (int)amenaza.codigoPosibilidad, (int)amenaza.codigoImpacto);
            }           
        }


        private void btAgregarAmenaza_Click(object sender, EventArgs e)
        {
            agregarAmenaza agregar = new agregarAmenaza();
            AddOwnedForm(agregar);
            agregar.Show();
        }
    }
}
