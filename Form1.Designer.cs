namespace alexander
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.strtGameBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.progressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.downloadLbl = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // strtGameBtn
            // 
            this.strtGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.strtGameBtn.BorderRadius = 6;
            this.strtGameBtn.BorderThickness = 2;
            this.strtGameBtn.CheckedState.Parent = this.strtGameBtn;
            this.strtGameBtn.CustomImages.Parent = this.strtGameBtn;
            this.strtGameBtn.FillColor = System.Drawing.Color.YellowGreen;
            this.strtGameBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.strtGameBtn.Font = new System.Drawing.Font("Dameron Bold Italic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strtGameBtn.ForeColor = System.Drawing.Color.White;
            this.strtGameBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.strtGameBtn.HoverState.Parent = this.strtGameBtn;
            this.strtGameBtn.Location = new System.Drawing.Point(816, 390);
            this.strtGameBtn.Name = "strtGameBtn";
            this.strtGameBtn.ShadowDecoration.Parent = this.strtGameBtn;
            this.strtGameBtn.Size = new System.Drawing.Size(212, 79);
            this.strtGameBtn.TabIndex = 0;
            this.strtGameBtn.Text = "jugar";
            this.strtGameBtn.UseTransparentBackground = true;
            this.strtGameBtn.Click += new System.EventHandler(this.strtGameBtn_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImage = global::alexander.Properties.Resources.clear11;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.FillColor = System.Drawing.Color.Transparent;
            this.Button1.FillColor2 = System.Drawing.Color.Transparent;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.Location = new System.Drawing.Point(12, 510);
            this.Button1.Name = "Button1";
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(61, 63);
            this.Button1.TabIndex = 1;
            this.Button1.UseTransparentBackground = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BorderColor = System.Drawing.Color.Black;
            this.progressBar1.BorderSize = 1;
            this.progressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.progressBar1.Location = new System.Drawing.Point(820, 485);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressMaxColor = System.Drawing.Color.Red;
            this.progressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar1.Size = new System.Drawing.Size(208, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // downloadLbl
            // 
            this.downloadLbl.AutoSize = true;
            this.downloadLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downloadLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.downloadLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadLbl.Location = new System.Drawing.Point(824, 469);
            this.downloadLbl.Name = "downloadLbl";
            this.downloadLbl.Size = new System.Drawing.Size(0, 13);
            this.downloadLbl.TabIndex = 2;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BackgroundImage = global::alexander.Properties.Resources.FACE111;
            this.guna2GradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(12, 114);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(65, 63);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.BackgroundImage = global::alexander.Properties.Resources.Discord11;
            this.guna2GradientButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton5.CheckedState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.CustomImages.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.HoverState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Location = new System.Drawing.Point(12, 54);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(65, 63);
            this.guna2GradientButton5.TabIndex = 8;
            this.guna2GradientButton5.UseTransparentBackground = true;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BackgroundImage = global::alexander.Properties.Resources.web11;
            this.guna2GradientButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(12, 183);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(65, 63);
            this.guna2GradientButton2.TabIndex = 5;
            this.guna2GradientButton2.UseTransparentBackground = true;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BackgroundImage = global::alexander.Properties.Resources.web11;
            this.guna2GradientButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(12, 252);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(65, 63);
            this.guna2GradientButton3.TabIndex = 6;
            this.guna2GradientButton3.UseTransparentBackground = true;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BackgroundImage = global::alexander.Properties.Resources.web11;
            this.guna2GradientButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(12, 321);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(65, 63);
            this.guna2GradientButton4.TabIndex = 7;
            this.guna2GradientButton4.UseTransparentBackground = true;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.BackgroundImage = global::alexander.Properties.Resources.web11;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.CheckedState.Parent = this.Button2;
            this.Button2.CustomImages.Parent = this.Button2;
            this.Button2.FillColor = System.Drawing.Color.Transparent;
            this.Button2.FillColor2 = System.Drawing.Color.Transparent;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.HoverState.Parent = this.Button2;
            this.Button2.Location = new System.Drawing.Point(12, 390);
            this.Button2.Name = "Button2";
            this.Button2.ShadowDecoration.Parent = this.Button2;
            this.Button2.Size = new System.Drawing.Size(65, 63);
            this.Button2.TabIndex = 2;
            this.Button2.UseTransparentBackground = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(285, 225);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::alexander.Properties.Resources.logo__1_1;
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(280, 220);
            this.guna2ImageButton2.Location = new System.Drawing.Point(83, 12);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(275, 215);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(283, 212);
            this.guna2ImageButton2.TabIndex = 10;
            this.guna2ImageButton2.UseTransparentBackground = true;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.Image = global::alexander.Properties.Resources.los_trofeos_celeste_llegaron;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(235, 205);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::alexander.Properties.Resources.los_trofeos_celeste_llegaron;
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(230, 200);
            this.guna2ImageButton3.Location = new System.Drawing.Point(582, 390);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Image = global::alexander.Properties.Resources.los_trofeos_celeste_llegaron;
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(230, 200);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(228, 183);
            this.guna2ImageButton3.TabIndex = 11;
            this.guna2ImageButton3.UseTransparentBackground = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = global::alexander.Properties.Resources.feature_BR_fr1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(285, 225);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::alexander.Properties.Resources.feature_BR_fr;
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(280, 220);
            this.guna2ImageButton1.Location = new System.Drawing.Point(701, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::alexander.Properties.Resources.feature_BR_fr;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(275, 215);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(327, 212);
            this.guna2ImageButton1.TabIndex = 14;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.CheckedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.HoverState.Image = global::alexander.Properties.Resources.server;
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(235, 205);
            this.guna2ImageButton4.HoverState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(230, 200);
            this.guna2ImageButton4.Location = new System.Drawing.Point(83, 390);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.Image = global::alexander.Properties.Resources.server;
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(230, 200);
            this.guna2ImageButton4.PressedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Size = new System.Drawing.Size(228, 183);
            this.guna2ImageButton4.TabIndex = 15;
            this.guna2ImageButton4.UseTransparentBackground = true;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.CheckedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.HoverState.Image = global::alexander.Properties.Resources.reformo_de_sets_clase;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(235, 205);
            this.guna2ImageButton5.HoverState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Image = global::alexander.Properties.Resources.reformo_de_sets_clase;
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(230, 200);
            this.guna2ImageButton5.Location = new System.Drawing.Point(337, 390);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.Image = global::alexander.Properties.Resources.reformo_de_sets_clase;
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(230, 200);
            this.guna2ImageButton5.PressedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Size = new System.Drawing.Size(228, 183);
            this.guna2ImageButton5.TabIndex = 16;
            this.guna2ImageButton5.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::alexander.Properties.Resources.bg_maj_2_56;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.guna2ImageButton5);
            this.Controls.Add(this.guna2ImageButton4);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2GradientButton5);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.downloadLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.strtGameBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton strtGameBtn;
        private Guna.UI2.WinForms.Guna2GradientButton Button1;
        private Guna.UI.WinForms.GunaProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label downloadLbl;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton Button2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
    }
}