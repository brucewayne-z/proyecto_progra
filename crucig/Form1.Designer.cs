﻿namespace crucig
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            btnConfiguracion = new ToolStripMenuItem();
            btnResultados = new ToolStripMenuItem();
            btnJugarPartida = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            panelResultados = new Panel();
            btnRegresar = new Button();
            dgvResultados = new DataGridView();
            panelJuego = new Panel();
            label15 = new Label();
            label7 = new Label();
            pictureJugador2 = new PictureBox();
            pictureJugador1 = new PictureBox();
            labelPuntuacionJugador2 = new Label();
            labelPuntuacionJugador1 = new Label();
            btnReiniciarPartida = new Button();
            btnEndGame = new Button();
            labelEstadisticasPlayer2 = new Label();
            labelEstadisticasPlayer1 = new Label();
            textPalabra = new TextBox();
            label9 = new Label();
            labelTiempoTurnoRestante = new Label();
            label8 = new Label();
            label5 = new Label();
            labelJugadorActual = new Label();
            label6 = new Label();
            n1 = new Label();
            definicion1 = new Label();
            definicion5 = new Label();
            definicion4 = new Label();
            definicion3 = new Label();
            definicion2 = new Label();
            labelTiempoRestante = new Label();
            n5 = new Label();
            n4 = new Label();
            n3 = new Label();
            n2 = new Label();
            btnCheck = new Button();
            pictureBox4 = new PictureBox();
            panelConfiguracion = new Panel();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnGuardarConfiguracion = new Button();
            btnFoto2 = new Button();
            nameJugador2 = new TextBox();
            nameJugador1 = new TextBox();
            label1 = new Label();
            tiempoTurno = new NumericUpDown();
            tiempoPartida = new NumericUpDown();
            label2 = new Label();
            btnFoto1 = new Button();
            label3 = new Label();
            label4 = new Label();
            panelMenuPrincipal = new Panel();
            btnJugarAhoraMenuPrincipal = new Button();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            openFile1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            timerTurno = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            panelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureJugador2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureJugador1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tiempoTurno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tiempoPartida).BeginInit();
            panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnConfiguracion, btnResultados, btnJugarPartida });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1082, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(116, 24);
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnResultados
            // 
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(95, 24);
            btnResultados.Text = "Resultados";
            btnResultados.Click += btnResultados_Click;
            // 
            // btnJugarPartida
            // 
            btnJugarPartida.Name = "btnJugarPartida";
            btnJugarPartida.Size = new Size(108, 24);
            btnJugarPartida.Text = "Jugar Partida";
            btnJugarPartida.Click += btnJugarPartida_Click_1;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(panelResultados);
            panelPrincipal.Controls.Add(panelJuego);
            panelPrincipal.Controls.Add(panelConfiguracion);
            panelPrincipal.Location = new Point(0, 61);
            panelPrincipal.Margin = new Padding(3, 4, 3, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1079, 587);
            panelPrincipal.TabIndex = 1;
            // 
            // panelResultados
            // 
            panelResultados.Controls.Add(btnRegresar);
            panelResultados.Controls.Add(dgvResultados);
            panelResultados.Dock = DockStyle.Fill;
            panelResultados.Location = new Point(0, 0);
            panelResultados.Margin = new Padding(3, 4, 3, 4);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(1079, 587);
            panelResultados.TabIndex = 2;
            panelResultados.Visible = false;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(11, 7, 19);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.SlateBlue;
            btnRegresar.Location = new Point(911, 17);
            btnRegresar.Margin = new Padding(3, 4, 3, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(149, 36);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar al menú";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.BackgroundColor = Color.FromArgb(11, 7, 19);
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(0, -25);
            dgvResultados.Margin = new Padding(3, 4, 3, 4);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.RowTemplate.Height = 25;
            dgvResultados.Size = new Size(1075, 589);
            dgvResultados.TabIndex = 0;
            // 
            // panelJuego
            // 
            panelJuego.BackColor = Color.FromArgb(11, 7, 19);
            panelJuego.Controls.Add(label15);
            panelJuego.Controls.Add(label7);
            panelJuego.Controls.Add(pictureJugador2);
            panelJuego.Controls.Add(pictureJugador1);
            panelJuego.Controls.Add(labelPuntuacionJugador2);
            panelJuego.Controls.Add(labelPuntuacionJugador1);
            panelJuego.Controls.Add(btnReiniciarPartida);
            panelJuego.Controls.Add(btnEndGame);
            panelJuego.Controls.Add(labelEstadisticasPlayer2);
            panelJuego.Controls.Add(labelEstadisticasPlayer1);
            panelJuego.Controls.Add(textPalabra);
            panelJuego.Controls.Add(label9);
            panelJuego.Controls.Add(labelTiempoTurnoRestante);
            panelJuego.Controls.Add(label8);
            panelJuego.Controls.Add(label5);
            panelJuego.Controls.Add(labelJugadorActual);
            panelJuego.Controls.Add(label6);
            panelJuego.Controls.Add(n1);
            panelJuego.Controls.Add(definicion1);
            panelJuego.Controls.Add(definicion5);
            panelJuego.Controls.Add(definicion4);
            panelJuego.Controls.Add(definicion3);
            panelJuego.Controls.Add(definicion2);
            panelJuego.Controls.Add(labelTiempoRestante);
            panelJuego.Controls.Add(n5);
            panelJuego.Controls.Add(n4);
            panelJuego.Controls.Add(n3);
            panelJuego.Controls.Add(n2);
            panelJuego.Controls.Add(btnCheck);
            panelJuego.Controls.Add(pictureBox4);
            panelJuego.Dock = DockStyle.Fill;
            panelJuego.Location = new Point(0, 0);
            panelJuego.Margin = new Padding(3, 4, 3, 4);
            panelJuego.Name = "panelJuego";
            panelJuego.Size = new Size(1079, 587);
            panelJuego.TabIndex = 1;
            panelJuego.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(11, 7, 19);
            label15.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(959, 221);
            label15.Name = "label15";
            label15.Size = new Size(62, 18);
            label15.TabIndex = 72;
            label15.Text = "Puntos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(11, 7, 19);
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(841, 221);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 71;
            label7.Text = "Puntos:";
            // 
            // pictureJugador2
            // 
            pictureJugador2.Location = new Point(959, 96);
            pictureJugador2.Margin = new Padding(3, 4, 3, 4);
            pictureJugador2.Name = "pictureJugador2";
            pictureJugador2.Size = new Size(101, 116);
            pictureJugador2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureJugador2.TabIndex = 70;
            pictureJugador2.TabStop = false;
            // 
            // pictureJugador1
            // 
            pictureJugador1.Location = new Point(841, 96);
            pictureJugador1.Margin = new Padding(3, 4, 3, 4);
            pictureJugador1.Name = "pictureJugador1";
            pictureJugador1.Size = new Size(101, 116);
            pictureJugador1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureJugador1.TabIndex = 69;
            pictureJugador1.TabStop = false;
            // 
            // labelPuntuacionJugador2
            // 
            labelPuntuacionJugador2.AutoSize = true;
            labelPuntuacionJugador2.ForeColor = SystemColors.Control;
            labelPuntuacionJugador2.Location = new Point(1024, 221);
            labelPuntuacionJugador2.Name = "labelPuntuacionJugador2";
            labelPuntuacionJugador2.Size = new Size(17, 20);
            labelPuntuacionJugador2.TabIndex = 66;
            labelPuntuacionJugador2.Text = "0";
            // 
            // labelPuntuacionJugador1
            // 
            labelPuntuacionJugador1.AutoSize = true;
            labelPuntuacionJugador1.ForeColor = SystemColors.Control;
            labelPuntuacionJugador1.Location = new Point(905, 221);
            labelPuntuacionJugador1.Name = "labelPuntuacionJugador1";
            labelPuntuacionJugador1.Size = new Size(17, 20);
            labelPuntuacionJugador1.TabIndex = 65;
            labelPuntuacionJugador1.Text = "0";
            // 
            // btnReiniciarPartida
            // 
            btnReiniciarPartida.BackColor = Color.FromArgb(11, 7, 19);
            btnReiniciarPartida.FlatStyle = FlatStyle.Flat;
            btnReiniciarPartida.ForeColor = Color.IndianRed;
            btnReiniciarPartida.Location = new Point(959, 4);
            btnReiniciarPartida.Margin = new Padding(3, 4, 3, 4);
            btnReiniciarPartida.Name = "btnReiniciarPartida";
            btnReiniciarPartida.Size = new Size(109, 31);
            btnReiniciarPartida.TabIndex = 64;
            btnReiniciarPartida.Text = "Reiniciar partida";
            btnReiniciarPartida.UseVisualStyleBackColor = false;
            btnReiniciarPartida.Click += btnReiniciarPartida_Click;
            // 
            // btnEndGame
            // 
            btnEndGame.BackColor = Color.FromArgb(11, 7, 19);
            btnEndGame.FlatStyle = FlatStyle.Flat;
            btnEndGame.ForeColor = Color.IndianRed;
            btnEndGame.Location = new Point(843, 4);
            btnEndGame.Margin = new Padding(3, 4, 3, 4);
            btnEndGame.Name = "btnEndGame";
            btnEndGame.Size = new Size(109, 31);
            btnEndGame.TabIndex = 63;
            btnEndGame.Text = "Terminar juego";
            btnEndGame.UseVisualStyleBackColor = false;
            btnEndGame.Click += btnEndGame_Click;
            // 
            // labelEstadisticasPlayer2
            // 
            labelEstadisticasPlayer2.AutoSize = true;
            labelEstadisticasPlayer2.BackColor = Color.FromArgb(11, 7, 19);
            labelEstadisticasPlayer2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstadisticasPlayer2.ForeColor = SystemColors.Control;
            labelEstadisticasPlayer2.Location = new Point(960, 67);
            labelEstadisticasPlayer2.Name = "labelEstadisticasPlayer2";
            labelEstadisticasPlayer2.Padding = new Padding(17, 3, 17, 3);
            labelEstadisticasPlayer2.Size = new Size(104, 24);
            labelEstadisticasPlayer2.TabIndex = 62;
            labelEstadisticasPlayer2.Text = "jugador2";
            // 
            // labelEstadisticasPlayer1
            // 
            labelEstadisticasPlayer1.AutoSize = true;
            labelEstadisticasPlayer1.BackColor = Color.FromArgb(11, 7, 19);
            labelEstadisticasPlayer1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstadisticasPlayer1.ForeColor = SystemColors.Control;
            labelEstadisticasPlayer1.Location = new Point(841, 67);
            labelEstadisticasPlayer1.Name = "labelEstadisticasPlayer1";
            labelEstadisticasPlayer1.Padding = new Padding(17, 3, 17, 3);
            labelEstadisticasPlayer1.Size = new Size(104, 24);
            labelEstadisticasPlayer1.TabIndex = 61;
            labelEstadisticasPlayer1.Text = "jugador1";
            // 
            // textPalabra
            // 
            textPalabra.BackColor = SystemColors.Window;
            textPalabra.Location = new Point(603, 125);
            textPalabra.Margin = new Padding(3, 4, 3, 4);
            textPalabra.Name = "textPalabra";
            textPalabra.Size = new Size(180, 27);
            textPalabra.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(11, 7, 19);
            label9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(626, 81);
            label9.Name = "label9";
            label9.Padding = new Padding(17, 5, 17, 5);
            label9.Size = new Size(148, 32);
            label9.TabIndex = 59;
            label9.Text = "Ingresar palabra";
            // 
            // labelTiempoTurnoRestante
            // 
            labelTiempoTurnoRestante.AutoSize = true;
            labelTiempoTurnoRestante.BackColor = Color.FromArgb(11, 7, 19);
            labelTiempoTurnoRestante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempoTurnoRestante.ForeColor = SystemColors.Control;
            labelTiempoTurnoRestante.Location = new Point(418, 3);
            labelTiempoTurnoRestante.Name = "labelTiempoTurnoRestante";
            labelTiempoTurnoRestante.Size = new Size(61, 18);
            labelTiempoTurnoRestante.TabIndex = 58;
            labelTiempoTurnoRestante.Text = "Tiempo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(11, 7, 19);
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(270, 1);
            label8.Name = "label8";
            label8.Size = new Size(158, 19);
            label8.TabIndex = 57;
            label8.Text = "Cambio de turno en:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(11, 7, 19);
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(14, 0);
            label5.Name = "label5";
            label5.Size = new Size(159, 19);
            label5.TabIndex = 56;
            label5.Text = "Tiempo transcurrido:";
            // 
            // labelJugadorActual
            // 
            labelJugadorActual.AutoSize = true;
            labelJugadorActual.BackColor = Color.FromArgb(11, 7, 19);
            labelJugadorActual.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelJugadorActual.ForeColor = Color.SpringGreen;
            labelJugadorActual.Location = new Point(614, 3);
            labelJugadorActual.Name = "labelJugadorActual";
            labelJugadorActual.Size = new Size(79, 24);
            labelJugadorActual.TabIndex = 55;
            labelJugadorActual.Text = "jugador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(11, 7, 19);
            label6.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(520, 3);
            label6.Name = "label6";
            label6.Size = new Size(97, 24);
            label6.TabIndex = 54;
            label6.Text = "Turno de:";
            // 
            // n1
            // 
            n1.AutoSize = true;
            n1.FlatStyle = FlatStyle.Flat;
            n1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            n1.ForeColor = SystemColors.Control;
            n1.Location = new Point(465, 393);
            n1.Name = "n1";
            n1.Size = new Size(18, 19);
            n1.TabIndex = 53;
            n1.Text = "n";
            // 
            // definicion1
            // 
            definicion1.AutoSize = true;
            definicion1.FlatStyle = FlatStyle.Flat;
            definicion1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            definicion1.ForeColor = SystemColors.Control;
            definicion1.Location = new Point(499, 393);
            definicion1.Name = "definicion1";
            definicion1.Size = new Size(80, 19);
            definicion1.TabIndex = 52;
            definicion1.Text = "definicion";
            // 
            // definicion5
            // 
            definicion5.AutoSize = true;
            definicion5.FlatStyle = FlatStyle.Flat;
            definicion5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            definicion5.ForeColor = SystemColors.Control;
            definicion5.Location = new Point(499, 549);
            definicion5.Name = "definicion5";
            definicion5.Size = new Size(80, 19);
            definicion5.TabIndex = 51;
            definicion5.Text = "definicion";
            // 
            // definicion4
            // 
            definicion4.AutoSize = true;
            definicion4.FlatStyle = FlatStyle.Flat;
            definicion4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            definicion4.ForeColor = SystemColors.Control;
            definicion4.Location = new Point(499, 511);
            definicion4.Name = "definicion4";
            definicion4.Size = new Size(80, 19);
            definicion4.TabIndex = 50;
            definicion4.Text = "definicion";
            // 
            // definicion3
            // 
            definicion3.AutoSize = true;
            definicion3.FlatStyle = FlatStyle.Flat;
            definicion3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            definicion3.ForeColor = SystemColors.Control;
            definicion3.Location = new Point(499, 480);
            definicion3.Name = "definicion3";
            definicion3.Size = new Size(80, 19);
            definicion3.TabIndex = 49;
            definicion3.Text = "definicion";
            // 
            // definicion2
            // 
            definicion2.AutoSize = true;
            definicion2.FlatStyle = FlatStyle.Flat;
            definicion2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            definicion2.ForeColor = SystemColors.Control;
            definicion2.Location = new Point(499, 436);
            definicion2.Name = "definicion2";
            definicion2.Size = new Size(80, 19);
            definicion2.TabIndex = 48;
            definicion2.Text = "definicion";
            // 
            // labelTiempoRestante
            // 
            labelTiempoRestante.AutoSize = true;
            labelTiempoRestante.BackColor = Color.FromArgb(11, 7, 19);
            labelTiempoRestante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempoRestante.ForeColor = SystemColors.Control;
            labelTiempoRestante.Location = new Point(153, 1);
            labelTiempoRestante.Name = "labelTiempoRestante";
            labelTiempoRestante.Size = new Size(61, 18);
            labelTiempoRestante.TabIndex = 46;
            labelTiempoRestante.Text = "Tiempo";
            // 
            // n5
            // 
            n5.AutoSize = true;
            n5.FlatStyle = FlatStyle.Flat;
            n5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            n5.ForeColor = SystemColors.Control;
            n5.Location = new Point(465, 547);
            n5.Name = "n5";
            n5.Size = new Size(18, 19);
            n5.TabIndex = 44;
            n5.Text = "n";
            // 
            // n4
            // 
            n4.AutoSize = true;
            n4.FlatStyle = FlatStyle.Flat;
            n4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            n4.ForeColor = SystemColors.Control;
            n4.Location = new Point(465, 511);
            n4.Name = "n4";
            n4.Size = new Size(18, 19);
            n4.TabIndex = 41;
            n4.Text = "n";
            // 
            // n3
            // 
            n3.AutoSize = true;
            n3.FlatStyle = FlatStyle.Flat;
            n3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            n3.ForeColor = SystemColors.Control;
            n3.Location = new Point(465, 480);
            n3.Name = "n3";
            n3.Size = new Size(18, 19);
            n3.TabIndex = 39;
            n3.Text = "n";
            // 
            // n2
            // 
            n2.AutoSize = true;
            n2.FlatStyle = FlatStyle.Flat;
            n2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            n2.ForeColor = SystemColors.Control;
            n2.Location = new Point(465, 436);
            n2.Name = "n2";
            n2.Size = new Size(18, 19);
            n2.TabIndex = 37;
            n2.Text = "n";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(11, 7, 19);
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.ForeColor = Color.MediumSlateBlue;
            btnCheck.Location = new Point(640, 165);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(109, 31);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Adivinar!";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bg;
            pictureBox4.Location = new Point(0, -19);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1082, 67);
            pictureBox4.TabIndex = 68;
            pictureBox4.TabStop = false;
            // 
            // panelConfiguracion
            // 
            panelConfiguracion.BackColor = Color.FromArgb(11, 7, 19);
            panelConfiguracion.Controls.Add(pictureBox2);
            panelConfiguracion.Controls.Add(label14);
            panelConfiguracion.Controls.Add(label13);
            panelConfiguracion.Controls.Add(label12);
            panelConfiguracion.Controls.Add(label11);
            panelConfiguracion.Controls.Add(btnGuardarConfiguracion);
            panelConfiguracion.Controls.Add(btnFoto2);
            panelConfiguracion.Controls.Add(nameJugador2);
            panelConfiguracion.Controls.Add(nameJugador1);
            panelConfiguracion.Controls.Add(label1);
            panelConfiguracion.Controls.Add(tiempoTurno);
            panelConfiguracion.Controls.Add(tiempoPartida);
            panelConfiguracion.Controls.Add(label2);
            panelConfiguracion.Controls.Add(btnFoto1);
            panelConfiguracion.Controls.Add(label3);
            panelConfiguracion.Controls.Add(label4);
            panelConfiguracion.Dock = DockStyle.Fill;
            panelConfiguracion.Location = new Point(0, 0);
            panelConfiguracion.Margin = new Padding(3, 4, 3, 4);
            panelConfiguracion.Name = "panelConfiguracion";
            panelConfiguracion.Size = new Size(1079, 587);
            panelConfiguracion.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2023_05_06_201828;
            pictureBox2.Location = new Point(826, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 593);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(99, 90, 105);
            label14.Location = new Point(197, 349);
            label14.Name = "label14";
            label14.Size = new Size(155, 22);
            label14.TabIndex = 17;
            label14.Text = "Segundo jugador";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(99, 90, 105);
            label13.Location = new Point(42, 349);
            label13.Name = "label13";
            label13.Size = new Size(134, 22);
            label13.TabIndex = 16;
            label13.Text = "Primer jugador";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(99, 90, 105);
            label12.Location = new Point(345, 203);
            label12.Name = "label12";
            label12.Size = new Size(97, 22);
            label12.TabIndex = 15;
            label12.Text = "Segundos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(99, 90, 105);
            label11.Location = new Point(48, 203);
            label11.Name = "label11";
            label11.Size = new Size(97, 22);
            label11.TabIndex = 14;
            label11.Text = "Segundos";
            // 
            // btnGuardarConfiguracion
            // 
            btnGuardarConfiguracion.FlatStyle = FlatStyle.Flat;
            btnGuardarConfiguracion.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarConfiguracion.ForeColor = Color.SlateBlue;
            btnGuardarConfiguracion.Location = new Point(33, 527);
            btnGuardarConfiguracion.Margin = new Padding(3, 4, 3, 4);
            btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            btnGuardarConfiguracion.Size = new Size(176, 44);
            btnGuardarConfiguracion.TabIndex = 13;
            btnGuardarConfiguracion.Text = "Guardar";
            btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            btnGuardarConfiguracion.Click += btnGuardarConfiguracion_Click;
            // 
            // btnFoto2
            // 
            btnFoto2.BackColor = Color.FromArgb(52, 42, 68);
            btnFoto2.FlatAppearance.BorderSize = 0;
            btnFoto2.FlatStyle = FlatStyle.Flat;
            btnFoto2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFoto2.ForeColor = SystemColors.Control;
            btnFoto2.Location = new Point(197, 381);
            btnFoto2.Margin = new Padding(3, 4, 3, 4);
            btnFoto2.Name = "btnFoto2";
            btnFoto2.Size = new Size(125, 32);
            btnFoto2.TabIndex = 12;
            btnFoto2.Text = "Foto de perfil";
            btnFoto2.UseVisualStyleBackColor = false;
            btnFoto2.Click += btnFoto2_Click;
            // 
            // nameJugador2
            // 
            nameJugador2.BackColor = Color.FromArgb(11, 7, 19);
            nameJugador2.BorderStyle = BorderStyle.FixedSingle;
            nameJugador2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameJugador2.ForeColor = Color.White;
            nameJugador2.Location = new Point(197, 299);
            nameJugador2.Margin = new Padding(3, 4, 3, 4);
            nameJugador2.Name = "nameJugador2";
            nameJugador2.Size = new Size(114, 29);
            nameJugador2.TabIndex = 10;
            // 
            // nameJugador1
            // 
            nameJugador1.BackColor = Color.FromArgb(11, 7, 19);
            nameJugador1.BorderStyle = BorderStyle.FixedSingle;
            nameJugador1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameJugador1.ForeColor = Color.White;
            nameJugador1.Location = new Point(47, 299);
            nameJugador1.Margin = new Padding(3, 4, 3, 4);
            nameJugador1.Name = "nameJugador1";
            nameJugador1.Size = new Size(114, 29);
            nameJugador1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(274, 22);
            label1.TabIndex = 0;
            label1.Text = "CONFIGURACIÓN DE JUEGO";
            // 
            // tiempoTurno
            // 
            tiempoTurno.BackColor = Color.FromArgb(42, 32, 58);
            tiempoTurno.BorderStyle = BorderStyle.None;
            tiempoTurno.ForeColor = SystemColors.Window;
            tiempoTurno.Location = new Point(345, 168);
            tiempoTurno.Margin = new Padding(3, 4, 3, 4);
            tiempoTurno.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            tiempoTurno.Name = "tiempoTurno";
            tiempoTurno.Size = new Size(224, 23);
            tiempoTurno.TabIndex = 8;
            // 
            // tiempoPartida
            // 
            tiempoPartida.BackColor = Color.FromArgb(42, 32, 58);
            tiempoPartida.BorderStyle = BorderStyle.None;
            tiempoPartida.ForeColor = SystemColors.Window;
            tiempoPartida.Location = new Point(48, 168);
            tiempoPartida.Margin = new Padding(3, 4, 3, 4);
            tiempoPartida.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            tiempoPartida.Name = "tiempoPartida";
            tiempoPartida.Size = new Size(211, 23);
            tiempoPartida.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(42, 125);
            label2.Name = "label2";
            label2.Size = new Size(153, 22);
            label2.TabIndex = 1;
            label2.Text = "Tiempo de juego";
            // 
            // btnFoto1
            // 
            btnFoto1.BackColor = Color.FromArgb(52, 42, 68);
            btnFoto1.FlatAppearance.BorderSize = 0;
            btnFoto1.FlatStyle = FlatStyle.Flat;
            btnFoto1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFoto1.ForeColor = SystemColors.Control;
            btnFoto1.Location = new Point(39, 381);
            btnFoto1.Margin = new Padding(3, 4, 3, 4);
            btnFoto1.Name = "btnFoto1";
            btnFoto1.Size = new Size(123, 32);
            btnFoto1.TabIndex = 11;
            btnFoto1.Text = "Foto de perfil";
            btnFoto1.UseVisualStyleBackColor = false;
            btnFoto1.Click += btnFoto1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(345, 125);
            label3.Name = "label3";
            label3.Size = new Size(154, 22);
            label3.TabIndex = 2;
            label3.Text = "Tiempo por turno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(47, 264);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 3;
            label4.Text = "Nombres";
            // 
            // panelMenuPrincipal
            // 
            panelMenuPrincipal.BackColor = Color.FromArgb(11, 7, 17);
            panelMenuPrincipal.Controls.Add(btnJugarAhoraMenuPrincipal);
            panelMenuPrincipal.Controls.Add(label10);
            panelMenuPrincipal.Controls.Add(pictureBox1);
            panelMenuPrincipal.Location = new Point(0, 39);
            panelMenuPrincipal.Margin = new Padding(3, 4, 3, 4);
            panelMenuPrincipal.Name = "panelMenuPrincipal";
            panelMenuPrincipal.Size = new Size(1082, 609);
            panelMenuPrincipal.TabIndex = 14;
            // 
            // btnJugarAhoraMenuPrincipal
            // 
            btnJugarAhoraMenuPrincipal.BackColor = Color.FromArgb(42, 32, 58);
            btnJugarAhoraMenuPrincipal.FlatAppearance.BorderSize = 0;
            btnJugarAhoraMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnJugarAhoraMenuPrincipal.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnJugarAhoraMenuPrincipal.ForeColor = Color.Snow;
            btnJugarAhoraMenuPrincipal.Location = new Point(3, 147);
            btnJugarAhoraMenuPrincipal.Margin = new Padding(3, 4, 3, 4);
            btnJugarAhoraMenuPrincipal.Name = "btnJugarAhoraMenuPrincipal";
            btnJugarAhoraMenuPrincipal.Size = new Size(224, 32);
            btnJugarAhoraMenuPrincipal.TabIndex = 2;
            btnJugarAhoraMenuPrincipal.Text = "Juega ahora";
            btnJugarAhoraMenuPrincipal.UseVisualStyleBackColor = false;
            btnJugarAhoraMenuPrincipal.Click += btnJugarAhoraMenuPrincipal_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(10, 52);
            label10.Name = "label10";
            label10.Size = new Size(166, 29);
            label10.TabIndex = 1;
            label10.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2023_05_06_201828;
            pictureBox1.Location = new Point(232, 21);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(848, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFile1
            // 
            openFile1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 648);
            Controls.Add(panelMenuPrincipal);
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            panelJuego.ResumeLayout(false);
            panelJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureJugador2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureJugador1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelConfiguracion.ResumeLayout(false);
            panelConfiguracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tiempoTurno).EndInit();
            ((System.ComponentModel.ISupportInitialize)tiempoPartida).EndInit();
            panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnConfiguracion;
        private ToolStripMenuItem btnJugarPartida;
        private ToolStripMenuItem btnResultados;
        private Panel panelPrincipal;
        private Panel panelResultados;
        private Panel panelJuego;
        private Panel panelConfiguracion;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown tiempoTurno;
        private NumericUpDown tiempoPartida;
        private TextBox nameJugador2;
        private TextBox nameJugador1;
        private Button btnFoto2;
        private Button btnFoto1;
        private Button btnGuardarConfiguracion;
        private OpenFileDialog openFile1;
        private Button btnCheck;
        private TextBox async1;
        private TextBox await3;
        private TextBox await2;
        private TextBox thread6;
        private TextBox thread5;
        private TextBox thread4;
        private TextBox thread3;
        private TextBox thread2;
        private TextBox async5;
        private TextBox async4;
        private TextBox async3;
        private TextBox async2;
        private TextBox await5;
        private TextBox await4;
        private TextBox deferred8;
        private TextBox deferred7;
        private TextBox deferred6;
        private TextBox deferred5;
        private TextBox deferred4;
        private TextBox deferred3;
        private TextBox deferred2;
        private TextBox handler7;
        private TextBox handler6;
        private TextBox handler5;
        private TextBox handler4;
        private TextBox handler3;
        private TextBox handler2;
        private Label label5;
        private Label labelEstadisticasPlayer2;
        private Label definicion5;
        private Label definicion4;
        private RichTextBox richTextBox1;
        private Label label12;
        private Label label11;
        private Label n5;
        private Label n4;
        private Label n3;
        private RichTextBox richTextBox2;
        private Label n2;
        private System.Windows.Forms.Timer timer1;
        private Label labelTiempoRestante;
        private Label definicion3;
        private Label definicion2;
        private Label label16;
        private Label definicion1;
        private Label n1;
        private Label labelJugadorActual;
        private Label label6;
        private Label label8;
        private System.Windows.Forms.Timer timerTurno;
        private Label labelTiempoTurnoRestante;
        private Label label9;
        private TextBox textPalabra;
        private Label labelEstadisticasPlayer1;
        private DataGridView dgvResultados;
        private Button btnEndGame;
        private Button btnRegresar;
        private Button btnReiniciarPartida;
        private Label labelPuntuacionJugador2;
        private Label labelPuntuacionJugador1;
        private Panel panelMenuPrincipal;
        private PictureBox pictureBox1;
        private Label label10;
        private Button btnJugarAhoraMenuPrincipal;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureJugador2;
        private PictureBox pictureJugador1;
        private Label label7;
        private Label label15;
    }
}