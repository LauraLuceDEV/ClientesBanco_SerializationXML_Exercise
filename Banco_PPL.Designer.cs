namespace MiBanco
{
    partial class Banco_PPL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco_PPL));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAddClientes = new System.Windows.Forms.Button();
            this.btnModifClientes = new System.Windows.Forms.Button();
            this.btnDeleteClientes = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridViewBanco = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(365, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido";
            // 
            // btnAddClientes
            // 
            this.btnAddClientes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClientes.Location = new System.Drawing.Point(77, 132);
            this.btnAddClientes.Name = "btnAddClientes";
            this.btnAddClientes.Size = new System.Drawing.Size(129, 56);
            this.btnAddClientes.TabIndex = 1;
            this.btnAddClientes.Text = "AÑADIR";
            this.btnAddClientes.UseVisualStyleBackColor = true;
            this.btnAddClientes.Click += new System.EventHandler(this.btnAddClientes_Click);
            // 
            // btnModifClientes
            // 
            this.btnModifClientes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifClientes.Location = new System.Drawing.Point(77, 234);
            this.btnModifClientes.Name = "btnModifClientes";
            this.btnModifClientes.Size = new System.Drawing.Size(129, 56);
            this.btnModifClientes.TabIndex = 2;
            this.btnModifClientes.Text = "MODIFICAR";
            this.btnModifClientes.UseVisualStyleBackColor = true;
            this.btnModifClientes.Click += new System.EventHandler(this.btnModifClientes_Click);
            // 
            // btnDeleteClientes
            // 
            this.btnDeleteClientes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClientes.Location = new System.Drawing.Point(77, 334);
            this.btnDeleteClientes.Name = "btnDeleteClientes";
            this.btnDeleteClientes.Size = new System.Drawing.Size(129, 56);
            this.btnDeleteClientes.TabIndex = 3;
            this.btnDeleteClientes.Text = "ELIMINAR";
            this.btnDeleteClientes.UseVisualStyleBackColor = true;
            this.btnDeleteClientes.Click += new System.EventHandler(this.btnDeleteClientes_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarClientes.Location = new System.Drawing.Point(77, 441);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(129, 56);
            this.btnMostrarClientes.TabIndex = 4;
            this.btnMostrarClientes.Text = "MOSTRAR";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(841, 543);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridViewBanco
            // 
            this.dataGridViewBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanco.Location = new System.Drawing.Point(267, 132);
            this.dataGridViewBanco.Name = "dataGridViewBanco";
            this.dataGridViewBanco.Size = new System.Drawing.Size(635, 365);
            this.dataGridViewBanco.TabIndex = 6;
            this.dataGridViewBanco.Visible = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Banco_PPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.dataGridViewBanco);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnDeleteClientes);
            this.Controls.Add(this.btnModifClientes);
            this.Controls.Add(this.btnAddClientes);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Banco_PPL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANCO LLBB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAddClientes;
        private System.Windows.Forms.Button btnModifClientes;
        private System.Windows.Forms.Button btnDeleteClientes;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridViewBanco;
        private System.Data.DataSet dataSet1;
    }
}

