﻿namespace UbiTec
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.btonMaximizar = new System.Windows.Forms.PictureBox();
            this.btonMinimizar = new System.Windows.Forms.PictureBox();
            this.btonRestaurar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenidos al instituto tecnologico de tlaxiaco";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::UbiTec.Properties.Resources._1707498448438__2_;
            this.pictureBox3.Location = new System.Drawing.Point(0, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1200, 593);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 641);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1200, 59);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UbiTec.Properties.Resources.Group_5;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(0, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Busqueda ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Image = global::UbiTec.Properties.Resources.simbolo_x;
            this.BotonCerrar.Location = new System.Drawing.Point(1163, 12);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 8;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // btonMaximizar
            // 
            this.btonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonMaximizar.Image = global::UbiTec.Properties.Resources.cuadrado_en_blanco;
            this.btonMaximizar.Location = new System.Drawing.Point(1120, 12);
            this.btonMaximizar.Name = "btonMaximizar";
            this.btonMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btonMaximizar.TabIndex = 9;
            this.btonMaximizar.TabStop = false;
            this.btonMaximizar.Click += new System.EventHandler(this.btonMaximizar_Click);
            // 
            // btonMinimizar
            // 
            this.btonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonMinimizar.Image = global::UbiTec.Properties.Resources.eliminar;
            this.btonMinimizar.Location = new System.Drawing.Point(1077, 12);
            this.btonMinimizar.Name = "btonMinimizar";
            this.btonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btonMinimizar.TabIndex = 10;
            this.btonMinimizar.TabStop = false;
            this.btonMinimizar.Click += new System.EventHandler(this.btonMinimizar_Click);
            // 
            // btonRestaurar
            // 
            this.btonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btonRestaurar.Image = global::UbiTec.Properties.Resources.dupdo__1_;
            this.btonRestaurar.Location = new System.Drawing.Point(1120, 12);
            this.btonRestaurar.Name = "btonRestaurar";
            this.btonRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btonRestaurar.TabIndex = 11;
            this.btonRestaurar.TabStop = false;
            this.btonRestaurar.Visible = false;
            this.btonRestaurar.Click += new System.EventHandler(this.btonRestaurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btonRestaurar);
            this.Controls.Add(this.btonMinimizar);
            this.Controls.Add(this.btonMaximizar);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonRestaurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.PictureBox btonMaximizar;
        private System.Windows.Forms.PictureBox btonMinimizar;
        private System.Windows.Forms.PictureBox btonRestaurar;
    }
}
