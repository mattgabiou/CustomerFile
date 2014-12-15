namespace CustomerFile
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
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelDirections = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmpNumber = new System.Windows.Forms.Label();
            this.textBoxEmpNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_EmployeeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelFile = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(3, 27);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFullName.TabIndex = 2;
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(12, 36);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(116, 13);
            this.labelDirections.TabIndex = 3;
            this.labelDirections.Text = "Enter the customer info";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Full Name";
            // 
            // labelEmpNumber
            // 
            this.labelEmpNumber.AutoSize = true;
            this.labelEmpNumber.Location = new System.Drawing.Point(167, 11);
            this.labelEmpNumber.Name = "labelEmpNumber";
            this.labelEmpNumber.Size = new System.Drawing.Size(93, 13);
            this.labelEmpNumber.TabIndex = 6;
            this.labelEmpNumber.Text = "Employee Number";
            // 
            // textBoxEmpNumber
            // 
            this.textBoxEmpNumber.Location = new System.Drawing.Point(167, 27);
            this.textBoxEmpNumber.Name = "textBoxEmpNumber";
            this.textBoxEmpNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpNumber.TabIndex = 5;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(331, 11);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(331, 27);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(331, 85);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(100, 23);
            this.buttonEnterData.TabIndex = 9;
            this.buttonEnterData.Text = "Enter Customer";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxFullName);
            this.panel1.Controls.Add(this.textBoxEmpNumber);
            this.panel1.Controls.Add(this.textBoxPhoneNumber);
            this.panel1.Controls.Add(this.labelEmpNumber);
            this.panel1.Controls.Add(this.buttonEnterData);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelPhoneNumber);
            this.panel1.Location = new System.Drawing.Point(15, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 136);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_ID,
            this.Grid_Name,
            this.Grid_EmployeeNumber,
            this.Grid_PhoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(15, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 336);
            this.dataGridView1.TabIndex = 12;
            // 
            // Grid_ID
            // 
            this.Grid_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Grid_ID.HeaderText = "ID";
            this.Grid_ID.Name = "Grid_ID";
            this.Grid_ID.Width = 43;
            // 
            // Grid_Name
            // 
            this.Grid_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grid_Name.HeaderText = "Name";
            this.Grid_Name.Name = "Grid_Name";
            // 
            // Grid_EmployeeNumber
            // 
            this.Grid_EmployeeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grid_EmployeeNumber.HeaderText = "EmployeeNumber";
            this.Grid_EmployeeNumber.Name = "Grid_EmployeeNumber";
            // 
            // Grid_PhoneNumber
            // 
            this.Grid_PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grid_PhoneNumber.HeaderText = "Phone Number";
            this.Grid_PhoneNumber.Name = "Grid_PhoneNumber";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonDelFile);
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Controls.Add(this.buttonDisplay);
            this.panel2.Location = new System.Drawing.Point(15, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 100);
            this.panel2.TabIndex = 10;
            // 
            // buttonDelFile
            // 
            this.buttonDelFile.Location = new System.Drawing.Point(329, 32);
            this.buttonDelFile.Name = "buttonDelFile";
            this.buttonDelFile.Size = new System.Drawing.Size(113, 23);
            this.buttonDelFile.TabIndex = 11;
            this.buttonDelFile.Text = "Delete File";
            this.buttonDelFile.UseVisualStyleBackColor = true;
            this.buttonDelFile.Click += new System.EventHandler(this.buttonDelFile_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(168, 32);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(113, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(3, 32);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(113, 23);
            this.buttonDisplay.TabIndex = 1;
            this.buttonDisplay.Text = "Display Customers";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonEnterData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmpNumber;
        private System.Windows.Forms.TextBox textBoxEmpNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_EmployeeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_PhoneNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelFile;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonDisplay;
    }
}

