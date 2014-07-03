using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ventasProducto.Presentacion;

namespace ventasProducto
{
    public partial class VentanaPrincipal : Form
    {


      
    

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea Salir","Principal",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            this.Close();
        }


        /**
         * abre la ventana cliente_buscar
         * */

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Ventana_Cliente a = new Ventana_Cliente();
           //a.ShowDialog();

            Ventana_Cliente.DefInstance.MdiParent = this;
            Ventana_Cliente.DefInstance.Show();
        }

        /**
         * abre ventana producto...
         * */
        private void mantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Producto.DefInstance.MdiParent = this;
            Ventana_Producto.DefInstance.Show();
        }

        /**
         * abre la ventana de ventas
         * */
        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Venta.DefInstance.MdiParent = this;
            Ventana_Venta.DefInstance.Show();
        }
        // estilo vertical
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // estilo horizontal
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // estilo cascada
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }


        // click de acerca de donde se muestra quien creó el software..
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerca ayuda = new acerca();
            ayuda.ShowDialog();
        }


        // agregar nuevo cliente...
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    
    
    
    }
}
