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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tablaAbastecimientosActuales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnVerReportesYCierres = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.checkBoxCF = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBombasDisponibles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadEfectivoPorCobrar = new System.Windows.Forms.TextBox();
            this.txtCantidadLitrosGasolina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoAbstecimiento = new System.Windows.Forms.ComboBox();
            this.btnSolicitarDespacho = new System.Windows.Forms.Button();
            this.txtPrecioGasolinaDeHoy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listaDespachosBomba1 = new System.Windows.Forms.ListBox();
            this.listaDespachosBomba2 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnIniciarDespachoBomba1 = new System.Windows.Forms.Button();
            this.btnDetenerDespachoBomba1 = new System.Windows.Forms.Button();
            this.txtProgresoLitrosBomba1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProgresoMontoBomba1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRealizarCobroBomba1 = new System.Windows.Forms.Button();
            this.txtIdDespachoBomba1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIdDespachoBomba2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnRealizarCobroBomba2 = new System.Windows.Forms.Button();
            this.txtProgresoMontoBomba2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtProgresoLitrosBomba2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnDetenerDespachoBomba2 = new System.Windows.Forms.Button();
            this.btnIniciarDespachoBomba2 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.tablaCierresPasados = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.tablaAbastecimientosPasados = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.cbSeleccionDeFiltro = new System.Windows.Forms.ComboBox();
            this.graficaDeUsoDeBombas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBombaMásUsada = new System.Windows.Forms.TextBox();
            this.txtBombaMenosUsada = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnCargarDatosDeFiltro = new System.Windows.Forms.Button();
            this.btnSiguienteAbastecimientoBomba1 = new System.Windows.Forms.Button();
            this.btnSiguienteAbastecimientoBomba2 = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabBienvenida.SuspendLayout();
            this.tabVentaGasolina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabAbastecimientos.SuspendLayout();
            this.tabSeleccionReportesYCierres.SuspendLayout();
            this.tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAbastecimientosActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCierresPasados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAbastecimientosPasados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaDeUsoDeBombas)).BeginInit();
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
            this.tabVentaGasolina.Controls.Add(this.txtPrecioGasolinaDeHoy);
            this.tabVentaGasolina.Controls.Add(this.label11);
            this.tabVentaGasolina.Controls.Add(this.btnSolicitarDespacho);
            this.tabVentaGasolina.Controls.Add(this.label10);
            this.tabVentaGasolina.Controls.Add(this.cbTipoAbstecimiento);
            this.tabVentaGasolina.Controls.Add(this.txtCantidadLitrosGasolina);
            this.tabVentaGasolina.Controls.Add(this.txtCantidadEfectivoPorCobrar);
            this.tabVentaGasolina.Controls.Add(this.label9);
            this.tabVentaGasolina.Controls.Add(this.label8);
            this.tabVentaGasolina.Controls.Add(this.label7);
            this.tabVentaGasolina.Controls.Add(this.cbBombasDisponibles);
            this.tabVentaGasolina.Controls.Add(this.label6);
            this.tabVentaGasolina.Controls.Add(this.checkBoxCF);
            this.tabVentaGasolina.Controls.Add(this.label5);
            this.tabVentaGasolina.Controls.Add(this.txtNombreCliente);
            this.tabVentaGasolina.Controls.Add(this.label4);
            this.tabVentaGasolina.Controls.Add(this.txtNitCliente);
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
            this.btnRealizarPedidoGasolina.Enabled = false;
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
            this.btnAbastecimientoBombas.Enabled = false;
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
            this.btnReportesYCierres.Enabled = false;
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
            this.tabAbastecimientos.Controls.Add(this.btnSiguienteAbastecimientoBomba2);
            this.tabAbastecimientos.Controls.Add(this.btnSiguienteAbastecimientoBomba1);
            this.tabAbastecimientos.Controls.Add(this.txtIdDespachoBomba2);
            this.tabAbastecimientos.Controls.Add(this.label20);
            this.tabAbastecimientos.Controls.Add(this.btnRealizarCobroBomba2);
            this.tabAbastecimientos.Controls.Add(this.txtProgresoMontoBomba2);
            this.tabAbastecimientos.Controls.Add(this.label21);
            this.tabAbastecimientos.Controls.Add(this.txtProgresoLitrosBomba2);
            this.tabAbastecimientos.Controls.Add(this.label22);
            this.tabAbastecimientos.Controls.Add(this.btnDetenerDespachoBomba2);
            this.tabAbastecimientos.Controls.Add(this.btnIniciarDespachoBomba2);
            this.tabAbastecimientos.Controls.Add(this.txtIdDespachoBomba1);
            this.tabAbastecimientos.Controls.Add(this.label19);
            this.tabAbastecimientos.Controls.Add(this.btnRealizarCobroBomba1);
            this.tabAbastecimientos.Controls.Add(this.txtProgresoMontoBomba1);
            this.tabAbastecimientos.Controls.Add(this.label18);
            this.tabAbastecimientos.Controls.Add(this.txtProgresoLitrosBomba1);
            this.tabAbastecimientos.Controls.Add(this.label17);
            this.tabAbastecimientos.Controls.Add(this.btnDetenerDespachoBomba1);
            this.tabAbastecimientos.Controls.Add(this.btnIniciarDespachoBomba1);
            this.tabAbastecimientos.Controls.Add(this.label16);
            this.tabAbastecimientos.Controls.Add(this.label15);
            this.tabAbastecimientos.Controls.Add(this.listaDespachosBomba2);
            this.tabAbastecimientos.Controls.Add(this.listaDespachosBomba1);
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
            this.tabSeleccionReportesYCierres.Controls.Add(this.tablaAbastecimientosActuales);
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
            this.tabReportes.Controls.Add(this.btnCargarDatosDeFiltro);
            this.tabReportes.Controls.Add(this.txtBombaMenosUsada);
            this.tabReportes.Controls.Add(this.label27);
            this.tabReportes.Controls.Add(this.txtBombaMásUsada);
            this.tabReportes.Controls.Add(this.label26);
            this.tabReportes.Controls.Add(this.graficaDeUsoDeBombas);
            this.tabReportes.Controls.Add(this.cbSeleccionDeFiltro);
            this.tabReportes.Controls.Add(this.label25);
            this.tabReportes.Controls.Add(this.label24);
            this.tabReportes.Controls.Add(this.tablaAbastecimientosPasados);
            this.tabReportes.Controls.Add(this.label23);
            this.tabReportes.Controls.Add(this.tablaCierresPasados);
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
            this.button4.Location = new System.Drawing.Point(343, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "Regresar al inicio";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tablaAbastecimientosActuales
            // 
            this.tablaAbastecimientosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAbastecimientosActuales.Location = new System.Drawing.Point(17, 37);
            this.tablaAbastecimientosActuales.Name = "tablaAbastecimientosActuales";
            this.tablaAbastecimientosActuales.Size = new System.Drawing.Size(560, 277);
            this.tablaAbastecimientosActuales.TabIndex = 7;
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
            // txtNitCliente
            // 
            this.txtNitCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNitCliente.Location = new System.Drawing.Point(69, 63);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.Size = new System.Drawing.Size(117, 29);
            this.txtNitCliente.TabIndex = 7;
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
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(319, 63);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(117, 29);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // checkBoxCF
            // 
            this.checkBoxCF.AutoSize = true;
            this.checkBoxCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCF.Location = new System.Drawing.Point(482, 62);
            this.checkBoxCF.Name = "checkBoxCF";
            this.checkBoxCF.Size = new System.Drawing.Size(51, 24);
            this.checkBoxCF.TabIndex = 11;
            this.checkBoxCF.Text = "CF";
            this.checkBoxCF.UseVisualStyleBackColor = true;
            this.checkBoxCF.CheckedChanged += new System.EventHandler(this.checkBoxCF_CheckedChanged);
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
            // cbBombasDisponibles
            // 
            this.cbBombasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBombasDisponibles.FormattingEnabled = true;
            this.cbBombasDisponibles.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbBombasDisponibles.Location = new System.Drawing.Point(89, 158);
            this.cbBombasDisponibles.Name = "cbBombasDisponibles";
            this.cbBombasDisponibles.Size = new System.Drawing.Size(97, 32);
            this.cbBombasDisponibles.TabIndex = 13;
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
            // txtCantidadEfectivoPorCobrar
            // 
            this.txtCantidadEfectivoPorCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEfectivoPorCobrar.Location = new System.Drawing.Point(222, 216);
            this.txtCantidadEfectivoPorCobrar.Name = "txtCantidadEfectivoPorCobrar";
            this.txtCantidadEfectivoPorCobrar.Size = new System.Drawing.Size(117, 29);
            this.txtCantidadEfectivoPorCobrar.TabIndex = 19;
            this.txtCantidadEfectivoPorCobrar.TextChanged += new System.EventHandler(this.txtCantidadEfectivoPorCobrar_TextChanged);
            this.txtCantidadEfectivoPorCobrar.Enter += new System.EventHandler(this.txtCantidadEfectivoPorCobrar_Enter);
            this.txtCantidadEfectivoPorCobrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadEfectivoPorCobrar_KeyPress);
            // 
            // txtCantidadLitrosGasolina
            // 
            this.txtCantidadLitrosGasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadLitrosGasolina.Location = new System.Drawing.Point(60, 216);
            this.txtCantidadLitrosGasolina.Name = "txtCantidadLitrosGasolina";
            this.txtCantidadLitrosGasolina.Size = new System.Drawing.Size(117, 29);
            this.txtCantidadLitrosGasolina.TabIndex = 20;
            this.txtCantidadLitrosGasolina.TextChanged += new System.EventHandler(this.txtCantidadLitrosGasolina_TextChanged);
            this.txtCantidadLitrosGasolina.Enter += new System.EventHandler(this.txtCantidadLitrosGasolina_Enter);
            this.txtCantidadLitrosGasolina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadLitrosGasolina_KeyPress);
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
            // cbTipoAbstecimiento
            // 
            this.cbTipoAbstecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoAbstecimiento.FormattingEnabled = true;
            this.cbTipoAbstecimiento.Items.AddRange(new object[] {
            "TANQUE LLENO",
            "PREPAGO"});
            this.cbTipoAbstecimiento.Location = new System.Drawing.Point(319, 158);
            this.cbTipoAbstecimiento.Name = "cbTipoAbstecimiento";
            this.cbTipoAbstecimiento.Size = new System.Drawing.Size(226, 32);
            this.cbTipoAbstecimiento.TabIndex = 21;
            this.cbTipoAbstecimiento.SelectedIndexChanged += new System.EventHandler(this.cbTipoAbstecimiento_SelectedIndexChanged);
            // 
            // btnSolicitarDespacho
            // 
            this.btnSolicitarDespacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarDespacho.Location = new System.Drawing.Point(370, 216);
            this.btnSolicitarDespacho.Name = "btnSolicitarDespacho";
            this.btnSolicitarDespacho.Size = new System.Drawing.Size(175, 30);
            this.btnSolicitarDespacho.TabIndex = 23;
            this.btnSolicitarDespacho.Text = "SOLICITAR";
            this.btnSolicitarDespacho.UseVisualStyleBackColor = true;
            this.btnSolicitarDespacho.Click += new System.EventHandler(this.btnSolicitarDespacho_Click);
            // 
            // txtPrecioGasolinaDeHoy
            // 
            this.txtPrecioGasolinaDeHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioGasolinaDeHoy.Location = new System.Drawing.Point(64, 319);
            this.txtPrecioGasolinaDeHoy.Name = "txtPrecioGasolinaDeHoy";
            this.txtPrecioGasolinaDeHoy.Size = new System.Drawing.Size(117, 29);
            this.txtPrecioGasolinaDeHoy.TabIndex = 25;
            this.txtPrecioGasolinaDeHoy.Text = "8.64";
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
            // listaDespachosBomba1
            // 
            this.listaDespachosBomba1.FormattingEnabled = true;
            this.listaDespachosBomba1.Location = new System.Drawing.Point(7, 247);
            this.listaDespachosBomba1.Name = "listaDespachosBomba1";
            this.listaDespachosBomba1.Size = new System.Drawing.Size(282, 82);
            this.listaDespachosBomba1.TabIndex = 10;
            // 
            // listaDespachosBomba2
            // 
            this.listaDespachosBomba2.FormattingEnabled = true;
            this.listaDespachosBomba2.Location = new System.Drawing.Point(303, 247);
            this.listaDespachosBomba2.Name = "listaDespachosBomba2";
            this.listaDespachosBomba2.Size = new System.Drawing.Size(282, 82);
            this.listaDespachosBomba2.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "DESPACHOS SOLICITADOS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "DESPACHOS SOLICITADOS";
            // 
            // btnIniciarDespachoBomba1
            // 
            this.btnIniciarDespachoBomba1.Enabled = false;
            this.btnIniciarDespachoBomba1.Location = new System.Drawing.Point(7, 146);
            this.btnIniciarDespachoBomba1.Name = "btnIniciarDespachoBomba1";
            this.btnIniciarDespachoBomba1.Size = new System.Drawing.Size(132, 23);
            this.btnIniciarDespachoBomba1.TabIndex = 14;
            this.btnIniciarDespachoBomba1.Text = "INICIAR";
            this.btnIniciarDespachoBomba1.UseVisualStyleBackColor = true;
            // 
            // btnDetenerDespachoBomba1
            // 
            this.btnDetenerDespachoBomba1.Enabled = false;
            this.btnDetenerDespachoBomba1.Location = new System.Drawing.Point(145, 146);
            this.btnDetenerDespachoBomba1.Name = "btnDetenerDespachoBomba1";
            this.btnDetenerDespachoBomba1.Size = new System.Drawing.Size(141, 23);
            this.btnDetenerDespachoBomba1.TabIndex = 15;
            this.btnDetenerDespachoBomba1.Text = "DETENER";
            this.btnDetenerDespachoBomba1.UseVisualStyleBackColor = true;
            // 
            // txtProgresoLitrosBomba1
            // 
            this.txtProgresoLitrosBomba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgresoLitrosBomba1.Location = new System.Drawing.Point(52, 94);
            this.txtProgresoLitrosBomba1.Name = "txtProgresoLitrosBomba1";
            this.txtProgresoLitrosBomba1.Size = new System.Drawing.Size(89, 29);
            this.txtProgresoLitrosBomba1.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "LT:";
            // 
            // txtProgresoMontoBomba1
            // 
            this.txtProgresoMontoBomba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgresoMontoBomba1.Location = new System.Drawing.Point(181, 94);
            this.txtProgresoMontoBomba1.Name = "txtProgresoMontoBomba1";
            this.txtProgresoMontoBomba1.Size = new System.Drawing.Size(89, 29);
            this.txtProgresoMontoBomba1.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(148, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Q.";
            // 
            // btnRealizarCobroBomba1
            // 
            this.btnRealizarCobroBomba1.Enabled = false;
            this.btnRealizarCobroBomba1.Location = new System.Drawing.Point(7, 185);
            this.btnRealizarCobroBomba1.Name = "btnRealizarCobroBomba1";
            this.btnRealizarCobroBomba1.Size = new System.Drawing.Size(279, 23);
            this.btnRealizarCobroBomba1.TabIndex = 25;
            this.btnRealizarCobroBomba1.Text = "COBRO";
            this.btnRealizarCobroBomba1.UseVisualStyleBackColor = true;
            // 
            // txtIdDespachoBomba1
            // 
            this.txtIdDespachoBomba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDespachoBomba1.Location = new System.Drawing.Point(145, 49);
            this.txtIdDespachoBomba1.Name = "txtIdDespachoBomba1";
            this.txtIdDespachoBomba1.Size = new System.Drawing.Size(141, 29);
            this.txtIdDespachoBomba1.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "ID DESPACHO";
            // 
            // txtIdDespachoBomba2
            // 
            this.txtIdDespachoBomba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDespachoBomba2.Location = new System.Drawing.Point(436, 46);
            this.txtIdDespachoBomba2.Name = "txtIdDespachoBomba2";
            this.txtIdDespachoBomba2.Size = new System.Drawing.Size(141, 29);
            this.txtIdDespachoBomba2.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(298, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "ID DESPACHO";
            // 
            // btnRealizarCobroBomba2
            // 
            this.btnRealizarCobroBomba2.Enabled = false;
            this.btnRealizarCobroBomba2.Location = new System.Drawing.Point(305, 185);
            this.btnRealizarCobroBomba2.Name = "btnRealizarCobroBomba2";
            this.btnRealizarCobroBomba2.Size = new System.Drawing.Size(279, 23);
            this.btnRealizarCobroBomba2.TabIndex = 35;
            this.btnRealizarCobroBomba2.Text = "COBRO";
            this.btnRealizarCobroBomba2.UseVisualStyleBackColor = true;
            // 
            // txtProgresoMontoBomba2
            // 
            this.txtProgresoMontoBomba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgresoMontoBomba2.Location = new System.Drawing.Point(479, 94);
            this.txtProgresoMontoBomba2.Name = "txtProgresoMontoBomba2";
            this.txtProgresoMontoBomba2.Size = new System.Drawing.Size(89, 29);
            this.txtProgresoMontoBomba2.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(446, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 20);
            this.label21.TabIndex = 33;
            this.label21.Text = "Q.";
            // 
            // txtProgresoLitrosBomba2
            // 
            this.txtProgresoLitrosBomba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgresoLitrosBomba2.Location = new System.Drawing.Point(340, 94);
            this.txtProgresoLitrosBomba2.Name = "txtProgresoLitrosBomba2";
            this.txtProgresoLitrosBomba2.Size = new System.Drawing.Size(89, 29);
            this.txtProgresoLitrosBomba2.TabIndex = 32;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(303, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 20);
            this.label22.TabIndex = 31;
            this.label22.Text = "LT:";
            // 
            // btnDetenerDespachoBomba2
            // 
            this.btnDetenerDespachoBomba2.Enabled = false;
            this.btnDetenerDespachoBomba2.Location = new System.Drawing.Point(443, 146);
            this.btnDetenerDespachoBomba2.Name = "btnDetenerDespachoBomba2";
            this.btnDetenerDespachoBomba2.Size = new System.Drawing.Size(141, 23);
            this.btnDetenerDespachoBomba2.TabIndex = 30;
            this.btnDetenerDespachoBomba2.Text = "DETENER";
            this.btnDetenerDespachoBomba2.UseVisualStyleBackColor = true;
            // 
            // btnIniciarDespachoBomba2
            // 
            this.btnIniciarDespachoBomba2.Enabled = false;
            this.btnIniciarDespachoBomba2.Location = new System.Drawing.Point(305, 146);
            this.btnIniciarDespachoBomba2.Name = "btnIniciarDespachoBomba2";
            this.btnIniciarDespachoBomba2.Size = new System.Drawing.Size(132, 23);
            this.btnIniciarDespachoBomba2.TabIndex = 29;
            this.btnIniciarDespachoBomba2.Text = "INICIAR";
            this.btnIniciarDespachoBomba2.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "CIERRES";
            // 
            // tablaCierresPasados
            // 
            this.tablaCierresPasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCierresPasados.Location = new System.Drawing.Point(16, 26);
            this.tablaCierresPasados.Name = "tablaCierresPasados";
            this.tablaCierresPasados.Size = new System.Drawing.Size(156, 317);
            this.tablaCierresPasados.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(178, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "DESPACHOS";
            // 
            // tablaAbastecimientosPasados
            // 
            this.tablaAbastecimientosPasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAbastecimientosPasados.Location = new System.Drawing.Point(181, 26);
            this.tablaAbastecimientosPasados.Name = "tablaAbastecimientosPasados";
            this.tablaAbastecimientosPasados.Size = new System.Drawing.Size(156, 317);
            this.tablaAbastecimientosPasados.TabIndex = 11;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(357, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "FILTRO:";
            // 
            // cbSeleccionDeFiltro
            // 
            this.cbSeleccionDeFiltro.FormattingEnabled = true;
            this.cbSeleccionDeFiltro.Location = new System.Drawing.Point(411, 23);
            this.cbSeleccionDeFiltro.Name = "cbSeleccionDeFiltro";
            this.cbSeleccionDeFiltro.Size = new System.Drawing.Size(163, 21);
            this.cbSeleccionDeFiltro.TabIndex = 14;
            // 
            // graficaDeUsoDeBombas
            // 
            chartArea2.Name = "ChartArea1";
            this.graficaDeUsoDeBombas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficaDeUsoDeBombas.Legends.Add(legend2);
            this.graficaDeUsoDeBombas.Location = new System.Drawing.Point(360, 56);
            this.graficaDeUsoDeBombas.Name = "graficaDeUsoDeBombas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficaDeUsoDeBombas.Series.Add(series2);
            this.graficaDeUsoDeBombas.Size = new System.Drawing.Size(214, 133);
            this.graficaDeUsoDeBombas.TabIndex = 15;
            this.graficaDeUsoDeBombas.Text = "chart1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(357, 208);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "MAS USADA";
            // 
            // txtBombaMásUsada
            // 
            this.txtBombaMásUsada.Location = new System.Drawing.Point(430, 205);
            this.txtBombaMásUsada.Name = "txtBombaMásUsada";
            this.txtBombaMásUsada.Size = new System.Drawing.Size(144, 20);
            this.txtBombaMásUsada.TabIndex = 17;
            // 
            // txtBombaMenosUsada
            // 
            this.txtBombaMenosUsada.Location = new System.Drawing.Point(430, 245);
            this.txtBombaMenosUsada.Name = "txtBombaMenosUsada";
            this.txtBombaMenosUsada.Size = new System.Drawing.Size(144, 20);
            this.txtBombaMenosUsada.TabIndex = 19;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(357, 248);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "MENOR";
            // 
            // btnCargarDatosDeFiltro
            // 
            this.btnCargarDatosDeFiltro.Location = new System.Drawing.Point(342, 296);
            this.btnCargarDatosDeFiltro.Name = "btnCargarDatosDeFiltro";
            this.btnCargarDatosDeFiltro.Size = new System.Drawing.Size(246, 27);
            this.btnCargarDatosDeFiltro.TabIndex = 20;
            this.btnCargarDatosDeFiltro.Text = "CARGAR DATOS";
            this.btnCargarDatosDeFiltro.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAbastecimientoBomba1
            // 
            this.btnSiguienteAbastecimientoBomba1.Enabled = false;
            this.btnSiguienteAbastecimientoBomba1.Location = new System.Drawing.Point(7, 332);
            this.btnSiguienteAbastecimientoBomba1.Name = "btnSiguienteAbastecimientoBomba1";
            this.btnSiguienteAbastecimientoBomba1.Size = new System.Drawing.Size(282, 23);
            this.btnSiguienteAbastecimientoBomba1.TabIndex = 38;
            this.btnSiguienteAbastecimientoBomba1.Text = "COBRO";
            this.btnSiguienteAbastecimientoBomba1.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAbastecimientoBomba2
            // 
            this.btnSiguienteAbastecimientoBomba2.Enabled = false;
            this.btnSiguienteAbastecimientoBomba2.Location = new System.Drawing.Point(303, 332);
            this.btnSiguienteAbastecimientoBomba2.Name = "btnSiguienteAbastecimientoBomba2";
            this.btnSiguienteAbastecimientoBomba2.Size = new System.Drawing.Size(282, 23);
            this.btnSiguienteAbastecimientoBomba2.TabIndex = 39;
            this.btnSiguienteAbastecimientoBomba2.Text = "COBRO";
            this.btnSiguienteAbastecimientoBomba2.UseVisualStyleBackColor = true;
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
            this.tabReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAbastecimientosActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCierresPasados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAbastecimientosPasados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaDeUsoDeBombas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
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
        private System.Windows.Forms.DataGridView tablaAbastecimientosActuales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxCF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBombasDisponibles;
        private System.Windows.Forms.TextBox txtCantidadEfectivoPorCobrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadLitrosGasolina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipoAbstecimiento;
        private System.Windows.Forms.Button btnSolicitarDespacho;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtPrecioGasolinaDeHoy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listaDespachosBomba2;
        private System.Windows.Forms.ListBox listaDespachosBomba1;
        private System.Windows.Forms.Button btnDetenerDespachoBomba1;
        private System.Windows.Forms.Button btnIniciarDespachoBomba1;
        private System.Windows.Forms.TextBox txtIdDespachoBomba1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnRealizarCobroBomba1;
        private System.Windows.Forms.TextBox txtProgresoMontoBomba1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtProgresoLitrosBomba1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIdDespachoBomba2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnRealizarCobroBomba2;
        private System.Windows.Forms.TextBox txtProgresoMontoBomba2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtProgresoLitrosBomba2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnDetenerDespachoBomba2;
        private System.Windows.Forms.Button btnIniciarDespachoBomba2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView tablaCierresPasados;
        private System.Windows.Forms.Button btnCargarDatosDeFiltro;
        private System.Windows.Forms.TextBox txtBombaMenosUsada;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBombaMásUsada;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaDeUsoDeBombas;
        private System.Windows.Forms.ComboBox cbSeleccionDeFiltro;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView tablaAbastecimientosPasados;
        private System.Windows.Forms.Button btnSiguienteAbastecimientoBomba2;
        private System.Windows.Forms.Button btnSiguienteAbastecimientoBomba1;
    }
}

