namespace Proyecto_Hospital
{
    partial class Pacto
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
            this.tpacto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bcancelar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tsala = new System.Windows.Forms.TextBox();
            this.tdepart = new System.Windows.Forms.TextBox();
            this.thospital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgpacto = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pacto_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.costo_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttotal = new System.Windows.Forms.TextBox();
            this.tcosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgpacto)).BeginInit();
            this.SuspendLayout();
            // 
            // tpacto
            // 
            this.tpacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpacto.Location = new System.Drawing.Point(780, 23);
            this.tpacto.Name = "tpacto";
            this.tpacto.Size = new System.Drawing.Size(98, 20);
            this.tpacto.TabIndex = 31;
            this.tpacto.Text = "32301-RS-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Numero de Pacto de Stock";
            // 
            // bcancelar
            // 
            this.bcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.Location = new System.Drawing.Point(656, 43);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(82, 47);
            this.bcancelar.TabIndex = 29;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(575, 43);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(75, 47);
            this.bguardar.TabIndex = 28;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // dtfecha
            // 
            this.dtfecha.CustomFormat = "dd/mm/yyyy";
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha.Location = new System.Drawing.Point(505, 147);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(104, 20);
            this.dtfecha.TabIndex = 27;
            this.dtfecha.Value = new System.DateTime(2017, 5, 30, 21, 8, 46, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(437, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "MATERIAL MEDICO QUIRURGICO Y SUEROS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "PACTO DE STOCK ENTRE ALMACEN SALA/SERVICIO";
            // 
            // tsala
            // 
            this.tsala.Location = new System.Drawing.Point(545, 109);
            this.tsala.Name = "tsala";
            this.tsala.Size = new System.Drawing.Size(241, 20);
            this.tsala.TabIndex = 23;
            // 
            // tdepart
            // 
            this.tdepart.Location = new System.Drawing.Point(179, 66);
            this.tdepart.Name = "tdepart";
            this.tdepart.Size = new System.Drawing.Size(122, 20);
            this.tdepart.TabIndex = 22;
            // 
            // thospital
            // 
            this.thospital.Location = new System.Drawing.Point(67, 43);
            this.thospital.Name = "thospital";
            this.thospital.Size = new System.Drawing.Size(221, 20);
            this.thospital.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "MUNICIPIO, DEPARTAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "HOSPITAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Secretaria De Salud";
            // 
            // dgpacto
            // 
            this.dgpacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.codigo_stock,
            this.descripcion,
            this.unidad_medida,
            this.pacto_stocks,
            this.frecuencia,
            this.costo_unitario,
            this.costo_total});
            this.dgpacto.Location = new System.Drawing.Point(16, 183);
            this.dgpacto.Name = "dgpacto";
            this.dgpacto.Size = new System.Drawing.Size(869, 203);
            this.dgpacto.TabIndex = 32;
            // 
            // numero
            // 
            this.numero.HeaderText = "N#";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numero.Width = 30;
            // 
            // codigo_stock
            // 
            this.codigo_stock.DataPropertyName = "codigo_stock";
            this.codigo_stock.HeaderText = "Codigo";
            this.codigo_stock.Name = "codigo_stock";
            this.codigo_stock.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 400;
            // 
            // unidad_medida
            // 
            this.unidad_medida.DataPropertyName = "unidad_medida";
            this.unidad_medida.FillWeight = 70F;
            this.unidad_medida.HeaderText = "Unidad de Medida";
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unidad_medida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unidad_medida.Width = 70;
            // 
            // pacto_stocks
            // 
            this.pacto_stocks.DataPropertyName = "pacto_stocks";
            this.pacto_stocks.FillWeight = 70F;
            this.pacto_stocks.HeaderText = "Pacto de Stock";
            this.pacto_stocks.Name = "pacto_stocks";
            this.pacto_stocks.Width = 70;
            // 
            // frecuencia
            // 
            this.frecuencia.DataPropertyName = "frecuencia";
            this.frecuencia.FillWeight = 70F;
            this.frecuencia.HeaderText = "Frecuencia";
            this.frecuencia.Name = "frecuencia";
            this.frecuencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.frecuencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.frecuencia.Width = 70;
            // 
            // costo_unitario
            // 
            this.costo_unitario.DataPropertyName = "costo_unitario";
            this.costo_unitario.FillWeight = 50F;
            this.costo_unitario.HeaderText = "Costo Unitario";
            this.costo_unitario.Name = "costo_unitario";
            this.costo_unitario.Width = 70;
            // 
            // costo_total
            // 
            this.costo_total.DataPropertyName = "costo_total";
            this.costo_total.FillWeight = 50F;
            this.costo_total.HeaderText = "Costo Total";
            this.costo_total.Name = "costo_total";
            this.costo_total.Width = 60;
            // 
            // ttotal
            // 
            this.ttotal.Location = new System.Drawing.Point(822, 392);
            this.ttotal.Name = "ttotal";
            this.ttotal.ReadOnly = true;
            this.ttotal.Size = new System.Drawing.Size(56, 20);
            this.ttotal.TabIndex = 35;
            // 
            // tcosto
            // 
            this.tcosto.Location = new System.Drawing.Point(760, 392);
            this.tcosto.Name = "tcosto";
            this.tcosto.ReadOnly = true;
            this.tcosto.Size = new System.Drawing.Size(56, 20);
            this.tcosto.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(757, 418);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(106, 35);
            this.btncalcular.TabIndex = 37;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Pacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 482);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.ttotal);
            this.Controls.Add(this.tcosto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgpacto);
            this.Controls.Add(this.tpacto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsala);
            this.Controls.Add(this.tdepart);
            this.Controls.Add(this.thospital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacto";
            this.Load += new System.EventHandler(this.Pacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tpacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tsala;
        private System.Windows.Forms.TextBox tdepart;
        private System.Windows.Forms.TextBox thospital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgpacto;
        private System.Windows.Forms.TextBox ttotal;
        private System.Windows.Forms.TextBox tcosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacto_stocks;
        private System.Windows.Forms.DataGridViewComboBoxColumn frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total;
        private System.Windows.Forms.Button btncalcular;
    }
}