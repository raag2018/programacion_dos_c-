using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoUnidadTres{
    public partial class Frm_Aeticulos : Form{
        public Frm_Aeticulos(){
            InitializeComponent();
        }

        #region "Variables"
        int nCodigo_ar = 0;
        int nCodigo_me = 0;
        int nCodigo_ca = 0;
        #endregion
        #region "Metodos"
        private void Estado_texto(bool lEstado){
            txtDescripcion.ReadOnly = !lEstado;
            txtMarca.ReadOnly = !lEstado;
        } 
        private void Limpiar_texto(){
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtCategoria.Clear();
            txtMedida.Clear();
        }
        private void Estado_botones_proceso(bool lEstado){
            btn_cancelar.Visible = !lEstado;
            btn_guardar.Visible = !lEstado;
            btn_buscar_categoria.Visible = !lEstado;
            btn_buscar_medida.Visible = !lEstado;
        }
        private void Estado_botones_principales(bool lEstado){
            btnAgregar.Enabled = lEstado;
            btn_actualizar.Enabled = lEstado;
            btn_eliminar.Enabled = lEstado;
            btn_reporte.Enabled = lEstado;
            btn_salir.Enabled = lEstado;
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
        }

        private void btn_cancelar_Click(object sender, EventArgs e){
            this.Estado_texto(false);
            this.Limpiar_texto();
            this.Estado_botones_proceso(false);
            this.Estado_botones_principales(true);
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

    }
}
