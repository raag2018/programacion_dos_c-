using Entidades;
using Negocio;
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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }
        #region "Metodos"
        int nEstado = 0;
        int nCodigo = 0;
        private void FormatoCategoria() {
            dgvCategoria.Columns[0].Width = 80;
            dgvCategoria.Columns[1].Width = 300;
            dgvCategoria.Columns[0].HeaderText = "CODIGO";
            dgvCategoria.Columns[1].HeaderText = "CATEGORIA";
        }
        private void estado(bool estado){
            gbCategoria.Enabled = estado;
            gbBotonesPrincipales.Enabled = !estado;
            flpCategoria.Enabled = !estado;
        }
        private void ListadoCategoria(string cTexto) {
            Negocio_Categoria negocio_Categoria = new Negocio_Categoria();
            dgvCategoria.DataSource = negocio_Categoria.ListadoCategoria(cTexto);
            this.FormatoCategoria();
        }
        private void MostrarMensaje(string titulo, string mensaje, string icono){
            MessageBox.Show(
                   mensaje,
                   titulo,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }
        #endregion
        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Categorias_Load(object sender, EventArgs e) {
            this.ListadoCategoria("%");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e){
            if(string.IsNullOrEmpty(txtCategoria.Text)){
                MessageBox.Show(
                    "Debe ingresar la descripcion de la categoria",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }else{
                string respuesta = "";
                Entidad_Categoria categoria = new Entidad_Categoria();
                categoria.id_ca = nCodigo;
                categoria.descripcion_ca = txtCategoria.Text.Trim();
                respuesta = Negocio_Categoria.Guardar_ca(nEstado, categoria);
                if (respuesta.Equals("OK")){
                    this.ListadoCategoria("%");
                    txtCategoria.Text = "";
                    nEstado = 0;
                    nCodigo = 0;
                    estado(false);
                    MessageBox.Show(
                   "Registro guardado exitosamente",
                   "Mensaje del sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(
                         respuesta,
                         "Mensaje del sistema",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }
            lblEstado.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Nueva Categoria";
            txtCategoria.Text = "";
            nEstado = 1;
            estado(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e){
            this.ListadoCategoria(txtBuscar.Text.Trim());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "";
            txtCategoria.Text = "";
            estado(false);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Actualizando Categoria";
            nEstado = 2;
            estado(true);
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoria.Text = dgvCategoria.CurrentRow.Cells["descripcion_ca"].Value.ToString();
            nCodigo = Convert.ToInt32(dgvCategoria.CurrentRow.Cells["id_ca"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            string respuesta = "";
            DialogResult dialogResult = MessageBox.Show(
                "Estas de seguro de eliminar este registro",
                "Pregunta del sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop);
            if (dialogResult == DialogResult.Yes){
                respuesta = Negocio_Categoria.Eliminar_ca(nCodigo);
                if (respuesta.Equals("OK")){
                    ListadoCategoria("%");
                    MessageBox.Show(
                        "Registro Eliminado",
                        "Mensaje Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    txtCategoria.Text = "";
                    nEstado = 0;
                    nCodigo = 0;
                }
            }
        }
    }
}
