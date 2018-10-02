using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decorator.Pizzas;

namespace Decorator.Ingredientes
{
    class Tocino<T> : ComponentDecoratorIngredientes where T : ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Tocino.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Tocino(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 40;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 1060;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t tocino,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T(Tocino<T> tocino)
        {
            return (T)tocino.Pizza;
        }
    }
}
