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
    class Champiñon<T> : ComponentDecoratorIngredientes where T : ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Champinones.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Champiñon(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 20;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 16;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t champiñon,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T(Champiñon<T> champiñon)
        {
            return (T)champiñon.Pizza;
        }
    }
}
