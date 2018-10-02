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
    class Pepperoni<T> : ComponentDecoratorIngredientes where T: ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Pepperoni.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Pepperoni(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 0;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 696;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t pepperoni,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T(Pepperoni<T> pepperoni)
        {
            return (T)pepperoni.Pizza;
        }
    }
}
