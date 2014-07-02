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
    public partial class Ventana_Producto : Form
    {

        private static Ventana_Producto instance;
        public static Ventana_Producto DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new Ventana_Producto();
                return instance;
            }
            set
            {
                instance = value;
            }
        }



        public Ventana_Producto()
        {
            InitializeComponent();
            this.grid_producto.ReadOnly = true;
           
        }

        private void Ventana_Producto_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla Producto'
            //Puede moverla o quitarla según sea necesario.

            this.productoAdapter.Fill(this.producto_diagram.producto);

        }
    }
}
