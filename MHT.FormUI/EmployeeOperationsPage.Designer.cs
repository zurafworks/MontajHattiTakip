namespace ZrfMusteriTakip.FormUI
{
    partial class EmployeeOperationsPageUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeOperationsPageUI));
            this.dgwVeriler = new System.Windows.Forms.DataGridView();
            this.drpdwnSelectedVeri = new System.Windows.Forms.ComboBox();
            this.btnShiftStart = new System.Windows.Forms.Button();
            this.btnShiftEnd = new System.Windows.Forms.Button();
            this.btnBreakStart = new System.Windows.Forms.Button();
            this.btnUseStart = new System.Windows.Forms.Button();
            this.btnBreakEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUseEnd = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwVeriler
            // 
            this.dgwVeriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwVeriler.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dgwVeriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVeriler.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgwVeriler.Location = new System.Drawing.Point(493, 287);
            this.dgwVeriler.Name = "dgwVeriler";
            this.dgwVeriler.RowTemplate.Height = 25;
            this.dgwVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwVeriler.Size = new System.Drawing.Size(674, 259);
            this.dgwVeriler.TabIndex = 0;
            // 
            // drpdwnSelectedVeri
            // 
            this.drpdwnSelectedVeri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpdwnSelectedVeri.BackColor = System.Drawing.Color.DarkBlue;
            this.drpdwnSelectedVeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdwnSelectedVeri.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drpdwnSelectedVeri.ForeColor = System.Drawing.Color.White;
            this.drpdwnSelectedVeri.FormattingEnabled = true;
            this.drpdwnSelectedVeri.Location = new System.Drawing.Point(509, 142);
            this.drpdwnSelectedVeri.Name = "drpdwnSelectedVeri";
            this.drpdwnSelectedVeri.Size = new System.Drawing.Size(648, 38);
            this.drpdwnSelectedVeri.TabIndex = 13;
            this.drpdwnSelectedVeri.Text = "Listelenecek Veri";
            this.drpdwnSelectedVeri.SelectedIndexChanged += new System.EventHandler(this.drpdwnSelectedVeri_SelectedIndexChanged);
            this.drpdwnSelectedVeri.Enter += new System.EventHandler(this.drpdwnSelectedVeri_Enter);
            this.drpdwnSelectedVeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drpdwnSelectedVeri_KeyPress);
            this.drpdwnSelectedVeri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drpdwnSelectedVeri_MouseClick);
            // 
            // btnShiftStart
            // 
            this.btnShiftStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShiftStart.BackColor = System.Drawing.Color.Transparent;
            this.btnShiftStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShiftStart.BackgroundImage")));
            this.btnShiftStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShiftStart.FlatAppearance.BorderSize = 0;
            this.btnShiftStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftStart.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShiftStart.ForeColor = System.Drawing.Color.White;
            this.btnShiftStart.Location = new System.Drawing.Point(65, 274);
            this.btnShiftStart.Name = "btnShiftStart";
            this.btnShiftStart.Size = new System.Drawing.Size(156, 57);
            this.btnShiftStart.TabIndex = 2;
            this.btnShiftStart.Text = "Başla";
            this.btnShiftStart.UseVisualStyleBackColor = false;
            this.btnShiftStart.Click += new System.EventHandler(this.btnShiftStart_Click);
            // 
            // btnShiftEnd
            // 
            this.btnShiftEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShiftEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnShiftEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShiftEnd.BackgroundImage")));
            this.btnShiftEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShiftEnd.FlatAppearance.BorderSize = 0;
            this.btnShiftEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftEnd.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShiftEnd.ForeColor = System.Drawing.Color.White;
            this.btnShiftEnd.Location = new System.Drawing.Point(254, 274);
            this.btnShiftEnd.Name = "btnShiftEnd";
            this.btnShiftEnd.Size = new System.Drawing.Size(156, 57);
            this.btnShiftEnd.TabIndex = 3;
            this.btnShiftEnd.Text = "Bitir";
            this.btnShiftEnd.UseVisualStyleBackColor = false;
            this.btnShiftEnd.Click += new System.EventHandler(this.btnShiftEnd_Click);
            // 
            // btnBreakStart
            // 
            this.btnBreakStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreakStart.BackColor = System.Drawing.Color.Transparent;
            this.btnBreakStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBreakStart.BackgroundImage")));
            this.btnBreakStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBreakStart.FlatAppearance.BorderSize = 0;
            this.btnBreakStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakStart.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBreakStart.ForeColor = System.Drawing.Color.White;
            this.btnBreakStart.Location = new System.Drawing.Point(65, 445);
            this.btnBreakStart.Name = "btnBreakStart";
            this.btnBreakStart.Size = new System.Drawing.Size(156, 57);
            this.btnBreakStart.TabIndex = 6;
            this.btnBreakStart.Text = "Başla";
            this.btnBreakStart.UseVisualStyleBackColor = false;
            this.btnBreakStart.Click += new System.EventHandler(this.btnBreakStart_Click);
            // 
            // btnUseStart
            // 
            this.btnUseStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseStart.BackColor = System.Drawing.Color.Transparent;
            this.btnUseStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUseStart.BackgroundImage")));
            this.btnUseStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUseStart.FlatAppearance.BorderSize = 0;
            this.btnUseStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseStart.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUseStart.ForeColor = System.Drawing.Color.White;
            this.btnUseStart.Location = new System.Drawing.Point(484, 204);
            this.btnUseStart.Name = "btnUseStart";
            this.btnUseStart.Size = new System.Drawing.Size(347, 57);
            this.btnUseStart.TabIndex = 5;
            this.btnUseStart.Text = "Kullanmaya Başla";
            this.btnUseStart.UseVisualStyleBackColor = false;
            this.btnUseStart.Click += new System.EventHandler(this.btnUseStart_Click);
            // 
            // btnBreakEnd
            // 
            this.btnBreakEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreakEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnBreakEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBreakEnd.BackgroundImage")));
            this.btnBreakEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBreakEnd.FlatAppearance.BorderSize = 0;
            this.btnBreakEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakEnd.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBreakEnd.ForeColor = System.Drawing.Color.White;
            this.btnBreakEnd.Location = new System.Drawing.Point(254, 445);
            this.btnBreakEnd.Name = "btnBreakEnd";
            this.btnBreakEnd.Size = new System.Drawing.Size(156, 57);
            this.btnBreakEnd.TabIndex = 4;
            this.btnBreakEnd.Text = "Bitir";
            this.btnBreakEnd.UseVisualStyleBackColor = false;
            this.btnBreakEnd.Click += new System.EventHandler(this.btnBreakEnd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vardiya:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mola:";
            // 
            // btnUseEnd
            // 
            this.btnUseEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnUseEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUseEnd.BackgroundImage")));
            this.btnUseEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUseEnd.FlatAppearance.BorderSize = 0;
            this.btnUseEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseEnd.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUseEnd.ForeColor = System.Drawing.Color.White;
            this.btnUseEnd.Location = new System.Drawing.Point(837, 204);
            this.btnUseEnd.Name = "btnUseEnd";
            this.btnUseEnd.Size = new System.Drawing.Size(347, 57);
            this.btnUseEnd.TabIndex = 5;
            this.btnUseEnd.Text = "Kullanımı Bitir";
            this.btnUseEnd.UseVisualStyleBackColor = false;
            this.btnUseEnd.Click += new System.EventHandler(this.btnUseEnd_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEmployeeName.Location = new System.Drawing.Point(158, 48);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(63, 32);
            this.lblEmployeeName.TabIndex = 14;
            this.lblEmployeeName.Text = "İsim";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSurname.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSurname.Location = new System.Drawing.Point(158, 80);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(104, 32);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Soyisim";
            // 
            // EmployeeOperationsPageUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBreakEnd);
            this.Controls.Add(this.btnUseEnd);
            this.Controls.Add(this.btnUseStart);
            this.Controls.Add(this.btnBreakStart);
            this.Controls.Add(this.btnShiftEnd);
            this.Controls.Add(this.btnShiftStart);
            this.Controls.Add(this.drpdwnSelectedVeri);
            this.Controls.Add(this.dgwVeriler);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeOperationsPageUI";
            this.Text = "MHT Emplooyee Operations Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_onload);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgwVeriler;
        private ComboBox drpdwnSelectedVeri;
        private Button btnShiftStart;
        private Button btnShiftEnd;
        private Button btnBreakStart;
        private Button btnUseStart;
        private Button btnBreakEnd;
        private Label label1;
        private Label label2;
        private Button btnUseEnd;
        private Label lblEmployeeName;
        private Label lblSurname;
    }
}