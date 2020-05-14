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
using System.Xml.Serialization;

namespace MiBanco
{
    public partial class FormEliminarCliente : Form
    {
        private Banco miListaClientes;

        public FormEliminarCliente()
        {
            InitializeComponent();
            this.miListaClientes = Banco.crearListaClientes();
            cargarComboBox();
        }

        //Cargamos los DNI de nuestros Clientes
        private void cargarComboBox()
        {
            List<String> lstDni = miListaClientes.getListadoDni();
            foreach (String dni in lstDni)  comboBoxDni.Items.Add(dni);

        }

        //Rellenamos los datos de los Clientes
        private void cargarDatosClientes(object sender, EventArgs e)
        {
            Cliente cargarCliente = this.miListaClientes.getClienteDni(comboBoxDni.SelectedItem.ToString());

            lblDni.Text = cargarCliente.Dni;
            lblDireccion.Text = cargarCliente.Direccion;
            lblEdad.Text = cargarCliente.Edad.ToString();
            lblTlf.Text = cargarCliente.Telefono;
            lblNombre.Text = cargarCliente.Nombre;
            lblNumCuenta.Text = cargarCliente.NumCuenta.ToString();
        }

        //Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String dniCb = Convert.ToString(comboBoxDni.SelectedItem);

            for (int i = 0; i < this.miListaClientes.ListaClientes.Count; i++)
            {
                if (dniCb == this.miListaClientes.ListaClientes[i].Dni)
                {
                    this.miListaClientes.ListaClientes.RemoveAt(i);
                    comboBoxDni.Items.Remove(comboBoxDni.SelectedItem);

                    if (File.Exists("mibanco.xml"))
                    {
                        FileStream docXML = new FileStream("mibanco.xml", FileMode.Create);
                        XmlSerializer format = new XmlSerializer(this.miListaClientes.GetType());
                        format.Serialize(docXML, this.miListaClientes);

                        docXML.Close();
                    }
                    i = this.miListaClientes.ListaClientes.Count;
                }
            }

            borrarCamposEliminarCli();
            MessageBox.Show( "Se ha eliminado correctamente.", "Éxito");
        }

        //Botón Atrás
        private void btnSalir_Click(object sender, EventArgs e)
        {
            borrarCamposEliminarCli();
            this.Close();
        }

        //Función privada que nos limpia/borra las labels rellenas
        private void borrarCamposEliminarCli()
        {
            lblDni.Text = "";
            lblEdad.Text = "";
            lblNombre.Text = "";
            lblDireccion.Text = "";
            lblTlf.Text = "";
            lblNumCuenta.Text = "";
        }

        
    }
}
