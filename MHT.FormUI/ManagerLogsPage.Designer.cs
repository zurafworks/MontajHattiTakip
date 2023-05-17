namespace ZrfMusteriTakip.FormUI
{
    partial class ManagerLogsPageUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogsPageUI));
            this.dgwVardiyaVeriler = new System.Windows.Forms.DataGridView();
            this.dgwKullanımVeriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVardiyaVeriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanımVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwVardiyaVeriler
            // 
            this.dgwVardiyaVeriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwVardiyaVeriler.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dgwVardiyaVeriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwVardiyaVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVardiyaVeriler.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgwVardiyaVeriler.Location = new System.Drawing.Point(56, 143);
            this.dgwVardiyaVeriler.Name = "dgwVardiyaVeriler";
            this.dgwVardiyaVeriler.RowTemplate.Height = 25;
            this.dgwVardiyaVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwVardiyaVeriler.Size = new System.Drawing.Size(329, 403);
            this.dgwVardiyaVeriler.TabIndex = 0;
            // 
            // dgwKullanımVeriler
            // 
            this.dgwKullanımVeriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwKullanımVeriler.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dgwKullanımVeriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwKullanımVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanımVeriler.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgwKullanımVeriler.Location = new System.Drawing.Point(464, 143);
            this.dgwKullanımVeriler.Name = "dgwKullanımVeriler";
            this.dgwKullanımVeriler.RowTemplate.Height = 25;
            this.dgwKullanımVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKullanımVeriler.Size = new System.Drawing.Size(722, 403);
            this.dgwKullanımVeriler.TabIndex = 0;
            // 
            // ManagerLogsPageUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgwKullanımVeriler);
            this.Controls.Add(this.dgwVardiyaVeriler);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerLogsPageUI";
            this.Text = "MHT Manager Operations Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_onload);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVardiyaVeriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanımVeriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwVardiyaVeriler;
        private DataGridView dgwKullanımVeriler;
    }
}