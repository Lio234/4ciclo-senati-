namespace C_Presentacion
{
    partial class Registro_ventas_CP
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
            this.label_Fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_producto_buscar = new System.Windows.Forms.Button();
            this.btn_cliente_buscar = new System.Windows.Forms.Button();
            this.btn_Cerar = new System.Windows.Forms.Button();
            this.btn_detalle_guardar = new System.Windows.Forms.Button();
            this.btn_detalle_Agregar = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_cliente_id = new System.Windows.Forms.TextBox();
            this.txt_Detalle_Total = new System.Windows.Forms.TextBox();
            this.txt_Detalle_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_producto_precio = new System.Windows.Forms.TextBox();
            this.txt_producto_descripcion = new System.Windows.Forms.TextBox();
            this.txt_producto_id = new System.Windows.Forms.TextBox();
            this.txt_cliente_nombre = new System.Windows.Forms.TextBox();
            this.dgv_registroVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registroVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Location = new System.Drawing.Point(25, 40);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(40, 13);
            this.label_Fecha.TabIndex = 0;
            this.label_Fecha.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Total S/.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalle de Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio x U.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Producto";
            // 
            // btn_producto_buscar
            // 
            this.btn_producto_buscar.Location = new System.Drawing.Point(147, 147);
            this.btn_producto_buscar.Name = "btn_producto_buscar";
            this.btn_producto_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_producto_buscar.TabIndex = 8;
            this.btn_producto_buscar.Text = "Buscar";
            this.btn_producto_buscar.UseVisualStyleBackColor = true;
            this.btn_producto_buscar.Click += new System.EventHandler(this.btn_producto_buscar_Click);
            // 
            // btn_cliente_buscar
            // 
            this.btn_cliente_buscar.Location = new System.Drawing.Point(147, 75);
            this.btn_cliente_buscar.Name = "btn_cliente_buscar";
            this.btn_cliente_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_buscar.TabIndex = 9;
            this.btn_cliente_buscar.Text = "Buscar";
            this.btn_cliente_buscar.UseVisualStyleBackColor = true;
            this.btn_cliente_buscar.Click += new System.EventHandler(this.btn_cliente_buscar_Click);
            // 
            // btn_Cerar
            // 
            this.btn_Cerar.Location = new System.Drawing.Point(364, 456);
            this.btn_Cerar.Name = "btn_Cerar";
            this.btn_Cerar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerar.TabIndex = 10;
            this.btn_Cerar.Text = "Cerar";
            this.btn_Cerar.UseVisualStyleBackColor = true;
            this.btn_Cerar.Click += new System.EventHandler(this.btn_Cerar_Click);
            // 
            // btn_detalle_guardar
            // 
            this.btn_detalle_guardar.Location = new System.Drawing.Point(15, 456);
            this.btn_detalle_guardar.Name = "btn_detalle_guardar";
            this.btn_detalle_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_detalle_guardar.TabIndex = 11;
            this.btn_detalle_guardar.Text = "Guardar";
            this.btn_detalle_guardar.UseVisualStyleBackColor = true;
            this.btn_detalle_guardar.Click += new System.EventHandler(this.btn_detalle_guardar_Click);
            // 
            // btn_detalle_Agregar
            // 
            this.btn_detalle_Agregar.Location = new System.Drawing.Point(538, 148);
            this.btn_detalle_Agregar.Name = "btn_detalle_Agregar";
            this.btn_detalle_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_detalle_Agregar.TabIndex = 12;
            this.btn_detalle_Agregar.Text = "Agregar";
            this.btn_detalle_Agregar.UseVisualStyleBackColor = true;
            this.btn_detalle_Agregar.Click += new System.EventHandler(this.btn_detalle_Agregar_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(66, 37);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(185, 20);
            this.txt_fecha.TabIndex = 13;
            // 
            // txt_cliente_id
            // 
            this.txt_cliente_id.Location = new System.Drawing.Point(71, 75);
            this.txt_cliente_id.Name = "txt_cliente_id";
            this.txt_cliente_id.Size = new System.Drawing.Size(70, 20);
            this.txt_cliente_id.TabIndex = 14;
            // 
            // txt_Detalle_Total
            // 
            this.txt_Detalle_Total.Location = new System.Drawing.Point(513, 456);
            this.txt_Detalle_Total.Name = "txt_Detalle_Total";
            this.txt_Detalle_Total.ReadOnly = true;
            this.txt_Detalle_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Detalle_Total.TabIndex = 16;
            // 
            // txt_Detalle_Cantidad
            // 
            this.txt_Detalle_Cantidad.Location = new System.Drawing.Point(454, 150);
            this.txt_Detalle_Cantidad.Name = "txt_Detalle_Cantidad";
            this.txt_Detalle_Cantidad.Size = new System.Drawing.Size(78, 20);
            this.txt_Detalle_Cantidad.TabIndex = 17;
            // 
            // txt_producto_precio
            // 
            this.txt_producto_precio.Location = new System.Drawing.Point(383, 149);
            this.txt_producto_precio.Name = "txt_producto_precio";
            this.txt_producto_precio.ReadOnly = true;
            this.txt_producto_precio.Size = new System.Drawing.Size(65, 20);
            this.txt_producto_precio.TabIndex = 18;
            // 
            // txt_producto_descripcion
            // 
            this.txt_producto_descripcion.Location = new System.Drawing.Point(228, 149);
            this.txt_producto_descripcion.Name = "txt_producto_descripcion";
            this.txt_producto_descripcion.ReadOnly = true;
            this.txt_producto_descripcion.Size = new System.Drawing.Size(146, 20);
            this.txt_producto_descripcion.TabIndex = 19;
            // 
            // txt_producto_id
            // 
            this.txt_producto_id.Location = new System.Drawing.Point(71, 149);
            this.txt_producto_id.Name = "txt_producto_id";
            this.txt_producto_id.Size = new System.Drawing.Size(70, 20);
            this.txt_producto_id.TabIndex = 20;
            // 
            // txt_cliente_nombre
            // 
            this.txt_cliente_nombre.Location = new System.Drawing.Point(228, 76);
            this.txt_cliente_nombre.Name = "txt_cliente_nombre";
            this.txt_cliente_nombre.ReadOnly = true;
            this.txt_cliente_nombre.Size = new System.Drawing.Size(292, 20);
            this.txt_cliente_nombre.TabIndex = 21;
            // 
            // dgv_registroVentas
            // 
            this.dgv_registroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registroVentas.Location = new System.Drawing.Point(11, 177);
            this.dgv_registroVentas.Name = "dgv_registroVentas";
            this.dgv_registroVentas.Size = new System.Drawing.Size(602, 273);
            this.dgv_registroVentas.TabIndex = 22;
            this.dgv_registroVentas.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_registroVentas_UserDeletedRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Detalle de Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Producto";
            // 
            // Registro_ventas_CP
            // 
            this.AccessibleName = "sdsa";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 498);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Detalle_Cantidad);
            this.Controls.Add(this.dgv_registroVentas);
            this.Controls.Add(this.txt_cliente_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Detalle_Total);
            this.Controls.Add(this.txt_producto_descripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cliente_id);
            this.Controls.Add(this.txt_producto_id);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_detalle_Agregar);
            this.Controls.Add(this.btn_producto_buscar);
            this.Controls.Add(this.btn_detalle_guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Cerar);
            this.Controls.Add(this.txt_producto_precio);
            this.Controls.Add(this.btn_cliente_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registro_ventas_CP";
            this.Text = "Registro_ventas_CP";
            this.Load += new System.EventHandler(this.Registro_ventas_CP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registroVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_producto_buscar;
        private System.Windows.Forms.Button btn_cliente_buscar;
        private System.Windows.Forms.Button btn_Cerar;
        private System.Windows.Forms.Button btn_detalle_guardar;
        private System.Windows.Forms.Button btn_detalle_Agregar;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_cliente_id;
        private System.Windows.Forms.TextBox txt_Detalle_Total;
        private System.Windows.Forms.TextBox txt_Detalle_Cantidad;
        private System.Windows.Forms.TextBox txt_producto_precio;
        private System.Windows.Forms.TextBox txt_producto_descripcion;
        private System.Windows.Forms.TextBox txt_producto_id;
        private System.Windows.Forms.TextBox txt_cliente_nombre;
        private System.Windows.Forms.DataGridView dgv_registroVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}