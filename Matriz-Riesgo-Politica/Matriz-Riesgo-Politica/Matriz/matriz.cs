using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Matriz_Riesgo_Politica.Matriz
{
    public partial class matriz : Form
    {
        public string codigoMatriz;
        Gestion_RiesgosEntities BD = new Gestion_RiesgosEntities();

        public void Parametros(string Codigo, string Amenaza, int posibilidad, int impacto)
        {
            evaluarParametros(Codigo, Amenaza, posibilidad, impacto);
        }

        private void evaluarParametros(string codigo, string Amenaza, int posibilidad, int impacto)
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
                        lst.Items.Add(codigo + "-" + Amenaza);
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
                     c.codigoCategoria,
                     c.nombreCategoriaRiesgo,
                     x.codigoImpacto,
                     x.codigoPosibilidad
                }).ToList();

            foreach(var amenaza in amenazas)
            {
                evaluarParametros(amenaza.codigoCategoria.ToString(),  amenaza.nombreCategoriaRiesgo, (int)amenaza.codigoPosibilidad, (int)amenaza.codigoImpacto);
            }           
        }


        private void btAgregarAmenaza_Click(object sender, EventArgs e)
        {
            agregarAmenaza agregar = new agregarAmenaza();
            AddOwnedForm(agregar);
            agregar.Show();
        }

        private void btImprimirPoliticas_Click(object sender, EventArgs e)
        {
            string direccion = "";
            saveFileDialogPoliticas.InitialDirectory = @"C:\";
            saveFileDialogPoliticas.Title = "Guardar PDF de politicas";
            saveFileDialogPoliticas.DefaultExt = "pdf";
            saveFileDialogPoliticas.Filter = "Pdf files (*.pdf)|*.pdf";
            saveFileDialogPoliticas.FilterIndex = 2;
            saveFileDialogPoliticas.RestoreDirectory = true;
            if (saveFileDialogPoliticas.ShowDialog() == DialogResult.OK)
            {
                direccion = saveFileDialogPoliticas.FileName;

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(direccion, FileMode.Create));
                doc.Open();

                Paragraph title = new Paragraph();
                title.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 18f, BaseColor.BLACK);
                title.Alignment = Element.ALIGN_CENTER;
                title.Add("Politicas de seguridad");               
                doc.Add(title);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                cabeceraAnalisisRiesgo infoCabecera = obtenerCabecera(int.Parse(codigoMatriz));

                Paragraph seccion1 = new Paragraph();
                seccion1.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14f, BaseColor.BLACK);
                seccion1.Add("1. Datos de politicas");
                doc.Add(seccion1);
                doc.Add(Chunk.NEWLINE);
                
                doc.Add(new Paragraph("Codigo de matriz: " + infoCabecera.codigoAnalisisRiesgo));
                doc.Add(new Paragraph("Version: 1.1"));
                doc.Add(new Paragraph("Fecha de creacion: " + DateTime.Parse(infoCabecera.fechaCreacion.ToString()).ToShortDateString()));
                doc.Add(new Paragraph("Nombre del responsable: " + infoCabecera.nombreAuditor));
                doc.Add(new Paragraph("Nombre del aprobador: " + infoCabecera.nombreAprobador));
                doc.Add(new Paragraph("Nivel de confidencialidad: " + infoCabecera.nivelConfidencialidad));
                doc.Add(Chunk.NEWLINE);


                //************************************************************************************************

                Paragraph seccion2 = new Paragraph();
                seccion2.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14f, BaseColor.BLACK);
                seccion2.Add("2. Objetivos");
                doc.Add(seccion2);
                doc.Add(Chunk.NEWLINE);

                doc.Add(new Paragraph(infoCabecera.objetivosAnalisisRiesgo));

                doc.Add(Chunk.NEWLINE);

                //************************************************************************************************

                Paragraph seccion3 = new Paragraph();
                seccion3.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14f, BaseColor.BLACK);
                seccion3.Add("3. Alcance");
                doc.Add(seccion3);
                doc.Add(Chunk.NEWLINE);

                doc.Add(new Paragraph(infoCabecera.alcanceAnalisisRiesgo));

                doc.Add(Chunk.NEWLINE);

                //************************************************************************************************

                Paragraph seccion4 = new Paragraph();
                seccion4.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14f, BaseColor.BLACK);
                seccion4.Add("4. Detalle de politicas");
                doc.Add(seccion4);
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("A continuacion se detallaran todos las politicas aplicables a partir de las amenazas descritas y seleccionadas en la matriz de riesgos: "));
                doc.Add(Chunk.NEWLINE);

                //Imprimir Listado
                obtenerAmenazas(doc);




                doc.Close();

            }
        }

        private cabeceraAnalisisRiesgo obtenerCabecera (int codigoMatriz)
        {
            cabeceraAnalisisRiesgo cabecera = BD.cabeceraAnalisisRiesgoes.Where(c => c.codigoAnalisisRiesgo.Equals(codigoMatriz)).FirstOrDefault();

            return cabecera;
        }

        private void obtenerAmenazas(Document doc)
        {
            string nombreControl;
            int codigo;
            string[] amenaza;
            Paragraph enunciado = new Paragraph();
            Paragraph secciones = new Paragraph();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is ListBox)
                {
                    ListBox lst = control as ListBox;
                    foreach(string item in lst.Items)
                    {
                        amenaza = item.Split(new char[] {'-'});
                        codigo = int.Parse(amenaza[0]);
                        enunciado.IndentationLeft = 20;
                        enunciado.Add(obtenerEnunciado(codigo));
                        doc.Add(enunciado);
                        doc.Add(Chunk.NEWLINE);

                        //obtener seccion politica amenaza
                        secciones.IndentationLeft = 25;
                        secciones.Add(obtenerSeccionesPolitica(codigo));
                        doc.Add(secciones);
                        doc.Add(Chunk.NEWLINE);
                    }                   
                }
            }
        }

        private string obtenerEnunciado(int codigoCategoria)
        {

            enunciadoPoliticaAmenaza enunciado = BD.enunciadoPoliticaAmenazas.Where(E => E.codigoCategoria.Equals(codigoCategoria)).FirstOrDefault();

            return enunciado.descripcionEnunciado;

        }

        private List obtenerSeccionesPolitica(int codigoCategoria)
        {
            List listadoSecciones = new List(true);


            var secciones = BD.seccionPoliticaAmenazas.Join(BD.enunciadoPoliticaAmenazas,
                    e => e.codigoEnunciadoPolitica,
                    s => s.codigoEnunciadoPolitica,
                    (e, s) =>
                    new
                    {
                        e.descripcionSeccion,
                        s.codigoCategoria
                    }

                ).Where(s => s.codigoCategoria.Equals(codigoCategoria)).ToList();


            ListItem item; 

            foreach (var seccion in secciones)
            {
                item = new ListItem(seccion.descripcionSeccion);
                listadoSecciones.Add(item);
            }


            return listadoSecciones;

        }


    }
}
