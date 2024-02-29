using proyectoUnidadTres.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoUnidadTres.Model;
namespace proyectoUnidadTres{
    public partial class Frm_Articulos : Form {
        public Frm_Articulos() {
            InitializeComponent();
        }

        #region "Variables"
        int nCodigo_ar = 0;
        int nCodigo_me = 0;
        int nCodigo_ca = 0;
        int nEstadoRegistro = 0;
        #endregion
        #region "Metodos"
        private void Estado_texto(bool lEstado) {
            txtDescripcion.ReadOnly = !lEstado;
            txtMarca.ReadOnly = !lEstado;
        }
        private void Limpiar_texto() {
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtCategoria.Clear();
            txtMedida.Clear();
        }
        private void Estado_botones_proceso(bool lEstado) {
            btn_cancelar.Visible = lEstado;
            btn_guardar.Visible = lEstado;
            btn_buscar_categoria.Visible = lEstado;
            btn_buscar_medida.Visible = lEstado;
            //deshabilitar la seccion de buscar y el datagridview
            btnBuscar.Enabled = !lEstado;
            txtBuscar.Enabled = !lEstado;
            Dgv_Articulos.Enabled = !lEstado;
        }
        private void Estado_botones_principales(bool lEstado) {
            btnAgregar.Enabled = lEstado;
            btn_actualizar.Enabled = lEstado;
            btn_eliminar.Enabled = lEstado;
            btn_reporte.Enabled = lEstado;
            btn_salir.Enabled = lEstado;
        } 
        private void Formato_Articulo(){
            Dgv_Articulos.Columns[0].Width = 90;
            Dgv_Articulos.Columns[0].HeaderText = "CODIGO";
            Dgv_Articulos.Columns[1].Width = 180;
            Dgv_Articulos.Columns[1].HeaderText = "DESCRIPCION";
            Dgv_Articulos.Columns[2].Width = 120;
            Dgv_Articulos.Columns[2].HeaderText = "MARCA";
            Dgv_Articulos.Columns[3].Width = 100;
            Dgv_Articulos.Columns[3].HeaderText = "MEDIDA";
            Dgv_Articulos.Columns[4].Width = 150;
            Dgv_Articulos.Columns[4].HeaderText = "CATEGORIA";
            Dgv_Articulos.Columns[5].Visible = false;
            Dgv_Articulos.Columns[6].Visible = false;
        }
        private void Formato_Medida(){
            dgvMedida.Columns[0].Width = 130;
            dgvMedida.Columns[0].HeaderText = "MEDIDA";
            dgvMedida.Columns[1].Visible = false;
        }
        private void Formato_Categoria()
        {
            dgvCategoria.Columns[0].Width = 130;
            dgvCategoria.Columns[0].HeaderText = "CATEGORIA";
            dgvCategoria.Columns[1].Visible = false;
        }
        private void listadoArticulos(string param){
            DbContextArticulo Datos = new DbContextArticulo();
            Dgv_Articulos.DataSource = Datos.ListadoArticulos(param);
            this.Formato_Articulo();
        }
        private void listadoMedidas(){
            DbContextArticulo Datos = new DbContextArticulo();
            dgvMedida.DataSource = Datos.ListadoMedida();
            this.Formato_Medida();
        }
        private void listadoCategoria(){
            DbContextArticulo Datos = new DbContextArticulo();
            dgvCategoria.DataSource = Datos.ListadoCategoria();
            this.Formato_Categoria();
        }
        private void selecionarItemMedida(){
            if (string.IsNullOrEmpty(Convert.ToString(
                dgvMedida.CurrentRow.Cells["codigo_me"].Value))){
                MessageBox.Show("Seleccione una medida",
                                "Alerta del sistem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }else{
                this.nCodigo_me = Convert.ToInt32(
                dgvMedida.CurrentRow.Cells["codigo_me"].Value);
                this.txtMedida.Text = Convert.ToString(dgvMedida.CurrentRow.Cells["descripcion_me"].Value);
            }
        }
        private void selecionarItemCategoria()
        {
            if (string.IsNullOrEmpty(Convert.ToString(
                dgvCategoria.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("Seleccione una categoria",
                                "Alerta del sistem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_ca = Convert.ToInt32(
                dgvCategoria.CurrentRow.Cells["codigo_ca"].Value);
                this.txtCategoria.Text = Convert.ToString(dgvCategoria.CurrentRow.Cells["descripcion_ca"].Value);
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e){
            this.Estado_texto(true);
            this.Limpiar_texto();
            this.Estado_botones_proceso(true);
            this.Estado_botones_principales(false);
            this.txtDescripcion.Focus();
            nEstadoRegistro = 1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e){
            this.Estado_texto(false);
            this.Limpiar_texto();
            this.Estado_botones_proceso(false);
            this.Estado_botones_principales(true);
            nEstadoRegistro = 0;
            nCodigo_ar = 0;
            nCodigo_me = 0;
            nCodigo_ca = 0;
        }
        private void btn_actualizar_Click(object sender, EventArgs e){
            nEstadoRegistro = 2;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Aeticulos_Load(object sender, EventArgs e){
            this.listadoArticulos("%");
            this.listadoMedidas();
            this.listadoCategoria();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            Articulo art = new Articulo();
            art.codigo_ar = nCodigo_ar;
            art.descripcion_ar = txtDescripcion.Text.Trim();
            art.marca_ar = txtMarca.Text.Trim();
            art.codigo_me = this.nCodigo_me;
            art.codigo_ca = this.nCodigo_ca;
            DbContextArticulo db = new DbContextArticulo();
            respuesta = db.RegistrosArticulo(nEstadoRegistro, art);
            if (respuesta.Equals("ok")){
                this.listadoArticulos("%");
                this.Estado_texto(false);
                this.Limpiar_texto();
                this.Estado_botones_proceso(false);
                this.Estado_botones_principales(true);
                nEstadoRegistro = 0;
                nCodigo_ar = 0;
                nCodigo_me = 0;
                nCodigo_ca = 0;
                MessageBox.Show("Registro exitos", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                MessageBox.Show(respuesta);
            }
        }

        private void btn_buscar_medida_Click(object sender, EventArgs e)
        {
            panelMedida.Location = txtDescripcion.Location;
            panelMedida.Visible = true;
        }

        private void btnRetornarMedida_Click(object sender, EventArgs e)
        {
            panelMedida.Visible = false;
        }

        private void dgvMedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionarItemMedida();
            panelMedida.Visible=false;
        }

        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {
            panelCategoria.Location = txtDescripcion.Location;
            panelCategoria.Visible = true;
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionarItemCategoria();
            panelCategoria.Visible = false;
        }

        private void btn_retornar_categoria_Click(object sender, EventArgs e)
        {
            panelCategoria.Visible = false;
        }
    }
}
