using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace MiBanco
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Banco_PPL());
        }

        //Métodos del programa

        //Crear instancia Banco/Lista Clientes por defecto
        public static Banco crearListaClientes(){
            Banco banco = new Banco();

            XmlSerializer format = new XmlSerializer(banco.GetType());
             if (File.Exists("mibanco.xml")){
                  FileStream f = new FileStream("mibanco.xml", FileMode.Open);
                 while (f.Position < f.Length){
                    banco = (Banco)format.Deserialize(f);
                 }
                 f.Close();
             }
            return banco;
        }
    }
}
