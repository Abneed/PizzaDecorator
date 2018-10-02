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
    class Aceituna<T> : ComponentDecoratorIngredientes where T : ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Aceitunas.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Aceituna(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 30;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 17.25;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t aceituna,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T (Aceituna<T> aceituna)
        {
            return (T)aceituna.Pizza;
        }
    }
}
