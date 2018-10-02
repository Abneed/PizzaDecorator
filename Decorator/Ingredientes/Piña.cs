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
    class Piña<T> : ComponentDecoratorIngredientes where T: ComponentPizza
    {

        public Image Img = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Pina.png");

        public override Image PintarImagen()
        {
            return Img;
        }

        public Piña(ComponentPizza OrdenPizza)
        {
            this.Pizza = OrdenPizza;
        }

        public override int ObtenerPrecio()
        {
            return this.Pizza.ObtenerPrecio() + 10;
        }

        public override double ContarCalorias()
        {
            return this.Pizza.ContarCalorias() + 83;
        }

        public override string ObtenerDescripcion()
        {
            return this.Pizza.ObtenerDescripcion() + "\t piña,\n";
        }

        public T Undecorate()
        {
            return (T)Pizza;
        }

        public static implicit operator T(Piña<T> piña)
        {
            return (T)piña.Pizza;
        }
    }
}
