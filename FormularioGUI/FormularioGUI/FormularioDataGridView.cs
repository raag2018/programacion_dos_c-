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
    public partial class FormularioDataGridView : Form
    {
        public FormularioDataGridView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e){
            if (txtNombres.Text != "" && txtCorreo.Text != ""){
                dgvDatos.Rows.Add(txtNombres.Text, txtCorreo.Text);
                txtNombres.Text = "";
                txtCorreo.Text = "";
                MessageBox.Show("Datos Guardados");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            DialogResult result;
            result = MessageBox.Show(
                "Desea eliminar este registro", 
                "Aviso del sistem",
                MessageBoxButtons.YesNo
                );
            if ( result == DialogResult.Yes ){
                int nFila = dgvDatos.CurrentRow.Index;
                dgvDatos.Rows.RemoveAt(nFila);
                MessageBox.Show("Registro eliminado exitosamente");
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e){
            txtNombres.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Column1"].Value);
            txtCorreo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Column2"].Value);
        }
    }
}
