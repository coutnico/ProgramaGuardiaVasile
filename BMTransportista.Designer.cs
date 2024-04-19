namespace CapturarIngresos
{
    partial class BMTransportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMTransportista));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudNroTarjeta = new System.Windows.Forms.NumericUpDown();
            this.ibBuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRegistro = new System.Windows.Forms.NumericUpDown();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ibEliminar = new FontAwesome.Sharp.IconButton();
            this.ibModificar = new FontAwesome.Sharp.IconButton();
            this.nudLegajo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegistro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLegajo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.nudNroTarjeta);
            this.panel1.Controls.Add(this.ibBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(56, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 179);
            this.panel1.TabIndex = 0;
            // 
            // nudNroTarjeta
            // 
            this.nudNroTarjeta.Location = new System.Drawing.Point(38, 99);
            this.nudNroTarjeta.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNroTarjeta.Name = "nudNroTarjeta";
            this.nudNroTarjeta.Size = new System.Drawing.Size(171, 20);
            this.nudNroTarjeta.TabIndex = 0;
            // 
            // ibBuscar
            // 
            this.ibBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibBuscar.ForeColor = System.Drawing.Color.White;
            this.ibBuscar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.ibBuscar.IconColor = System.Drawing.Color.White;
            this.ibBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibBuscar.IconSize = 20;
            this.ibBuscar.Location = new System.Drawing.Point(85, 137);
            this.ibBuscar.Name = "ibBuscar";
            this.ibBuscar.Size = new System.Drawing.Size(84, 27);
            this.ibBuscar.TabIndex = 1;
            this.ibBuscar.Text = "Buscar";
            this.ibBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibBuscar.UseVisualStyleBackColor = true;
            this.ibBuscar.Click += new System.EventHandler(this.ibBuscar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 69);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingresar N° de interno del chofer para rastrear datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRegistro
            // 
            this.nudRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudRegistro.Location = new System.Drawing.Point(489, 236);
            this.nudRegistro.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudRegistro.Name = "nudRegistro";
            this.nudRegistro.Size = new System.Drawing.Size(206, 20);
            this.nudRegistro.TabIndex = 2;
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblRegistro.Location = new System.Drawing.Point(397, 238);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(90, 14);
            this.lblRegistro.TabIndex = 35;
            this.lblRegistro.Text = "Nro Registro:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.lblIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIngreso.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.White;
            this.lblIngreso.Location = new System.Drawing.Point(12, 9);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(134, 23);
            this.lblIngreso.TabIndex = 49;
            this.lblIngreso.Text = "Transportista";
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
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "Datos de ingreso ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 41);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(364, 166);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 14);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(489, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(437, 380);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 14);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(489, 375);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(206, 23);
            this.txtFecha.TabIndex = 8;
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.Black;
            this.lblDni.Location = new System.Drawing.Point(448, 306);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 14);
            this.lblDni.TabIndex = 73;
            this.lblDni.Text = "DNI:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CapturarIngresos.Properties.Resources.user_128_512;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // ibEliminar
            // 
            this.ibEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ibEliminar.FlatAppearance.BorderSize = 0;
            this.ibEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEliminar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibEliminar.IconColor = System.Drawing.Color.Black;
            this.ibEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEliminar.IconSize = 30;
            this.ibEliminar.Location = new System.Drawing.Point(546, 423);
            this.ibEliminar.Name = "ibEliminar";
            this.ibEliminar.Size = new System.Drawing.Size(90, 35);
            this.ibEliminar.TabIndex = 4;
            this.ibEliminar.Text = "Eliminar";
            this.ibEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibEliminar.UseVisualStyleBackColor = false;
            this.ibEliminar.Click += new System.EventHandler(this.ibEliminar_Click);
            // 
            // ibModificar
            // 
            this.ibModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ibModificar.FlatAppearance.BorderSize = 0;
            this.ibModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibModificar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibModificar.IconColor = System.Drawing.Color.Black;
            this.ibModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibModificar.IconSize = 30;
            this.ibModificar.Location = new System.Drawing.Point(546, 423);
            this.ibModificar.Name = "ibModificar";
            this.ibModificar.Size = new System.Drawing.Size(90, 35);
            this.ibModificar.TabIndex = 5;
            this.ibModificar.Text = "Modificar";
            this.ibModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibModificar.UseVisualStyleBackColor = false;
            this.ibModificar.Click += new System.EventHandler(this.ibModificar_Click);
            // 
            // nudLegajo
            // 
            this.nudLegajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nudLegajo.Location = new System.Drawing.Point(489, 97);
            this.nudLegajo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudLegajo.Name = "nudLegajo";
            this.nudLegajo.Size = new System.Drawing.Size(206, 20);
            this.nudLegajo.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(430, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 79;
            this.label2.Text = "Legajo:";
            // 
            // txtDNI
            // 
            this.txtDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Location = new System.Drawing.Point(489, 304);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(206, 20);
            this.txtDNI.TabIndex = 83;
            // 
            // BMTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 488);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.nudLegajo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.nudRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ibEliminar);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.ibModificar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "BMTransportista";
            this.Text = "BMTransportista";
            this.Load += new System.EventHandler(this.BMTransportista_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNroTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegistro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLegajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudRegistro;
        private FontAwesome.Sharp.IconButton ibBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private FontAwesome.Sharp.IconButton ibEliminar;
        private FontAwesome.Sharp.IconButton ibModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudNroTarjeta;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.NumericUpDown nudLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
    }
}