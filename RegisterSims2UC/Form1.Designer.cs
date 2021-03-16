namespace RegisterSims3CC
{
    partial class mainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.Reg = new System.Windows.Forms.Button();
            this.Unreg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gamepath = new System.Windows.Forms.TextBox();
            this.selfolder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.ForeColor = System.Drawing.Color.Black;
            this.Reg.Location = new System.Drawing.Point(12, 109);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(150, 26);
            this.Reg.TabIndex = 0;
            this.Reg.Text = "Register The Sims 2";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // Unreg
            // 
            this.Unreg.ForeColor = System.Drawing.Color.Black;
            this.Unreg.Location = new System.Drawing.Point(165, 109);
            this.Unreg.Name = "Unreg";
            this.Unreg.Size = new System.Drawing.Size(150, 26);
            this.Unreg.TabIndex = 1;
            this.Unreg.Text = "Remove The Sims 2";
            this.Unreg.UseVisualStyleBackColor = true;
            this.Unreg.Click += new System.EventHandler(this.Unreg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(100, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Register The Sims 2\r\nUltimate Collection";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Select the Sims 2 Ultimate Collection folder:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseMove);
            // 
            // gamepath
            // 
            this.gamepath.ForeColor = System.Drawing.Color.Black;
            this.gamepath.HideSelection = false;
            this.gamepath.Location = new System.Drawing.Point(12, 79);
            this.gamepath.Name = "gamepath";
            this.gamepath.ReadOnly = true;
            this.gamepath.Size = new System.Drawing.Size(231, 20);
            this.gamepath.TabIndex = 30;
            this.gamepath.TextChanged += new System.EventHandler(this.gamepath_TextChanged);
            // 
            // selfolder
            // 
            this.selfolder.ForeColor = System.Drawing.Color.Black;
            this.selfolder.Location = new System.Drawing.Point(249, 76);
            this.selfolder.Name = "selfolder";
            this.selfolder.Size = new System.Drawing.Size(66, 26);
            this.selfolder.TabIndex = 33;
            this.selfolder.Text = "Browse...";
            this.selfolder.UseVisualStyleBackColor = true;
            this.selfolder.Click += new System.EventHandler(this.selfolder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseMove);
            // 
            // mainUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(324, 144);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selfolder);
            this.Controls.Add(this.gamepath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Unreg);
            this.Controls.Add(this.Reg);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainUI";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register The Sims 2 UC";
            this.Load += new System.EventHandler(this.mainUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainUI_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.Button Unreg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gamepath;
        private System.Windows.Forms.Button selfolder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

