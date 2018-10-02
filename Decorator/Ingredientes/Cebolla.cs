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
    class Cebolla<T> : ComponentDecoratorIngredientes where T: ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Cebolla.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Cebolla(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 15;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 115;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t cebolla,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T (Cebolla<T> cebolla)
        {
            return (T)cebolla.Pizza;
        }
    }
}
