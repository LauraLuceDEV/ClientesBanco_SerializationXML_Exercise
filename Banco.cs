using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MiBanco
{
    [Serializable()]
    [XmlRoot("Banco")]
    public class Banco
    {
        private List<Cliente> lstClientes = new List<Cliente>();

        //Constructores
        //Por defecto
        public Banco() { }

        //Por parametros
        public Banco(List<Cliente> lstClientes)
        {
            this.lstClientes = lstClientes;
                 
        }

        public List<Cliente> ListaClientes
        {
            get { return lstClientes; }
            set { lstClientes = value; }
        }

        public List<String> getListadoDni()
        {
            List<String> lstDni = new List<String>();

            for(int i=0; i < this.lstClientes.Count; i++)
            {
                lstDni.Add(lstClientes[i].Dni);
            }
            return lstDni;
        }

        public Cliente getClienteDni(String dni)
        {
            if(dni != null){
                foreach (Cliente cli in ListaClientes){
                    if (cli.Dni == dni) {
                        return cli;
                    }
                }
            }
            return null;
        }

        //Método estático del programa
        //Crear instancia Banco/Lista Clientes por defecto a partir del fichero XML
        public static Banco crearListaClientes()
        {
            Banco banco = new Banco();

            XmlSerializer format = new XmlSerializer(banco.GetType());
            if (File.Exists("mibanco.xml"))
            {
                FileStream f = new FileStream("mibanco.xml", FileMode.Open);
                while (f.Position < f.Length)
                {
                    banco = (Banco)format.Deserialize(f);
                }
                f.Close();
            }
            return banco;
        }
    }
}
