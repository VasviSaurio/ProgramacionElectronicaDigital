namespace ProyectoGasolinera
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabBienvenida = new System.Windows.Forms.TabPage();
            this.tabVentaGasolina = new System.Windows.Forms.TabPage();
            this.btnConectarPuerto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPuertosDisponibles = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRealizarPedidoGasolina = new System.Windows.Forms.Button();
            this.btnObtenerPuertosDisponibles = new System.Windows.Forms.Button();
            this.btnCerrarPuerto = new System.Windows.Forms.Button();
            this.btnAbastecimientoBombas = new System.Windows.Forms.Button();
            this.btnReportesYCierres = new System.Windows.Forms.Button();
            this.tabAbastecimientos = new System.Windows.Forms.TabPage();
            this.tabSeleccionReportesYCierres = new System.Windows.Forms.TabPage();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.btnRegresarAlInicio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnVerReportesYCierres = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabBienvenida.SuspendLayout();
            this.tabVentaGasolina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabAbastecimientos.SuspendLayout();
            this.tabSeleccionReportesYCierres.SuspendLayout();
            this.tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabBienvenida);
            this.tabControl2.Controls.Add(this.tabVentaGasolina);
            this.tabControl2.Controls.Add(this.tabAbastecimientos);
            this.tabControl2.Controls.Add(this.tabSeleccionReportesYCierres);
            this.tabControl2.Controls.Add(this.tabReportes);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(599, 385);
            this.tabControl2.TabIndex = 0;
            // 
            // tabBienvenida
            // 
            this.tabBienvenida.Controls.Add(this.btnReportesYCierres);
            this.tabBienvenida.Controls.Add(this.btnAbastecimientoBombas);
            this.tabBienvenida.Controls.Add(this.btnCerrarPuerto);
            this.tabBienvenida.Controls.Add(this.btnObtenerPuertosDisponibles);
            this.tabBienvenida.Controls.Add(this.btnRealizarPedidoGasolina);
            this.tabBienvenida.Controls.Add(this.pictureBox1);
            this.tabBienvenida.Controls.Add(this.cbPuertosDisponibles);
            this.tabBienvenida.Controls.Add(this.label1);
            this.tabBienvenida.Controls.Add(this.btnConectarPuerto);
            this.tabBienvenida.Location = new System.Drawing.Point(4, 22);
            this.tabBienvenida.Name = "tabBienvenida";
            this.tabBienvenida.Padding = new System.Windows.Forms.Padding(3);
            this.tabBienvenida.Size = new System.Drawing.Size(591, 359);
            this.tabBienvenida.TabIndex = 0;
            this.tabBienvenida.Text = "BIENVENIDA";
            this.tabBienvenida.UseVisualStyleBackColor = true;
            this.tabBienvenida.Click += new System.EventHandler(this.tabBienvenida_Click);
            // 
            // tabVentaGasolina
            // 
            this.tabVentaGasolina.Controls.Add(this.btnRegresarAlInicio);
            this.tabVentaGasolina.Location = new System.Drawing.Point(4, 22);
            this.tabVentaGasolina.Name = "tabVentaGasolina";
            this.tabVentaGasolina.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentaGasolina.Size = new System.Drawing.Size(591, 359);
            this.tabVentaGasolina.TabIndex = 1;
            this.tabVentaGasolina.Text = "VENTA GASOLINA";
            this.tabVentaGasolina.UseVisualStyleBackColor = true;
            // 
            // btnConectarPuerto
            // 
            this.btnConectarPuerto.Location = new System.Drawing.Point(292, 315);
            this.btnConectarPuerto.Name = "btnConectarPuerto";
            this.btnConectarPuerto.Size = new System.Drawing.Size(90, 38);
            this.btnConectarPuerto.TabIndex = 0;
            this.btnConectarPuerto.Text = "ABRIR";
            this.btnConectarPuerto.UseVisualStyleBackColor = true;
            this.btnConectarPuerto.Click += new System.EventHandler(this.btnConectarPuerto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUERTOS \r\nDISPONIBLES:";
            // 
            // cbPuertosDisponibles
            // 
            this.cbPuertosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPuertosDisponibles.FormattingEnabled = true;
            this.cbPuertosDisponibles.Location = new System.Drawing.Point(93, 316);
            this.cbPuertosDisponibles.Name = "cbPuertosDisponibles";
            this.cbPuertosDisponibles.Size = new System.Drawing.Size(193, 33);
            this.cbPuertosDisponibles.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnRealizarPedidoGasolina
            // 
            this.btnRealizarPedidoGasolina.Location = new System.Drawing.Point(47, 205);
            this.btnRealizarPedidoGasolina.Name = "btnRealizarPedidoGasolina";
            this.btnRealizarPedidoGasolina.Size = new System.Drawing.Size(159, 63);
            this.btnRealizarPedidoGasolina.TabIndex = 4;
            this.btnRealizarPedidoGasolina.Text = "VENTA";
            this.btnRealizarPedidoGasolina.UseVisualStyleBackColor = true;
            this.btnRealizarPedidoGasolina.Click += new System.EventHandler(this.btnRealizarPedidoGasolina_Click);
            // 
            // btnObtenerPuertosDisponibles
            // 
            this.btnObtenerPuertosDisponibles.Location = new System.Drawing.Point(484, 315);
            this.btnObtenerPuertosDisponibles.Name = "btnObtenerPuertosDisponibles";
            this.btnObtenerPuertosDisponibles.Size = new System.Drawing.Size(90, 38);
            this.btnObtenerPuertosDisponibles.TabIndex = 5;
            this.btnObtenerPuertosDisponibles.Text = "ACTUALIZAR PUERTOS";
            this.btnObtenerPuertosDisponibles.UseVisualStyleBackColor = true;
            this.btnObtenerPuertosDisponibles.Click += new System.EventHandler(this.btnObtenerPuertosDisponibles_Click);
            // 
            // btnCerrarPuerto
            // 
            this.btnCerrarPuerto.Enabled = false;
            this.btnCerrarPuerto.Location = new System.Drawing.Point(388, 315);
            this.btnCerrarPuerto.Name = "btnCerrarPuerto";
            this.btnCerrarPuerto.Size = new System.Drawing.Size(90, 38);
            this.btnCerrarPuerto.TabIndex = 6;
            this.btnCerrarPuerto.Text = "CERRAR";
            this.btnCerrarPuerto.UseVisualStyleBackColor = true;
            this.btnCerrarPuerto.Click += new System.EventHandler(this.btnCerrarPuerto_Click);
            // 
            // btnAbastecimientoBombas
            // 
            this.btnAbastecimientoBombas.Location = new System.Drawing.Point(213, 205);
            this.btnAbastecimientoBombas.Name = "btnAbastecimientoBombas";
            this.btnAbastecimientoBombas.Size = new System.Drawing.Size(159, 63);
            this.btnAbastecimientoBombas.TabIndex = 7;
            this.btnAbastecimientoBombas.Text = "ABASTECIMIENTO";
            this.btnAbastecimientoBombas.UseVisualStyleBackColor = true;
            this.btnAbastecimientoBombas.Click += new System.EventHandler(this.btnAbastecimientoBombas_Click);
            // 
            // btnReportesYCierres
            // 
            this.btnReportesYCierres.Location = new System.Drawing.Point(378, 205);
            this.btnReportesYCierres.Name = "btnReportesYCierres";
            this.btnReportesYCierres.Size = new System.Drawing.Size(159, 63);
            this.btnReportesYCierres.TabIndex = 8;
            this.btnReportesYCierres.Text = "REPORTES Y CIERRES";
            this.btnReportesYCierres.UseVisualStyleBackColor = true;
            this.btnReportesYCierres.Click += new System.EventHandler(this.btnReportesYCierres_Click);
            // 
            // tabAbastecimientos
            // 
            this.tabAbastecimientos.Controls.Add(this.button2);
            this.tabAbastecimientos.Location = new System.Drawing.Point(4, 22);
            this.tabAbastecimientos.Name = "tabAbastecimientos";
            this.tabAbastecimientos.Size = new System.Drawing.Size(591, 359);
            this.tabAbastecimientos.TabIndex = 2;
            this.tabAbastecimientos.Text = "ABASTECIMIENTO";
            this.tabAbastecimientos.UseVisualStyleBackColor = true;
            // 
            // tabSeleccionReportesYCierres
            // 
            this.tabSeleccionReportesYCierres.Controls.Add(this.btnVerReportesYCierres);
            this.tabSeleccionReportesYCierres.Controls.Add(this.btnCerrarCaja);
            this.tabSeleccionReportesYCierres.Controls.Add(this.label2);
            this.tabSeleccionReportesYCierres.Controls.Add(this.dataGridView1);
            this.tabSeleccionReportesYCierres.Controls.Add(this.button3);
            this.tabSeleccionReportesYCierres.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionReportesYCierres.Name = "tabSeleccionReportesYCierres";
            this.tabSeleccionReportesYCierres.Size = new System.Drawing.Size(591, 359);
            this.tabSeleccionReportesYCierres.TabIndex = 3;
            this.tabSeleccionReportesYCierres.Text = "REPORTES Y CIERRES";
            this.tabSeleccionReportesYCierres.UseVisualStyleBackColor = true;
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.button4);
            this.tabReportes.Location = new System.Drawing.Point(4, 22);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Size = new System.Drawing.Size(591, 359);
            this.tabReportes.TabIndex = 4;
            this.tabReportes.Text = "REPORTES";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // btnRegresarAlInicio
            // 
            this.btnRegresarAlInicio.Location = new System.Drawing.Point(426, 326);
            this.btnRegresarAlInicio.Name = "btnRegresarAlInicio";
            this.btnRegresarAlInicio.Size = new System.Drawing.Size(159, 27);
            this.btnRegresarAlInicio.TabIndex = 5;
            this.btnRegresarAlInicio.Text = "Regresar al inicio";
            this.btnRegresarAlInicio.UseVisualStyleBackColor = true;
            this.btnRegresarAlInicio.Click += new System.EventHandler(this.btnRegresarAlInicio_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Regresar al inicio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Regresar al inicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "Regresar al inicio";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 277);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ABASTECIMIENTOS DEL DÍA";
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(17, 320);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(159, 27);
            this.btnCerrarCaja.TabIndex = 9;
            this.btnCerrarCaja.Text = "Cerrar caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            // 
            // btnVerReportesYCierres
            // 
            this.btnVerReportesYCierres.Location = new System.Drawing.Point(212, 320);
            this.btnVerReportesYCierres.Name = "btnVerReportesYCierres";
            this.btnVerReportesYCierres.Size = new System.Drawing.Size(159, 27);
            this.btnVerReportesYCierres.TabIndex = 10;
            this.btnVerReportesYCierres.Text = "Reportes y cierres";
            this.btnVerReportesYCierres.UseVisualStyleBackColor = true;
            this.btnVerReportesYCierres.Click += new System.EventHandler(this.btnVerReportesYCierres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 404);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabBienvenida.ResumeLayout(false);
            this.tabBienvenida.PerformLayout();
            this.tabVentaGasolina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabAbastecimientos.ResumeLayout(false);
            this.tabSeleccionReportesYCierres.ResumeLayout(false);
            this.tabSeleccionReportesYCierres.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabBienvenida;
        private System.Windows.Forms.TabPage tabVentaGasolina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectarPuerto;
        private System.Windows.Forms.ComboBox cbPuertosDisponibles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRealizarPedidoGasolina;
        private System.Windows.Forms.Button btnObtenerPuertosDisponibles;
        private System.Windows.Forms.Button btnCerrarPuerto;
        private System.Windows.Forms.Button btnReportesYCierres;
        private System.Windows.Forms.Button btnAbastecimientoBombas;
        private System.Windows.Forms.Button btnRegresarAlInicio;
        private System.Windows.Forms.TabPage tabAbastecimientos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabSeleccionReportesYCierres;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnVerReportesYCierres;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

