namespace ZrfMusteriTakip.FormUI
{
    partial class ManagerHomePageUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHomePageUI));
            this.btnEmployeeOperations = new System.Windows.Forms.Button();
            this.btnMachineOperations = new System.Windows.Forms.Button();
            this.fpGraphicView = new ScottPlot.FormsPlot();
            this.SuspendLayout();
            // 
            // btnEmployeeOperations
            // 
            this.btnEmployeeOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeOperations.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeOperations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeOperations.BackgroundImage")));
            this.btnEmployeeOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeOperations.FlatAppearance.BorderSize = 0;
            this.btnEmployeeOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeOperations.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeOperations.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeOperations.Location = new System.Drawing.Point(1012, 110);
            this.btnEmployeeOperations.Name = "btnEmployeeOperations";
            this.btnEmployeeOperations.Size = new System.Drawing.Size(181, 77);
            this.btnEmployeeOperations.TabIndex = 2;
            this.btnEmployeeOperations.Text = "İşçi \r\nİşlemleri";
            this.btnEmployeeOperations.UseVisualStyleBackColor = false;
            this.btnEmployeeOperations.Click += new System.EventHandler(this.btnEmployeeOperations_Click);
            // 
            // btnMachineOperations
            // 
            this.btnMachineOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMachineOperations.BackColor = System.Drawing.Color.Transparent;
            this.btnMachineOperations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMachineOperations.BackgroundImage")));
            this.btnMachineOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMachineOperations.FlatAppearance.BorderSize = 0;
            this.btnMachineOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineOperations.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMachineOperations.ForeColor = System.Drawing.Color.White;
            this.btnMachineOperations.Location = new System.Drawing.Point(1012, 217);
            this.btnMachineOperations.Name = "btnMachineOperations";
            this.btnMachineOperations.Size = new System.Drawing.Size(181, 77);
            this.btnMachineOperations.TabIndex = 2;
            this.btnMachineOperations.Text = "Makine\r\nİşlemleri";
            this.btnMachineOperations.UseVisualStyleBackColor = false;
            this.btnMachineOperations.Click += new System.EventHandler(this.btnEmployeeOperations_Click);
            // 
            // fpGraphicView
            // 
            this.fpGraphicView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpGraphicView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fpGraphicView.Location = new System.Drawing.Point(66, 67);
            this.fpGraphicView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpGraphicView.Name = "fpGraphicView";
            this.fpGraphicView.Size = new System.Drawing.Size(834, 477);
            this.fpGraphicView.TabIndex = 3;
            // 
            // ManagerHomePageUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.fpGraphicView);
            this.Controls.Add(this.btnMachineOperations);
            this.Controls.Add(this.btnEmployeeOperations);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerHomePageUI";
            this.Text = "MHT Manager Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_onload);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnEmployeeOperations;
        private Button btnMachineOperations;
        private ScottPlot.FormsPlot fpGraphicView;
    }
}