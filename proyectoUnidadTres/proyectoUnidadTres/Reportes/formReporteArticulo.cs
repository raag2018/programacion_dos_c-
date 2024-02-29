using Microsoft.Reporting.WinForms;
using proyectoUnidadTres.Logica;
using Simple.Data.Ado.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoUnidadTres.Reportes
{
    public partial class formReporteArticulo : Form
    {

        #region "Metodos"
        private void ListadoArticulos(){
            SqlConnection sqlCon = Conexion.getConexion().CrearConexion();
            try{
                string sentencia = "SELECT a.codigo_ar, a.descripcion_ar, a.marca_ar, c.descripcion_ca, b.descripcion_me " +
                                   "FROM tb_articulos a " +
                                   "INNER JOIN tb_categoria c ON c.codigo_ca = a.codigo_ca " +
                                   "INNER JOIN tb_medida b ON b.codigo_me = a.codigo_me; ";
                SqlDataAdapter resultado = new SqlDataAdapter(sentencia, sqlCon);
                DataSet fuente = new DataSet();
                resultado.Fill(fuente);
                ReportDataSource source = new ReportDataSource("DataSet1", fuente.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.LocalReport.ReportPath = "ReporteArticulo.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
            } catch (Exception ex) { 
                throw ex; 
            }finally{
                if(sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        #endregion
        public formReporteArticulo()
        {
            InitializeComponent();
        }

        private void formReporteArticulo_Load(object sender, EventArgs e)
        {
            this.ListadoArticulos();
            //this.reportViewer1.RefreshReport();
        }
    }
}
