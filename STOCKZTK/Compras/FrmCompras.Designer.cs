namespace STOCKZTK
{
    partial class FrmCompras
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
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.panelCompra = new System.Windows.Forms.Panel();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFacturaC = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gridCompra = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(238, 76);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(39, 30);
            this.btnBuscarP.TabIndex = 0;
            this.btnBuscarP.Text = "B";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            // 
            // panelCompra
            // 
            this.panelCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCompra.Controls.Add(this.txtProveedor);
            this.panelCompra.Controls.Add(this.btnBuscarP);
            this.panelCompra.Controls.Add(this.label1);
            this.panelCompra.Controls.Add(this.dtFacturaC);
            this.panelCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompra.Location = new System.Drawing.Point(0, 0);
            this.panelCompra.Name = "panelCompra";
            this.panelCompra.Size = new System.Drawing.Size(746, 125);
            this.panelCompra.TabIndex = 1;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(12, 82);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(220, 20);
            this.txtProveedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // dtFacturaC
            // 
            this.dtFacturaC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFacturaC.Location = new System.Drawing.Point(13, 13);
            this.dtFacturaC.Name = "dtFacturaC";
            this.dtFacturaC.Size = new System.Drawing.Size(97, 20);
            this.dtFacturaC.TabIndex = 0;
            this.dtFacturaC.Value = new System.DateTime(2020, 3, 18, 12, 19, 43, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gridCompra
            // 
            this.gridCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompra.Location = new System.Drawing.Point(0, 165);
            this.gridCompra.Name = "gridCompra";
            this.gridCompra.Size = new System.Drawing.Size(746, 162);
            this.gridCompra.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(578, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 475);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gridCompra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelCompra);
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas";
            this.panelCompra.ResumeLayout(false);
            this.panelCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Panel panelCompra;
        private System.Windows.Forms.DateTimePicker dtFacturaC;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView gridCompra;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

