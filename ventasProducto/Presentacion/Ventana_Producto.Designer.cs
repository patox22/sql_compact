namespace ventasProducto.Presentacion
{
    partial class Ventana_Producto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grid_producto = new System.Windows.Forms.DataGridView();
            this.productodiagramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_diagram = new ventasProducto.Producto_diagram();
            this.productoAdapter = new ventasProducto.Producto_diagramTableAdapters.productoTableAdapter();
            this.productoManager = new ventasProducto.Producto_diagramTableAdapters.TableAdapterManager();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productodiagramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_diagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_costo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_descr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_producto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(252, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Utilidad:";
            // 
            // txt_costo
            // 
            this.txt_costo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_costo.Location = new System.Drawing.Point(89, 79);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(106, 20);
            this.txt_costo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio Costo:";
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_stock.Location = new System.Drawing.Point(594, 28);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(66, 20);
            this.txt_stock.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock:";
            // 
            // txt_descr
            // 
            this.txt_descr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_descr.Location = new System.Drawing.Point(438, 28);
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.Size = new System.Drawing.Size(106, 20);
            this.txt_descr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_nombre.Location = new System.Drawing.Point(254, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(106, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txt_producto
            // 
            this.txt_producto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_producto.Enabled = false;
            this.txt_producto.Location = new System.Drawing.Point(89, 28);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(106, 20);
            this.txt_producto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(762, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
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
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grid_producto
            // 
            this.grid_producto.AllowUserToAddRows = false;
            this.grid_producto.AllowUserToDeleteRows = false;
            this.grid_producto.AllowUserToOrderColumns = true;
            this.grid_producto.AutoGenerateColumns = false;
            this.grid_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.pcostoDataGridViewTextBoxColumn,
            this.utilidadDataGridViewTextBoxColumn});
            this.grid_producto.DataSource = this.productoBindingSource;
            this.grid_producto.Location = new System.Drawing.Point(69, 176);
            this.grid_producto.Name = "grid_producto";
            this.grid_producto.ReadOnly = true;
            this.grid_producto.Size = new System.Drawing.Size(642, 160);
            this.grid_producto.TabIndex = 3;
            // 
            // productodiagramBindingSource
            // 
            this.productodiagramBindingSource.DataSource = this.producto_diagram;
            this.productodiagramBindingSource.Position = 0;
            // 
            // producto_diagram
            // 
            this.producto_diagram.DataSetName = "Producto_diagram";
            this.producto_diagram.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoAdapter
            // 
            this.productoAdapter.ClearBeforeFill = true;
            // 
            // productoManager
            // 
            this.productoManager.BackupDataSetBeforeUpdate = false;
            this.productoManager.clienteTableAdapter = null;
            this.productoManager.detalleTableAdapter = null;
            this.productoManager.productoTableAdapter = this.productoAdapter;
            this.productoManager.UpdateOrder = ventasProducto.Producto_diagramTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.productoManager.ventaTableAdapter = null;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.productodiagramBindingSource;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pcostoDataGridViewTextBoxColumn
            // 
            this.pcostoDataGridViewTextBoxColumn.DataPropertyName = "pcosto";
            this.pcostoDataGridViewTextBoxColumn.HeaderText = "pcosto";
            this.pcostoDataGridViewTextBoxColumn.Name = "pcostoDataGridViewTextBoxColumn";
            this.pcostoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilidadDataGridViewTextBoxColumn
            // 
            this.utilidadDataGridViewTextBoxColumn.DataPropertyName = "utilidad";
            this.utilidadDataGridViewTextBoxColumn.HeaderText = "utilidad";
            this.utilidadDataGridViewTextBoxColumn.Name = "utilidadDataGridViewTextBoxColumn";
            this.utilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ventana_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 367);
            this.Controls.Add(this.grid_producto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ventana_Producto";
            this.Text = "Ventana_Producto";
            this.Load += new System.EventHandler(this.Ventana_Producto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productodiagramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_diagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_producto;
        private System.Windows.Forms.BindingSource productodiagramBindingSource;
        private Producto_diagram producto_diagram;
        private Producto_diagramTableAdapters.productoTableAdapter productoAdapter;
        private Producto_diagramTableAdapters.TableAdapterManager productoManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
  
    }
}