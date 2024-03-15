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
    public partial class MiPrimerFormulario : Form
    {
        //estado del registro
        int nEstado = 0;
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        private void MiPrimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e){
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            nEstado = 1;//para registro nuevo
            gbxArticulo.Enabled = true;
            grbBotonesPrincipales.Enabled = false;
            lsbArticulo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e){
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            gbxArticulo.Enabled = false;
            txtCodigo.Enabled = true;
            grbBotonesPrincipales.Enabled = true;
            nEstado = 0;
            lsbArticulo.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e){
            string registro = "";
            registro += txtCodigo.Text;
            registro += "," + txtDescripcion.Text;
            if(nEstado == 1){
                lsbArticulo.Items.Add(registro);
                MessageBox.Show("Registro agregado exitosamente");
            }else if(nEstado == 2){
                int elemento = lsbArticulo.SelectedIndex;
                lsbArticulo.Items.Remove(lsbArticulo.SelectedItem);
                lsbArticulo.Items.Insert(elemento, registro);
                MessageBox.Show("Registro actualizado exitosamente");
            }
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            gbxArticulo.Enabled = false;
            grbBotonesPrincipales.Enabled = true;
            lsbArticulo.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            lsbArticulo.Items.Remove(lsbArticulo.SelectedItem);
            MessageBox.Show("Registro eliminado exitosamente");
        }

        private void lsbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e){
            nEstado = 2;
            gbxArticulo.Enabled = true;
            grbBotonesPrincipales.Enabled = false;
            lsbArticulo.Enabled = false;
        }

        private void lsbArticulo_Click(object sender, EventArgs e){
            string textoSeleccionado = lsbArticulo.SelectedItem.ToString();
            string[] datos = textoSeleccionado.Split(',');
            txtCodigo.Text = datos[0];
            txtDescripcion.Text = datos[1];
            txtCodigo.Enabled = false;
        }

       
    }
}
