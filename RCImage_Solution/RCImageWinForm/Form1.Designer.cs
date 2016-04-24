namespace RCImageWinForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbDataAreaID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvFileInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.intWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvErrorFileInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.tpgConfig = new System.Windows.Forms.TabPage();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfigFileExtensions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfigFileSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileInfo)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorFileInfo)).BeginInit();
            this.tpgConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpgConfig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 617);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowConfig);
            this.tabPage1.Controls.Add(this.cmbDataAreaID);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.txtDir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbDataAreaID
            // 
            this.cmbDataAreaID.FormattingEnabled = true;
            this.cmbDataAreaID.Location = new System.Drawing.Point(20, 81);
            this.cmbDataAreaID.Name = "cmbDataAreaID";
            this.cmbDataAreaID.Size = new System.Drawing.Size(149, 21);
            this.cmbDataAreaID.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Please select the company:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Please select the directory of file path:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(3, 128);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(775, 460);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvFileInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 434);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Normal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvFileInfo
            // 
            this.dgvFileInfo.AllowUserToAddRows = false;
            this.dgvFileInfo.AllowUserToDeleteRows = false;
            this.dgvFileInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.intWidth,
            this.intHeight});
            this.dgvFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvFileInfo.Name = "dgvFileInfo";
            this.dgvFileInfo.ReadOnly = true;
            this.dgvFileInfo.Size = new System.Drawing.Size(761, 428);
            this.dgvFileInfo.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RCName";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "RC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "FullPath";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Full Path";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FileSize";
            this.Column3.HeaderText = "File Size";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Image";
            this.Column4.HeaderText = "Image";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // intWidth
            // 
            this.intWidth.DataPropertyName = "intWidth";
            this.intWidth.HeaderText = "Width";
            this.intWidth.Name = "intWidth";
            this.intWidth.ReadOnly = true;
            // 
            // intHeight
            // 
            this.intHeight.DataPropertyName = "intHeight";
            this.intHeight.HeaderText = "Height";
            this.intHeight.Name = "intHeight";
            this.intHeight.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvErrorFileInfo);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(767, 434);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Error";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvErrorFileInfo
            // 
            this.dgvErrorFileInfo.AllowUserToAddRows = false;
            this.dgvErrorFileInfo.AllowUserToDeleteRows = false;
            this.dgvErrorFileInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorFileInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.Width,
            this.Height});
            this.dgvErrorFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvErrorFileInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvErrorFileInfo.Name = "dgvErrorFileInfo";
            this.dgvErrorFileInfo.ReadOnly = true;
            this.dgvErrorFileInfo.Size = new System.Drawing.Size(761, 428);
            this.dgvErrorFileInfo.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RCName";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "RC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullPath";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Path";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FileSize";
            this.dataGridViewTextBoxColumn3.HeaderText = "File Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // Width
            // 
            this.Width.DataPropertyName = "intWidth";
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            // 
            // Height
            // 
            this.Height.DataPropertyName = "intHeight";
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(519, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(519, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtDir
            // 
            this.txtDir.Enabled = false;
            this.txtDir.Location = new System.Drawing.Point(20, 33);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(436, 20);
            this.txtDir.TabIndex = 0;
            // 
            // tpgConfig
            // 
            this.tpgConfig.Controls.Add(this.label3);
            this.tpgConfig.Controls.Add(this.txtMaxHeight);
            this.tpgConfig.Controls.Add(this.label10);
            this.tpgConfig.Controls.Add(this.label1);
            this.tpgConfig.Controls.Add(this.txtMaxWidth);
            this.tpgConfig.Controls.Add(this.label2);
            this.tpgConfig.Controls.Add(this.btnReadConfig);
            this.tpgConfig.Controls.Add(this.btnConfig);
            this.tpgConfig.Controls.Add(this.label7);
            this.tpgConfig.Controls.Add(this.label6);
            this.tpgConfig.Controls.Add(this.txtConfigFileExtensions);
            this.tpgConfig.Controls.Add(this.label5);
            this.tpgConfig.Controls.Add(this.txtConfigFileSize);
            this.tpgConfig.Controls.Add(this.label4);
            this.tpgConfig.Location = new System.Drawing.Point(4, 22);
            this.tpgConfig.Name = "tpgConfig";
            this.tpgConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpgConfig.Size = new System.Drawing.Size(781, 591);
            this.tpgConfig.TabIndex = 3;
            this.tpgConfig.Text = "Config";
            this.tpgConfig.UseVisualStyleBackColor = true;
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(489, 165);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(75, 23);
            this.btnReadConfig.TabIndex = 8;
            this.btnReadConfig.Text = "Read";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(489, 244);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Save";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Please enter the accepted file extensions split by |, like .gif|.jpge|.jpg.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(534, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Please enter a number to limit the max size for image file, like 1024 means only " +
    "image size with 1KB is accepted. ";
            // 
            // txtConfigFileExtensions
            // 
            this.txtConfigFileExtensions.Location = new System.Drawing.Point(65, 165);
            this.txtConfigFileExtensions.Name = "txtConfigFileExtensions";
            this.txtConfigFileExtensions.Size = new System.Drawing.Size(256, 20);
            this.txtConfigFileExtensions.TabIndex = 3;
            this.txtConfigFileExtensions.Text = ".gif|.jpge|.jpg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Allow image file extensions";
            // 
            // txtConfigFileSize
            // 
            this.txtConfigFileSize.Location = new System.Drawing.Point(65, 60);
            this.txtConfigFileSize.Name = "txtConfigFileSize";
            this.txtConfigFileSize.Size = new System.Drawing.Size(256, 20);
            this.txtConfigFileSize.TabIndex = 1;
            this.txtConfigFileSize.Text = "20480";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Allow image file max size";
            // 
            // btnShowConfig
            // 
            this.btnShowConfig.Location = new System.Drawing.Point(634, 79);
            this.btnShowConfig.Name = "btnShowConfig";
            this.btnShowConfig.Size = new System.Drawing.Size(108, 23);
            this.btnShowConfig.TabIndex = 8;
            this.btnShowConfig.Text = "Show config";
            this.btnShowConfig.UseVisualStyleBackColor = true;
            this.btnShowConfig.Visible = false;
            this.btnShowConfig.Click += new System.EventHandler(this.btnShowConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please enter a number to limit the max size of image width.";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(65, 270);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(256, 20);
            this.txtMaxWidth.TabIndex = 10;
            this.txtMaxWidth.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Allow image file max width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Please enter a number to limit the max size of image height.";
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(65, 375);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(256, 20);
            this.txtMaxHeight.TabIndex = 13;
            this.txtMaxHeight.Text = "90";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Allow image file max height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 617);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Import";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileInfo)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorFileInfo)).EndInit();
            this.tpgConfig.ResumeLayout(false);
            this.tpgConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.DataGridView dgvFileInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvErrorFileInfo;
        private System.Windows.Forms.TabPage tpgConfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfigFileExtensions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfigFileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReadConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn intWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn intHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDataAreaID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxHeight;
        private System.Windows.Forms.Label label10;
    }
}

