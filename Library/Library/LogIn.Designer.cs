namespace Library
{
    partial class LogIn
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
            this.radioXML = new System.Windows.Forms.RadioButton();
            this.radioSQL = new System.Windows.Forms.RadioButton();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.chbxWinAuth = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbInitialDialogue = new System.Windows.Forms.TextBox();
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.tbDataSource = new System.Windows.Forms.TextBox();
            this.gbXML = new System.Windows.Forms.GroupBox();
            this.btnSearchXML = new System.Windows.Forms.Button();
            this.tbXMLDataSource = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbSQL.SuspendLayout();
            this.gbXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioXML);
            this.groupBox1.Controls.Add(this.radioSQL);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose data source";
            // 
            // radioXML
            // 
            this.radioXML.AutoSize = true;
            this.radioXML.Location = new System.Drawing.Point(447, 20);
            this.radioXML.Name = "radioXML";
            this.radioXML.Size = new System.Drawing.Size(91, 17);
            this.radioXML.TabIndex = 1;
            this.radioXML.TabStop = true;
            this.radioXML.Text = "use XML data";
            this.radioXML.UseVisualStyleBackColor = true;
            this.radioXML.CheckedChanged += new System.EventHandler(this.radioXML_CheckedChanged);
            // 
            // radioSQL
            // 
            this.radioSQL.AutoSize = true;
            this.radioSQL.Checked = true;
            this.radioSQL.Location = new System.Drawing.Point(245, 19);
            this.radioSQL.Name = "radioSQL";
            this.radioSQL.Size = new System.Drawing.Size(92, 17);
            this.radioSQL.TabIndex = 0;
            this.radioSQL.TabStop = true;
            this.radioSQL.Text = "Use SQL data";
            this.radioSQL.UseVisualStyleBackColor = true;
            this.radioSQL.CheckedChanged += new System.EventHandler(this.radioSQL_CheckedChanged);
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.chbxWinAuth);
            this.gbSQL.Controls.Add(this.label6);
            this.gbSQL.Controls.Add(this.label5);
            this.gbSQL.Controls.Add(this.label4);
            this.gbSQL.Controls.Add(this.label3);
            this.gbSQL.Controls.Add(this.label2);
            this.gbSQL.Controls.Add(this.label1);
            this.gbSQL.Controls.Add(this.tbLogin);
            this.gbSQL.Controls.Add(this.tbPassword);
            this.gbSQL.Controls.Add(this.tbInitialDialogue);
            this.gbSQL.Controls.Add(this.tbConnectionString);
            this.gbSQL.Controls.Add(this.tbDataSource);
            this.gbSQL.Location = new System.Drawing.Point(26, 94);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(687, 189);
            this.gbSQL.TabIndex = 2;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "Sql Connection";
            // 
            // chbxWinAuth
            // 
            this.chbxWinAuth.AutoSize = true;
            this.chbxWinAuth.Location = new System.Drawing.Point(229, 73);
            this.chbxWinAuth.Name = "chbxWinAuth";
            this.chbxWinAuth.Size = new System.Drawing.Size(15, 14);
            this.chbxWinAuth.TabIndex = 11;
            this.chbxWinAuth.UseVisualStyleBackColor = true;
            this.chbxWinAuth.CheckedChanged += new System.EventHandler(this.connectionParams_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Connection String";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Use Windiws Authentification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Initial Dialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Source";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(229, 98);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(266, 20);
            this.tbLogin.TabIndex = 4;
            this.tbLogin.Leave += new System.EventHandler(this.connectionParams_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(229, 124);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(266, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Leave += new System.EventHandler(this.connectionParams_Leave);
            // 
            // tbInitialDialogue
            // 
            this.tbInitialDialogue.Location = new System.Drawing.Point(229, 46);
            this.tbInitialDialogue.Name = "tbInitialDialogue";
            this.tbInitialDialogue.Size = new System.Drawing.Size(266, 20);
            this.tbInitialDialogue.TabIndex = 2;
            this.tbInitialDialogue.Text = "Library";
            this.tbInitialDialogue.Leave += new System.EventHandler(this.connectionParams_Leave);
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(229, 150);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.ReadOnly = true;
            this.tbConnectionString.Size = new System.Drawing.Size(441, 20);
            this.tbConnectionString.TabIndex = 1;
            // 
            // tbDataSource
            // 
            this.tbDataSource.Location = new System.Drawing.Point(229, 20);
            this.tbDataSource.Name = "tbDataSource";
            this.tbDataSource.Size = new System.Drawing.Size(266, 20);
            this.tbDataSource.TabIndex = 0;
            this.tbDataSource.Text = "Alice-PC\\SQLEXPRESS";
            this.tbDataSource.Leave += new System.EventHandler(this.connectionParams_Leave);
            // 
            // gbXML
            // 
            this.gbXML.Controls.Add(this.btnSearchXML);
            this.gbXML.Controls.Add(this.tbXMLDataSource);
            this.gbXML.Controls.Add(this.label7);
            this.gbXML.Enabled = false;
            this.gbXML.Location = new System.Drawing.Point(26, 314);
            this.gbXML.Name = "gbXML";
            this.gbXML.Size = new System.Drawing.Size(687, 100);
            this.gbXML.TabIndex = 3;
            this.gbXML.TabStop = false;
            this.gbXML.Text = "Xml Connection";
            // 
            // btnSearchXML
            // 
            this.btnSearchXML.Location = new System.Drawing.Point(501, 45);
            this.btnSearchXML.Name = "btnSearchXML";
            this.btnSearchXML.Size = new System.Drawing.Size(75, 23);
            this.btnSearchXML.TabIndex = 13;
            this.btnSearchXML.Text = "Open...";
            this.btnSearchXML.UseVisualStyleBackColor = true;
            this.btnSearchXML.Click += new System.EventHandler(this.btnSearchXML_Click);
            // 
            // tbXMLDataSource
            // 
            this.tbXMLDataSource.Location = new System.Drawing.Point(229, 47);
            this.tbXMLDataSource.Name = "tbXMLDataSource";
            this.tbXMLDataSource.Size = new System.Drawing.Size(266, 20);
            this.tbXMLDataSource.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Choose XML Data source";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(491, 420);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(614, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 447);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbXML);
            this.Controls.Add(this.gbSQL);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSQL.ResumeLayout(false);
            this.gbSQL.PerformLayout();
            this.gbXML.ResumeLayout(false);
            this.gbXML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioXML;
        private System.Windows.Forms.RadioButton radioSQL;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.CheckBox chbxWinAuth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbInitialDialogue;
        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.TextBox tbDataSource;
        private System.Windows.Forms.GroupBox gbXML;
        private System.Windows.Forms.Button btnSearchXML;
        private System.Windows.Forms.TextBox tbXMLDataSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
    }
}