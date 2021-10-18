
namespace Formularios
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDistanciaEnvio = new System.Windows.Forms.Label();
            this.chEnvio = new System.Windows.Forms.CheckBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.dtgvCarrito = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrecioEnvio = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPrecioEnvio);
            this.panel3.Controls.Add(this.lblDistanciaEnvio);
            this.panel3.Controls.Add(this.chEnvio);
            this.panel3.Controls.Add(this.btnComprar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.nupCantidad);
            this.panel3.Controls.Add(this.btnAgregarCarrito);
            this.panel3.Controls.Add(this.dtgvCarrito);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lblDatosCliente);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtgvProductos);
            this.panel3.Controls.Add(this.dtgvClientes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(244, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 589);
            this.panel3.TabIndex = 2;
            // 
            // lblDistanciaEnvio
            // 
            this.lblDistanciaEnvio.AutoSize = true;
            this.lblDistanciaEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDistanciaEnvio.ForeColor = System.Drawing.Color.Red;
            this.lblDistanciaEnvio.Location = new System.Drawing.Point(32, 194);
            this.lblDistanciaEnvio.Name = "lblDistanciaEnvio";
            this.lblDistanciaEnvio.Size = new System.Drawing.Size(0, 15);
            this.lblDistanciaEnvio.TabIndex = 15;
            // 
            // chEnvio
            // 
            this.chEnvio.AutoSize = true;
            this.chEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chEnvio.Location = new System.Drawing.Point(337, 154);
            this.chEnvio.Name = "chEnvio";
            this.chEnvio.Size = new System.Drawing.Size(52, 19);
            this.chEnvio.TabIndex = 14;
            this.chEnvio.Text = "Envio";
            this.chEnvio.UseVisualStyleBackColor = true;
            this.chEnvio.CheckedChanged += new System.EventHandler(this.chEnvio_CheckedChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.Location = new System.Drawing.Point(300, 194);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(132, 23);
            this.btnComprar.TabIndex = 13;
            this.btnComprar.Text = "FINALIZAR COMPRA";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad";
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(507, 549);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(48, 23);
            this.nupCantidad.TabIndex = 11;
            this.nupCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCarrito.Location = new System.Drawing.Point(594, 549);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(149, 23);
            this.btnAgregarCarrito.TabIndex = 10;
            this.btnAgregarCarrito.Text = "AGREGAR AL CARRITO";
            this.btnAgregarCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // dtgvCarrito
            // 
            this.dtgvCarrito.AllowUserToAddRows = false;
            this.dtgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgvCarrito.Location = new System.Drawing.Point(438, 34);
            this.dtgvCarrito.Name = "dtgvCarrito";
            this.dtgvCarrito.RowTemplate.Height = 25;
            this.dtgvCarrito.Size = new System.Drawing.Size(463, 183);
            this.dtgvCarrito.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Monto Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(438, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Carrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(438, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(45, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SELECCIONAR CLIENTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.Location = new System.Drawing.Point(32, 87);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(128, 17);
            this.lblDatosCliente.TabIndex = 3;
            this.lblDatosCliente.Text = "Seleccione un cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATOS CLIENTE:";
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.AllowUserToAddRows = false;
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.marca,
            this.precio,
            this.stock});
            this.dtgvProductos.Location = new System.Drawing.Point(438, 262);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.RowTemplate.Height = 25;
            this.dtgvProductos.Size = new System.Drawing.Size(463, 271);
            this.dtgvProductos.TabIndex = 1;
            this.dtgvProductos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvProductos_RowHeaderMouseClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.Width = 60;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 60;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.Width = 50;
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.AllowUserToAddRows = false;
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuil,
            this.apellidoNombre,
            this.saldo});
            this.dtgvClientes.Location = new System.Drawing.Point(32, 262);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.RowTemplate.Height = 25;
            this.dtgvClientes.Size = new System.Drawing.Size(383, 271);
            this.dtgvClientes.TabIndex = 0;
            this.dtgvClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvClientes_RowHeaderMouseClick);
            // 
            // cuil
            // 
            this.cuil.HeaderText = "CUIL";
            this.cuil.Name = "cuil";
            // 
            // apellidoNombre
            // 
            this.apellidoNombre.HeaderText = "Apellido y nombre";
            this.apellidoNombre.Name = "apellidoNombre";
            this.apellidoNombre.Width = 150;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.Width = 90;
            // 
            // lblPrecioEnvio
            // 
            this.lblPrecioEnvio.AutoSize = true;
            this.lblPrecioEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioEnvio.Location = new System.Drawing.Point(300, 130);
            this.lblPrecioEnvio.Name = "lblPrecioEnvio";
            this.lblPrecioEnvio.Size = new System.Drawing.Size(0, 15);
            this.lblPrecioEnvio.TabIndex = 16;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 660);
            this.Controls.Add(this.panel3);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.DataGridView dtgvCarrito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.CheckBox chEnvio;
        private System.Windows.Forms.Label lblDistanciaEnvio;
        private System.Windows.Forms.Label lblPrecioEnvio;
    }
}