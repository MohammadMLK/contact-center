namespace contact_center
{
    partial class loginfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginfrm));
            this.athenticationGB = new System.Windows.Forms.GroupBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordlable = new System.Windows.Forms.Label();
            this.usernamelable = new System.Windows.Forms.Label();
            this.athenticationGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // athenticationGB
            // 
            this.athenticationGB.Controls.Add(this.enterbutton);
            this.athenticationGB.Controls.Add(this.pictureBox1);
            this.athenticationGB.Controls.Add(this.textBox2);
            this.athenticationGB.Controls.Add(this.textBox1);
            this.athenticationGB.Controls.Add(this.passwordlable);
            this.athenticationGB.Controls.Add(this.usernamelable);
            this.athenticationGB.Location = new System.Drawing.Point(14, 15);
            this.athenticationGB.Name = "athenticationGB";
            this.athenticationGB.Size = new System.Drawing.Size(492, 411);
            this.athenticationGB.TabIndex = 0;
            this.athenticationGB.TabStop = false;
            this.athenticationGB.Text = "AUTHENTICATION";
            // 
            // enterbutton
            // 
            this.enterbutton.Image = ((System.Drawing.Image)(resources.GetObject("enterbutton.Image")));
            this.enterbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enterbutton.Location = new System.Drawing.Point(180, 348);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(161, 47);
            this.enterbutton.TabIndex = 5;
            this.enterbutton.Text = "ENTER";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 24);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 24);
            this.textBox1.TabIndex = 2;
            // 
            // passwordlable
            // 
            this.passwordlable.AutoSize = true;
            this.passwordlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlable.Location = new System.Drawing.Point(8, 304);
            this.passwordlable.Name = "passwordlable";
            this.passwordlable.Size = new System.Drawing.Size(112, 20);
            this.passwordlable.TabIndex = 1;
            this.passwordlable.Text = "PASSWORD:";
            this.passwordlable.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernamelable
            // 
            this.usernamelable.AutoSize = true;
            this.usernamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelable.Location = new System.Drawing.Point(7, 258);
            this.usernamelable.Name = "usernamelable";
            this.usernamelable.Size = new System.Drawing.Size(113, 20);
            this.usernamelable.TabIndex = 0;
            this.usernamelable.Text = "USER NAME:";
            this.usernamelable.Click += new System.EventHandler(this.usernamelable_Click);
            // 
            // loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 443);
            this.Controls.Add(this.athenticationGB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginfrm";
            this.Text = "login form";
            this.athenticationGB.ResumeLayout(false);
            this.athenticationGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox athenticationGB;
        private System.Windows.Forms.Label passwordlable;
        private System.Windows.Forms.Label usernamelable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enterbutton;
    }
}