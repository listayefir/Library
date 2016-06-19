namespace DisconnectedModelApp
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
            this.components = new System.ComponentModel.Container();
            this.dgv_Debitors = new System.Windows.Forms.DataGridView();
            this.cms_deleteRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCurrentRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_bind = new System.Windows.Forms.Button();
            this.dgv_Credits = new System.Windows.Forms.DataGridView();
            this.dgv_Payments = new System.Windows.Forms.DataGridView();
            this.btn_acceptChanges = new System.Windows.Forms.Button();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_saveXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debitors)).BeginInit();
            this.cms_deleteRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Debitors
            // 
            this.dgv_Debitors.AllowUserToAddRows = false;
            this.dgv_Debitors.AllowUserToDeleteRows = false;
            this.dgv_Debitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Debitors.ContextMenuStrip = this.cms_deleteRow;
            this.dgv_Debitors.Location = new System.Drawing.Point(13, 51);
            this.dgv_Debitors.Name = "dgv_Debitors";
            this.dgv_Debitors.ReadOnly = true;
            this.dgv_Debitors.Size = new System.Drawing.Size(548, 136);
            this.dgv_Debitors.TabIndex = 0;
            this.dgv_Debitors.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            // 
            // cms_deleteRow
            // 
            this.cms_deleteRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCurrentRowToolStripMenuItem});
            this.cms_deleteRow.Name = "cms_deleteRow";
            this.cms_deleteRow.Size = new System.Drawing.Size(172, 26);
            this.cms_deleteRow.Text = "Delete current row";
            this.cms_deleteRow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cms_deleteRow_MouseClick);
            // 
            // deleteCurrentRowToolStripMenuItem
            // 
            this.deleteCurrentRowToolStripMenuItem.Name = "deleteCurrentRowToolStripMenuItem";
            this.deleteCurrentRowToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteCurrentRowToolStripMenuItem.Text = "Delete current row";
            // 
            // btn_bind
            // 
            this.btn_bind.Location = new System.Drawing.Point(13, 13);
            this.btn_bind.Name = "btn_bind";
            this.btn_bind.Size = new System.Drawing.Size(75, 23);
            this.btn_bind.TabIndex = 1;
            this.btn_bind.Text = "Bind DGV";
            this.btn_bind.UseVisualStyleBackColor = true;
            this.btn_bind.Click += new System.EventHandler(this.btn_bind_Click);
            // 
            // dgv_Credits
            // 
            this.dgv_Credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credits.Location = new System.Drawing.Point(13, 193);
            this.dgv_Credits.Name = "dgv_Credits";
            this.dgv_Credits.Size = new System.Drawing.Size(548, 86);
            this.dgv_Credits.TabIndex = 2;
            this.dgv_Credits.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            // 
            // dgv_Payments
            // 
            this.dgv_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payments.Location = new System.Drawing.Point(12, 285);
            this.dgv_Payments.Name = "dgv_Payments";
            this.dgv_Payments.Size = new System.Drawing.Size(548, 86);
            this.dgv_Payments.TabIndex = 3;
            this.dgv_Payments.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            // 
            // btn_acceptChanges
            // 
            this.btn_acceptChanges.Location = new System.Drawing.Point(107, 13);
            this.btn_acceptChanges.Name = "btn_acceptChanges";
            this.btn_acceptChanges.Size = new System.Drawing.Size(114, 23);
            this.btn_acceptChanges.TabIndex = 4;
            this.btn_acceptChanges.Text = "Accept Changes";
            this.btn_acceptChanges.UseVisualStyleBackColor = true;
            this.btn_acceptChanges.Click += new System.EventHandler(this.btn_acceptChanges_Click);
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(255, 13);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(126, 20);
            this.tbx_Search.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(388, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseMnemonic = false;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_saveXML
            // 
            this.btn_saveXML.Location = new System.Drawing.Point(469, 12);
            this.btn_saveXML.Name = "btn_saveXML";
            this.btn_saveXML.Size = new System.Drawing.Size(91, 23);
            this.btn_saveXML.TabIndex = 7;
            this.btn_saveXML.Text = "Save to XML";
            this.btn_saveXML.UseVisualStyleBackColor = true;
            this.btn_saveXML.Click += new System.EventHandler(this.btn_saveXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 383);
            this.Controls.Add(this.btn_saveXML);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_Search);
            this.Controls.Add(this.btn_acceptChanges);
            this.Controls.Add(this.dgv_Payments);
            this.Controls.Add(this.dgv_Credits);
            this.Controls.Add(this.btn_bind);
            this.Controls.Add(this.dgv_Debitors);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debitors)).EndInit();
            this.cms_deleteRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Debitors;
        private System.Windows.Forms.Button btn_bind;
        private System.Windows.Forms.DataGridView dgv_Credits;
        private System.Windows.Forms.DataGridView dgv_Payments;
        private System.Windows.Forms.Button btn_acceptChanges;
        private System.Windows.Forms.ContextMenuStrip cms_deleteRow;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentRowToolStripMenuItem;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_saveXML;
    }
}

