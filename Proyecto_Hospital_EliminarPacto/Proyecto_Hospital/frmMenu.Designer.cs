namespace Proyecto_Hospital
{
    partial class frmMenu
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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pactoDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reposicionDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.pactoDeStockToolStripMenuItem,
            this.reposicionDeStockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar ";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // pactoDeStockToolStripMenuItem
            // 
            this.pactoDeStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.pactoDeStockToolStripMenuItem.Enabled = false;
            this.pactoDeStockToolStripMenuItem.Name = "pactoDeStockToolStripMenuItem";
            this.pactoDeStockToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.pactoDeStockToolStripMenuItem.Text = "Pacto de Stock";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarToolStripMenuItem.Text = "Buscar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // reposicionDeStockToolStripMenuItem
            // 
            this.reposicionDeStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.mostrarToolStripMenuItem1});
            this.reposicionDeStockToolStripMenuItem.Enabled = false;
            this.reposicionDeStockToolStripMenuItem.Name = "reposicionDeStockToolStripMenuItem";
            this.reposicionDeStockToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.reposicionDeStockToolStripMenuItem.Text = "Reposicion de Stock";
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            this.mostrarToolStripMenuItem1.Click += new System.EventHandler(this.mostrarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 241);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pactoDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reposicionDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}