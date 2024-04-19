namespace CapturarIngresos
{
    partial class AgregarTransportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTransportista));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ibAgregar = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.nudRegistro = new System.Windows.Forms.NumericUpDown();
            this.ibSacarFoto = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLegajo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNrotarjeta = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.ibEscanear = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrotarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(848, 45);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "Datos de ingreso ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 41);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.lblIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIngreso.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.White;
            this.lblIngreso.Location = new System.Drawing.Point(12, 11);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(155, 23);
            this.lblIngreso.TabIndex = 10;
            this.lblIngreso.Text = "Agregar Chofer";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(470, 166);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // ibAgregar
            // 
            this.ibAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ibAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibAgregar.FlatAppearance.BorderSize = 0;
            this.ibAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibAgregar.IconColor = System.Drawing.Color.Black;
            this.ibAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgregar.IconSize = 30;
            this.ibAgregar.Location = new System.Drawing.Point(746, 385);
            this.ibAgregar.Name = "ibAgregar";
            this.ibAgregar.Size = new System.Drawing.Size(90, 35);
            this.ibAgregar.TabIndex = 7;
            this.ibAgregar.Text = "Aceptar";
            this.ibAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAgregar.UseVisualStyleBackColor = false;
            this.ibAgregar.Click += new System.EventHandler(this.ibAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(341, 167);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 16);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(375, 266);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(93, 16);
            this.lblDni.TabIndex = 33;
            this.lblDni.Text = "Nro Registro:";
            // 
            // nudRegistro
            // 
            this.nudRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudRegistro.Location = new System.Drawing.Point(470, 266);
            this.nudRegistro.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudRegistro.Name = "nudRegistro";
            this.nudRegistro.Size = new System.Drawing.Size(196, 20);
            this.nudRegistro.TabIndex = 2;
            // 
            // ibSacarFoto
            // 
            this.ibSacarFoto.FlatAppearance.BorderSize = 0;
            this.ibSacarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSacarFoto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSacarFoto.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.ibSacarFoto.IconColor = System.Drawing.Color.Black;
            this.ibSacarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSacarFoto.IconSize = 30;
            this.ibSacarFoto.Location = new System.Drawing.Point(113, 385);
            this.ibSacarFoto.Name = "ibSacarFoto";
            this.ibSacarFoto.Size = new System.Drawing.Size(120, 48);
            this.ibSacarFoto.TabIndex = 6;
            this.ibSacarFoto.Text = "Sacar Foto";
            this.ibSacarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSacarFoto.UseVisualStyleBackColor = true;
            this.ibSacarFoto.Click += new System.EventHandler(this.ibSacarFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CapturarIngresos.Properties.Resources.user_128_512;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(663, 458);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 14);
            this.lblFecha.TabIndex = 65;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(715, 453);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(121, 23);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(429, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "DNI:";
            // 
            // nudLegajo
            // 
            this.nudLegajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudLegajo.Location = new System.Drawing.Point(470, 120);
            this.nudLegajo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudLegajo.Name = "nudLegajo";
            this.nudLegajo.Size = new System.Drawing.Size(196, 20);
            this.nudLegajo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(409, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Legajo:";
            // 
            // nudNrotarjeta
            // 
            this.nudNrotarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudNrotarjeta.Location = new System.Drawing.Point(470, 213);
            this.nudNrotarjeta.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNrotarjeta.Name = "nudNrotarjeta";
            this.nudNrotarjeta.Size = new System.Drawing.Size(196, 20);
            this.nudNrotarjeta.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(387, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "N° Tarjeta:";
            // 
            // txtDNI
            // 
            this.txtDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Location = new System.Drawing.Point(470, 321);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(196, 20);
            this.txtDNI.TabIndex = 82;
            // 
            // ibEscanear
            // 
            this.ibEscanear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibEscanear.FlatAppearance.BorderSize = 0;
            this.ibEscanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEscanear.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.ibEscanear.IconColor = System.Drawing.Color.Black;
            this.ibEscanear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEscanear.IconSize = 30;
            this.ibEscanear.Location = new System.Drawing.Point(738, 48);
            this.ibEscanear.Name = "ibEscanear";
            this.ibEscanear.Size = new System.Drawing.Size(98, 35);
            this.ibEscanear.TabIndex = 83;
            this.ibEscanear.Text = "Escanear";
            this.ibEscanear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibEscanear.UseVisualStyleBackColor = true;
            this.ibEscanear.Click += new System.EventHandler(this.ibEscanear_Click);
            // 
            // AgregarTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 488);
            this.Controls.Add(this.ibEscanear);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.nudNrotarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudLegajo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.ibSacarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudRegistro);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.ibAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AgregarTransportista";
            this.Text = "AgregarTransportista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarTransportista_FormClosing);
            this.Load += new System.EventHandler(this.AgregarTransportista_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrotarjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton ibAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.NumericUpDown nudRegistro;
        private FontAwesome.Sharp.IconButton ibSacarFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNrotarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private FontAwesome.Sharp.IconButton ibEscanear;
    }
}