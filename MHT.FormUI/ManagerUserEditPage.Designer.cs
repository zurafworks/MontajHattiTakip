namespace ZrfMusteriTakip.FormUI
{
    partial class ManagerUserEditPageUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerUserEditPageUI));
            this.tbxIsim = new System.Windows.Forms.TextBox();
            this.tbxSoyisim = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxIsManager = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxIsim
            // 
            this.tbxIsim.BackColor = System.Drawing.Color.DarkBlue;
            this.tbxIsim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxIsim.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxIsim.ForeColor = System.Drawing.Color.White;
            this.tbxIsim.Location = new System.Drawing.Point(62, 91);
            this.tbxIsim.Name = "tbxIsim";
            this.tbxIsim.PlaceholderText = "İsim";
            this.tbxIsim.Size = new System.Drawing.Size(174, 28);
            this.tbxIsim.TabIndex = 0;
            // 
            // tbxSoyisim
            // 
            this.tbxSoyisim.BackColor = System.Drawing.Color.DarkBlue;
            this.tbxSoyisim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSoyisim.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSoyisim.ForeColor = System.Drawing.Color.White;
            this.tbxSoyisim.Location = new System.Drawing.Point(308, 91);
            this.tbxSoyisim.Name = "tbxSoyisim";
            this.tbxSoyisim.PlaceholderText = "Soyisim";
            this.tbxSoyisim.Size = new System.Drawing.Size(174, 28);
            this.tbxSoyisim.TabIndex = 1;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.DarkBlue;
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUsername.ForeColor = System.Drawing.Color.White;
            this.tbxUsername.Location = new System.Drawing.Point(62, 198);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PlaceholderText = "Kullanıcı Adı";
            this.tbxUsername.Size = new System.Drawing.Size(264, 28);
            this.tbxUsername.TabIndex = 4;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.DarkBlue;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPassword.ForeColor = System.Drawing.Color.White;
            this.tbxPassword.Location = new System.Drawing.Point(62, 266);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PlaceholderText = "Şifre";
            this.tbxPassword.Size = new System.Drawing.Size(264, 28);
            this.tbxPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(611, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 62);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yeni Çalışan";
            // 
            // checkBox1
            // 
            this.cbxIsManager.AutoSize = true;
            this.cbxIsManager.BackColor = System.Drawing.Color.Transparent;
            this.cbxIsManager.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbxIsManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxIsManager.Location = new System.Drawing.Point(420, 198);
            this.cbxIsManager.Name = "checkBox1";
            this.cbxIsManager.Size = new System.Drawing.Size(188, 29);
            this.cbxIsManager.TabIndex = 9;
            this.cbxIsManager.Text = "      Yönetici Hesap";
            this.cbxIsManager.UseVisualStyleBackColor = false;
            // 
            // ManagerEditPageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cbxIsManager);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxSoyisim);
            this.Controls.Add(this.tbxIsim);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerEditPageUI";
            this.Text = "Manager Edit Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EkleUser_FormClosed);
            this.Load += new System.EventHandler(this.ManagerEditPageUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxIsim;
        private TextBox tbxSoyisim;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Button btnSave;
        private Label label2;
        private CheckBox cbxIsManager;
    }
}