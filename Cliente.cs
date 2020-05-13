using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MiBanco
{    public class Cliente
    {
        private String dni;
        private String nombre;
        private String direccion;
        private int edad;
        private String tlf;
        private int numCuenta;

        //Constructores
        public Cliente()
        {
        }

        //Constructor por parámetros
        public Cliente(String dni, String nombre, String direccion, String tlf, int edad, int numCuenta)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.tlf = tlf;
            this.numCuenta = numCuenta;
        }


        //Métodos SETTER y GETTER
        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public String Telefono
        {
            get { return tlf; }
            set { tlf = value; }
        }
        public int NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

    }
}
