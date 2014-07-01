using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ventasProducto
{
    class Cliente
    {
    // atributos  de la tabla cliente
        private int     _id_cliente;
        private string _nombres;
        private string _paterno;
        private string _materno;
        private string _direccion;
        private int _fono;
        private string _email;

      

     
    /**
     * Getter y Setter
     * */

        //1. cliente
        public int Id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
    
        //2. nombres

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
      
        
        //3.paterno
        public string Paterno
        {
            get { return _paterno; }
            set { _paterno = value; }
        }
      
      //4. materno

        public string Materno
        {
            get { return _materno; }
            set { _materno = value; }
        }
  
      //5. direccion

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

      //6. fono
        public int Fono
        {
            get { return _fono; }
            set { _fono = value; }
        }

      //7. email
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    
    
    
    
    
    
    
    }
}
