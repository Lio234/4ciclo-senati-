namespace C_Presentacion
{
    partial class Cliente_CP
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
            this.btn_dgv_cliente_buscar = new System.Windows.Forms.Button();
            this.txt_cliente_buscar_nombre = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txt_cliente_direccion = new System.Windows.Forms.TextBox();
            this.txt_cliente_tel = new System.Windows.Forms.TextBox();
            this.txt_cliente_ruc = new System.Windows.Forms.TextBox();
            this.txt_cliente_nombre = new System.Windows.Forms.TextBox();
            this.txt_cliente_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cliente_eliminar = new System.Windows.Forms.Button();
            this.btn_cliente_guardar = new System.Windows.Forms.Button();
            this.btn_cliente_nuevo = new System.Windows.Forms.Button();
            this.btn_cliente_buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dgv_cliente_buscar
            // 
            this.btn_dgv_cliente_buscar.Location = new System.Drawing.Point(277, 212);
            this.btn_dgv_cliente_buscar.Name = "btn_dgv_cliente_buscar";
            this.btn_dgv_cliente_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_dgv_cliente_buscar.TabIndex = 33;
            this.btn_dgv_cliente_buscar.Text = "Buscar";
            this.btn_dgv_cliente_buscar.UseVisualStyleBackColor = true;
            this.btn_dgv_cliente_buscar.Click += new System.EventHandler(this.btn_dgv_buscar_Click);
            // 
            // txt_cliente_buscar_nombre
            // 
            this.txt_cliente_buscar_nombre.Location = new System.Drawing.Point(13, 214);
            this.txt_cliente_buscar_nombre.Name = "txt_cliente_buscar_nombre";
            this.txt_cliente_buscar_nombre.Size = new System.Drawing.Size(258, 20);
            this.txt_cliente_buscar_nombre.TabIndex = 32;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(13, 240);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(339, 150);
            this.dgvCliente.TabIndex = 31;
            this.dgvCliente.SelectionChanged += new System.EventHandler(this.dgvCliente_SelectionChanged);
            // 
            // txt_cliente_direccion
            // 
            this.txt_cliente_direccion.Location = new System.Drawing.Point(68, 179);
            this.txt_cliente_direccion.Name = "txt_cliente_direccion";
            this.txt_cliente_direccion.Size = new System.Drawing.Size(181, 20);
            this.txt_cliente_direccion.TabIndex = 30;
            // 
            // txt_cliente_tel
            // 
            this.txt_cliente_tel.Location = new System.Drawing.Point(68, 150);
            this.txt_cliente_tel.Name = "txt_cliente_tel";
            this.txt_cliente_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente_tel.TabIndex = 29;
            // 
            // txt_cliente_ruc
            // 
            this.txt_cliente_ruc.Location = new System.Drawing.Point(68, 120);
            this.txt_cliente_ruc.Name = "txt_cliente_ruc";
            this.txt_cliente_ruc.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente_ruc.TabIndex = 28;
            // 
            // txt_cliente_nombre
            // 
            this.txt_cliente_nombre.Location = new System.Drawing.Point(68, 91);
            this.txt_cliente_nombre.Name = "txt_cliente_nombre";
            this.txt_cliente_nombre.Size = new System.Drawing.Size(181, 20);
            this.txt_cliente_nombre.TabIndex = 27;
            // 
            // txt_cliente_id
            // 
            this.txt_cliente_id.Location = new System.Drawing.Point(68, 58);
            this.txt_cliente_id.Name = "txt_cliente_id";
            this.txt_cliente_id.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente_id.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Télefono";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "RUC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_cliente_eliminar
            // 
            this.btn_cliente_eliminar.Location = new System.Drawing.Point(276, 113);
            this.btn_cliente_eliminar.Name = "btn_cliente_eliminar";
            this.btn_cliente_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_eliminar.TabIndex = 20;
            this.btn_cliente_eliminar.Text = "Eliminar";
            this.btn_cliente_eliminar.UseVisualStyleBackColor = true;
            this.btn_cliente_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cliente_guardar
            // 
            this.btn_cliente_guardar.Location = new System.Drawing.Point(276, 84);
            this.btn_cliente_guardar.Name = "btn_cliente_guardar";
            this.btn_cliente_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_guardar.TabIndex = 19;
            this.btn_cliente_guardar.Text = "Guardar";
            this.btn_cliente_guardar.UseVisualStyleBackColor = true;
            this.btn_cliente_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cliente_nuevo
            // 
            this.btn_cliente_nuevo.Location = new System.Drawing.Point(276, 55);
            this.btn_cliente_nuevo.Name = "btn_cliente_nuevo";
            this.btn_cliente_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_nuevo.TabIndex = 18;
            this.btn_cliente_nuevo.Text = "Nuevo";
            this.btn_cliente_nuevo.UseVisualStyleBackColor = true;
            this.btn_cliente_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_cliente_buscar
            // 
            this.btn_cliente_buscar.Location = new System.Drawing.Point(174, 55);
            this.btn_cliente_buscar.Name = "btn_cliente_buscar";
            this.btn_cliente_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_buscar.TabIndex = 17;
            this.btn_cliente_buscar.Text = "Buscar";
            this.btn_cliente_buscar.UseVisualStyleBackColor = true;
            this.btn_cliente_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cliente";
            // 
            // Cliente_CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_dgv_cliente_buscar);
            this.Controls.Add(this.txt_cliente_buscar_nombre);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txt_cliente_direccion);
            this.Controls.Add(this.txt_cliente_tel);
            this.Controls.Add(this.txt_cliente_ruc);
            this.Controls.Add(this.txt_cliente_nombre);
            this.Controls.Add(this.txt_cliente_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cliente_eliminar);
            this.Controls.Add(this.btn_cliente_guardar);
            this.Controls.Add(this.btn_cliente_nuevo);
            this.Controls.Add(this.btn_cliente_buscar);
            this.Name = "Cliente_CP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cliente_CP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dgv_cliente_buscar;
        private System.Windows.Forms.TextBox txt_cliente_buscar_nombre;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txt_cliente_direccion;
        private System.Windows.Forms.TextBox txt_cliente_tel;
        private System.Windows.Forms.TextBox txt_cliente_ruc;
        private System.Windows.Forms.TextBox txt_cliente_nombre;
        private System.Windows.Forms.TextBox txt_cliente_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cliente_eliminar;
        private System.Windows.Forms.Button btn_cliente_guardar;
        private System.Windows.Forms.Button btn_cliente_nuevo;
        private System.Windows.Forms.Button btn_cliente_buscar;
        private System.Windows.Forms.Label label6;
    }
}

