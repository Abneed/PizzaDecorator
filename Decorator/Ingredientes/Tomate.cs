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
    class Tomate<T> : ComponentDecoratorIngredientes where T : ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Tomate.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Tomate(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 15;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 30;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t tomate,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T(Tomate<T> tomate)
        {
            return (T)tomate.Pizza;
        }
    }
}
