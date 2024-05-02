namespace C_Presentacion
{
    partial class F_Principal_CP
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
            this.StripMenuItem_Registrar_Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Producto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_Registrar_Ventas,
            this.formulariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuItem_Registrar_Ventas
            // 
            this.StripMenuItem_Registrar_Ventas.Name = "StripMenuItem_Registrar_Ventas";
            this.StripMenuItem_Registrar_Ventas.Size = new System.Drawing.Size(102, 20);
            this.StripMenuItem_Registrar_Ventas.Text = "Registrar Ventas";
            this.StripMenuItem_Registrar_Ventas.Click += new System.EventHandler(this.StripMenuItem_Registrar_Ventas_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_Cliente,
            this.StripMenuItem_Producto});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // StripMenuItem_Cliente
            // 
            this.StripMenuItem_Cliente.Name = "StripMenuItem_Cliente";
            this.StripMenuItem_Cliente.Size = new System.Drawing.Size(123, 22);
            this.StripMenuItem_Cliente.Text = "Cliente";
            this.StripMenuItem_Cliente.Click += new System.EventHandler(this.StripMenuItem_Cliente_Click_1);
            // 
            // StripMenuItem_Producto
            // 
            this.StripMenuItem_Producto.Name = "StripMenuItem_Producto";
            this.StripMenuItem_Producto.Size = new System.Drawing.Size(123, 22);
            this.StripMenuItem_Producto.Text = "Producto";
            this.StripMenuItem_Producto.Click += new System.EventHandler(this.StripMenuItem_Producto_Click_1);
            // 
            // F_Principal_CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Principal_CP";
            this.Text = "F_Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Registrar_Ventas;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Cliente;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Producto;
    }
}