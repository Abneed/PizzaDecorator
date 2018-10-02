namespace Decorator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbIngredientes = new System.Windows.Forms.GroupBox();
            this.gbTipoPizza = new System.Windows.Forms.GroupBox();
            this.rtxtListadoIngredientes = new System.Windows.Forms.RichTextBox();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.pbxPizza = new System.Windows.Forms.PictureBox();
            this.pbxPepperoni = new System.Windows.Forms.PictureBox();
            this.pbxJamon = new System.Windows.Forms.PictureBox();
            this.pbxTocino = new System.Windows.Forms.PictureBox();
            this.pbxChile = new System.Windows.Forms.PictureBox();
            this.pbxJalapeno = new System.Windows.Forms.PictureBox();
            this.pbxChampinon = new System.Windows.Forms.PictureBox();
            this.pbxCebolla = new System.Windows.Forms.PictureBox();
            this.pbxTomate = new System.Windows.Forms.PictureBox();
            this.pbxAceituna = new System.Windows.Forms.PictureBox();
            this.pbxPina = new System.Windows.Forms.PictureBox();
            this.mcbxPepperoni = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxJamon = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxTocino = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxChileMorron = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxJalapeno = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxChampinon = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxCebolla = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxTomate = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxAceituna = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbxPina = new MaterialSkin.Controls.MaterialCheckBox();
            this.mradPizzaRegular = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradPizzaVegetariana = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnComprar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbIngredientes.SuspendLayout();
            this.gbTipoPizza.SuspendLayout();
            this.gbxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPepperoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJamon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTocino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJalapeno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChampinon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCebolla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTomate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAceituna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPina)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngredientes
            // 
            this.gbIngredientes.Controls.Add(this.mcbxPina);
            this.gbIngredientes.Controls.Add(this.mcbxAceituna);
            this.gbIngredientes.Controls.Add(this.mcbxTomate);
            this.gbIngredientes.Controls.Add(this.mcbxCebolla);
            this.gbIngredientes.Controls.Add(this.mcbxChampinon);
            this.gbIngredientes.Controls.Add(this.mcbxJalapeno);
            this.gbIngredientes.Controls.Add(this.mcbxChileMorron);
            this.gbIngredientes.Controls.Add(this.mcbxTocino);
            this.gbIngredientes.Controls.Add(this.mcbxJamon);
            this.gbIngredientes.Controls.Add(this.mcbxPepperoni);
            this.gbIngredientes.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngredientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbIngredientes.Location = new System.Drawing.Point(12, 90);
            this.gbIngredientes.Name = "gbIngredientes";
            this.gbIngredientes.Size = new System.Drawing.Size(161, 333);
            this.gbIngredientes.TabIndex = 14;
            this.gbIngredientes.TabStop = false;
            this.gbIngredientes.Text = "Ingredientes";
            // 
            // gbTipoPizza
            // 
            this.gbTipoPizza.Controls.Add(this.mradPizzaVegetariana);
            this.gbTipoPizza.Controls.Add(this.mradPizzaRegular);
            this.gbTipoPizza.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPizza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbTipoPizza.Location = new System.Drawing.Point(12, 3);
            this.gbTipoPizza.Name = "gbTipoPizza";
            this.gbTipoPizza.Size = new System.Drawing.Size(521, 81);
            this.gbTipoPizza.TabIndex = 15;
            this.gbTipoPizza.TabStop = false;
            this.gbTipoPizza.Text = "Selecciona el tipo de Pizza:";
            // 
            // rtxtListadoIngredientes
            // 
            this.rtxtListadoIngredientes.Location = new System.Drawing.Point(6, 19);
            this.rtxtListadoIngredientes.Name = "rtxtListadoIngredientes";
            this.rtxtListadoIngredientes.Size = new System.Drawing.Size(187, 399);
            this.rtxtListadoIngredientes.TabIndex = 16;
            this.rtxtListadoIngredientes.Text = "";
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.rtxtListadoIngredientes);
            this.gbxListado.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxListado.Location = new System.Drawing.Point(539, 3);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(204, 430);
            this.gbxListado.TabIndex = 17;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Orden";
            // 
            // pbxPizza
            // 
            this.pbxPizza.BackColor = System.Drawing.Color.White;
            this.pbxPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPizza.Location = new System.Drawing.Point(179, 90);
            this.pbxPizza.Name = "pbxPizza";
            this.pbxPizza.Size = new System.Drawing.Size(354, 333);
            this.pbxPizza.TabIndex = 19;
            this.pbxPizza.TabStop = false;
            // 
            // pbxPepperoni
            // 
            this.pbxPepperoni.BackColor = System.Drawing.Color.Transparent;
            this.pbxPepperoni.Location = new System.Drawing.Point(179, 90);
            this.pbxPepperoni.Name = "pbxPepperoni";
            this.pbxPepperoni.Size = new System.Drawing.Size(354, 333);
            this.pbxPepperoni.TabIndex = 20;
            this.pbxPepperoni.TabStop = false;
            // 
            // pbxJamon
            // 
            this.pbxJamon.BackColor = System.Drawing.Color.Transparent;
            this.pbxJamon.Location = new System.Drawing.Point(179, 90);
            this.pbxJamon.Name = "pbxJamon";
            this.pbxJamon.Size = new System.Drawing.Size(354, 333);
            this.pbxJamon.TabIndex = 21;
            this.pbxJamon.TabStop = false;
            // 
            // pbxTocino
            // 
            this.pbxTocino.BackColor = System.Drawing.Color.Transparent;
            this.pbxTocino.Location = new System.Drawing.Point(179, 90);
            this.pbxTocino.Name = "pbxTocino";
            this.pbxTocino.Size = new System.Drawing.Size(354, 333);
            this.pbxTocino.TabIndex = 22;
            this.pbxTocino.TabStop = false;
            // 
            // pbxChile
            // 
            this.pbxChile.BackColor = System.Drawing.Color.Transparent;
            this.pbxChile.Location = new System.Drawing.Point(179, 90);
            this.pbxChile.Name = "pbxChile";
            this.pbxChile.Size = new System.Drawing.Size(354, 333);
            this.pbxChile.TabIndex = 23;
            this.pbxChile.TabStop = false;
            // 
            // pbxJalapeno
            // 
            this.pbxJalapeno.BackColor = System.Drawing.Color.Transparent;
            this.pbxJalapeno.Location = new System.Drawing.Point(179, 90);
            this.pbxJalapeno.Name = "pbxJalapeno";
            this.pbxJalapeno.Size = new System.Drawing.Size(354, 333);
            this.pbxJalapeno.TabIndex = 24;
            this.pbxJalapeno.TabStop = false;
            // 
            // pbxChampinon
            // 
            this.pbxChampinon.BackColor = System.Drawing.Color.Transparent;
            this.pbxChampinon.Location = new System.Drawing.Point(179, 90);
            this.pbxChampinon.Name = "pbxChampinon";
            this.pbxChampinon.Size = new System.Drawing.Size(354, 333);
            this.pbxChampinon.TabIndex = 25;
            this.pbxChampinon.TabStop = false;
            // 
            // pbxCebolla
            // 
            this.pbxCebolla.BackColor = System.Drawing.Color.Transparent;
            this.pbxCebolla.Location = new System.Drawing.Point(179, 90);
            this.pbxCebolla.Name = "pbxCebolla";
            this.pbxCebolla.Size = new System.Drawing.Size(354, 333);
            this.pbxCebolla.TabIndex = 26;
            this.pbxCebolla.TabStop = false;
            // 
            // pbxTomate
            // 
            this.pbxTomate.BackColor = System.Drawing.Color.Transparent;
            this.pbxTomate.Location = new System.Drawing.Point(179, 90);
            this.pbxTomate.Name = "pbxTomate";
            this.pbxTomate.Size = new System.Drawing.Size(354, 333);
            this.pbxTomate.TabIndex = 27;
            this.pbxTomate.TabStop = false;
            // 
            // pbxAceituna
            // 
            this.pbxAceituna.BackColor = System.Drawing.Color.Transparent;
            this.pbxAceituna.Location = new System.Drawing.Point(179, 90);
            this.pbxAceituna.Name = "pbxAceituna";
            this.pbxAceituna.Size = new System.Drawing.Size(354, 333);
            this.pbxAceituna.TabIndex = 28;
            this.pbxAceituna.TabStop = false;
            // 
            // pbxPina
            // 
            this.pbxPina.BackColor = System.Drawing.Color.Transparent;
            this.pbxPina.Location = new System.Drawing.Point(179, 90);
            this.pbxPina.Name = "pbxPina";
            this.pbxPina.Size = new System.Drawing.Size(354, 333);
            this.pbxPina.TabIndex = 29;
            this.pbxPina.TabStop = false;
            // 
            // mcbxPepperoni
            // 
            this.mcbxPepperoni.AutoSize = true;
            this.mcbxPepperoni.Depth = 0;
            this.mcbxPepperoni.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxPepperoni.Location = new System.Drawing.Point(21, 22);
            this.mcbxPepperoni.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxPepperoni.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxPepperoni.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxPepperoni.Name = "mcbxPepperoni";
            this.mcbxPepperoni.Ripple = true;
            this.mcbxPepperoni.Size = new System.Drawing.Size(93, 30);
            this.mcbxPepperoni.TabIndex = 30;
            this.mcbxPepperoni.Text = "Pepperoni";
            this.mcbxPepperoni.UseVisualStyleBackColor = true;
            this.mcbxPepperoni.CheckedChanged += new System.EventHandler(this.mcbxPepperoni_CheckedChanged);
            // 
            // mcbxJamon
            // 
            this.mcbxJamon.AutoSize = true;
            this.mcbxJamon.Depth = 0;
            this.mcbxJamon.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxJamon.Location = new System.Drawing.Point(21, 51);
            this.mcbxJamon.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxJamon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxJamon.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxJamon.Name = "mcbxJamon";
            this.mcbxJamon.Ripple = true;
            this.mcbxJamon.Size = new System.Drawing.Size(72, 30);
            this.mcbxJamon.TabIndex = 31;
            this.mcbxJamon.Text = "Jamón";
            this.mcbxJamon.UseVisualStyleBackColor = true;
            this.mcbxJamon.CheckedChanged += new System.EventHandler(this.mcbxJamon_CheckedChanged);
            // 
            // mcbxTocino
            // 
            this.mcbxTocino.AutoSize = true;
            this.mcbxTocino.Depth = 0;
            this.mcbxTocino.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxTocino.Location = new System.Drawing.Point(21, 81);
            this.mcbxTocino.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxTocino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxTocino.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxTocino.Name = "mcbxTocino";
            this.mcbxTocino.Ripple = true;
            this.mcbxTocino.Size = new System.Drawing.Size(72, 30);
            this.mcbxTocino.TabIndex = 32;
            this.mcbxTocino.Text = "Tocino";
            this.mcbxTocino.UseVisualStyleBackColor = true;
            this.mcbxTocino.CheckedChanged += new System.EventHandler(this.mcbxTocino_CheckedChanged);
            // 
            // mcbxChileMorron
            // 
            this.mcbxChileMorron.AutoSize = true;
            this.mcbxChileMorron.Depth = 0;
            this.mcbxChileMorron.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxChileMorron.Location = new System.Drawing.Point(21, 111);
            this.mcbxChileMorron.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxChileMorron.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxChileMorron.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxChileMorron.Name = "mcbxChileMorron";
            this.mcbxChileMorron.Ripple = true;
            this.mcbxChileMorron.Size = new System.Drawing.Size(109, 30);
            this.mcbxChileMorron.TabIndex = 33;
            this.mcbxChileMorron.Text = "Chile Morron";
            this.mcbxChileMorron.UseVisualStyleBackColor = true;
            this.mcbxChileMorron.CheckedChanged += new System.EventHandler(this.mcbxChileMorron_CheckedChanged);
            // 
            // mcbxJalapeno
            // 
            this.mcbxJalapeno.AutoSize = true;
            this.mcbxJalapeno.Depth = 0;
            this.mcbxJalapeno.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxJalapeno.Location = new System.Drawing.Point(21, 141);
            this.mcbxJalapeno.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxJalapeno.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxJalapeno.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxJalapeno.Name = "mcbxJalapeno";
            this.mcbxJalapeno.Ripple = true;
            this.mcbxJalapeno.Size = new System.Drawing.Size(86, 30);
            this.mcbxJalapeno.TabIndex = 34;
            this.mcbxJalapeno.Text = "Jalapeño";
            this.mcbxJalapeno.UseVisualStyleBackColor = true;
            this.mcbxJalapeno.CheckedChanged += new System.EventHandler(this.mcbxJalapeno_CheckedChanged);
            // 
            // mcbxChampinon
            // 
            this.mcbxChampinon.AutoSize = true;
            this.mcbxChampinon.Depth = 0;
            this.mcbxChampinon.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxChampinon.Location = new System.Drawing.Point(21, 171);
            this.mcbxChampinon.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxChampinon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxChampinon.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxChampinon.Name = "mcbxChampinon";
            this.mcbxChampinon.Ripple = true;
            this.mcbxChampinon.Size = new System.Drawing.Size(100, 30);
            this.mcbxChampinon.TabIndex = 35;
            this.mcbxChampinon.Text = "Champiñon";
            this.mcbxChampinon.UseVisualStyleBackColor = true;
            this.mcbxChampinon.CheckedChanged += new System.EventHandler(this.mcbxChampinon_CheckedChanged);
            // 
            // mcbxCebolla
            // 
            this.mcbxCebolla.AutoSize = true;
            this.mcbxCebolla.Depth = 0;
            this.mcbxCebolla.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxCebolla.Location = new System.Drawing.Point(21, 201);
            this.mcbxCebolla.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxCebolla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxCebolla.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxCebolla.Name = "mcbxCebolla";
            this.mcbxCebolla.Ripple = true;
            this.mcbxCebolla.Size = new System.Drawing.Size(76, 30);
            this.mcbxCebolla.TabIndex = 36;
            this.mcbxCebolla.Text = "Cebolla";
            this.mcbxCebolla.UseVisualStyleBackColor = true;
            this.mcbxCebolla.CheckedChanged += new System.EventHandler(this.mcbxCebolla_CheckedChanged);
            // 
            // mcbxTomate
            // 
            this.mcbxTomate.AutoSize = true;
            this.mcbxTomate.Depth = 0;
            this.mcbxTomate.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxTomate.Location = new System.Drawing.Point(21, 231);
            this.mcbxTomate.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxTomate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxTomate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxTomate.Name = "mcbxTomate";
            this.mcbxTomate.Ripple = true;
            this.mcbxTomate.Size = new System.Drawing.Size(77, 30);
            this.mcbxTomate.TabIndex = 37;
            this.mcbxTomate.Text = "Tomate";
            this.mcbxTomate.UseVisualStyleBackColor = true;
            this.mcbxTomate.CheckedChanged += new System.EventHandler(this.mcbxTomate_CheckedChanged);
            // 
            // mcbxAceituna
            // 
            this.mcbxAceituna.AutoSize = true;
            this.mcbxAceituna.Depth = 0;
            this.mcbxAceituna.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxAceituna.Location = new System.Drawing.Point(21, 261);
            this.mcbxAceituna.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxAceituna.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxAceituna.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxAceituna.Name = "mcbxAceituna";
            this.mcbxAceituna.Ripple = true;
            this.mcbxAceituna.Size = new System.Drawing.Size(84, 30);
            this.mcbxAceituna.TabIndex = 38;
            this.mcbxAceituna.Text = "Aceituna";
            this.mcbxAceituna.UseVisualStyleBackColor = true;
            this.mcbxAceituna.CheckedChanged += new System.EventHandler(this.mcbxAceituna_CheckedChanged);
            // 
            // mcbxPina
            // 
            this.mcbxPina.AutoSize = true;
            this.mcbxPina.Depth = 0;
            this.mcbxPina.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbxPina.Location = new System.Drawing.Point(21, 291);
            this.mcbxPina.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxPina.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxPina.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxPina.Name = "mcbxPina";
            this.mcbxPina.Ripple = true;
            this.mcbxPina.Size = new System.Drawing.Size(57, 30);
            this.mcbxPina.TabIndex = 39;
            this.mcbxPina.Text = "Piña";
            this.mcbxPina.UseVisualStyleBackColor = true;
            this.mcbxPina.CheckedChanged += new System.EventHandler(this.mcbxPina_CheckedChanged);
            // 
            // mradPizzaRegular
            // 
            this.mradPizzaRegular.AutoSize = true;
            this.mradPizzaRegular.Depth = 0;
            this.mradPizzaRegular.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradPizzaRegular.Location = new System.Drawing.Point(21, 19);
            this.mradPizzaRegular.Margin = new System.Windows.Forms.Padding(0);
            this.mradPizzaRegular.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradPizzaRegular.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradPizzaRegular.Name = "mradPizzaRegular";
            this.mradPizzaRegular.Ripple = true;
            this.mradPizzaRegular.Size = new System.Drawing.Size(113, 30);
            this.mradPizzaRegular.TabIndex = 30;
            this.mradPizzaRegular.TabStop = true;
            this.mradPizzaRegular.Text = "Pizza Regular";
            this.mradPizzaRegular.UseVisualStyleBackColor = true;
            this.mradPizzaRegular.CheckedChanged += new System.EventHandler(this.mradPizzaRegular_CheckedChanged);
            // 
            // mradPizzaVegetariana
            // 
            this.mradPizzaVegetariana.AutoSize = true;
            this.mradPizzaVegetariana.Depth = 0;
            this.mradPizzaVegetariana.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradPizzaVegetariana.Location = new System.Drawing.Point(21, 49);
            this.mradPizzaVegetariana.Margin = new System.Windows.Forms.Padding(0);
            this.mradPizzaVegetariana.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradPizzaVegetariana.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradPizzaVegetariana.Name = "mradPizzaVegetariana";
            this.mradPizzaVegetariana.Ripple = true;
            this.mradPizzaVegetariana.Size = new System.Drawing.Size(140, 30);
            this.mradPizzaVegetariana.TabIndex = 31;
            this.mradPizzaVegetariana.TabStop = true;
            this.mradPizzaVegetariana.Text = "Pizza Vegetariana";
            this.mradPizzaVegetariana.UseVisualStyleBackColor = true;
            this.mradPizzaVegetariana.CheckedChanged += new System.EventHandler(this.mradPizzaVegetariana_CheckedChanged);
            // 
            // mrbtnComprar
            // 
            this.mrbtnComprar.Depth = 0;
            this.mrbtnComprar.Location = new System.Drawing.Point(275, 443);
            this.mrbtnComprar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnComprar.Name = "mrbtnComprar";
            this.mrbtnComprar.Primary = true;
            this.mrbtnComprar.Size = new System.Drawing.Size(152, 49);
            this.mrbtnComprar.TabIndex = 30;
            this.mrbtnComprar.Text = "Comprar";
            this.mrbtnComprar.UseVisualStyleBackColor = true;
            this.mrbtnComprar.Click += new System.EventHandler(this.mrbtnComprar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxListado);
            this.panel1.Controls.Add(this.gbIngredientes);
            this.panel1.Controls.Add(this.gbTipoPizza);
            this.panel1.Controls.Add(this.mrbtnComprar);
            this.panel1.Controls.Add(this.pbxPina);
            this.panel1.Controls.Add(this.pbxPizza);
            this.panel1.Controls.Add(this.pbxAceituna);
            this.panel1.Controls.Add(this.pbxPepperoni);
            this.panel1.Controls.Add(this.pbxTomate);
            this.panel1.Controls.Add(this.pbxJamon);
            this.panel1.Controls.Add(this.pbxCebolla);
            this.panel1.Controls.Add(this.pbxTocino);
            this.panel1.Controls.Add(this.pbxChampinon);
            this.panel1.Controls.Add(this.pbxChile);
            this.panel1.Controls.Add(this.pbxJalapeno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 517);
            this.panel1.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 581);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PizzaDecorator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbIngredientes.ResumeLayout(false);
            this.gbIngredientes.PerformLayout();
            this.gbTipoPizza.ResumeLayout(false);
            this.gbTipoPizza.PerformLayout();
            this.gbxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPepperoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJamon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTocino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJalapeno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChampinon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCebolla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTomate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAceituna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPina)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbIngredientes;
        private System.Windows.Forms.GroupBox gbTipoPizza;
        private System.Windows.Forms.RichTextBox rtxtListadoIngredientes;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.PictureBox pbxPizza;
        private System.Windows.Forms.PictureBox pbxPepperoni;
        private System.Windows.Forms.PictureBox pbxJamon;
        private System.Windows.Forms.PictureBox pbxTocino;
        private System.Windows.Forms.PictureBox pbxChile;
        private System.Windows.Forms.PictureBox pbxJalapeno;
        private System.Windows.Forms.PictureBox pbxChampinon;
        private System.Windows.Forms.PictureBox pbxCebolla;
        private System.Windows.Forms.PictureBox pbxTomate;
        private System.Windows.Forms.PictureBox pbxAceituna;
        private System.Windows.Forms.PictureBox pbxPina;
        private MaterialSkin.Controls.MaterialCheckBox mcbxPina;
        private MaterialSkin.Controls.MaterialCheckBox mcbxAceituna;
        private MaterialSkin.Controls.MaterialCheckBox mcbxTomate;
        private MaterialSkin.Controls.MaterialCheckBox mcbxCebolla;
        private MaterialSkin.Controls.MaterialCheckBox mcbxChampinon;
        private MaterialSkin.Controls.MaterialCheckBox mcbxJalapeno;
        private MaterialSkin.Controls.MaterialCheckBox mcbxChileMorron;
        private MaterialSkin.Controls.MaterialCheckBox mcbxTocino;
        private MaterialSkin.Controls.MaterialCheckBox mcbxJamon;
        private MaterialSkin.Controls.MaterialCheckBox mcbxPepperoni;
        private MaterialSkin.Controls.MaterialRadioButton mradPizzaVegetariana;
        private MaterialSkin.Controls.MaterialRadioButton mradPizzaRegular;
        private MaterialSkin.Controls.MaterialRaisedButton mrbtnComprar;
        private System.Windows.Forms.Panel panel1;
    }
}

