namespace PassManager
{
    partial class fMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbMasterPW = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLastOpened = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btUnlock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbPass.ForeColor = System.Drawing.Color.White;
            this.tbPass.Location = new System.Drawing.Point(12, 130);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '●';
            this.tbPass.Size = new System.Drawing.Size(275, 20);
            this.tbPass.TabIndex = 0;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // lbMasterPW
            // 
            this.lbMasterPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMasterPW.AutoSize = true;
            this.lbMasterPW.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMasterPW.Location = new System.Drawing.Point(9, 111);
            this.lbMasterPW.Name = "lbMasterPW";
            this.lbMasterPW.Size = new System.Drawing.Size(91, 13);
            this.lbMasterPW.TabIndex = 1;
            this.lbMasterPW.Text = "Master Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Opened Database:";
            // 
            // lbLastOpened
            // 
            this.lbLastOpened.AutoSize = true;
            this.lbLastOpened.Location = new System.Drawing.Point(92, 35);
            this.lbLastOpened.Name = "lbLastOpened";
            this.lbLastOpened.Size = new System.Drawing.Size(147, 13);
            this.lbLastOpened.TabIndex = 4;
            this.lbLastOpened.Text = "No database recently opened";
            // 
            // btCreate
            // 
            this.btCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreate.Location = new System.Drawing.Point(178, 68);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(59, 23);
            this.btCreate.TabIndex = 5;
            this.btCreate.Text = "Create...";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btOpen
            // 
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Location = new System.Drawing.Point(95, 68);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(68, 23);
            this.btOpen.TabIndex = 6;
            this.btOpen.Text = "Open...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btUnlock
            // 
            this.btUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnlock.Enabled = false;
            this.btUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUnlock.Location = new System.Drawing.Point(301, 128);
            this.btUnlock.Name = "btUnlock";
            this.btUnlock.Size = new System.Drawing.Size(59, 23);
            this.btUnlock.TabIndex = 7;
            this.btUnlock.Text = "Unlock";
            this.btUnlock.UseVisualStyleBackColor = true;
            this.btUnlock.Click += new System.EventHandler(this.btUnlock_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(372, 162);
            this.Controls.Add(this.btUnlock);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.lbLastOpened);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMasterPW);
            this.Controls.Add(this.tbPass);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 201);
            this.Name = "fMain";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbMasterPW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLastOpened;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btUnlock;
    }
}

