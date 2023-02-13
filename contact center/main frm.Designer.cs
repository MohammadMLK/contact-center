namespace contact_center
{
    partial class main_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_frm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuitemtools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemaddcontact = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemchangepass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemcontactus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemaboutus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emergencybtn = new System.Windows.Forms.Button();
            this.familybtn = new System.Windows.Forms.Button();
            this.friendsbtn = new System.Windows.Forms.Button();
            this.partnersbtn = new System.Windows.Forms.Button();
            this.editcontactbutton = new System.Windows.Forms.Button();
            this.deletecontactbutton = new System.Windows.Forms.Button();
            this.addcontactbtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.contactbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.searchbox.SuspendLayout();
            this.contactbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitemtools,
            this.mnuitemchangepass,
            this.mnuitemcontactus,
            this.mnuitemaboutus});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuitemtools
            // 
            this.mnuitemtools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitemaddcontact});
            this.mnuitemtools.Name = "mnuitemtools";
            this.mnuitemtools.Size = new System.Drawing.Size(67, 24);
            this.mnuitemtools.Text = "TOOLS";
            this.mnuitemtools.Click += new System.EventHandler(this.mnuitemtools_Click);
            // 
            // mnuitemaddcontact
            // 
            this.mnuitemaddcontact.Name = "mnuitemaddcontact";
            this.mnuitemaddcontact.Size = new System.Drawing.Size(193, 26);
            this.mnuitemaddcontact.Text = "ADD CONTACT";
            // 
            // mnuitemchangepass
            // 
            this.mnuitemchangepass.Name = "mnuitemchangepass";
            this.mnuitemchangepass.Size = new System.Drawing.Size(164, 24);
            this.mnuitemchangepass.Text = "CHANGE PASSWORD";
            // 
            // mnuitemcontactus
            // 
            this.mnuitemcontactus.Name = "mnuitemcontactus";
            this.mnuitemcontactus.Size = new System.Drawing.Size(110, 24);
            this.mnuitemcontactus.Text = "CONTACT US";
            // 
            // mnuitemaboutus
            // 
            this.mnuitemaboutus.Name = "mnuitemaboutus";
            this.mnuitemaboutus.Size = new System.Drawing.Size(93, 24);
            this.mnuitemaboutus.Text = "ABOUT US";
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.groupBox2);
            this.toolbox.Controls.Add(this.editcontactbutton);
            this.toolbox.Controls.Add(this.deletecontactbutton);
            this.toolbox.Controls.Add(this.addcontactbtn);
            this.toolbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbox.Location = new System.Drawing.Point(12, 60);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(285, 565);
            this.toolbox.TabIndex = 1;
            this.toolbox.TabStop = false;
            this.toolbox.Text = "TOOLS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emergencybtn);
            this.groupBox2.Controls.Add(this.familybtn);
            this.groupBox2.Controls.Add(this.friendsbtn);
            this.groupBox2.Controls.Add(this.partnersbtn);
            this.groupBox2.Location = new System.Drawing.Point(23, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 304);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QUICK ACCESS";
            // 
            // emergencybtn
            // 
            this.emergencybtn.Image = ((System.Drawing.Image)(resources.GetObject("emergencybtn.Image")));
            this.emergencybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emergencybtn.Location = new System.Drawing.Point(16, 239);
            this.emergencybtn.Name = "emergencybtn";
            this.emergencybtn.Size = new System.Drawing.Size(216, 45);
            this.emergencybtn.TabIndex = 3;
            this.emergencybtn.Text = "EMERGENCY";
            this.emergencybtn.UseVisualStyleBackColor = true;
            // 
            // familybtn
            // 
            this.familybtn.Image = ((System.Drawing.Image)(resources.GetObject("familybtn.Image")));
            this.familybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.familybtn.Location = new System.Drawing.Point(16, 169);
            this.familybtn.Name = "familybtn";
            this.familybtn.Size = new System.Drawing.Size(216, 45);
            this.familybtn.TabIndex = 2;
            this.familybtn.Text = "FAMILY";
            this.familybtn.UseVisualStyleBackColor = true;
            // 
            // friendsbtn
            // 
            this.friendsbtn.Image = ((System.Drawing.Image)(resources.GetObject("friendsbtn.Image")));
            this.friendsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friendsbtn.Location = new System.Drawing.Point(16, 102);
            this.friendsbtn.Name = "friendsbtn";
            this.friendsbtn.Size = new System.Drawing.Size(216, 45);
            this.friendsbtn.TabIndex = 1;
            this.friendsbtn.Text = "FRIENDS";
            this.friendsbtn.UseVisualStyleBackColor = true;
            // 
            // partnersbtn
            // 
            this.partnersbtn.Image = ((System.Drawing.Image)(resources.GetObject("partnersbtn.Image")));
            this.partnersbtn.Location = new System.Drawing.Point(16, 35);
            this.partnersbtn.Name = "partnersbtn";
            this.partnersbtn.Size = new System.Drawing.Size(216, 45);
            this.partnersbtn.TabIndex = 0;
            this.partnersbtn.Text = "PARTNERS";
            this.partnersbtn.UseVisualStyleBackColor = true;
            this.partnersbtn.Click += new System.EventHandler(this.partnersbtn_Click);
            // 
            // editcontactbutton
            // 
            this.editcontactbutton.Image = ((System.Drawing.Image)(resources.GetObject("editcontactbutton.Image")));
            this.editcontactbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editcontactbutton.Location = new System.Drawing.Point(23, 168);
            this.editcontactbutton.Name = "editcontactbutton";
            this.editcontactbutton.Size = new System.Drawing.Size(238, 61);
            this.editcontactbutton.TabIndex = 2;
            this.editcontactbutton.Text = "EDIT CONTACT";
            this.editcontactbutton.UseVisualStyleBackColor = true;
            this.editcontactbutton.Click += new System.EventHandler(this.editcontactbutton_Click);
            // 
            // deletecontactbutton
            // 
            this.deletecontactbutton.Image = ((System.Drawing.Image)(resources.GetObject("deletecontactbutton.Image")));
            this.deletecontactbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletecontactbutton.Location = new System.Drawing.Point(23, 101);
            this.deletecontactbutton.Name = "deletecontactbutton";
            this.deletecontactbutton.Size = new System.Drawing.Size(238, 61);
            this.deletecontactbutton.TabIndex = 1;
            this.deletecontactbutton.Text = "DELETE CONTACT";
            this.deletecontactbutton.UseVisualStyleBackColor = true;
            // 
            // addcontactbtn
            // 
            this.addcontactbtn.Image = ((System.Drawing.Image)(resources.GetObject("addcontactbtn.Image")));
            this.addcontactbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addcontactbtn.Location = new System.Drawing.Point(23, 34);
            this.addcontactbtn.Name = "addcontactbtn";
            this.addcontactbtn.Size = new System.Drawing.Size(238, 61);
            this.addcontactbtn.TabIndex = 0;
            this.addcontactbtn.Text = "ADD CONTACT";
            this.addcontactbtn.UseVisualStyleBackColor = true;
            this.addcontactbtn.Click += new System.EventHandler(this.addcontactbtn_Click);
            // 
            // searchbox
            // 
            this.searchbox.Controls.Add(this.label1);
            this.searchbox.Controls.Add(this.searchbar);
            this.searchbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(318, 60);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(643, 107);
            this.searchbox.TabIndex = 2;
            this.searchbox.TabStop = false;
            this.searchbox.Text = "SEARCH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEARCH CONTACTS:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(206, 41);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(381, 24);
            this.searchbar.TabIndex = 0;
            this.searchbar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contactbox
            // 
            this.contactbox.Controls.Add(this.dataGridView1);
            this.contactbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactbox.Location = new System.Drawing.Point(318, 194);
            this.contactbox.Name = "contactbox";
            this.contactbox.Size = new System.Drawing.Size(643, 431);
            this.contactbox.TabIndex = 3;
            this.contactbox.TabStop = false;
            this.contactbox.Text = "CONTACTS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 637);
            this.Controls.Add(this.contactbox);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_frm";
            this.Text = "phone book";
            this.Activated += new System.EventHandler(this.main_frm_Activated);
            this.Load += new System.EventHandler(this.main_frm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            this.contactbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuitemtools;
        private System.Windows.Forms.ToolStripMenuItem mnuitemaddcontact;
        private System.Windows.Forms.ToolStripMenuItem mnuitemchangepass;
        private System.Windows.Forms.ToolStripMenuItem mnuitemcontactus;
        private System.Windows.Forms.ToolStripMenuItem mnuitemaboutus;
        private System.Windows.Forms.GroupBox toolbox;
        private System.Windows.Forms.GroupBox searchbox;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.GroupBox contactbox;
        private System.Windows.Forms.Button editcontactbutton;
        private System.Windows.Forms.Button deletecontactbutton;
        private System.Windows.Forms.Button addcontactbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button emergencybtn;
        private System.Windows.Forms.Button familybtn;
        private System.Windows.Forms.Button friendsbtn;
        private System.Windows.Forms.Button partnersbtn;
        private System.Windows.Forms.Label label1;
    }
}