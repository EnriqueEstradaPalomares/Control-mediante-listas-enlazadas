namespace Control_mediante_listas_enlazadas
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgrInicio = new System.Windows.Forms.Button();
            this.btnElimiPrimero = new System.Windows.Forms.Button();
            this.btnElimiUltimo = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnInverVista = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Pocision";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(375, 79);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(85, 20);
            this.txtPos.TabIndex = 34;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(247, 112);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 33;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(247, 77);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(247, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(247, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(14, 228);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(465, 197);
            this.txtLista.TabIndex = 29;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(105, 150);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 28;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(105, 115);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 27;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(105, 77);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descripsion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo";
            // 
            // btnAgrInicio
            // 
            this.btnAgrInicio.Location = new System.Drawing.Point(9, 185);
            this.btnAgrInicio.Name = "btnAgrInicio";
            this.btnAgrInicio.Size = new System.Drawing.Size(90, 23);
            this.btnAgrInicio.TabIndex = 36;
            this.btnAgrInicio.Text = "Agregar Inicio";
            this.btnAgrInicio.UseVisualStyleBackColor = true;
            this.btnAgrInicio.Click += new System.EventHandler(this.btnAgrInicio_Click);
            // 
            // btnElimiPrimero
            // 
            this.btnElimiPrimero.Location = new System.Drawing.Point(105, 185);
            this.btnElimiPrimero.Name = "btnElimiPrimero";
            this.btnElimiPrimero.Size = new System.Drawing.Size(90, 23);
            this.btnElimiPrimero.TabIndex = 37;
            this.btnElimiPrimero.Text = "Eliminar Primero";
            this.btnElimiPrimero.UseVisualStyleBackColor = true;
            this.btnElimiPrimero.Click += new System.EventHandler(this.btnElimiPrimero_Click);
            // 
            // btnElimiUltimo
            // 
            this.btnElimiUltimo.Location = new System.Drawing.Point(201, 185);
            this.btnElimiUltimo.Name = "btnElimiUltimo";
            this.btnElimiUltimo.Size = new System.Drawing.Size(90, 23);
            this.btnElimiUltimo.TabIndex = 38;
            this.btnElimiUltimo.Text = "Eliminar Ultimo";
            this.btnElimiUltimo.UseVisualStyleBackColor = true;
            this.btnElimiUltimo.Click += new System.EventHandler(this.btnElimiUltimo_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(297, 185);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(90, 37);
            this.btnReporte.TabIndex = 39;
            this.btnReporte.Text = "Reporte Inverso";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnInverVista
            // 
            this.btnInverVista.Location = new System.Drawing.Point(393, 185);
            this.btnInverVista.Name = "btnInverVista";
            this.btnInverVista.Size = new System.Drawing.Size(90, 23);
            this.btnInverVista.TabIndex = 40;
            this.btnInverVista.Text = "Invertir vista";
            this.btnInverVista.UseVisualStyleBackColor = true;
            this.btnInverVista.Click += new System.EventHandler(this.btnInverVista_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(247, 147);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 41;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 437);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnInverVista);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnElimiUltimo);
            this.Controls.Add(this.btnElimiPrimero);
            this.Controls.Add(this.btnAgrInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgrInicio;
        private System.Windows.Forms.Button btnElimiPrimero;
        private System.Windows.Forms.Button btnElimiUltimo;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnInverVista;
        private System.Windows.Forms.Button btnInsertar;
    }
}

