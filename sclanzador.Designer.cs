using System;
using System.ComponentModel;

namespace alexander
{
    partial class sclanzador
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
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = global::alexander.Properties.Resources.little_logo;
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(66, 57);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "sv";
            this.gunaButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixel;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 600);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sclanzador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::alexander.Properties.Resources.bg_maj_2_56;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sclanzador";
            this.Text = "sclanzador";
            this.Load += new System.EventHandler(this.sclanzador_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void sclanzador_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
           
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Panel panel1;
    }
}