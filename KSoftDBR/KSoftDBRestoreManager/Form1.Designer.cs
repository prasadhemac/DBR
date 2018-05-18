namespace KSoftDBRestoreManager
{
    partial class KSoftDBRestoreManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_user_id = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.tb_browse_files = new System.Windows.Forms.TextBox();
            this.bt_browse = new System.Windows.Forms.Button();
            this.bt_restore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_restore);
            this.groupBox2.Controls.Add(this.bt_browse);
            this.groupBox2.Controls.Add(this.tb_browse_files);
            this.groupBox2.Location = new System.Drawing.Point(24, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore Files";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_password);
            this.splitContainer1.Panel1.Controls.Add(this.tb_user_id);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_database);
            this.splitContainer1.Panel2.Controls.Add(this.tb_server);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(525, 144);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(4, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database";
            // 
            // tb_user_id
            // 
            this.tb_user_id.Location = new System.Drawing.Point(109, 15);
            this.tb_user_id.Name = "tb_user_id";
            this.tb_user_id.Size = new System.Drawing.Size(136, 20);
            this.tb_user_id.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(109, 77);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(136, 20);
            this.tb_password.TabIndex = 3;
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(107, 15);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(138, 20);
            this.tb_server.TabIndex = 2;
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(107, 77);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(138, 20);
            this.tb_database.TabIndex = 3;
            // 
            // tb_browse_files
            // 
            this.tb_browse_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_browse_files.Location = new System.Drawing.Point(13, 52);
            this.tb_browse_files.Name = "tb_browse_files";
            this.tb_browse_files.Size = new System.Drawing.Size(387, 24);
            this.tb_browse_files.TabIndex = 0;
            // 
            // bt_browse
            // 
            this.bt_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_browse.Location = new System.Drawing.Point(406, 52);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(88, 35);
            this.bt_browse.TabIndex = 1;
            this.bt_browse.Text = "Browse";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.BrowseButton_Clicked);
            // 
            // bt_restore
            // 
            this.bt_restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bt_restore.Location = new System.Drawing.Point(212, 105);
            this.bt_restore.Name = "bt_restore";
            this.bt_restore.Size = new System.Drawing.Size(129, 45);
            this.bt_restore.TabIndex = 2;
            this.bt_restore.Text = "Restore";
            this.bt_restore.UseVisualStyleBackColor = true;
            this.bt_restore.Click += new System.EventHandler(this.RestoreButton_Clicked);
            // 
            // KSoftDBRestoreManager
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "KSoftDBRestoreManager";
            this.Text = "KSoftDBRestoreManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_restore;
        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.TextBox tb_browse_files;
    }
}

