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
    class Jamon<T> : ComponentDecoratorIngredientes where T: ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Jamon.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Jamon(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 40;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 203;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t jamón,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T(Jamon<T> jamon)
        {
            return (T)jamon.Pizza;
        }
    }
}
