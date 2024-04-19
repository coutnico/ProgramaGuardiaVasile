namespace CapturarIngresos
{
    partial class RegistrosGuardados
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
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.tboxBuscador = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ibCalendario = new FontAwesome.Sharp.IconButton();
            this.clTodos = new System.Windows.Forms.CheckBox();
            this.clSinTarjeta = new System.Windows.Forms.CheckBox();
            this.clConTarjeta = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbInternos = new System.Windows.Forms.CheckBox();
            this.cbExternos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngresos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(152)))), ((int)(((byte)(195)))));
            this.dgvIngresos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresos.Location = new System.Drawing.Point(0, 100);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            this.dgvIngresos.Size = new System.Drawing.Size(848, 388);
            this.dgvIngresos.TabIndex = 4;
            this.dgvIngresos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresos_CellDoubleClick);
            // 
            // tboxBuscador
            // 
            this.tboxBuscador.Location = new System.Drawing.Point(68, 33);
            this.tboxBuscador.Multiline = true;
            this.tboxBuscador.Name = "tboxBuscador";
            this.tboxBuscador.Size = new System.Drawing.Size(383, 29);
            this.tboxBuscador.TabIndex = 12;
            this.tboxBuscador.TextChanged += new System.EventHandler(this.tboxBuscador_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.pictureBox1.Image = global::CapturarIngresos.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(26, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Calendario
            // 
            this.Calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendario.BackColor = System.Drawing.SystemColors.Control;
            this.Calendario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.ForeColor = System.Drawing.Color.Black;
            this.Calendario.Location = new System.Drawing.Point(555, 62);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.Name = "Calendario";
            this.Calendario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calendario.ShowTodayCircle = false;
            this.Calendario.TabIndex = 14;
            this.Calendario.TodayDate = new System.DateTime(2024, 4, 9, 0, 0, 0, 0);
            this.Calendario.Visible = false;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(555, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 29);
            this.panel1.TabIndex = 15;
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
            // ibCalendario
            // 
            this.ibCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.ibCalendario.FlatAppearance.BorderSize = 0;
            this.ibCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCalendario.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.ibCalendario.IconColor = System.Drawing.Color.Black;
            this.ibCalendario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCalendario.IconSize = 28;
            this.ibCalendario.Location = new System.Drawing.Point(801, 27);
            this.ibCalendario.Name = "ibCalendario";
            this.ibCalendario.Size = new System.Drawing.Size(33, 39);
            this.ibCalendario.TabIndex = 0;
            this.ibCalendario.UseVisualStyleBackColor = false;
            this.ibCalendario.Click += new System.EventHandler(this.ibCalendario_Click);
            // 
            // clTodos
            // 
            this.clTodos.AutoSize = true;
            this.clTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.clTodos.ForeColor = System.Drawing.Color.White;
            this.clTodos.Location = new System.Drawing.Point(14, 74);
            this.clTodos.Name = "clTodos";
            this.clTodos.Size = new System.Drawing.Size(56, 17);
            this.clTodos.TabIndex = 16;
            this.clTodos.Text = "Todos";
            this.clTodos.UseVisualStyleBackColor = false;
            this.clTodos.Visible = false;
            this.clTodos.CheckedChanged += new System.EventHandler(this.clTodos_CheckedChanged);
            // 
            // clSinTarjeta
            // 
            this.clSinTarjeta.AutoSize = true;
            this.clSinTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.clSinTarjeta.ForeColor = System.Drawing.Color.White;
            this.clSinTarjeta.Location = new System.Drawing.Point(212, 74);
            this.clSinTarjeta.Name = "clSinTarjeta";
            this.clSinTarjeta.Size = new System.Drawing.Size(114, 17);
            this.clSinTarjeta.TabIndex = 17;
            this.clSinTarjeta.Text = "Ingresos sin tarjeta";
            this.clSinTarjeta.UseVisualStyleBackColor = false;
            this.clSinTarjeta.Visible = false;
            this.clSinTarjeta.CheckedChanged += new System.EventHandler(this.clSinTarjeta_CheckedChanged);
            // 
            // clConTarjeta
            // 
            this.clConTarjeta.AutoSize = true;
            this.clConTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.clConTarjeta.ForeColor = System.Drawing.Color.White;
            this.clConTarjeta.Location = new System.Drawing.Point(87, 74);
            this.clConTarjeta.Name = "clConTarjeta";
            this.clConTarjeta.Size = new System.Drawing.Size(119, 17);
            this.clConTarjeta.TabIndex = 18;
            this.clConTarjeta.Text = "Ingresos con tarjeta";
            this.clConTarjeta.UseVisualStyleBackColor = false;
            this.clConTarjeta.Visible = false;
            this.clConTarjeta.CheckedChanged += new System.EventHandler(this.clConTarjeta_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.clSinTarjeta);
            this.panel2.Controls.Add(this.clTodos);
            this.panel2.Controls.Add(this.cbInternos);
            this.panel2.Controls.Add(this.cbExternos);
            this.panel2.Controls.Add(this.clConTarjeta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 100);
            this.panel2.TabIndex = 19;
            // 
            // cbInternos
            // 
            this.cbInternos.AutoSize = true;
            this.cbInternos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.cbInternos.ForeColor = System.Drawing.Color.White;
            this.cbInternos.Location = new System.Drawing.Point(87, 74);
            this.cbInternos.Name = "cbInternos";
            this.cbInternos.Size = new System.Drawing.Size(64, 17);
            this.cbInternos.TabIndex = 20;
            this.cbInternos.Text = "Internos";
            this.cbInternos.UseVisualStyleBackColor = false;
            this.cbInternos.Visible = false;
            this.cbInternos.CheckedChanged += new System.EventHandler(this.cbInternos_CheckedChanged);
            // 
            // cbExternos
            // 
            this.cbExternos.AutoSize = true;
            this.cbExternos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.cbExternos.ForeColor = System.Drawing.Color.White;
            this.cbExternos.Location = new System.Drawing.Point(14, 74);
            this.cbExternos.Name = "cbExternos";
            this.cbExternos.Size = new System.Drawing.Size(67, 17);
            this.cbExternos.TabIndex = 20;
            this.cbExternos.Text = "Externos";
            this.cbExternos.UseVisualStyleBackColor = false;
            this.cbExternos.Visible = false;
            this.cbExternos.CheckedChanged += new System.EventHandler(this.cbExternos_CheckedChanged);
            // 
            // RegistrosGuardados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 488);
            this.Controls.Add(this.ibCalendario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tboxBuscador);
            this.Controls.Add(this.dgvIngresos);
            this.Controls.Add(this.panel2);
            this.Name = "RegistrosGuardados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.TextBox tboxBuscador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibCalendario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.CheckBox clTodos;
        private System.Windows.Forms.CheckBox clSinTarjeta;
        private System.Windows.Forms.CheckBox clConTarjeta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbExternos;
        private System.Windows.Forms.CheckBox cbInternos;
    }
}

