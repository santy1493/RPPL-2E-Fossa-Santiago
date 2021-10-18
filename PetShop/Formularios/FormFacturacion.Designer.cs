
namespace Formularios
{
    partial class FormFacturacion
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnMostrarFactura = new System.Windows.Forms.Button();
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.numFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnMostrarFactura);
            this.panel3.Controls.Add(this.dtgvFacturas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(244, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 589);
            this.panel3.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.Location = new System.Drawing.Point(741, 547);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(122, 30);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir a .txt";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnMostrarFactura
            // 
            this.btnMostrarFactura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrarFactura.Location = new System.Drawing.Point(56, 547);
            this.btnMostrarFactura.Name = "btnMostrarFactura";
            this.btnMostrarFactura.Size = new System.Drawing.Size(138, 30);
            this.btnMostrarFactura.TabIndex = 1;
            this.btnMostrarFactura.Text = "Mostrar Detalle";
            this.btnMostrarFactura.UseVisualStyleBackColor = false;
            this.btnMostrarFactura.Click += new System.EventHandler(this.btnMostrarFactura_Click);
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFactura,
            this.fecha,
            this.cliente,
            this.cuil,
            this.tipoEnvio,
            this.precioEnvio,
            this.precioTotal});
            this.dtgvFacturas.Location = new System.Drawing.Point(56, 90);
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.RowTemplate.Height = 25;
            this.dtgvFacturas.Size = new System.Drawing.Size(807, 436);
            this.dtgvFacturas.TabIndex = 0;
            this.dtgvFacturas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvFacturas_RowHeaderMouseClick);
            // 
            // numFactura
            // 
            this.numFactura.HeaderText = "Num. Factura";
            this.numFactura.Name = "numFactura";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.Width = 150;
            // 
            // cuil
            // 
            this.cuil.HeaderText = "CUIL";
            this.cuil.Name = "cuil";
            this.cuil.Width = 114;
            // 
            // tipoEnvio
            // 
            this.tipoEnvio.HeaderText = "Tipo de Envio";
            this.tipoEnvio.Name = "tipoEnvio";
            // 
            // precioEnvio
            // 
            this.precioEnvio.HeaderText = "Precio Envio";
            this.precioEnvio.Name = "precioEnvio";
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "Precio Total";
            this.precioTotal.Name = "precioTotal";
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 660);
            this.Controls.Add(this.panel3);
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFacturas;
        private System.Windows.Forms.Button btnMostrarFactura;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
    }
}