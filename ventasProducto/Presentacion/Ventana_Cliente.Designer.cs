namespace ventasProducto.Presentacion
{
    partial class Ventana_Cliente
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
            this.components = new System.ComponentModel.Container();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.combo_id = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ventaTableAdapter = new ventasProducto.Producto_diagramTableAdapters.ventaTableAdapter();
            this.datagrid_producto = new System.Windows.Forms.DataGridView();
            this.producto_diagram = new ventasProducto.Producto_diagram();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ventasProducto.Producto_diagramTableAdapters.clienteTableAdapter();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_diagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.combo_id);
            this.groupDatos.Controls.Add(this.textBox1);
            this.groupDatos.Controls.Add(this.label7);
            this.groupDatos.Controls.Add(this.txt_telefono);
            this.groupDatos.Controls.Add(this.label6);
            this.groupDatos.Controls.Add(this.txt_direccion);
            this.groupDatos.Controls.Add(this.label5);
            this.groupDatos.Controls.Add(this.txt_materno);
            this.groupDatos.Controls.Add(this.label4);
            this.groupDatos.Controls.Add(this.txt_paterno);
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.txt_nombres);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Location = new System.Drawing.Point(37, 12);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(603, 171);
            this.groupDatos.TabIndex = 0;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos";
            // 
            // combo_id
            // 
            this.combo_id.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.combo_id.DataSource = this.clienteBindingSource;
            this.combo_id.DisplayMember = "id_cliente";
            this.combo_id.FormattingEnabled = true;
            this.combo_id.Location = new System.Drawing.Point(31, 37);
            this.combo_id.Name = "combo_id";
            this.combo_id.Size = new System.Drawing.Size(76, 21);
            this.combo_id.TabIndex = 14;
            this.combo_id.ValueMember = "id_cliente";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "email", true));
            this.textBox1.Location = new System.Drawing.Point(74, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-mail";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_telefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "fono", true));
            this.txt_telefono.Location = new System.Drawing.Point(306, 79);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(168, 20);
            this.txt_telefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "direccion", true));
            this.txt_direccion.Location = new System.Drawing.Point(74, 79);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(168, 20);
            this.txt_direccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección:";
            // 
            // txt_materno
            // 
            this.txt_materno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_materno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "materno", true));
            this.txt_materno.Location = new System.Drawing.Point(496, 35);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(100, 20);
            this.txt_materno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Materno";
            // 
            // txt_paterno
            // 
            this.txt_paterno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_paterno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "paterno", true));
            this.txt_paterno.Location = new System.Drawing.Point(334, 35);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(100, 20);
            this.txt_paterno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paterno:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_nombres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nombres", true));
            this.txt_nombres.Location = new System.Drawing.Point(171, 35);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(100, 20);
            this.txt_nombres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(669, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // datagrid_producto
            // 
            this.datagrid_producto.AllowUserToAddRows = false;
            this.datagrid_producto.AllowUserToDeleteRows = false;
            this.datagrid_producto.AutoGenerateColumns = false;
            this.datagrid_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.paternoDataGridViewTextBoxColumn,
            this.maternoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.fonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.datagrid_producto.DataSource = this.clienteBindingSource;
            this.datagrid_producto.Location = new System.Drawing.Point(45, 194);
            this.datagrid_producto.Name = "datagrid_producto";
            this.datagrid_producto.ReadOnly = true;
            this.datagrid_producto.Size = new System.Drawing.Size(730, 134);
            this.datagrid_producto.TabIndex = 2;
            // 
            // producto_diagram
            // 
            this.producto_diagram.DataSetName = "Producto_diagram";
            this.producto_diagram.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.producto_diagram;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paternoDataGridViewTextBoxColumn
            // 
            this.paternoDataGridViewTextBoxColumn.DataPropertyName = "paterno";
            this.paternoDataGridViewTextBoxColumn.HeaderText = "paterno";
            this.paternoDataGridViewTextBoxColumn.Name = "paternoDataGridViewTextBoxColumn";
            this.paternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maternoDataGridViewTextBoxColumn
            // 
            this.maternoDataGridViewTextBoxColumn.DataPropertyName = "materno";
            this.maternoDataGridViewTextBoxColumn.HeaderText = "materno";
            this.maternoDataGridViewTextBoxColumn.Name = "maternoDataGridViewTextBoxColumn";
            this.maternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fonoDataGridViewTextBoxColumn
            // 
            this.fonoDataGridViewTextBoxColumn.DataPropertyName = "fono";
            this.fonoDataGridViewTextBoxColumn.HeaderText = "fono";
            this.fonoDataGridViewTextBoxColumn.Name = "fonoDataGridViewTextBoxColumn";
            this.fonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ventana_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 389);
            this.Controls.Add(this.datagrid_producto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDatos);
            this.Name = "Ventana_Cliente";
            this.Text = "Ventana_Cliente";
            this.Load += new System.EventHandler(this.Ventana_Cliente_Load);
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_diagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_id;
        private Producto_diagramTableAdapters.ventaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.DataGridView datagrid_producto;
        private Producto_diagram producto_diagram;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Producto_diagramTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}