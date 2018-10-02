using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Decorator
{
    public abstract class ComponentPizza
    {
        public abstract double ContarCalorias();

        public abstract int ObtenerPrecio();

        public abstract string ObtenerDescripcion();

        public abstract Image PintarImagen();
    }
}
