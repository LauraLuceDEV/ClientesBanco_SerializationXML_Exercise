using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MiBanco
{
    public partial class FormInsertarClientes : Form
    {
        private Banco miListaClientes;

        public FormInsertarClientes()
        {
            InitializeComponent();
            this.miListaClientes = Program.crearListaClientes();
        }

        //Botón - Guardar
        /// <summary>
        /// Nos guardará una instancia cliente en la lista de la instancia 'Banco'.
        /// Primero comprobará que todos los campos están rellenos y tienen el formato correcto
        /// Después comprobará si existirá el documento XML (Se debe cambiar la ruta)
        /// Si existe el documento añadirá el cliente a 'miBanco.XML'
        /// Sino existe el documento antes de añadir el cliente, nos creará el doc y añadirá el cliente a 'miBanco.XML'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbDni.Text.Length > 0 && tbNombre.Text.Length > 0 && tbDireccion.Text.Length >0 &&
                tbEdad.Text.Length > 0 && tbMovil.Text.Length > 0 && tbNumCuenta.Text.Length > 0 )
            {
                Boolean noExisteErrorDni = RegexUtils.validarDni(tbDni.Text);
                Boolean noExisteErrorMovil = RegexUtils.validarTlfCuenta(tbMovil.Text);
                Boolean noExisteErrorCuenta = RegexUtils.validarTlfCuenta(tbNumCuenta.Text);
                Boolean noExisteErrorEdad = RegexUtils.validarEdad(tbEdad.Text);

                if(noExisteErrorDni && noExisteErrorEdad && noExisteErrorMovil && noExisteErrorCuenta)
                {
                    Cliente cli = new Cliente(tbDni.Text, tbNombre.Text, tbDireccion.Text, tbMovil.Text, 
                        Convert.ToInt32(tbEdad.Text), Convert.ToInt32(tbNumCuenta.Text));

                    this.miListaClientes.ListaClientes.Add(cli);

                    //Cambiar la ruta
                    string nombreArchivoXML = "mibanco.xml";

                    if (File.Exists(nombreArchivoXML)){
                        FileStream docXML = new FileStream("mibanco.xml", FileMode.Open);
                        XmlSerializer format = new XmlSerializer(this.miListaClientes.GetType());
                        format.Serialize(docXML, this.miListaClientes);
                 
                        docXML.Close();
                    } 
                    else{
                        FileStream docXML = new FileStream("mibanco.xml", FileMode.Create);
                        XmlSerializer format = new XmlSerializer(this.miListaClientes.GetType());
                        format.Serialize(docXML, this.miListaClientes);
                        docXML.Close();
                 
        
                    }
                    borrarCampos();

                }
                else if (!noExisteErrorDni){
                    MessageBox.Show("Debe insertar un formato correcto para el DNI.");

                }else if (!noExisteErrorMovil){
                    MessageBox.Show("Debe insertar un formato correcto de dígitos (sólo 9).");

                }else if (!noExisteErrorCuenta){
                    MessageBox.Show("Debe insertar un número de cuenta correcto (Sólo 9 dígitos).");

                }else if (!noExisteErrorEdad){
                    MessageBox.Show("Compruebe de nuevo su edad: Que esté bien escrita y mayor de edad");

                }else { MessageBox.Show("Compruebe de nuevo todos los campos."); }

            }else { MessageBox.Show("Debe rellenar todos los campos"); }
        }

        //Botón - SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (tbDni.Text.Length > 0 || tbNombre.Text.Length > 0 || tbDireccion.Text.Length > 0 ||
                tbEdad.Text.Length > 0 || tbMovil.Text.Length > 0 || tbNumCuenta.Text.Length > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "ERROR", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    borrarCampos();
                    this.Close();
                }
            }
            else { this.Close(); }
        }

        private void borrarCampos()
        {
            tbDireccion.Clear();
            tbDni.Clear();
            tbEdad.Clear();
            tbMovil.Clear();
            tbNombre.Clear();
            tbNumCuenta.Clear();
        }
    }
}
