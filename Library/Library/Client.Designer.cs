namespace Library
{
    partial class Client
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbBookPublisher = new System.Windows.Forms.TextBox();
            this.tbBookDate = new System.Windows.Forms.TextBox();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMagNumber = new System.Windows.Forms.TextBox();
            this.tbMagDate = new System.Windows.Forms.TextBox();
            this.tbMagPublisher = new System.Windows.Forms.TextBox();
            this.tbMagName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMagazines = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbArtAuthor = new System.Windows.Forms.TextBox();
            this.tbArtDate = new System.Windows.Forms.TextBox();
            this.tbArtPublisher = new System.Windows.Forms.TextBox();
            this.tbArtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.btnRefreshBooks = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Magazines/Articles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefreshBooks);
            this.tabPage1.Controls.Add(this.tbBookAuthor);
            this.tabPage1.Controls.Add(this.tbBookDate);
            this.tabPage1.Controls.Add(this.tbBookPublisher);
            this.tabPage1.Controls.Add(this.tbBookName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 50);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(644, 308);
            this.dgvBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of publication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Author";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(12, 24);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(146, 20);
            this.tbBookName.TabIndex = 5;
            // 
            // tbBookPublisher
            // 
            this.tbBookPublisher.Location = new System.Drawing.Point(164, 23);
            this.tbBookPublisher.Name = "tbBookPublisher";
            this.tbBookPublisher.Size = new System.Drawing.Size(148, 20);
            this.tbBookPublisher.TabIndex = 6;
            // 
            // tbBookDate
            // 
            this.tbBookDate.Location = new System.Drawing.Point(318, 23);
            this.tbBookDate.Name = "tbBookDate";
            this.tbBookDate.Size = new System.Drawing.Size(113, 20);
            this.tbBookDate.TabIndex = 7;
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(469, 24);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(121, 20);
            this.tbBookAuthor.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMagNumber);
            this.groupBox1.Controls.Add(this.tbMagDate);
            this.groupBox1.Controls.Add(this.tbMagPublisher);
            this.groupBox1.Controls.Add(this.tbMagName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvMagazines);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magazines";
            // 
            // tbMagNumber
            // 
            this.tbMagNumber.Location = new System.Drawing.Point(464, 34);
            this.tbMagNumber.Name = "tbMagNumber";
            this.tbMagNumber.Size = new System.Drawing.Size(98, 20);
            this.tbMagNumber.TabIndex = 17;
            // 
            // tbMagDate
            // 
            this.tbMagDate.Location = new System.Drawing.Point(313, 33);
            this.tbMagDate.Name = "tbMagDate";
            this.tbMagDate.Size = new System.Drawing.Size(90, 20);
            this.tbMagDate.TabIndex = 16;
            // 
            // tbMagPublisher
            // 
            this.tbMagPublisher.Location = new System.Drawing.Point(159, 33);
            this.tbMagPublisher.Name = "tbMagPublisher";
            this.tbMagPublisher.Size = new System.Drawing.Size(125, 20);
            this.tbMagPublisher.TabIndex = 15;
            // 
            // tbMagName
            // 
            this.tbMagName.Location = new System.Drawing.Point(7, 34);
            this.tbMagName.Name = "tbMagName";
            this.tbMagName.Size = new System.Drawing.Size(123, 20);
            this.tbMagName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of publication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Publisher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Name";
            // 
            // dgvMagazines
            // 
            this.dgvMagazines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazines.Location = new System.Drawing.Point(2, 60);
            this.dgvMagazines.Name = "dgvMagazines";
            this.dgvMagazines.Size = new System.Drawing.Size(633, 146);
            this.dgvMagazines.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbArtAuthor);
            this.groupBox2.Controls.Add(this.tbArtDate);
            this.groupBox2.Controls.Add(this.tbArtPublisher);
            this.groupBox2.Controls.Add(this.tbArtName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dgvArticles);
            this.groupBox2.Location = new System.Drawing.Point(6, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles";
            // 
            // tbArtAuthor
            // 
            this.tbArtAuthor.Location = new System.Drawing.Point(464, 34);
            this.tbArtAuthor.Name = "tbArtAuthor";
            this.tbArtAuthor.Size = new System.Drawing.Size(98, 20);
            this.tbArtAuthor.TabIndex = 17;
            // 
            // tbArtDate
            // 
            this.tbArtDate.Location = new System.Drawing.Point(313, 33);
            this.tbArtDate.Name = "tbArtDate";
            this.tbArtDate.Size = new System.Drawing.Size(90, 20);
            this.tbArtDate.TabIndex = 16;
            // 
            // tbArtPublisher
            // 
            this.tbArtPublisher.Location = new System.Drawing.Point(159, 33);
            this.tbArtPublisher.Name = "tbArtPublisher";
            this.tbArtPublisher.Size = new System.Drawing.Size(125, 20);
            this.tbArtPublisher.TabIndex = 15;
            // 
            // tbArtName
            // 
            this.tbArtName.Location = new System.Drawing.Point(7, 34);
            this.tbArtName.Name = "tbArtName";
            this.tbArtName.Size = new System.Drawing.Size(123, 20);
            this.tbArtName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Author";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Date of publication";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Publisher";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Name";
            // 
            // dgvArticles
            // 
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Location = new System.Drawing.Point(2, 60);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.Size = new System.Drawing.Size(633, 146);
            this.dgvArticles.TabIndex = 9;
            // 
            // btnRefreshBooks
            // 
            this.btnRefreshBooks.Location = new System.Drawing.Point(12, 392);
            this.btnRefreshBooks.Name = "btnRefreshBooks";
            this.btnRefreshBooks.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshBooks.TabIndex = 9;
            this.btnRefreshBooks.Text = "Refresh";
            this.btnRefreshBooks.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "Client";
            this.Text = "Library";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.TextBox tbBookDate;
        private System.Windows.Forms.TextBox tbBookPublisher;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbArtAuthor;
        private System.Windows.Forms.TextBox tbArtDate;
        private System.Windows.Forms.TextBox tbArtPublisher;
        private System.Windows.Forms.TextBox tbArtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMagNumber;
        private System.Windows.Forms.TextBox tbMagDate;
        private System.Windows.Forms.TextBox tbMagPublisher;
        private System.Windows.Forms.TextBox tbMagName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvMagazines;
        private System.Windows.Forms.Button btnRefreshBooks;
    }
}

