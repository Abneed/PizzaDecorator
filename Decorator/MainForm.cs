using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decorator.Pizzas;
using Decorator.Ingredientes;

namespace Decorator
{
    public partial class MainForm : MaterialForm
    {
        ComponentPizza pizzaRegular;
        ComponentPizza pizzaVegetariana;
        TipoPizza tipoPizza;

        enum TipoPizza
        {
            Regular,
            Vegetariana
        }

        private void Mostrar()
        {
            if (!radPizzaRegular.Checked && !radPizzaVegetariana.Checked)
            {
                rtxtListadoIngredientes.Text = "Por favor, seleccionar tipo de pizza.";
                return;
            }

            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    rtxtListadoIngredientes.Text = pizzaRegular.ObtenerDescripcion() +
                        "\nPrecio total: $" + pizzaRegular.ObtenerPrecio() +
                        "\nCalorias: " + pizzaRegular.ContarCalorias().ToString();
                    break;
                case TipoPizza.Vegetariana:
                    rtxtListadoIngredientes.Text = pizzaVegetariana.ObtenerDescripcion() +
                        "\nPrecio total: $" + pizzaVegetariana.ObtenerPrecio() +
                        "\nCalorias: " + pizzaVegetariana.ContarCalorias().ToString();
                    break;
            }
            
        }

        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbIngredientes.Enabled = false;
            //pbxPizza.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Regular.png");
            pbxPepperoni.Parent = pbxPizza;
            pbxPepperoni.BackColor = Color.Transparent;
            pbxPepperoni.Location = new Point(0, 0);
            //pbxPepperoni.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Pepperoni.png");
            pbxJamon.Parent = pbxPepperoni;
            pbxJamon.BackColor = Color.Transparent;
            pbxJamon.Location = new Point(0, 0);
            //pbxJamon.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Jamon.png");
            pbxTocino.Parent = pbxJamon;
            pbxTocino.BackColor = Color.Transparent;
            pbxTocino.Location = new Point(0, 0);
            //pbxTocino.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Tocino.png");
            pbxChile.Parent = pbxTocino;
            pbxChile.BackColor = Color.Transparent;
            pbxChile.Location = new Point(0, 0);
            //pbxChile.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\BellPepper.png");
            pbxJalapeno.Parent = pbxChile;
            pbxJalapeno.BackColor = Color.Transparent;
            pbxJalapeno.Location = new Point(0, 0);
            //pbxJalapeno.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Jalapeno.png");
            pbxChampinon.Parent = pbxJalapeno;
            pbxChampinon.BackColor = Color.Transparent;
            pbxChampinon.Location = new Point(0, 0);
            //pbxChampinon.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Champinones.png");
            pbxCebolla.Parent = pbxChampinon;
            pbxCebolla.BackColor = Color.Transparent;
            pbxCebolla.Location = new Point(0, 0);
            //pbxCebolla.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Cebolla.png");
            pbxTomate.Parent = pbxCebolla;
            pbxTomate.BackColor = Color.Transparent;
            pbxTomate.Location = new Point(0, 0);
            //pbxTomate.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Tomate.png");
            pbxAceituna.Parent = pbxTomate;
            pbxAceituna.BackColor = Color.Transparent;
            pbxAceituna.Location = new Point(0, 0);
            //pbxAceituna.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Aceitunas.png");
            pbxPina.Parent = pbxAceituna;
            pbxPina.BackColor = Color.Transparent;
            pbxPina.Location = new Point(0, 0);
            //pbxPina.Image = Image.FromFile(Application.StartupPath + @"\IngredientesPNG\Pina.png");

        }

        private void ActualizarIngredientes()
        {
            foreach (CheckBox cbk in gbIngredientes.Controls)
            {
                if (!cbk.Checked)
                    continue;

                switch (tipoPizza)
                {
                    case TipoPizza.Regular:
                        switch (cbk.Text.ToLower())
                        {
                            case "pepperoni":
                                pizzaRegular = new Pepperoni<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "jamón":
                                pizzaRegular = new Jamon<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "tocino":
                                pizzaRegular = new Tocino<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "chile morron":
                                pizzaRegular = new ChileMorron<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "jalapeño":
                                pizzaRegular = new Jalapeño<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "champiñon":
                                pizzaRegular = new Champiñon<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "cebolla":
                                pizzaRegular = new Cebolla<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "tomate":
                                pizzaRegular = new Tomate<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "aceituna":
                                pizzaRegular = new Aceituna<ConcretePizzaRegular>(pizzaRegular);
                                break;
                            case "piña":
                                pizzaRegular = new Piña<ConcretePizzaRegular>(pizzaRegular);
                                break;
                        }
                        break;
                    case TipoPizza.Vegetariana:
                        switch (cbk.Text.ToLower())
                        {
                            case "pepperoni":
                                pizzaVegetariana = new Pepperoni<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "jamón":
                                pizzaVegetariana = new Jamon<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "tocino":
                                pizzaVegetariana = new Tocino<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "chile morron":
                                pizzaVegetariana = new ChileMorron<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "jalapeño":
                                pizzaVegetariana = new Jalapeño<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "champiñon":
                                pizzaVegetariana = new Champiñon<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "cebolla":
                                pizzaVegetariana = new Cebolla<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "tomate":
                                pizzaVegetariana = new Tomate<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "aceituna":
                                pizzaVegetariana = new Aceituna<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                            case "piña":
                                pizzaVegetariana = new Piña<ConcretePizzaVegetariana>(pizzaVegetariana);
                                break;
                        }
                        break;
                }           
            }
        }

        private void radPizzaRegular_CheckedChanged(object sender, EventArgs e)
        {
            // Borrar/Destruir objeto pizzaVegetariana.
            pizzaVegetariana = null;

            // Limpia todos los CheckBoxes del gbIngredientes.
            foreach (CheckBox cbk in gbIngredientes.Controls)
                cbk.Checked = false;
            
            pizzaRegular = new ConcretePizzaRegular();
            pbxPizza.Image = pizzaRegular.PintarImagen(); 
            tipoPizza = TipoPizza.Regular;

            gbIngredientes.Enabled = true;
            Mostrar();
        }

        private void radPizzaVegetariana_CheckedChanged(object sender, EventArgs e)
        {
            // Borrar/Destruir objeto pizzaRegular.
            pizzaRegular = null;

            // Limpia todos los CheckBoxes del gbIngredientes.
            foreach (CheckBox cbk in gbIngredientes.Controls)
                cbk.Checked = false;

            pizzaVegetariana = new ConcretePizzaVegetariana();
            pbxPizza.Image = pizzaVegetariana.PintarImagen();
            tipoPizza = TipoPizza.Vegetariana;

            gbIngredientes.Enabled = true;
            Mostrar();
        }

        
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void cbxPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxPepperoni.Checked)
                    {
                        // Agregar pepperoni...
                        pizzaRegular = new Pepperoni<ConcretePizzaRegular>(pizzaRegular);
                        pbxPepperoni.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Descartar pepperoni...
                        pizzaRegular = new Pepperoni<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxPepperoni.Image = null;
                    }
                    break;
                case TipoPizza.Vegetariana:
                    if (cbxPepperoni.Checked)
                    {
                        // Agregar pepperoni...
                        pizzaVegetariana = new Pepperoni<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxPepperoni.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Descartar pepperoni...
                        pizzaVegetariana = new Pepperoni<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxPepperoni.Image = null;
                    }
                    break;
            }

            Mostrar();
        }

        private void cbxJamon_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxJamon.Checked)
                    {
                        // Agregar jamon...
                        pizzaRegular = new Jamon<ConcretePizzaRegular>(pizzaRegular);
                        pbxJamon.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar jamon...
                        pizzaRegular = new Jamon<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxJamon.Image = null;
                    }
                    break;
                case TipoPizza.Vegetariana:
                    if (cbxJamon.Checked)
                    {
                        // Agregar jamon...
                        pizzaVegetariana = new Jamon<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxJamon.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar jamon...
                        pizzaVegetariana = new Jamon<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxJamon.Image = null;
                    }
                    break;
            }

            Mostrar();
        }

        private void cbxTocino_CheckedChanged(object sender, EventArgs e)
        {

            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxTocino.Checked)
                    {
                        // Agregar tocino...
                        pizzaRegular = new Tocino<ConcretePizzaRegular>(pizzaRegular);
                        pbxTocino.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar tocino...
                        pizzaRegular = new Tocino<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxTocino.Image = null;
                    }
                    break;

                case TipoPizza.Vegetariana:
                    if (cbxTocino.Checked)
                    {
                        // Agregar tocino...
                        pizzaVegetariana = new Tocino<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxTocino.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar tocino...
                        pizzaVegetariana = new Tocino<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxTocino.Image = null;
                    }
                    break;
            }
            Mostrar();
        }

        private void cbxChileMorron_CheckedChanged(object sender, EventArgs e)
        {

            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxChileMorron.Checked)
                    {
                        // Agregar chile morron...
                        pizzaRegular = new ChileMorron<ConcretePizzaRegular>(pizzaRegular);
                        pbxChile.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar chile morron...
                        pizzaRegular = new ChileMorron<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxChile.Image = null;
                    }
                    break;

                case TipoPizza.Vegetariana:
                    if (cbxChileMorron.Checked)
                    {
                        // Agregar chile morron...
                        pizzaVegetariana = new ChileMorron<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxChile.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar chile morron...
                        pizzaVegetariana = new ChileMorron<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxChile.Image = null;
                    }
                    break;
            }
            Mostrar();
        }

        private void cbxJalapeño_CheckedChanged(object sender, EventArgs e)
        {

            switch (tipoPizza)
            {
                case TipoPizza.Regular:

                    if (cbxJalapeño.Checked)
                    {
                        // Agregar jalapeño...
                        pizzaRegular = new Jalapeño<ConcretePizzaRegular>(pizzaRegular);
                        pbxJalapeno.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar jalapeño...
                        pizzaRegular = new Jalapeño<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxJalapeno.Image = null;
                    }
                    break;

                case TipoPizza.Vegetariana:
                    if (cbxJalapeño.Checked)
                    {
                        // Agregar jalapeño...
                        pizzaVegetariana = new Jalapeño<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxJalapeno.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar jalapeño...
                        pizzaVegetariana = new Jalapeño<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxJalapeno.Image = null;
                    }
                    break;

            }

            Mostrar();
        }

        private void cbxChampiñon_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxChampiñon.Checked)
                    {
                        // Agregar champiñon...
                        pizzaRegular = new Champiñon<ConcretePizzaRegular>(pizzaRegular);
                        pbxChampinon.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar champiñon...
                        pizzaRegular = new Champiñon<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxChampinon.Image = null;
                    }
                    break;
                case TipoPizza.Vegetariana:
                    if (cbxChampiñon.Checked)
                    {
                        // Agregar champiñon...
                        pizzaVegetariana = new Champiñon<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxChampinon.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar champiñon...
                        pizzaVegetariana = new Champiñon<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxChampinon.Image = null;
                    }
                    break;
            }

            Mostrar();
        }

        private void cbxCebolla_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxCebolla.Checked)
                    {
                        // Agregar cebolla...
                        pizzaRegular = new Cebolla<ConcretePizzaRegular>(pizzaRegular);
                        pbxCebolla.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar cebolla...
                        pizzaRegular = new Cebolla<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxCebolla.Image = null;
                    }
                    break;

                case TipoPizza.Vegetariana:
                    if (cbxCebolla.Checked)
                    {
                        // Agregar cebolla...
                        pizzaVegetariana = new Cebolla<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxCebolla.Image = pizzaVegetariana.PintarImagen(); ;
                    }
                    else
                    {
                        // Eliminar cebolla...
                        pizzaVegetariana = new Cebolla<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxCebolla.Image = null;
                    }
                    break;
            }

            Mostrar();
        }

        private void cbxTomate_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxTomate.Checked)
                    {
                        // Agregar tomate...
                        pizzaRegular = new Tomate<ConcretePizzaRegular>(pizzaRegular);
                        pbxTomate.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar tomate...
                        pizzaRegular = new Tomate<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxTomate.Image = null;
                    }
                    break;
                case TipoPizza.Vegetariana:
                    if (cbxTomate.Checked)
                    {
                        // Agregar tomate...
                        pizzaVegetariana = new Tomate<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxTomate.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar tomate...
                        pizzaVegetariana = new Tomate<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxTomate.Image = null;
                    }
                    break;
            }

            Mostrar();
        }

        private void cbxAceituna_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxAceituna.Checked)
                    {
                        // Agregar aceituna...
                        pizzaRegular = new Aceituna<ConcretePizzaRegular>(pizzaRegular);
                        pbxAceituna.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar aceituna...
                        pizzaRegular = new Aceituna<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxAceituna.Image = null;
                    }
                    break;

                case TipoPizza.Vegetariana:
                    if (cbxAceituna.Checked)
                    {
                        // Agregar aceituna...
                        pizzaVegetariana = new Aceituna<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxAceituna.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar aceituna...
                        pizzaVegetariana = new Aceituna<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxAceituna.Image = null;
                    }
                    break;
            }

            Mostrar();
        }

        private void cbxPiña_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipoPizza)
            {
                case TipoPizza.Regular:
                    if (cbxPiña.Checked)
                    {
                        // Agregar piña...
                        pizzaRegular = new Piña<ConcretePizzaRegular>(pizzaRegular);
                        pbxPina.Image = pizzaRegular.PintarImagen();
                    }
                    else
                    {
                        // Eliminar piña...
                        pizzaRegular = new Piña<ConcretePizzaRegular>(new ConcretePizzaRegular()).Undecorate();
                        ActualizarIngredientes();
                        pbxPina.Image = null;
                    }
                    break;

                case TipoPizza.Vegetariana:
                    if (cbxPiña.Checked)
                    {
                        // Agregar piña...
                        pizzaVegetariana = new Piña<ConcretePizzaVegetariana>(pizzaVegetariana);
                        pbxPina.Image = pizzaVegetariana.PintarImagen();
                    }
                    else
                    {
                        // Eliminar piña...
                        pizzaVegetariana = new Piña<ConcretePizzaVegetariana>(new ConcretePizzaVegetariana()).Undecorate();
                        ActualizarIngredientes();
                        pbxPina.Image = null;
                    }
                    break;

            }

            Mostrar();
        }
    }
}
