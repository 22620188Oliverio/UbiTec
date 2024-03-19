namespace UbiTec
{
    partial class Sacar_Turno
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btonMaximizar = new System.Windows.Forms.PictureBox();
            this.btonRestaurar = new System.Windows.Forms.PictureBox();
            this.btonMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(499, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(395, 417);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(411, 34);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa tu nombre";
            this.label1.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.BackColor = System.Drawing.Color.White;
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Image = global::UbiTec.Properties.Resources.simbolo_x;
            this.BotonCerrar.Location = new System.Drawing.Point(1163, 12);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 9;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::UbiTec.Properties.Resources.Group_5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btonMaximizar
            // 
            this.btonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonMaximizar.BackColor = System.Drawing.Color.White;
            this.btonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonMaximizar.Image = global::UbiTec.Properties.Resources.cuadrado_en_blanco;
            this.btonMaximizar.Location = new System.Drawing.Point(1121, 12);
            this.btonMaximizar.Name = "btonMaximizar";
            this.btonMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btonMaximizar.TabIndex = 11;
            this.btonMaximizar.TabStop = false;
            this.btonMaximizar.Click += new System.EventHandler(this.btonMaximizar_Click);
            // 
            // btonRestaurar
            // 
            this.btonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonRestaurar.BackColor = System.Drawing.Color.White;
            this.btonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonRestaurar.Image = global::UbiTec.Properties.Resources.dupdo__1_;
            this.btonRestaurar.Location = new System.Drawing.Point(1121, 12);
            this.btonRestaurar.Name = "btonRestaurar";
            this.btonRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btonRestaurar.TabIndex = 13;
            this.btonRestaurar.TabStop = false;
            this.btonRestaurar.Visible = false;
            this.btonRestaurar.Click += new System.EventHandler(this.btonRestaurar_Click);
            // 
            // btonMinimizar
            // 
            this.btonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonMinimizar.BackColor = System.Drawing.Color.White;
            this.btonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonMinimizar.Image = global::UbiTec.Properties.Resources.eliminar;
            this.btonMinimizar.Location = new System.Drawing.Point(1080, 12);
            this.btonMinimizar.Name = "btonMinimizar";
            this.btonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btonMinimizar.TabIndex = 12;
            this.btonMinimizar.TabStop = false;
            this.btonMinimizar.Click += new System.EventHandler(this.btonMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 59);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 59);
            this.button2.TabIndex = 0;
            this.button2.Text = "Regresar a ubicaciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UbiTec.Properties.Resources.Tec_Tlaxiaco_3337_;
            this.pictureBox2.Location = new System.Drawing.Point(499, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Sacar_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btonRestaurar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btonMinimizar);
            this.Controls.Add(this.btonMaximizar);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sacar_Turno";
            this.Text = "Sacar_Turno";
            this.Load += new System.EventHandler(this.Sacar_Turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btonMaximizar;
        private System.Windows.Forms.PictureBox btonRestaurar;
        private System.Windows.Forms.PictureBox btonMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}