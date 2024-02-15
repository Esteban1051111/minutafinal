namespace Minutas2
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.cmbMinutas = new System.Windows.Forms.ComboBox();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.btnNueva_minuta = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnpoderes = new System.Windows.Forms.Button();
            this.panelPoderes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelPoderes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Titulo.Location = new System.Drawing.Point(477, 27);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(159, 46);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Minutas";
            // 
            // cmbMinutas
            // 
            this.cmbMinutas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMinutas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMinutas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbMinutas.FormattingEnabled = true;
            this.cmbMinutas.Location = new System.Drawing.Point(409, 101);
            this.cmbMinutas.Name = "cmbMinutas";
            this.cmbMinutas.Size = new System.Drawing.Size(285, 21);
            this.cmbMinutas.TabIndex = 1;
            this.cmbMinutas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(485, 163);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(144, 29);
            this.btnseleccionar.TabIndex = 3;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNueva_minuta
            // 
            this.btnNueva_minuta.Location = new System.Drawing.Point(523, 235);
            this.btnNueva_minuta.Name = "btnNueva_minuta";
            this.btnNueva_minuta.Size = new System.Drawing.Size(96, 23);
            this.btnNueva_minuta.TabIndex = 4;
            this.btnNueva_minuta.Text = "nueva minuta";
            this.btnNueva_minuta.UseVisualStyleBackColor = true;
            this.btnNueva_minuta.Click += new System.EventHandler(this.btnNueva_minuta_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMenu.Controls.Add(this.panelPoderes);
            this.panelMenu.Controls.Add(this.btnpoderes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 446);
            this.panelMenu.TabIndex = 5;
            // 
            // btnpoderes
            // 
            this.btnpoderes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpoderes.Location = new System.Drawing.Point(0, 0);
            this.btnpoderes.Name = "btnpoderes";
            this.btnpoderes.Size = new System.Drawing.Size(200, 49);
            this.btnpoderes.TabIndex = 6;
            this.btnpoderes.Text = "PODERES";
            this.btnpoderes.UseVisualStyleBackColor = true;
            // 
            // panelPoderes
            // 
            this.panelPoderes.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelPoderes.Controls.Add(this.button4);
            this.panelPoderes.Controls.Add(this.button3);
            this.panelPoderes.Controls.Add(this.button2);
            this.panelPoderes.Controls.Add(this.button1);
            this.panelPoderes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPoderes.Location = new System.Drawing.Point(0, 49);
            this.panelPoderes.Name = "panelPoderes";
            this.panelPoderes.Size = new System.Drawing.Size(200, 95);
            this.panelPoderes.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 446);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnNueva_minuta);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.cmbMinutas);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "Minutas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelPoderes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.ComboBox cmbMinutas;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Button btnNueva_minuta;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPoderes;
        private System.Windows.Forms.Button btnpoderes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

