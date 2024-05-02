namespace C_Presentacion
{
    partial class Producto_CP
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_dgv_producto_buscar = new System.Windows.Forms.Button();
            this.txt_producto_buscar_descripcion = new System.Windows.Forms.TextBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.txt_producto_precio = new System.Windows.Forms.TextBox();
            this.txt_producto_categoria = new System.Windows.Forms.TextBox();
            this.txt_producto_descripcion = new System.Windows.Forms.TextBox();
            this.txt_producto_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_producto_eliminar = new System.Windows.Forms.Button();
            this.btn_producto_guardar = new System.Windows.Forms.Button();
            this.btn_producto_nuevo = new System.Windows.Forms.Button();
            this.btn_producto_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Producto";
            // 
            // btn_dgv_producto_buscar
            // 
            this.btn_dgv_producto_buscar.Location = new System.Drawing.Point(284, 212);
            this.btn_dgv_producto_buscar.Name = "btn_dgv_producto_buscar";
            this.btn_dgv_producto_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_dgv_producto_buscar.TabIndex = 51;
            this.btn_dgv_producto_buscar.Text = "Buscar";
            this.btn_dgv_producto_buscar.UseVisualStyleBackColor = true;
            this.btn_dgv_producto_buscar.Click += new System.EventHandler(this.btn_dgv_producto_buscar_Click);
            // 
            // txt_producto_buscar_descripcion
            // 
            this.txt_producto_buscar_descripcion.Location = new System.Drawing.Point(20, 214);
            this.txt_producto_buscar_descripcion.Name = "txt_producto_buscar_descripcion";
            this.txt_producto_buscar_descripcion.Size = new System.Drawing.Size(258, 20);
            this.txt_producto_buscar_descripcion.TabIndex = 50;
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(20, 240);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(339, 150);
            this.dgvProducto.TabIndex = 49;
            this.dgvProducto.SelectionChanged += new System.EventHandler(this.dgvProducto_SelectionChanged);
            // 
            // txt_producto_precio
            // 
            this.txt_producto_precio.Location = new System.Drawing.Point(75, 150);
            this.txt_producto_precio.Name = "txt_producto_precio";
            this.txt_producto_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_producto_precio.TabIndex = 47;
            // 
            // txt_producto_categoria
            // 
            this.txt_producto_categoria.Location = new System.Drawing.Point(75, 120);
            this.txt_producto_categoria.Name = "txt_producto_categoria";
            this.txt_producto_categoria.Size = new System.Drawing.Size(100, 20);
            this.txt_producto_categoria.TabIndex = 46;
            // 
            // txt_producto_descripcion
            // 
            this.txt_producto_descripcion.Location = new System.Drawing.Point(75, 91);
            this.txt_producto_descripcion.Name = "txt_producto_descripcion";
            this.txt_producto_descripcion.Size = new System.Drawing.Size(181, 20);
            this.txt_producto_descripcion.TabIndex = 45;
            // 
            // txt_producto_id
            // 
            this.txt_producto_id.Location = new System.Drawing.Point(75, 58);
            this.txt_producto_id.Name = "txt_producto_id";
            this.txt_producto_id.Size = new System.Drawing.Size(100, 20);
            this.txt_producto_id.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Precio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Descripción";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_producto_eliminar
            // 
            this.btn_producto_eliminar.Location = new System.Drawing.Point(283, 113);
            this.btn_producto_eliminar.Name = "btn_producto_eliminar";
            this.btn_producto_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_producto_eliminar.TabIndex = 38;
            this.btn_producto_eliminar.Text = "Eliminar";
            this.btn_producto_eliminar.UseVisualStyleBackColor = true;
            this.btn_producto_eliminar.Click += new System.EventHandler(this.btn_producto_eliminar_Click);
            // 
            // btn_producto_guardar
            // 
            this.btn_producto_guardar.Location = new System.Drawing.Point(283, 84);
            this.btn_producto_guardar.Name = "btn_producto_guardar";
            this.btn_producto_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_producto_guardar.TabIndex = 37;
            this.btn_producto_guardar.Text = "Guardar";
            this.btn_producto_guardar.UseVisualStyleBackColor = true;
            this.btn_producto_guardar.Click += new System.EventHandler(this.btn_producto_guardar_Click);
            // 
            // btn_producto_nuevo
            // 
            this.btn_producto_nuevo.Location = new System.Drawing.Point(283, 55);
            this.btn_producto_nuevo.Name = "btn_producto_nuevo";
            this.btn_producto_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_producto_nuevo.TabIndex = 36;
            this.btn_producto_nuevo.Text = "Nuevo";
            this.btn_producto_nuevo.UseVisualStyleBackColor = true;
            this.btn_producto_nuevo.Click += new System.EventHandler(this.btn_producto_nuevo_Click);
            // 
            // btn_producto_buscar
            // 
            this.btn_producto_buscar.Location = new System.Drawing.Point(181, 55);
            this.btn_producto_buscar.Name = "btn_producto_buscar";
            this.btn_producto_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_producto_buscar.TabIndex = 35;
            this.btn_producto_buscar.Text = "Buscar";
            this.btn_producto_buscar.UseVisualStyleBackColor = true;
            this.btn_producto_buscar.Click += new System.EventHandler(this.btn_producto_buscar_Click);
            // 
            // Producto_CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 403);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_dgv_producto_buscar);
            this.Controls.Add(this.txt_producto_buscar_descripcion);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.txt_producto_precio);
            this.Controls.Add(this.txt_producto_categoria);
            this.Controls.Add(this.txt_producto_descripcion);
            this.Controls.Add(this.txt_producto_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_producto_eliminar);
            this.Controls.Add(this.btn_producto_guardar);
            this.Controls.Add(this.btn_producto_nuevo);
            this.Controls.Add(this.btn_producto_buscar);
            this.Name = "Producto_CP";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_dgv_producto_buscar;
        private System.Windows.Forms.TextBox txt_producto_buscar_descripcion;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TextBox txt_producto_precio;
        private System.Windows.Forms.TextBox txt_producto_categoria;
        private System.Windows.Forms.TextBox txt_producto_descripcion;
        private System.Windows.Forms.TextBox txt_producto_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_producto_eliminar;
        private System.Windows.Forms.Button btn_producto_guardar;
        private System.Windows.Forms.Button btn_producto_nuevo;
        private System.Windows.Forms.Button btn_producto_buscar;
    }
}