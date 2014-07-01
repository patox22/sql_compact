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
    public partial class Ventana_Venta : Form
    {
        private static Ventana_Venta instance;
        public static Ventana_Venta DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new Ventana_Venta();
                return instance;
            }
            set
            {
                instance = value;
            }
        }






        public Ventana_Venta()
        {
            InitializeComponent();
        }

        private void Ventana_Venta_Load(object sender, EventArgs e)
        {

        }
    }
}
