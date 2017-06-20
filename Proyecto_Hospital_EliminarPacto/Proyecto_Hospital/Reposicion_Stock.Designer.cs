namespace Proyecto_Hospital
{
    partial class Reposicion_Stock
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtotal = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtgReposicion = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pacto_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpacto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.brnbguardar = new System.Windows.Forms.Button();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReposicion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 77;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 13);
            this.lblCodigo.TabIndex = 76;
            this.lblCodigo.Text = "ingrese codigo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(262, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 45);
            this.btnBuscar.TabIndex = 75;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(854, 118);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(82, 47);
            this.btnMostrar.TabIndex = 74;
            this.btnMostrar.Text = "mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // txtotal
            // 
            this.txtotal.Location = new System.Drawing.Point(1030, 418);
            this.txtotal.Name = "txtotal";
            this.txtotal.ReadOnly = true;
            this.txtotal.Size = new System.Drawing.Size(49, 20);
            this.txtotal.TabIndex = 73;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(956, 418);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.ReadOnly = true;
            this.txtcosto.Size = new System.Drawing.Size(49, 20);
            this.txtcosto.TabIndex = 72;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(905, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 71;
            this.lblTotal.Text = "Total";
            // 
            // dtgReposicion
            // 
            this.dtgReposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReposicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.codigo_stock,
            this.descripcion,
            this.unidad_medida,
            this.pacto_stocks,
            this.frecuencia,
            this.Existencia,
            this.entregado,
            this.pendiente,
            this.costo_unitario,
            this.costo_total});
            this.dtgReposicion.Location = new System.Drawing.Point(48, 193);
            this.dtgReposicion.Name = "dtgReposicion";
            this.dtgReposicion.Size = new System.Drawing.Size(1086, 201);
            this.dtgReposicion.TabIndex = 70;
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
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // entregado
            // 
            this.entregado.HeaderText = "Entregado";
            this.entregado.Name = "entregado";
            // 
            // pendiente
            // 
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
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
            // tpacto
            // 
            this.tpacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpacto.Location = new System.Drawing.Point(814, 43);
            this.tpacto.Name = "tpacto";
            this.tpacto.Size = new System.Drawing.Size(91, 20);
            this.tpacto.TabIndex = 69;
            this.tpacto.Text = "32301-RS-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Numero de Pacto de Stock";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(690, 65);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 45);
            this.btncancelar.TabIndex = 67;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // brnbguardar
            // 
            this.brnbguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnbguardar.Location = new System.Drawing.Point(597, 65);
            this.brnbguardar.Name = "brnbguardar";
            this.brnbguardar.Size = new System.Drawing.Size(68, 45);
            this.brnbguardar.TabIndex = 66;
            this.brnbguardar.Text = "Guardar";
            this.brnbguardar.UseVisualStyleBackColor = true;
            this.brnbguardar.Click += new System.EventHandler(this.brnbguardar_Click_1);
            // 
            // dtfecha
            // 
            this.dtfecha.CustomFormat = "dd/mm/yyyy";
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha.Location = new System.Drawing.Point(539, 167);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(97, 20);
            this.dtfecha.TabIndex = 65;
            this.dtfecha.Value = new System.DateTime(2017, 5, 30, 21, 8, 46, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(464, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "MATERIAL MEDICO QUIRURGICO Y SUEROS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "PACTO DE STOCK ENTRE ALMACEN SALA/SERVICIO";
            // 
            // txtsala
            // 
            this.txtsala.Location = new System.Drawing.Point(579, 129);
            this.txtsala.Name = "txtsala";
            this.txtsala.Size = new System.Drawing.Size(234, 20);
            this.txtsala.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "Secretaria De Salud";
            // 
            // Reposicion_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 467);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtotal);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtgReposicion);
            this.Controls.Add(this.tpacto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.brnbguardar);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsala);
            this.Controls.Add(this.label1);
            this.Name = "Reposicion_Stock";
            this.Text = "Reposicion_Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dtgReposicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtotal;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dtgReposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacto_stocks;
        private System.Windows.Forms.DataGridViewComboBoxColumn frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total;
        private System.Windows.Forms.TextBox tpacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button brnbguardar;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsala;
        private System.Windows.Forms.Label label1;
    }
}