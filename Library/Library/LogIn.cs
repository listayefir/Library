using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;

namespace Library
{
    
    public partial class LogIn : Form
    {
       

        public string ConnectionParameters { get;  set; }
        public SourceType DBType { get; private set; }
        public LogIn()
        {
            InitializeComponent();
            tbConnectionString.Text = "Data Source =; Initial Catalog=;uid=;pwd=; ";
            
        }

        private void radioXML_CheckedChanged(object sender, EventArgs e)
        {
            if (radioXML.Checked)
            {
                gbXML.Enabled = true;
            }
            else
                gbXML.Enabled = false;
        }

        private void radioSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioSQL.Checked)
                gbSQL.Enabled = false;
            else
                gbSQL.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectionParams_Leave(object sender, EventArgs e)
        {
            if (chbxWinAuth.Checked)
            {
                tbLogin.Enabled = false;
                tbPassword.Enabled = false;
                tbConnectionString.Text = string.Format("Data Source = {0}; Initial Catalog= {1};"+
                    "Integrated Security=True",
                    tbDataSource.Text.Trim().ToString(), tbInitialDialogue.Text.Trim().ToString());
            }
            else
            {
                tbLogin.Enabled = true;
                tbPassword.Enabled = true;
                tbConnectionString.Text = string.Format("Data Source = {0}; Initial Catalog= {1};" +
                    "uid={2};pwd={3};",
                     tbDataSource.Text.Trim().ToString(), tbInitialDialogue.Text.Trim().ToString(),
                     tbLogin.Text.Trim().ToString(), tbPassword.Text.Trim().ToString());

            }
        }

        private void btnSearchXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog xmlFileDialog = new OpenFileDialog();
            xmlFileDialog.FileName = string.Empty;
            xmlFileDialog.Filter = "File XML (*.xml)|*.xml| All files(*.*)|*.*";

            if (xmlFileDialog.ShowDialog() == DialogResult.OK)
                tbXMLDataSource.Text = xmlFileDialog.FileName;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (radioXML.Checked)
            {
                ConnectionParameters = tbXMLDataSource.Text.Trim().ToString();
                DBType = SourceType.XML;
            }
            else
            {               
                    if (tbDataSource.Text.Trim().ToString()==string.Empty||
                        tbInitialDialogue.Text.Trim().ToString() == string.Empty)
                    {
                        MessageBox.Show("Enter server and database");
                        return;
                    }    
                    
                    if (!chbxWinAuth.Checked)
                {
                    if (tbLogin.Text.Trim().ToString()==string.Empty||
                        tbPassword.Text.Trim().ToString() == string.Empty)
                    {
                        MessageBox.Show("Enter login and password");
                        return;
                    }
                }

                ConnectionParameters = tbConnectionString.Text.Trim().ToString();
                DBType = SourceType.SQL;                                  
               
            }

            DialogResult = DialogResult.OK;
        }
    }
}
