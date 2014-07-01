namespace ventasProducto.Presentacion
{
    partial class Ventana_Venta
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
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label ivaLabel;
            System.Windows.Forms.Label netoLabel;
            System.Windows.Forms.Label codClienteLabel;
            System.Windows.Forms.Label condicionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_venta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_neto = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_condicion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            totalLabel = new System.Windows.Forms.Label();
            ivaLabel = new System.Windows.Forms.Label();
            netoLabel = new System.Windows.Forms.Label();
            codClienteLabel = new System.Windows.Forms.Label();
            condicionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(codClienteLabel);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(condicionLabel);
            this.groupBox1.Controls.Add(this.txt_condicion);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(ivaLabel);
            this.groupBox1.Controls.Add(this.txt_iva);
            this.groupBox1.Controls.Add(netoLabel);
            this.groupBox1.Controls.Add(this.txt_neto);
            this.groupBox1.Controls.Add(this.dateTime_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_venta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para comenzar , seleccione un código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código Venta:";
            // 
            // cb_venta
            // 
            this.cb_venta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cb_venta.DisplayMember = "CodVenta";
            this.cb_venta.FormattingEnabled = true;
            this.cb_venta.Location = new System.Drawing.Point(91, 32);
            this.cb_venta.Name = "cb_venta";
            this.cb_venta.Size = new System.Drawing.Size(128, 21);
            this.cb_venta.TabIndex = 5;
            this.cb_venta.ValueMember = "CodVenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha:";
            // 
            // dateTime_fecha
            // 
            this.dateTime_fecha.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dateTime_fecha.Location = new System.Drawing.Point(57, 67);
            this.dateTime_fecha.Name = "dateTime_fecha";
            this.dateTime_fecha.Size = new System.Drawing.Size(200, 20);
            this.dateTime_fecha.TabIndex = 8;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(300, 99);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_total.Location = new System.Drawing.Point(340, 96);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 16;
            // 
            // ivaLabel
            // 
            ivaLabel.AutoSize = true;
            ivaLabel.Location = new System.Drawing.Point(163, 100);
            ivaLabel.Name = "ivaLabel";
            ivaLabel.Size = new System.Drawing.Size(25, 13);
            ivaLabel.TabIndex = 13;
            ivaLabel.Text = "Iva:";
            // 
            // txt_iva
            // 
            this.txt_iva.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_iva.Location = new System.Drawing.Point(194, 96);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(100, 20);
            this.txt_iva.TabIndex = 14;
            // 
            // netoLabel
            // 
            netoLabel.AutoSize = true;
            netoLabel.Location = new System.Drawing.Point(11, 99);
            netoLabel.Name = "netoLabel";
            netoLabel.Size = new System.Drawing.Size(33, 13);
            netoLabel.TabIndex = 11;
            netoLabel.Text = "Neto:";
            // 
            // txt_neto
            // 
            this.txt_neto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_neto.Location = new System.Drawing.Point(57, 96);
            this.txt_neto.Name = "txt_neto";
            this.txt_neto.Size = new System.Drawing.Size(100, 20);
            this.txt_neto.TabIndex = 12;
            // 
            // codClienteLabel
            // 
            codClienteLabel.AutoSize = true;
            codClienteLabel.Location = new System.Drawing.Point(180, 129);
            codClienteLabel.Name = "codClienteLabel";
            codClienteLabel.Size = new System.Drawing.Size(78, 13);
            codClienteLabel.TabIndex = 19;
            codClienteLabel.Text = "Código Cliente:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_cliente.Location = new System.Drawing.Point(264, 126);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente.TabIndex = 20;
            // 
            // condicionLabel
            // 
            condicionLabel.AutoSize = true;
            condicionLabel.Location = new System.Drawing.Point(11, 129);
            condicionLabel.Name = "condicionLabel";
            condicionLabel.Size = new System.Drawing.Size(57, 13);
            condicionLabel.TabIndex = 17;
            condicionLabel.Text = "Condición:";
            // 
            // txt_condicion
            // 
            this.txt_condicion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_condicion.Location = new System.Drawing.Point(74, 122);
            this.txt_condicion.Name = "txt_condicion";
            this.txt_condicion.Size = new System.Drawing.Size(100, 20);
            this.txt_condicion.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(518, 12);
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
            // Ventana_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 311);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ventana_Venta";
            this.Text = "Ventana_Venta";
            this.Load += new System.EventHandler(this.Ventana_Venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_venta;
        private System.Windows.Forms.DateTimePicker dateTime_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_condicion;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_neto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}