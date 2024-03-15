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
    public partial class AdministradorDeDiseño : Form
    {
        public AdministradorDeDiseño()
        {
            InitializeComponent();
            InitializeComponent();

            // Creamos un nuevo TableLayoutPanel
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Dock = DockStyle.Fill; // Establecemos el acoplamiento para llenar el formulario
            tableLayoutPanel1.ColumnCount = 2; // Definimos el número de columnas
            tableLayoutPanel1.RowCount = 2; // Definimos el número de filas
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Ajustamos el ancho de las columnas al 50% de la ventana
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // Ajustamos el alto de las filas al 50% de la ventana

            // Creamos algunos controles para agregar al TableLayoutPanel
            Button button1 = new Button();
            button1.Text = "Botón 1";

            Button button2 = new Button();
            button2.Text = "Botón 2";

            Button button3 = new Button();
            button3.Text = "Botón 3";

            Button button4 = new Button();
            button4.Text = "Botón 4";

            // Añadimos los controles al TableLayoutPanel
            tableLayoutPanel1.Controls.Add(button1, 0, 0); // Agregamos el botón 1 a la posición (0, 0)
            tableLayoutPanel1.Controls.Add(button2, 1, 0); // Agregamos el botón 2 a la posición (1, 0)
            tableLayoutPanel1.Controls.Add(button3, 0, 1); // Agregamos el botón 3 a la posición (0, 1)
            tableLayoutPanel1.Controls.Add(button4, 1, 1); // Agregamos el botón 4 a la posición (1, 1)

            // Agregamos el TableLayoutPanel al formulario
            this.Controls.Add(tableLayoutPanel1);
        }

        private void AdministradorDeDiseño_Load(object sender, EventArgs e)
        {

        }
    }
}
