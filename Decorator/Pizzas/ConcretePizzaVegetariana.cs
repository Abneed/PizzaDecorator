using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Decorator.Pizzas
{
    class ConcretePizzaVegetariana : ComponentPizza
    {
        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Vegetariana.png");

        public override double ContarCalorias()
        {
            return 120;
        }

        public override int ObtenerPrecio()
        {
            return 179;
        }

        public override string ObtenerDescripcion()
        {
            return "Pizza vegetariana con:\n";
        }

        public override Image PintarImagen()
        {
            return Img;
        }
    }
}
