using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace proyectoUnidadTres.Model{
   public class Articulo{
        public int codigo_ar {  get; set; }
        public string descripcion_ar { get; set; }
        public string marca_ar { get; set; }
        public int codigo_me { get; set; }
        public int codigo_ca { get; set; }
    }
}
