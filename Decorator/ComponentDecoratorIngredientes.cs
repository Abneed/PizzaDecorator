using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ComponentDecoratorIngredientes : ComponentPizza
    {
        protected ComponentPizza Pizza;

        //public void EstablecerComponente(ComponentPizza componentPizza)
        //{
        //    this.Pizza = componentPizza;
        //}
    }
}
