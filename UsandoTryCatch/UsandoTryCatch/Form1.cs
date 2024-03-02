using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UsandoTryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double lado;
            try
            {
                lado = Convert.ToDouble(txtLado.Text);
                lblResultado.Text = "El �rea del cuadrado mide \n" +
                Convert.ToString(lado * lado) + " unidades cuadradas";
            }
            catch (FormatException objetoExcepci�n)
            {
                //txtLado.Text = "";
                lblResultado.Text = "Error en la medida del lado; \n" +
                    "vuelva a escribirla. \n" + objetoExcepci�n.Message;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int inferior, superior = 100;
            try
            {
                inferior = Convert.ToInt32(txtNumero.Text);
                lblResultadoDiv.Text = "Al dividir entre 100 obtenemos " +
                Convert.ToString(superior / inferior);
            }
            catch (DivideByZeroException objetoExcepci�n)
            {
                lblResultadoDiv.Text = "Error: imposible dividir entre cero:\n vuelva a introducirlos datos";
            }
            catch (FormatException objetoExcepci�n)
            {
                lblResultadoDiv.Text = "Error en el n�mero: vuelva a introducirlo";
            }
            catch (SystemException objetoExcepci�n)
            {
                lblResultadoDiv.Text = objetoExcepci�n.ToString();
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e){
            try{
                lblResultadoNum.Text =  "El texto a sido convertido: "+Convert.ToString(PalabraAN�mero(txtTextoNumero.Text));
            }catch (FormatException ex){
                lblResultadoNum.Text = ex.Message;
            }
           
        }
        private int PalabraAN�mero(string palabra){
            int resultado = 0;
            if (palabra == "diez"){
                resultado = 10;
            }else if (palabra == "cien"){
                resultado = 100;
            }else if (palabra == "mil"){
                resultado = 1000;
            }else{
                throw (new FormatException
                ("Entrada incorrecta: PalabraAN�mero"));
            }
            return resultado;
        }
    }
}

