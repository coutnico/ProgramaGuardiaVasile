namespace CapturarIngresos
{
    partial class EscanerDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscanerDocumento));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSalida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ibSacarFotoFrente = new FontAwesome.Sharp.IconButton();
            this.ibSacarFotoDorso = new FontAwesome.Sharp.IconButton();
            this.ibAceptar = new FontAwesome.Sharp.IconButton();
            this.ibRefresh = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(848, 47);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "Datos de ingreso ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 43);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(237)))));
            this.lblSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalida.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.White;
            this.lblSalida.Location = new System.Drawing.Point(12, 9);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(176, 23);
            this.lblSalida.TabIndex = 62;
            this.lblSalida.Text = "Escanear registro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CapturarIngresos.Properties.Resources.licencia_de_conducir;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::CapturarIngresos.Properties.Resources.licencia_de_conducir;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(443, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 76;
            this.label1.Text = "Frente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 33);
            this.label2.TabIndex = 77;
            this.label2.Text = "Dorso";
            // 
            // ibSacarFotoFrente
            // 
            this.ibSacarFotoFrente.FlatAppearance.BorderSize = 0;
            this.ibSacarFotoFrente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSacarFotoFrente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSacarFotoFrente.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.ibSacarFotoFrente.IconColor = System.Drawing.Color.Black;
            this.ibSacarFotoFrente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSacarFotoFrente.IconSize = 30;
            this.ibSacarFotoFrente.Location = new System.Drawing.Point(154, 365);
            this.ibSacarFotoFrente.Name = "ibSacarFotoFrente";
            this.ibSacarFotoFrente.Size = new System.Drawing.Size(120, 36);
            this.ibSacarFotoFrente.TabIndex = 78;
            this.ibSacarFotoFrente.Text = "Sacar Foto";
            this.ibSacarFotoFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSacarFotoFrente.UseVisualStyleBackColor = true;
            this.ibSacarFotoFrente.Click += new System.EventHandler(this.ibSacarFotoFrente_Click);
            // 
            // ibSacarFotoDorso
            // 
            this.ibSacarFotoDorso.FlatAppearance.BorderSize = 0;
            this.ibSacarFotoDorso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSacarFotoDorso.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSacarFotoDorso.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.ibSacarFotoDorso.IconColor = System.Drawing.Color.Black;
            this.ibSacarFotoDorso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSacarFotoDorso.IconSize = 30;
            this.ibSacarFotoDorso.Location = new System.Drawing.Point(574, 365);
            this.ibSacarFotoDorso.Name = "ibSacarFotoDorso";
            this.ibSacarFotoDorso.Size = new System.Drawing.Size(120, 36);
            this.ibSacarFotoDorso.TabIndex = 79;
            this.ibSacarFotoDorso.Text = "Sacar Foto";
            this.ibSacarFotoDorso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSacarFotoDorso.UseVisualStyleBackColor = true;
            this.ibSacarFotoDorso.Click += new System.EventHandler(this.ibSacarFotoDorso_Click);
            // 
            // ibAceptar
            // 
            this.ibAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibAceptar.FlatAppearance.BorderSize = 0;
            this.ibAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.ibAceptar.IconColor = System.Drawing.Color.Black;
            this.ibAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAceptar.IconSize = 40;
            this.ibAceptar.Location = new System.Drawing.Point(369, 427);
            this.ibAceptar.Name = "ibAceptar";
            this.ibAceptar.Size = new System.Drawing.Size(116, 40);
            this.ibAceptar.TabIndex = 80;
            this.ibAceptar.Text = "Aceptar";
            this.ibAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAceptar.UseVisualStyleBackColor = false;
            this.ibAceptar.Click += new System.EventHandler(this.ibAceptar_Click);
            // 
            // ibRefresh
            // 
            this.ibRefresh.FlatAppearance.BorderSize = 0;
            this.ibRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibRefresh.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.ibRefresh.IconColor = System.Drawing.Color.Gray;
            this.ibRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibRefresh.IconSize = 30;
            this.ibRefresh.Location = new System.Drawing.Point(412, 232);
            this.ibRefresh.Name = "ibRefresh";
            this.ibRefresh.Size = new System.Drawing.Size(23, 23);
            this.ibRefresh.TabIndex = 84;
            this.ibRefresh.UseVisualStyleBackColor = true;
            this.ibRefresh.Click += new System.EventHandler(this.ibRefresh_Click);
            // 
            // EscanerDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 488);
            this.Controls.Add(this.ibRefresh);
            this.Controls.Add(this.ibAceptar);
            this.Controls.Add(this.ibSacarFotoDorso);
            this.Controls.Add(this.ibSacarFotoFrente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EscanerDocumento";
            this.Text = "EscanerDocumento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EscanerDocumento_FormClosing);
            this.Load += new System.EventHandler(this.EscanerDocumento_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibSacarFotoFrente;
        private FontAwesome.Sharp.IconButton ibSacarFotoDorso;
        private FontAwesome.Sharp.IconButton ibAceptar;
        private FontAwesome.Sharp.IconButton ibRefresh;
    }
}