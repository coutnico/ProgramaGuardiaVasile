namespace CapturarIngresos
{
    partial class BMIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIngresos));
            this.lblIngreso = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ibModificar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ibEliminar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudDni = new System.Windows.Forms.NumericUpDown();
            this.ibBuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.cbSectorVisitante = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbSubArea = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSectorVisitante = new System.Windows.Forms.Label();
            this.lblSubArea = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbxNombres = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).BeginInit();
            this.SuspendLayout();
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
            this.lblIngreso.Size = new System.Drawing.Size(83, 23);
            this.lblIngreso.TabIndex = 11;
            this.lblIngreso.Text = "Ingreso";
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
            this.menuStrip1.Size = new System.Drawing.Size(1114, 45);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "Datos de ingreso ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 41);
            // 
            // ibModificar
            // 
            this.ibModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ibModificar.FlatAppearance.BorderSize = 0;
            this.ibModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibModificar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibModificar.IconColor = System.Drawing.Color.Black;
            this.ibModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibModificar.IconSize = 30;
            this.ibModificar.Location = new System.Drawing.Point(1012, 421);
            this.ibModificar.Name = "ibModificar";
            this.ibModificar.Size = new System.Drawing.Size(90, 35);
            this.ibModificar.TabIndex = 10;
            this.ibModificar.Text = "Modificar";
            this.ibModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibModificar.UseVisualStyleBackColor = false;
            this.ibModificar.Click += new System.EventHandler(this.ibModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CapturarIngresos.Properties.Resources.user_128_512;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ibEliminar
            // 
            this.ibEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ibEliminar.FlatAppearance.BorderSize = 0;
            this.ibEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEliminar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibEliminar.IconColor = System.Drawing.Color.Black;
            this.ibEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEliminar.IconSize = 30;
            this.ibEliminar.Location = new System.Drawing.Point(1012, 421);
            this.ibEliminar.Name = "ibEliminar";
            this.ibEliminar.Size = new System.Drawing.Size(90, 35);
            this.ibEliminar.TabIndex = 9;
            this.ibEliminar.Text = "Eliminar";
            this.ibEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibEliminar.UseVisualStyleBackColor = false;
            this.ibEliminar.Click += new System.EventHandler(this.ibEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.nudDni);
            this.panel1.Controls.Add(this.ibBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 229);
            this.panel1.TabIndex = 0;
            // 
            // nudDni
            // 
            this.nudDni.Location = new System.Drawing.Point(67, 134);
            this.nudDni.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDni.Name = "nudDni";
            this.nudDni.Size = new System.Drawing.Size(144, 20);
            this.nudDni.TabIndex = 2;
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
            this.ibBuscar.Location = new System.Drawing.Point(96, 166);
            this.ibBuscar.Name = "ibBuscar";
            this.ibBuscar.Size = new System.Drawing.Size(84, 27);
            this.ibBuscar.TabIndex = 3;
            this.ibBuscar.Text = "Buscar";
            this.ibBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibBuscar.UseVisualStyleBackColor = true;
            this.ibBuscar.Click += new System.EventHandler(this.ibBuscar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 69);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingresar Dni de visitante para rastrear datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDNI
            // 
            this.txtDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Location = new System.Drawing.Point(789, 165);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(234, 20);
            this.txtDNI.TabIndex = 70;
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(752, 168);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 14);
            this.lblDni.TabIndex = 65;
            this.lblDni.Text = "DNI:";
            // 
            // cbSectorVisitante
            // 
            this.cbSectorVisitante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbSectorVisitante.FormattingEnabled = true;
            this.cbSectorVisitante.Location = new System.Drawing.Point(438, 311);
            this.cbSectorVisitante.Name = "cbSectorVisitante";
            this.cbSectorVisitante.Size = new System.Drawing.Size(236, 21);
            this.cbSectorVisitante.TabIndex = 55;
            this.cbSectorVisitante.SelectedIndexChanged += new System.EventHandler(this.cbSectorVisitante_SelectedIndexChanged);
            // 
            // cbArea
            // 
            this.cbArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(791, 311);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(232, 21);
            this.cbArea.TabIndex = 56;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // cbSubArea
            // 
            this.cbSubArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbSubArea.FormattingEnabled = true;
            this.cbSubArea.Location = new System.Drawing.Point(438, 377);
            this.cbSubArea.Name = "cbSubArea";
            this.cbSubArea.Size = new System.Drawing.Size(236, 21);
            this.cbSubArea.TabIndex = 57;
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(791, 241);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(232, 21);
            this.cbTipo.TabIndex = 54;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(692, 244);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(95, 14);
            this.lblTipo.TabIndex = 63;
            this.lblTipo.Text = "Tipo de visita:";
            // 
            // lblSectorVisitante
            // 
            this.lblSectorVisitante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSectorVisitante.AutoSize = true;
            this.lblSectorVisitante.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectorVisitante.Location = new System.Drawing.Point(382, 314);
            this.lblSectorVisitante.Name = "lblSectorVisitante";
            this.lblSectorVisitante.Size = new System.Drawing.Size(52, 14);
            this.lblSectorVisitante.TabIndex = 62;
            this.lblSectorVisitante.Text = "Sector:";
            // 
            // lblSubArea
            // 
            this.lblSubArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSubArea.AutoSize = true;
            this.lblSubArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubArea.Location = new System.Drawing.Point(371, 380);
            this.lblSubArea.Name = "lblSubArea";
            this.lblSubArea.Size = new System.Drawing.Size(65, 14);
            this.lblSubArea.TabIndex = 61;
            this.lblSubArea.Text = "SubArea:";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(747, 314);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(41, 14);
            this.lblArea.TabIndex = 60;
            this.lblArea.Text = "Area:";
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(366, 243);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(68, 14);
            this.lblNombres.TabIndex = 59;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(373, 167);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 14);
            this.lblApellido.TabIndex = 58;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbxNombres
            // 
            this.tbxNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbxNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxNombres.Location = new System.Drawing.Point(438, 240);
            this.tbxNombres.Name = "tbxNombres";
            this.tbxNombres.Size = new System.Drawing.Size(236, 20);
            this.tbxNombres.TabIndex = 53;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxApellido.Location = new System.Drawing.Point(438, 164);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(236, 20);
            this.tbxApellido.TabIndex = 52;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(916, 511);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 74;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(887, 551);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 13);
            this.lblHora.TabIndex = 72;
            this.lblHora.Text = "Hora Ingreso:";
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.Location = new System.Drawing.Point(961, 548);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(141, 20);
            this.txtHora.TabIndex = 75;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Location = new System.Drawing.Point(961, 508);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(141, 20);
            this.txtFecha.TabIndex = 73;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoraSalida.Location = new System.Drawing.Point(961, 585);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(141, 20);
            this.txtHoraSalida.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Hora Salida:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "Datos";
            // 
            // BMIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.cbSectorVisitante);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.cbSubArea);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSectorVisitante);
            this.Controls.Add(this.lblSubArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbxNombres);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ibEliminar);
            this.Controls.Add(this.ibModificar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BMIngresos";
            this.Text = "BMIngresos";
            this.Load += new System.EventHandler(this.BMIngresos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconButton ibModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibBuscar;
        private System.Windows.Forms.NumericUpDown nudDni;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cbSectorVisitante;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbSubArea;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSectorVisitante;
        private System.Windows.Forms.Label lblSubArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbxNombres;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}