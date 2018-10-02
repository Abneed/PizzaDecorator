using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Decorator.Pizzas
{
    public class ConcretePizzaRegular : ComponentPizza
    {
        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Regular.png");

        public override double ContarCalorias()
        {
            return 240;
        }

        public override int ObtenerPrecio()
        {
            return 139;
        }

        public override string ObtenerDescripcion()
        {
            return "Pizza regular con:\n";
        }

        public override Image PintarImagen()
        {
            return Img;
        }
    }
}
