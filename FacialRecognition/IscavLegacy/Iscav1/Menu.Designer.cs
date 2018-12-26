namespace Iscav1
{
    partial class Menu
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.enrolarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(426, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propietarioToolStripMenuItem,
            this.propiedadToolStripMenuItem,
            this.residenteToolStripMenuItem,
            this.visitaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // propietarioToolStripMenuItem
            // 
            this.propietarioToolStripMenuItem.Name = "propietarioToolStripMenuItem";
            this.propietarioToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.propietarioToolStripMenuItem.Text = "Propietario";
            this.propietarioToolStripMenuItem.Click += new System.EventHandler(this.propietarioToolStripMenuItem_Click);
            // 
            // propiedadToolStripMenuItem
            // 
            this.propiedadToolStripMenuItem.Name = "propiedadToolStripMenuItem";
            this.propiedadToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.propiedadToolStripMenuItem.Text = "Propiedad";
            this.propiedadToolStripMenuItem.Click += new System.EventHandler(this.propiedadToolStripMenuItem_Click);
            // 
            // residenteToolStripMenuItem
            // 
            this.residenteToolStripMenuItem.Name = "residenteToolStripMenuItem";
            this.residenteToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.residenteToolStripMenuItem.Text = "Residente";
            this.residenteToolStripMenuItem.Click += new System.EventHandler(this.residenteToolStripMenuItem_Click);
            // 
            // visitaToolStripMenuItem
            // 
            this.visitaToolStripMenuItem.Name = "visitaToolStripMenuItem";
            this.visitaToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.visitaToolStripMenuItem.Text = "Visita";
            this.visitaToolStripMenuItem.Click += new System.EventHandler(this.visitaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // enrolarToolStripMenuItem
            // 
            this.enrolarToolStripMenuItem.Name = "enrolarToolStripMenuItem";
            this.enrolarToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.enrolarToolStripMenuItem.Text = "Enrolar";
            this.enrolarToolStripMenuItem.Click += new System.EventHandler(this.enrolarToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrolarToolStripMenuItem;
    }
}