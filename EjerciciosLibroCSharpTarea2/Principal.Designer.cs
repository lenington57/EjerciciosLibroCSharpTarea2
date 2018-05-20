namespace BibliaRegistro
{
    partial class RegistrosForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosBibliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.bibliaToolStripMenuItem,
            this.ayudaStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosBibliaToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // librosBibliaToolStripMenuItem
            // 
            this.librosBibliaToolStripMenuItem.Name = "librosBibliaToolStripMenuItem";
            this.librosBibliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.librosBibliaToolStripMenuItem.Text = "Libros Biblia";
            this.librosBibliaToolStripMenuItem.Click += new System.EventHandler(this.librosBibliaToolStripMenuItem_Click);
            // 
            // bibliaToolStripMenuItem
            // 
            this.bibliaToolStripMenuItem.Name = "bibliaToolStripMenuItem";
            this.bibliaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.bibliaToolStripMenuItem.Text = "Consultar";
            // 
            // ayudaStripMenuItem
            // 
            this.ayudaStripMenuItem.Name = "ayudaStripMenuItem";
            this.ayudaStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaStripMenuItem.Text = "Ayuda";
            // 
            // RegistrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 382);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrosForm";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosBibliaToolStripMenuItem;
    }
}

