namespace Minutas2
{
    partial class VentaContadoParticulares
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneleditordetexto = new System.Windows.Forms.Panel();
            this.paneltxt = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.paneltxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.paneleditordetexto);
            this.panel1.Controls.Add(this.paneltxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 515);
            this.panel1.TabIndex = 0;
            // 
            // paneleditordetexto
            // 
            this.paneleditordetexto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paneleditordetexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneleditordetexto.Location = new System.Drawing.Point(358, 0);
            this.paneleditordetexto.Name = "paneleditordetexto";
            this.paneleditordetexto.Size = new System.Drawing.Size(686, 515);
            this.paneleditordetexto.TabIndex = 1;
            this.paneleditordetexto.Paint += new System.Windows.Forms.PaintEventHandler(this.paneleditordetexto_Paint);
            // 
            // paneltxt
            // 
            this.paneltxt.Controls.Add(this.button1);
            this.paneltxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneltxt.Location = new System.Drawing.Point(0, 0);
            this.paneltxt.Name = "paneltxt";
            this.paneltxt.Size = new System.Drawing.Size(358, 515);
            this.paneltxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentaContadoParticulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 515);
            this.Controls.Add(this.panel1);
            this.Name = "VentaContadoParticulares";
            this.Text = "VentaContadoParticulares";
            this.Load += new System.EventHandler(this.VentaContadoParticulares_Load);
            this.panel1.ResumeLayout(false);
            this.paneltxt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneltxt;
        public System.Windows.Forms.Panel paneleditordetexto;
        private System.Windows.Forms.Button button1;
    }
}