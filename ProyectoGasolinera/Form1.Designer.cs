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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBombas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.tabVentaGasolina.Controls.Add(this.label12);
            this.tabVentaGasolina.Controls.Add(this.button5);
            this.tabVentaGasolina.Controls.Add(this.textBox4);
            this.tabVentaGasolina.Controls.Add(this.label11);
            this.tabVentaGasolina.Controls.Add(this.button1);
            this.tabVentaGasolina.Controls.Add(this.label10);
            this.tabVentaGasolina.Controls.Add(this.comboBox1);
            this.tabVentaGasolina.Controls.Add(this.textBox3);
            this.tabVentaGasolina.Controls.Add(this.textBox5);
            this.tabVentaGasolina.Controls.Add(this.label9);
            this.tabVentaGasolina.Controls.Add(this.label8);
            this.tabVentaGasolina.Controls.Add(this.label7);
            this.tabVentaGasolina.Controls.Add(this.cbBombas);
            this.tabVentaGasolina.Controls.Add(this.label6);
            this.tabVentaGasolina.Controls.Add(this.checkBox1);
            this.tabVentaGasolina.Controls.Add(this.label5);
            this.tabVentaGasolina.Controls.Add(this.textBox2);
            this.tabVentaGasolina.Controls.Add(this.label4);
            this.tabVentaGasolina.Controls.Add(this.textBox1);
            this.tabVentaGasolina.Controls.Add(this.label3);
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
            this.btnConectarPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
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
            this.btnRealizarPedidoGasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnObtenerPuertosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCerrarPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAbastecimientoBombas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnReportesYCierres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabAbastecimientos.Controls.Add(this.button7);
            this.tabAbastecimientos.Controls.Add(this.button6);
            this.tabAbastecimientos.Controls.Add(this.label16);
            this.tabAbastecimientos.Controls.Add(this.label15);
            this.tabAbastecimientos.Controls.Add(this.listBox2);
            this.tabAbastecimientos.Controls.Add(this.listBox1);
            this.tabAbastecimientos.Controls.Add(this.panel1);
            this.tabAbastecimientos.Controls.Add(this.label14);
            this.tabAbastecimientos.Controls.Add(this.label13);
            this.tabAbastecimientos.Controls.Add(this.button2);
            this.tabAbastecimientos.Location = new System.Drawing.Point(4, 22);
            this.tabAbastecimientos.Name = "tabAbastecimientos";
            this.tabAbastecimientos.Size = new System.Drawing.Size(591, 359);
            this.tabAbastecimientos.TabIndex = 2;
            this.tabAbastecimientos.Text = "ABASTECIMIENTO";
            this.tabAbastecimientos.UseVisualStyleBackColor = true;
            this.tabAbastecimientos.Click += new System.EventHandler(this.tabAbastecimientos_Click);
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
            this.btnRegresarAlInicio.Location = new System.Drawing.Point(426, 323);
            this.btnRegresarAlInicio.Name = "btnRegresarAlInicio";
            this.btnRegresarAlInicio.Size = new System.Drawing.Size(159, 27);
            this.btnRegresarAlInicio.TabIndex = 5;
            this.btnRegresarAlInicio.Text = "Regresar al inicio";
            this.btnRegresarAlInicio.UseVisualStyleBackColor = true;
            this.btnRegresarAlInicio.Click += new System.EventHandler(this.btnRegresarAlInicio_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 3);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "DATOS DEL CLIENTE:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(69, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 29);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "NIT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "NOMBRE:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(319, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 29);
            this.textBox2.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(487, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "CF";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATOS DE LA TRANSACCION:";
            // 
            // cbBombas
            // 
            this.cbBombas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBombas.FormattingEnabled = true;
            this.cbBombas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbBombas.Location = new System.Drawing.Point(89, 158);
            this.cbBombas.Name = "cbBombas";
            this.cbBombas.Size = new System.Drawing.Size(97, 32);
            this.cbBombas.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "BOMBA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "LT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Q:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(222, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 29);
            this.textBox5.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(60, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 29);
            this.textBox3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "TIPO ABAST.";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TANQUE LLENO",
            "PREPAGO"});
            this.comboBox1.Location = new System.Drawing.Point(319, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 32);
            this.comboBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(370, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "SOLICITAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(64, 319);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 29);
            this.textBox4.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 32);
            this.label11.TabIndex = 24;
            this.label11.Text = "Precio\r\nLitro";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(193, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 30);
            this.button5.TabIndex = 26;
            this.button5.Text = "MODIFICAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "DATOS DE LA GASOLINERA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 7;
            this.label13.Text = "BOMBA1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(488, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = ":BOMBA2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(295, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 320);
            this.panel1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 286);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 69);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(303, 286);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(282, 69);
            this.listBox2.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "DESPACHOS SOLICITADOS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(303, 267);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "DESPACHOS SOLICITADOS";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
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
            this.tabVentaGasolina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabAbastecimientos.ResumeLayout(false);
            this.tabAbastecimientos.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBombas;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

