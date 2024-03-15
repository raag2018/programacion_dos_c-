using formulariosGUI.Modelo;

namespace formulariosGUI
{
    public partial class SuperHeroe : Form
    {


        public SuperHeroe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        #region "Objetos"
            var poderVolaar = new SuperPoder();
            poderVolaar.Nombre = "Volar";
            poderVolaar.Descripcion = "Capacidad para poder volar";
            poderVolaar.Nivel = NivelPoder.NivelDos;
            var superFuerza = new SuperPoder();
            superFuerza.Nombre = "Super Fuerza";
            superFuerza.Nivel = NivelPoder.NivelTres;
            var superman = new Modelo.SuperHeroe();
            superman.Id = Guid.Parse("a26437c5-1f98-4c37-b14a-e1e1cf2f7f2d");
            superman.Nombre = "Superman";
            superman.IdentidadSecreta = "Clark Kent";
            superman.Ciudad = "Metropolis";
            superman.PuedeVolar = true;
            List<SuperPoder> PoderesSuperman = new List<SuperPoder>();
            PoderesSuperman.Add(superFuerza);
            PoderesSuperman.Add(poderVolaar);
            superman.SuperPoderes = PoderesSuperman;
            lblListadoPoderes.Text = superman.UsarSuperPoderes();
        #endregion

        }


    }
}
