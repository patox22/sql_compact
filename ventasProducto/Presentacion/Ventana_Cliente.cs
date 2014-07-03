using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ventasProducto.Presentacion
{
    public partial class Ventana_Cliente : Form
    {

        private static Ventana_Cliente instance;
        public static Ventana_Cliente DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new Ventana_Cliente();
                return instance;
            }
            set
            {
                instance = value;
            }
        }


        public Ventana_Cliente()
        {
            InitializeComponent();
            this.datagrid_producto.ReadOnly = true;
        }

        private void Ventana_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'producto_diagram.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.producto_diagram.cliente);
            // TODO: esta línea de código carga datos en la tabla 'producto_diagram.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.producto_diagram.venta);
            // TODO: esta línea de código carga datos en la tabla 'producto_diagram.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.producto_diagram.cliente);

        }

     

    

       
      
    }
}
