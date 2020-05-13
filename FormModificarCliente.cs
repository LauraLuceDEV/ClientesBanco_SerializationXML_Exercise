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
using System.Xml.Serialization;

namespace MiBanco
{
    public partial class FormModificarCliente : Form
    {
        private Banco miListaClientes;
        
        public FormModificarCliente()
        {
            InitializeComponent();
            this.miListaClientes = Program.crearListaClientes();
            cargarComboBox();
        }

        //Nos cargará nuestro ComboBox copn los DNI de nuestros Clientes
        private void cargarComboBox()
        {
            List<String> lstDni = miListaClientes.getListadoDni();

            foreach (String dni in lstDni)
            {
                comboBoxDni.Items.Add(dni);
            }
        
        }

        //Nos cargará nuestros campos con los datos de el cliente previamente seleccionado en el ComboBox
        private void CargarDatosClientesGB(object sender, EventArgs e)
        {
            Cliente cargarCliente = this.miListaClientes.getClienteDni(comboBoxDni.SelectedItem.ToString());

            labelDni.Text = cargarCliente.Dni;
            tbDireccion.Text = cargarCliente.Direccion;
            tbEdad.Text = cargarCliente.Edad.ToString();
            tbMovil.Text = cargarCliente.Telefono;
            tbNombre.Text = cargarCliente.Nombre;
            tbNumCuenta.Text = cargarCliente.NumCuenta.ToString();
        }




        //Botón Atrás - SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            borrarCamposModifCli();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliModificado = new Cliente(labelDni.Text, tbNombre.Text, tbDireccion.Text,   
                tbMovil.Text,Convert.ToInt32(tbEdad.Text), Convert.ToInt32(tbNumCuenta.Text));
            
            for(int i=0; i < this.miListaClientes.ListaClientes.Count; i++)
            {
                if(cliModificado.Dni == this.miListaClientes.ListaClientes[i].Dni)
                {
                    this.miListaClientes.ListaClientes[i] = cliModificado;

                    if (File.Exists("mibanco.xml")){
                        FileStream docXML = new FileStream("mibanco.xml", FileMode.Open);
                        XmlSerializer format = new XmlSerializer(this.miListaClientes.GetType());
                        format.Serialize(docXML, this.miListaClientes);

                        docXML.Close();
                    }
                    i = this.miListaClientes.ListaClientes.Count;
                }
            }
            borrarCamposModifCli();
            MessageBox.Show("Se han insertado los datos correctamente.", "Éxito");
        }

        //Función privada que nos limpia/borra los campos rellenos
        private void borrarCamposModifCli()
        {
            tbDireccion.Clear();
            tbEdad.Clear();
            tbMovil.Clear();
            tbNombre.Clear();
            tbNumCuenta.Clear();
        }

       
    }
}
