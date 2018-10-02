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
            this.radPizzaRegular = new System.Windows.Forms.RadioButton();
            this.radPizzaVegetariana = new System.Windows.Forms.RadioButton();
            this.cbxPepperoni = new System.Windows.Forms.CheckBox();
            this.cbxJamon = new System.Windows.Forms.CheckBox();
            this.cbxTocino = new System.Windows.Forms.CheckBox();
            this.cbxChileMorron = new System.Windows.Forms.CheckBox();
            this.cbxJalapeño = new System.Windows.Forms.CheckBox();
            this.cbxChampiñon = new System.Windows.Forms.CheckBox();
            this.cbxCebolla = new System.Windows.Forms.CheckBox();
            this.cbxTomate = new System.Windows.Forms.CheckBox();
            this.cbxAceituna = new System.Windows.Forms.CheckBox();
            this.cbxPiña = new System.Windows.Forms.CheckBox();
            this.gbIngredientes = new System.Windows.Forms.GroupBox();
            this.gbTipoPizza = new System.Windows.Forms.GroupBox();
            this.rtxtListadoIngredientes = new System.Windows.Forms.RichTextBox();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // radPizzaRegular
            // 
            this.radPizzaRegular.AutoSize = true;
            this.radPizzaRegular.Location = new System.Drawing.Point(6, 19);
            this.radPizzaRegular.Name = "radPizzaRegular";
            this.radPizzaRegular.Size = new System.Drawing.Size(90, 17);
            this.radPizzaRegular.TabIndex = 0;
            this.radPizzaRegular.Text = "Pizza Regular";
            this.radPizzaRegular.UseVisualStyleBackColor = true;
            this.radPizzaRegular.CheckedChanged += new System.EventHandler(this.radPizzaRegular_CheckedChanged);
            // 
            // radPizzaVegetariana
            // 
            this.radPizzaVegetariana.AutoSize = true;
            this.radPizzaVegetariana.Location = new System.Drawing.Point(6, 42);
            this.radPizzaVegetariana.Name = "radPizzaVegetariana";
            this.radPizzaVegetariana.Size = new System.Drawing.Size(110, 17);
            this.radPizzaVegetariana.TabIndex = 1;
            this.radPizzaVegetariana.Text = "Pizza Vegetariana";
            this.radPizzaVegetariana.UseVisualStyleBackColor = true;
            this.radPizzaVegetariana.CheckedChanged += new System.EventHandler(this.radPizzaVegetariana_CheckedChanged);
            // 
            // cbxPepperoni
            // 
            this.cbxPepperoni.AutoSize = true;
            this.cbxPepperoni.Location = new System.Drawing.Point(17, 37);
            this.cbxPepperoni.Name = "cbxPepperoni";
            this.cbxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.cbxPepperoni.TabIndex = 4;
            this.cbxPepperoni.Text = "Pepperoni";
            this.cbxPepperoni.UseVisualStyleBackColor = true;
            this.cbxPepperoni.CheckedChanged += new System.EventHandler(this.cbxPepperoni_CheckedChanged);
            // 
            // cbxJamon
            // 
            this.cbxJamon.AutoSize = true;
            this.cbxJamon.Location = new System.Drawing.Point(17, 60);
            this.cbxJamon.Name = "cbxJamon";
            this.cbxJamon.Size = new System.Drawing.Size(57, 17);
            this.cbxJamon.TabIndex = 5;
            this.cbxJamon.Text = "Jamón";
            this.cbxJamon.UseVisualStyleBackColor = true;
            this.cbxJamon.CheckedChanged += new System.EventHandler(this.cbxJamon_CheckedChanged);
            // 
            // cbxTocino
            // 
            this.cbxTocino.AutoSize = true;
            this.cbxTocino.Location = new System.Drawing.Point(17, 84);
            this.cbxTocino.Name = "cbxTocino";
            this.cbxTocino.Size = new System.Drawing.Size(59, 17);
            this.cbxTocino.TabIndex = 6;
            this.cbxTocino.Text = "Tocino";
            this.cbxTocino.UseVisualStyleBackColor = true;
            this.cbxTocino.CheckedChanged += new System.EventHandler(this.cbxTocino_CheckedChanged);
            // 
            // cbxChileMorron
            // 
            this.cbxChileMorron.AutoSize = true;
            this.cbxChileMorron.Location = new System.Drawing.Point(17, 107);
            this.cbxChileMorron.Name = "cbxChileMorron";
            this.cbxChileMorron.Size = new System.Drawing.Size(85, 17);
            this.cbxChileMorron.TabIndex = 7;
            this.cbxChileMorron.Text = "Chile Morron";
            this.cbxChileMorron.UseVisualStyleBackColor = true;
            this.cbxChileMorron.CheckedChanged += new System.EventHandler(this.cbxChileMorron_CheckedChanged);
            // 
            // cbxJalapeño
            // 
            this.cbxJalapeño.AutoSize = true;
            this.cbxJalapeño.Location = new System.Drawing.Point(17, 132);
            this.cbxJalapeño.Name = "cbxJalapeño";
            this.cbxJalapeño.Size = new System.Drawing.Size(69, 17);
            this.cbxJalapeño.TabIndex = 8;
            this.cbxJalapeño.Text = "Jalapeño";
            this.cbxJalapeño.UseVisualStyleBackColor = true;
            this.cbxJalapeño.CheckedChanged += new System.EventHandler(this.cbxJalapeño_CheckedChanged);
            // 
            // cbxChampiñon
            // 
            this.cbxChampiñon.AutoSize = true;
            this.cbxChampiñon.Location = new System.Drawing.Point(17, 156);
            this.cbxChampiñon.Name = "cbxChampiñon";
            this.cbxChampiñon.Size = new System.Drawing.Size(79, 17);
            this.cbxChampiñon.TabIndex = 9;
            this.cbxChampiñon.Text = "Champiñon";
            this.cbxChampiñon.UseVisualStyleBackColor = true;
            this.cbxChampiñon.CheckedChanged += new System.EventHandler(this.cbxChampiñon_CheckedChanged);
            // 
            // cbxCebolla
            // 
            this.cbxCebolla.AutoSize = true;
            this.cbxCebolla.Location = new System.Drawing.Point(17, 179);
            this.cbxCebolla.Name = "cbxCebolla";
            this.cbxCebolla.Size = new System.Drawing.Size(61, 17);
            this.cbxCebolla.TabIndex = 10;
            this.cbxCebolla.Text = "Cebolla";
            this.cbxCebolla.UseVisualStyleBackColor = true;
            this.cbxCebolla.CheckedChanged += new System.EventHandler(this.cbxCebolla_CheckedChanged);
            // 
            // cbxTomate
            // 
            this.cbxTomate.AutoSize = true;
            this.cbxTomate.Location = new System.Drawing.Point(17, 202);
            this.cbxTomate.Name = "cbxTomate";
            this.cbxTomate.Size = new System.Drawing.Size(62, 17);
            this.cbxTomate.TabIndex = 11;
            this.cbxTomate.Text = "Tomate";
            this.cbxTomate.UseVisualStyleBackColor = true;
            this.cbxTomate.CheckedChanged += new System.EventHandler(this.cbxTomate_CheckedChanged);
            // 
            // cbxAceituna
            // 
            this.cbxAceituna.AutoSize = true;
            this.cbxAceituna.Location = new System.Drawing.Point(17, 225);
            this.cbxAceituna.Name = "cbxAceituna";
            this.cbxAceituna.Size = new System.Drawing.Size(68, 17);
            this.cbxAceituna.TabIndex = 12;
            this.cbxAceituna.Text = "Aceituna";
            this.cbxAceituna.UseVisualStyleBackColor = true;
            this.cbxAceituna.CheckedChanged += new System.EventHandler(this.cbxAceituna_CheckedChanged);
            // 
            // cbxPiña
            // 
            this.cbxPiña.AutoSize = true;
            this.cbxPiña.Location = new System.Drawing.Point(17, 248);
            this.cbxPiña.Name = "cbxPiña";
            this.cbxPiña.Size = new System.Drawing.Size(47, 17);
            this.cbxPiña.TabIndex = 13;
            this.cbxPiña.Text = "Piña";
            this.cbxPiña.UseVisualStyleBackColor = true;
            this.cbxPiña.CheckedChanged += new System.EventHandler(this.cbxPiña_CheckedChanged);
            // 
            // gbIngredientes
            // 
            this.gbIngredientes.Controls.Add(this.cbxTomate);
            this.gbIngredientes.Controls.Add(this.cbxPiña);
            this.gbIngredientes.Controls.Add(this.cbxPepperoni);
            this.gbIngredientes.Controls.Add(this.cbxAceituna);
            this.gbIngredientes.Controls.Add(this.cbxJamon);
            this.gbIngredientes.Controls.Add(this.cbxTocino);
            this.gbIngredientes.Controls.Add(this.cbxCebolla);
            this.gbIngredientes.Controls.Add(this.cbxChileMorron);
            this.gbIngredientes.Controls.Add(this.cbxChampiñon);
            this.gbIngredientes.Controls.Add(this.cbxJalapeño);
            this.gbIngredientes.Location = new System.Drawing.Point(12, 167);
            this.gbIngredientes.Name = "gbIngredientes";
            this.gbIngredientes.Size = new System.Drawing.Size(200, 288);
            this.gbIngredientes.TabIndex = 14;
            this.gbIngredientes.TabStop = false;
            this.gbIngredientes.Text = "Ingredientes";
            // 
            // gbTipoPizza
            // 
            this.gbTipoPizza.Controls.Add(this.radPizzaRegular);
            this.gbTipoPizza.Controls.Add(this.radPizzaVegetariana);
            this.gbTipoPizza.Location = new System.Drawing.Point(12, 79);
            this.gbTipoPizza.Name = "gbTipoPizza";
            this.gbTipoPizza.Size = new System.Drawing.Size(200, 72);
            this.gbTipoPizza.TabIndex = 15;
            this.gbTipoPizza.TabStop = false;
            this.gbTipoPizza.Text = "Selecciona el tipo de Pizza:";
            // 
            // rtxtListadoIngredientes
            // 
            this.rtxtListadoIngredientes.Location = new System.Drawing.Point(6, 19);
            this.rtxtListadoIngredientes.Name = "rtxtListadoIngredientes";
            this.rtxtListadoIngredientes.Size = new System.Drawing.Size(187, 356);
            this.rtxtListadoIngredientes.TabIndex = 16;
            this.rtxtListadoIngredientes.Text = "";
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.rtxtListadoIngredientes);
            this.gbxListado.Location = new System.Drawing.Point(734, 79);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(199, 381);
            this.gbxListado.TabIndex = 17;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Orden";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(441, 493);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 18;
            this.btnFinalizar.Text = "Comprar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // pbxPizza
            // 
            this.pbxPizza.BackColor = System.Drawing.Color.White;
            this.pbxPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPizza.Location = new System.Drawing.Point(300, 127);
            this.pbxPizza.Name = "pbxPizza";
            this.pbxPizza.Size = new System.Drawing.Size(354, 333);
            this.pbxPizza.TabIndex = 19;
            this.pbxPizza.TabStop = false;
            // 
            // pbxPepperoni
            // 
            this.pbxPepperoni.BackColor = System.Drawing.Color.Transparent;
            this.pbxPepperoni.Location = new System.Drawing.Point(300, 127);
            this.pbxPepperoni.Name = "pbxPepperoni";
            this.pbxPepperoni.Size = new System.Drawing.Size(354, 333);
            this.pbxPepperoni.TabIndex = 20;
            this.pbxPepperoni.TabStop = false;
            // 
            // pbxJamon
            // 
            this.pbxJamon.BackColor = System.Drawing.Color.Transparent;
            this.pbxJamon.Location = new System.Drawing.Point(300, 127);
            this.pbxJamon.Name = "pbxJamon";
            this.pbxJamon.Size = new System.Drawing.Size(354, 333);
            this.pbxJamon.TabIndex = 21;
            this.pbxJamon.TabStop = false;
            // 
            // pbxTocino
            // 
            this.pbxTocino.BackColor = System.Drawing.Color.Transparent;
            this.pbxTocino.Location = new System.Drawing.Point(300, 127);
            this.pbxTocino.Name = "pbxTocino";
            this.pbxTocino.Size = new System.Drawing.Size(354, 333);
            this.pbxTocino.TabIndex = 22;
            this.pbxTocino.TabStop = false;
            // 
            // pbxChile
            // 
            this.pbxChile.BackColor = System.Drawing.Color.Transparent;
            this.pbxChile.Location = new System.Drawing.Point(300, 127);
            this.pbxChile.Name = "pbxChile";
            this.pbxChile.Size = new System.Drawing.Size(354, 333);
            this.pbxChile.TabIndex = 23;
            this.pbxChile.TabStop = false;
            // 
            // pbxJalapeno
            // 
            this.pbxJalapeno.BackColor = System.Drawing.Color.Transparent;
            this.pbxJalapeno.Location = new System.Drawing.Point(300, 127);
            this.pbxJalapeno.Name = "pbxJalapeno";
            this.pbxJalapeno.Size = new System.Drawing.Size(354, 333);
            this.pbxJalapeno.TabIndex = 24;
            this.pbxJalapeno.TabStop = false;
            // 
            // pbxChampinon
            // 
            this.pbxChampinon.BackColor = System.Drawing.Color.Transparent;
            this.pbxChampinon.Location = new System.Drawing.Point(300, 127);
            this.pbxChampinon.Name = "pbxChampinon";
            this.pbxChampinon.Size = new System.Drawing.Size(354, 333);
            this.pbxChampinon.TabIndex = 25;
            this.pbxChampinon.TabStop = false;
            // 
            // pbxCebolla
            // 
            this.pbxCebolla.BackColor = System.Drawing.Color.Transparent;
            this.pbxCebolla.Location = new System.Drawing.Point(300, 127);
            this.pbxCebolla.Name = "pbxCebolla";
            this.pbxCebolla.Size = new System.Drawing.Size(354, 333);
            this.pbxCebolla.TabIndex = 26;
            this.pbxCebolla.TabStop = false;
            // 
            // pbxTomate
            // 
            this.pbxTomate.BackColor = System.Drawing.Color.Transparent;
            this.pbxTomate.Location = new System.Drawing.Point(300, 127);
            this.pbxTomate.Name = "pbxTomate";
            this.pbxTomate.Size = new System.Drawing.Size(354, 333);
            this.pbxTomate.TabIndex = 27;
            this.pbxTomate.TabStop = false;
            // 
            // pbxAceituna
            // 
            this.pbxAceituna.BackColor = System.Drawing.Color.Transparent;
            this.pbxAceituna.Location = new System.Drawing.Point(300, 127);
            this.pbxAceituna.Name = "pbxAceituna";
            this.pbxAceituna.Size = new System.Drawing.Size(354, 333);
            this.pbxAceituna.TabIndex = 28;
            this.pbxAceituna.TabStop = false;
            // 
            // pbxPina
            // 
            this.pbxPina.BackColor = System.Drawing.Color.Transparent;
            this.pbxPina.Location = new System.Drawing.Point(300, 127);
            this.pbxPina.Name = "pbxPina";
            this.pbxPina.Size = new System.Drawing.Size(354, 333);
            this.pbxPina.TabIndex = 29;
            this.pbxPina.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 593);
            this.Controls.Add(this.pbxPina);
            this.Controls.Add(this.pbxAceituna);
            this.Controls.Add(this.pbxTomate);
            this.Controls.Add(this.pbxCebolla);
            this.Controls.Add(this.pbxChampinon);
            this.Controls.Add(this.pbxJalapeno);
            this.Controls.Add(this.pbxChile);
            this.Controls.Add(this.pbxTocino);
            this.Controls.Add(this.pbxJamon);
            this.Controls.Add(this.pbxPepperoni);
            this.Controls.Add(this.pbxPizza);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.gbTipoPizza);
            this.Controls.Add(this.gbIngredientes);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radPizzaRegular;
        private System.Windows.Forms.RadioButton radPizzaVegetariana;
        private System.Windows.Forms.CheckBox cbxPepperoni;
        private System.Windows.Forms.CheckBox cbxJamon;
        private System.Windows.Forms.CheckBox cbxTocino;
        private System.Windows.Forms.CheckBox cbxChileMorron;
        private System.Windows.Forms.CheckBox cbxJalapeño;
        private System.Windows.Forms.CheckBox cbxChampiñon;
        private System.Windows.Forms.CheckBox cbxCebolla;
        private System.Windows.Forms.CheckBox cbxTomate;
        private System.Windows.Forms.CheckBox cbxAceituna;
        private System.Windows.Forms.CheckBox cbxPiña;
        private System.Windows.Forms.GroupBox gbIngredientes;
        private System.Windows.Forms.GroupBox gbTipoPizza;
        private System.Windows.Forms.RichTextBox rtxtListadoIngredientes;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.Button btnFinalizar;
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
    }
}

