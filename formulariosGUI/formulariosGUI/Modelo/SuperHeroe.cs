using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulariosGUI.Modelo{
    class SuperHeroe{
        public Guid Id;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;
        public SuperHeroe(){
            Id = Guid.NewGuid();
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }
        public string UsarSuperPoderes(){
            string mensaje = $"{Nombre} está usando los siguientes superpoderes:";
            foreach (var poder in SuperPoderes){
                mensaje += $"\n {poder.Nombre},";
            }
            // Eliminamos la coma extra al final y añadimos un signo de exclamación.
            mensaje = mensaje.TrimEnd(',') + "!!";
            return mensaje;
        }
    }
}
