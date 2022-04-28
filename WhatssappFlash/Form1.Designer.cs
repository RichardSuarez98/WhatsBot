namespace WhatssappFlash
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWhatsapp = new System.Windows.Forms.Button();
            this.txtMensajePrevisualizacion = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnBotAutomatico = new System.Windows.Forms.Button();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPrevisualizacion = new System.Windows.Forms.Button();
            this.btnPersonalizado = new System.Windows.Forms.Button();
            this.nmrTImagen = new System.Windows.Forms.NumericUpDown();
            this.nmrTMensaje = new System.Windows.Forms.NumericUpDown();
            this.nmrTNumero = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.Location = new System.Drawing.Point(38, 46);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(165, 23);
            this.btnWhatsapp.TabIndex = 1;
            this.btnWhatsapp.Text = "Whatsapp";
            this.btnWhatsapp.UseVisualStyleBackColor = true;
            this.btnWhatsapp.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMensajePrevisualizacion
            // 
            this.txtMensajePrevisualizacion.Location = new System.Drawing.Point(12, 238);
            this.txtMensajePrevisualizacion.Multiline = true;
            this.txtMensajePrevisualizacion.Name = "txtMensajePrevisualizacion";
            this.txtMensajePrevisualizacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensajePrevisualizacion.Size = new System.Drawing.Size(217, 167);
            this.txtMensajePrevisualizacion.TabIndex = 2;
            this.txtMensajePrevisualizacion.WordWrap = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(38, 84);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(165, 23);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "Iniciar Campaña";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBotAutomatico
            // 
            this.btnBotAutomatico.Location = new System.Drawing.Point(38, 125);
            this.btnBotAutomatico.Name = "btnBotAutomatico";
            this.btnBotAutomatico.Size = new System.Drawing.Size(165, 23);
            this.btnBotAutomatico.TabIndex = 4;
            this.btnBotAutomatico.Text = "Iniciar Bot";
            this.btnBotAutomatico.UseVisualStyleBackColor = true;
            this.btnBotAutomatico.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Location = new System.Drawing.Point(493, 46);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.RowTemplate.Height = 25;
            this.dgvListaCliente.Size = new System.Drawing.Size(495, 357);
            this.dgvListaCliente.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(823, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cargar Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(277, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Cargar Imagen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPrevisualizacion
            // 
            this.btnPrevisualizacion.Location = new System.Drawing.Point(277, 382);
            this.btnPrevisualizacion.Name = "btnPrevisualizacion";
            this.btnPrevisualizacion.Size = new System.Drawing.Size(165, 23);
            this.btnPrevisualizacion.TabIndex = 10;
            this.btnPrevisualizacion.Text = "Previsualizar";
            this.btnPrevisualizacion.UseVisualStyleBackColor = true;
            this.btnPrevisualizacion.Click += new System.EventHandler(this.btnPrevisualizacion_Click);
            // 
            // btnPersonalizado
            // 
            this.btnPersonalizado.Location = new System.Drawing.Point(277, 353);
            this.btnPersonalizado.Name = "btnPersonalizado";
            this.btnPersonalizado.Size = new System.Drawing.Size(165, 23);
            this.btnPersonalizado.TabIndex = 11;
            this.btnPersonalizado.Text = "Agregar";
            this.btnPersonalizado.UseVisualStyleBackColor = true;
            this.btnPersonalizado.Click += new System.EventHandler(this.btnPersonalizado_Click);
            // 
            // nmrTImagen
            // 
            this.nmrTImagen.Location = new System.Drawing.Point(97, 189);
            this.nmrTImagen.Name = "nmrTImagen";
            this.nmrTImagen.Size = new System.Drawing.Size(33, 23);
            this.nmrTImagen.TabIndex = 12;
            this.nmrTImagen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrTMensaje
            // 
            this.nmrTMensaje.Location = new System.Drawing.Point(153, 189);
            this.nmrTMensaje.Name = "nmrTMensaje";
            this.nmrTMensaje.Size = new System.Drawing.Size(33, 23);
            this.nmrTMensaje.TabIndex = 13;
            this.nmrTMensaje.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrTNumero
            // 
            this.nmrTNumero.Location = new System.Drawing.Point(38, 189);
            this.nmrTNumero.Name = "nmrTNumero";
            this.nmrTNumero.Size = new System.Drawing.Size(33, 23);
            this.nmrTNumero.TabIndex = 14;
            this.nmrTNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(128, 154);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1013, 443);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.nmrTNumero);
            this.Controls.Add(this.nmrTMensaje);
            this.Controls.Add(this.nmrTImagen);
            this.Controls.Add(this.dgvListaCliente);
            this.Controls.Add(this.btnPersonalizado);
            this.Controls.Add(this.btnPrevisualizacion);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBotAutomatico);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMensajePrevisualizacion);
            this.Controls.Add(this.btnWhatsapp);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWhatsapp;
        private System.Windows.Forms.TextBox txtMensajePrevisualizacion;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnBotAutomatico;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnPrevisualizacion;
        private System.Windows.Forms.Button btnPersonalizado;
        private System.Windows.Forms.NumericUpDown nmrTImagen;
        private System.Windows.Forms.NumericUpDown nmrTMensaje;
        private System.Windows.Forms.NumericUpDown nmrTNumero;
        private System.Windows.Forms.Button btnStop;
    }
}
