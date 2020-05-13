using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBanco
{
    public partial class Banco_PPL : Form
    {
        public Banco_PPL()
        {
            InitializeComponent();
        }

        //Botón añadir Clientes
        private void btnAddClientes_Click(object sender, EventArgs e)
        {
            new FormInsertarClientes().ShowDialog();
        }

        //Botón Modificar Clientes
        private void btnModifClientes_Click(object sender, EventArgs e)
        {
            new FormModificarCliente().ShowDialog();
        }

        //Botón Eliminar Clientes
        private void btnDeleteClientes_Click(object sender, EventArgs e)
        {
            new FormEliminarCliente().ShowDialog();
        }

        //Botón Mostrar Clientes
        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            dataSet1.Clear();
            dataSet1.ReadXml("mibanco.xml");
            if (!dataGridViewBanco.Visible)
            {
                dataGridViewBanco.Visible = true;
                dataGridViewBanco.DataSource = dataSet1;
                dataGridViewBanco.DataMember = "Cliente";

            }else { dataGridViewBanco.Visible = false; }
            
        }

        //Botón - Salir de la APP
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
