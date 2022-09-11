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
using System.Data.Entity.Infrastructure;

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
            agregar.codigoMatriz = int.Parse(codigoMatriz);
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

                MessageBox.Show("Se guardo correctamente el archivo de politica", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private cabeceraAnalisisRiesgo obtenerCabecera (int codigoMatriz)
        {
            cabeceraAnalisisRiesgo cabecera = BD.cabeceraAnalisisRiesgoes.Where(c => c.codigoAnalisisRiesgo.Equals(codigoMatriz)).FirstOrDefault();

            return cabecera;
        }

        private detalleAnalisisRiesgo GetDataDetail(int codigoMatriz)
        {
            detalleAnalisisRiesgo detailData = BD.detalleAnalisisRiesgoes.Where(c => c.codigoAnalisisRiesgo.Equals(codigoMatriz)).FirstOrDefault();

            return detailData;
        }

        private void obtenerAmenazas(Document doc)
        {
            string nombreControl;
            int codigo;
            string[] amenaza;           
            List textoEnunciado;
            List textoSecciones;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is ListBox)
                {
                    ListBox lst = control as ListBox;
                    foreach(string item in lst.Items)
                    {
                        Paragraph enunciado = new Paragraph();
                        Paragraph secciones = new Paragraph();

                        amenaza = item.Split(new char[] {'-'});
                        codigo = int.Parse(amenaza[0]);
                        enunciado.IndentationLeft = 10;
                        

                        textoEnunciado = obtenerEnunciado(codigo);

                        if (textoEnunciado != null)
                        {
                            
                            enunciado.Add(textoEnunciado);
                            doc.Add(enunciado);
                            doc.Add(Chunk.NEWLINE);

                            //obtener seccion politica amenaza

                            textoSecciones = obtenerSeccionesPolitica(codigo);

                            if (textoSecciones != null)
                            {
                                secciones.IndentationLeft = 25;
                                secciones.Add(textoSecciones);
                                doc.Add(secciones);
                                doc.Add(Chunk.NEWLINE);
                            }

                            
                        }

                        
                    }                   
                }
            }
        }

        private List obtenerEnunciado(int codigoCategoria)
        {
            List listaPolitica = new List(List.UNORDERED, false, 15f);
            listaPolitica.SetListSymbol("\u2022");
            ListItem item;

            enunciadoPoliticaAmenaza enunciado = BD.enunciadoPoliticaAmenazas.Where(E => E.codigoCategoria.Equals(codigoCategoria)).FirstOrDefault();

            if (enunciado == null)
            {
                return null;
            }

            item = new ListItem(enunciado.descripcionEnunciado);
            listaPolitica.Add(item);

            return listaPolitica;

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


            if (secciones == null)
            {
                return null;
            }

            ListItem item; 

            foreach (var seccion in secciones)
            {
                item = new ListItem(seccion.descripcionSeccion);
                listadoSecciones.Add(item);
            }


            return listadoSecciones;

        }

        private void lst11_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst11.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();

        }

        private void lst12_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst12.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst13_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst13.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst14_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst14.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst15_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst15.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst21_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst21.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst22_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst22.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst23_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst23.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst24_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst24.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst25_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst25.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst31_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst31.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst32_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst32.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst33_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst33.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst34_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst34.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst35_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst35.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst41_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst41.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst42_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst42.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst43_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst43.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst44_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst44.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst45_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst45.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst51_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst51.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst52_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst52.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst53_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst53.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst54_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst54.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void lst55_DoubleClick(object sender, EventArgs e)
        {
            string[] texto = lst55.SelectedItem.ToString().Split(new char[] { '-' });
            int codigoAmenaza = int.Parse(texto[0]);
            detalleAmenaza detalle = new detalleAmenaza();
            detalle.codigoAmenza = codigoAmenaza;
            detalle.codigoAnalisisRiesgo = int.Parse(codigoMatriz);
            detalle.Show();
        }

        private void btImprimirPlan_Click(object sender, EventArgs e)
        {
            string direccion = "";
            saveFileDialogPoliticas.InitialDirectory = @"C:\";
            saveFileDialogPoliticas.Title = "Guardar PDF de plan de seguridad";
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
                title.Add("Plan de seguridad");
                doc.Add(title);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                cabeceraAnalisisRiesgo infoCabecera = obtenerCabecera(int.Parse(codigoMatriz));

                Paragraph seccion1 = new Paragraph();
                seccion1.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14f, BaseColor.BLACK);
                seccion1.Add("1. Datos del plan de seguridad");
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
                seccion4.Add("4. Detalle plan de seguridad");
                doc.Add(seccion4);
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("A continuacion se detallaran todos las acciones aplicables a partir de las amenazas descritas y seleccionadas en la matriz de riesgos: "));
                doc.Add(Chunk.NEWLINE);

                Paragraph seccion5 = new Paragraph();
                seccion5.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12f, BaseColor.BLACK);
                seccion5.Add("Evaluacion de las amenazas");
                seccion5.IndentationLeft = 10;
                doc.Add(seccion5);
                doc.Add(Chunk.NEWLINE);

                //Imprimir Listado
                ObtenerAcciones(doc);

                doc.Close();

                MessageBox.Show("Se guardo correctamente el archivo de plan", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ObtenerAcciones(Document doc)
        {
            int matriz = int.Parse(codigoMatriz);
            string nivelRiesgo;
            var detalle = BD.detalleAnalisisRiesgoes.Where(d => d.codigoAnalisisRiesgo == matriz).ToList();

            foreach(var item in detalle)
            {
                categoriasAmenaza amenaza = BD.categoriasAmenazas.Where(c => c.codigoCategoria == item.codigoCategoriaAmenza).FirstOrDefault();
                impactoRiesgo impacto = BD.impactoRiesgoes.Where(i => i.codigoImpacto == item.codigoImpacto).FirstOrDefault();
                posibilidadRiesgo posibilidad = BD.posibilidadRiesgoes.Where(p => p.codigoPosibilidad == item.codigoPosibilidad).FirstOrDefault();
                configuracionRiesgo estrategia = BD.configuracionRiesgoes.Where(ca => ca.codigoAccionRiesgo == item.codigoAccionRiesgo).FirstOrDefault();

                int valorRiesgo = (int)(posibilidad.puntajePosibilidad * impacto.puntajeImpacto);

                List<AccionRiesgo> acciones = BD.AccionRiesgoes.Where(a => a.codigoCategoria == item.codigoCategoriaAmenza && a.codigoAccionRiesgo == item.codigoAccionRiesgo && a.nivelRiesgoMinimo >= valorRiesgo && a.nivelRiesgoMayor <= valorRiesgo).ToList();

                Paragraph parrafoestrategia = new Paragraph();
                parrafoestrategia.Add("Estrategia de respuesta: " + estrategia.descripcionAccionRiesgo);
                parrafoestrategia.IndentationLeft = 20;
                doc.Add(parrafoestrategia);
                //doc.Add(Chunk.NEWLINE);

                Paragraph parrafoAmenaza = new Paragraph();
                parrafoAmenaza.Add("Amenza: " + amenaza.nombreCategoriaRiesgo);
                parrafoAmenaza.IndentationLeft = 20;
                doc.Add(parrafoAmenaza);
                //doc.Add(Chunk.NEWLINE);

                Paragraph parrafoPosibilidad = new Paragraph();
                parrafoPosibilidad.Add("Posibilidad: " + posibilidad.nivelPosibilidad);
                parrafoPosibilidad.IndentationLeft = 20;
                doc.Add(parrafoPosibilidad);
                //doc.Add(Chunk.NEWLINE);

                Paragraph parrafoImpacto = new Paragraph();
                parrafoImpacto.Add("Impacto: " + impacto.nivelImpacto);
                parrafoImpacto.IndentationLeft = 20;
                doc.Add(parrafoImpacto);
                //doc.Add(Chunk.NEWLINE);                

                if(valorRiesgo == 1)
                {
                    nivelRiesgo = "Muy Bajo";
                }else if (valorRiesgo >= 2 && valorRiesgo <= 4)
                {
                    nivelRiesgo = "Bajo";
                }else if (valorRiesgo >= 5 && valorRiesgo <= 9)
                {
                    nivelRiesgo = "Medio";
                }else if (valorRiesgo >= 10 && valorRiesgo <= 12)
                {
                    nivelRiesgo = "Alto";
                }else
                {
                    nivelRiesgo = "Muy Alto";
                }

                Paragraph parrafoRiesgo = new Paragraph();
                parrafoRiesgo.Add("Nivel de Riesgo: " + nivelRiesgo);
                parrafoRiesgo.IndentationLeft = 20;
                doc.Add(parrafoRiesgo);

                //doc.Add(Chunk.NEWLINE);

                //Acciones a imprimir
                Paragraph parrafo = new Paragraph();
                parrafo.Add("Listado de actividades:");
                parrafo.IndentationLeft = 20;
                doc.Add(parrafo);

                List listaAcciones = new List(List.UNORDERED, false, 15f);
                listaAcciones.SetListSymbol("\u2022");
                
                foreach (AccionRiesgo accion in acciones)
                {
                    ListItem itemAccion = new ListItem(accion.descripcionAccion);
                    listaAcciones.Add(itemAccion);
                }

                Paragraph parrafoAcciones = new Paragraph();
                parrafoAcciones.Add(listaAcciones);
                parrafoAcciones.IndentationLeft = 25;
                doc.Add(parrafoAcciones);
                doc.Add(Chunk.NEWLINE);

            }
        }

        private void btImprimirMatriz_Click(object sender, EventArgs e)
        {
            
            string direccion = "";
            saveFileDialogPoliticas.InitialDirectory = @"C:\";
            saveFileDialogPoliticas.Title = "Guardar PDF de matriz";
            saveFileDialogPoliticas.DefaultExt = "pdf";
            saveFileDialogPoliticas.Filter = "Pdf files (*.pdf)|*.pdf";
            saveFileDialogPoliticas.FilterIndex = 2;
            saveFileDialogPoliticas.RestoreDirectory = true;
            if (saveFileDialogPoliticas.ShowDialog() == DialogResult.OK)
            {
                direccion = saveFileDialogPoliticas.FileName;

                Document doc = new Document(iTextSharp.text.PageSize.A4.Rotate());
                PdfWriter.GetInstance(doc, new FileStream(direccion, FileMode.Create));
                doc.Open();

                PdfPTable tableColumns = new PdfPTable(6);

                var dataDetail = GetDataDetail(int.Parse(codigoMatriz));
                // amenzaDetail = dataDetail.

               // var amenazas = BD.categoriasAmenazas.Where(e=> );

                tableColumns.AddCell("");
                tableColumns.AddCell("Insignificante");
                tableColumns.AddCell("Menor");
                tableColumns.AddCell("Moderado");
                tableColumns.AddCell("Mayor");
                tableColumns.AddCell("Severo");

                tableColumns.AddCell("Row 2, Col 1");
                tableColumns.AddCell("Row 2, Col 2");
                tableColumns.AddCell("Row 2, Col 3");
                tableColumns.AddCell("Row 2, Col 4");
                tableColumns.AddCell("Row 2, Col 5");
                tableColumns.AddCell("Row 2, Col 6");

                tableColumns.AddCell("Row 3, Col 1");
                tableColumns.AddCell("Row 3, Col 2");
                tableColumns.AddCell("Row 3, Col 3");
                tableColumns.AddCell("Row 3, Col 4");
                tableColumns.AddCell("Row 3, Col 5");
                tableColumns.AddCell("Row 3, Col 6");

                tableColumns.AddCell("Row 4, Col 1");
                tableColumns.AddCell("Row 4, Col 2");
                tableColumns.AddCell("Row 4, Col 3");
                tableColumns.AddCell("Row 4, Col 4");
                tableColumns.AddCell("Row 4, Col 5");
                tableColumns.AddCell("Row 4, Col 6");

                tableColumns.AddCell("Row 5, Col 1");
                tableColumns.AddCell("Row 5, Col 2");
                tableColumns.AddCell("Row 5, Col 3");
                tableColumns.AddCell("Row 5, Col 4");
                tableColumns.AddCell("Row 5, Col 5");
                tableColumns.AddCell("Row 5, Col 6");

                tableColumns.AddCell("Row 6, Col 1");
                tableColumns.AddCell("Row 6, Col 2");
                tableColumns.AddCell("Row 6, Col 3");
                tableColumns.AddCell("Row 6, Col 4");
                tableColumns.AddCell("Row 6, Col 5");
                tableColumns.AddCell("Row 6, Col 6");

                //Imprimir Listado
                obtenerAmenazas(doc);

                doc.Add(tableColumns);

                doc.Close();

                MessageBox.Show("Se guardo correctamente el archivo de politica", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
