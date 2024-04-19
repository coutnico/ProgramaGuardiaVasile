namespace CapturarIngresos
{
    partial class viewInformes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ipFiltro = new FontAwesome.Sharp.IconPictureBox();
            this.ibCalendario = new FontAwesome.Sharp.IconButton();
            this.ibAceptar = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipFiltro)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(643, 47);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "Datos de ingreso ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 43);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(275, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 25);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "Informes";
            // 
            // Calendario
            // 
            this.Calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendario.BackColor = System.Drawing.SystemColors.Control;
            this.Calendario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.ForeColor = System.Drawing.Color.Black;
            this.Calendario.Location = new System.Drawing.Point(325, 107);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.Name = "Calendario";
            this.Calendario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calendario.ShowTodayCircle = false;
            this.Calendario.TabIndex = 65;
            this.Calendario.TodayDate = new System.DateTime(2024, 4, 9, 0, 0, 0, 0);
            this.Calendario.Visible = false;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(90, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 20);
            this.lblFecha.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(75, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 29);
            this.panel1.TabIndex = 66;
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(75, 219);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(249, 21);
            this.cbFiltro.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapturarIngresos.Properties.Resources.formulario_de_contacto;
            this.pictureBox1.Location = new System.Drawing.Point(352, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // ipFiltro
            // 
            this.ipFiltro.BackColor = System.Drawing.SystemColors.Control;
            this.ipFiltro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipFiltro.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.ipFiltro.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipFiltro.IconSize = 33;
            this.ipFiltro.Location = new System.Drawing.Point(36, 215);
            this.ipFiltro.Name = "ipFiltro";
            this.ipFiltro.Size = new System.Drawing.Size(33, 39);
            this.ipFiltro.TabIndex = 68;
            this.ipFiltro.TabStop = false;
            // 
            // ibCalendario
            // 
            this.ibCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibCalendario.BackColor = System.Drawing.SystemColors.Control;
            this.ibCalendario.FlatAppearance.BorderSize = 0;
            this.ibCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCalendario.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.ibCalendario.IconColor = System.Drawing.Color.Black;
            this.ibCalendario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCalendario.IconSize = 28;
            this.ibCalendario.Location = new System.Drawing.Point(36, 103);
            this.ibCalendario.Name = "ibCalendario";
            this.ibCalendario.Size = new System.Drawing.Size(33, 39);
            this.ibCalendario.TabIndex = 64;
            this.ibCalendario.UseVisualStyleBackColor = false;
            this.ibCalendario.Click += new System.EventHandler(this.ibCalendario_Click);
            // 
            // ibAceptar
            // 
            this.ibAceptar.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibAceptar.IconColor = System.Drawing.Color.Black;
            this.ibAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAceptar.IconSize = 30;
            this.ibAceptar.Location = new System.Drawing.Point(269, 357);
            this.ibAceptar.Name = "ibAceptar";
            this.ibAceptar.Size = new System.Drawing.Size(125, 34);
            this.ibAceptar.TabIndex = 63;
            this.ibAceptar.Text = "Aceptar";
            this.ibAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAceptar.UseVisualStyleBackColor = true;
            this.ibAceptar.Click += new System.EventHandler(this.ibAceptar_Click);
            // 
            // viewInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 412);
            this.Controls.Add(this.ipFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.ibCalendario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.ibAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "viewInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "viewInformes";
            this.Load += new System.EventHandler(this.viewInformes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton ibAceptar;
        private FontAwesome.Sharp.IconButton ibCalendario;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFiltro;
        private FontAwesome.Sharp.IconPictureBox ipFiltro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}