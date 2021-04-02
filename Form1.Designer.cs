namespace Actividad_Integradora_4_Problema_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtVigencia = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVencidos = new System.Windows.Forms.Button();
            this.btnOld = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vigencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Modelo:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(93, 48);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(135, 20);
            this.txtAño.TabIndex = 6;
            // 
            // txtVigencia
            // 
            this.txtVigencia.Location = new System.Drawing.Point(93, 80);
            this.txtVigencia.Name = "txtVigencia";
            this.txtVigencia.Size = new System.Drawing.Size(135, 20);
            this.txtVigencia.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(93, 112);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(135, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(93, 145);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(135, 20);
            this.txtPlacas.TabIndex = 9;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(93, 179);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(135, 20);
            this.txtColor.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(93, 209);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(135, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(103, 261);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvAutos
            // 
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Año,
            this.Vigencia,
            this.Marca,
            this.Placas,
            this.Color,
            this.Modelo});
            this.dgvAutos.Location = new System.Drawing.Point(286, 48);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.Size = new System.Drawing.Size(641, 239);
            this.dgvAutos.TabIndex = 13;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Vigencia
            // 
            this.Vigencia.HeaderText = "Vigencia";
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Placas
            // 
            this.Placas.HeaderText = "Placas";
            this.Placas.Name = "Placas";
            this.Placas.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // btnVencidos
            // 
            this.btnVencidos.Location = new System.Drawing.Point(319, 305);
            this.btnVencidos.Name = "btnVencidos";
            this.btnVencidos.Size = new System.Drawing.Size(75, 23);
            this.btnVencidos.TabIndex = 14;
            this.btnVencidos.Text = "Vencidos";
            this.btnVencidos.UseVisualStyleBackColor = true;
            this.btnVencidos.Click += new System.EventHandler(this.btnVencidos_Click);
            // 
            // btnOld
            // 
            this.btnOld.Location = new System.Drawing.Point(430, 305);
            this.btnOld.Name = "btnOld";
            this.btnOld.Size = new System.Drawing.Size(75, 23);
            this.btnOld.TabIndex = 15;
            this.btnOld.Text = "Modelos old";
            this.btnOld.UseVisualStyleBackColor = true;
            this.btnOld.Click += new System.EventHandler(this.btnOld_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(539, 305);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 16;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 367);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnOld);
            this.Controls.Add(this.btnVencidos);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtVigencia);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Actividad Integradora 4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtVigencia;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.Button btnVencidos;
        private System.Windows.Forms.Button btnOld;
        private System.Windows.Forms.Button btnTodos;
    }
}

