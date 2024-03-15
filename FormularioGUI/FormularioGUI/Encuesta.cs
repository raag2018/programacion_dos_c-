using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioGUI
{
    public partial class Encuesta : Form
    {
        public Encuesta()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            if (chkJs.Checked){
                resultado += chkJs.Text+ ", ";
            }
            if (chkHtml.Checked){
                resultado += chkHtml.Text + ", ";
            }
            if (chkCss.Checked){
                resultado += chkCss.Text;
            }
            if (rdbPresencial.Checked){
                resultado += " ::::: " + rdbPresencial.Text + " ::::: ";
            }else{
                resultado += " ::::: " + rdbVirtual.Text + " ::::: ";
            }
            txtResultado.Text = resultado;
        }
    }
}
