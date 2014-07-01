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
        }

     

    

       
      
    }
}
