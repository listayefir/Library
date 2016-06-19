using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DisconnectedModelApp
{
    public partial class Form1 : Form
    {

        //string connectionString = ConfigurationManager.ConnectionStrings[".BankSystemConnectionString"].ConnectionString;
        DataSet BankSystem;
        DataTable Debitors, Credits, Payments;
        DataView dataView;

        public Form1()
        {
            InitializeComponent();
            //CreateDebitorsTable();
            //CreateCreditsTable();
            //CreatePaymentsTable();
            

            BankSystem = new DataSet("BankSystem");
            BankSystem.ReadXml("BankSystem.xml");
          //  BankSystem.ReadXmlSchema("BankSystem.xsd");
            //BankSystem.Tables.AddRange(new DataTable[] { Debitors,Credits,Payments });

            //CreateRelationships();

        }

        private void CreateRelationships()
        {
            DataRelation dr = new DataRelation("Debitor-Credit",
                                                       BankSystem.Tables["Debitors"].Columns["ID"],
                                                       BankSystem.Tables["Credits"].Columns["DebitorID"]);
            BankSystem.Relations.Add(dr);
                                                       
            BankSystem.Relations.Add(new DataRelation("Credit-Payment",
                                                       BankSystem.Tables["Credits"].Columns["ID"],
                                                       BankSystem.Tables["Payments"].Columns["CreditID"]));

        }

        private void CreatePaymentsTable()
        {
           Payments = new DataTable("Payments");

            DataColumn column = new DataColumn("ID", typeof(Guid));
            column.Caption = "Payment ID";
            column.AllowDBNull = false;
            column.Unique = true;
            Payments.Columns.Add(column);

            column = new DataColumn("CreditID", typeof(Guid));
            column.Caption = "Credit ID";
            column.AllowDBNull = false;
            column.Unique = true;
            Payments.Columns.Add(column);

            column = new DataColumn("Payment", typeof(decimal));
            column.Caption = "Payment amount";
            column.AllowDBNull = false;
            Payments.Columns.Add(column);

            column = new DataColumn("PaymentDate", typeof(DateTime));
            column.Caption = "Payment date";
            column.AllowDBNull = false;
            Payments.Columns.Add(column);
        }
        private void CreateDebitorsTable()
        {
            Debitors = new DataTable("Debitors");

            DataColumn id = new DataColumn("ID", typeof(Guid));
            id.Caption = "Debitor's ID";
            //id.AutoIncrement = true;
            //id.AutoIncrementStep = 1;
            //id.AutoIncrementSeed = 0;
            id.Unique = true;
            id.AllowDBNull = false;
            // id.ReadOnly = true;

            DataColumn name = new DataColumn("Name", typeof(string));
            name.Caption = "Debitor's name";
            name.AllowDBNull = false;

            DataColumn postIndex = new DataColumn("PostIndex", typeof(string));
            name.Caption = "Debitor's post index";
            name.AllowDBNull = false;

            DataColumn phoneNumber = new DataColumn("PhoneNumber", typeof(string));
            name.Caption = "Debitor's phone number";
            name.AllowDBNull = true;

            Debitors.Columns.AddRange(new DataColumn[] { id, name, postIndex, phoneNumber });

            DataRow newRow = Debitors.NewRow();

            newRow[id] = Guid.NewGuid();
            newRow[name] = "Alice";
            newRow[postIndex] = "91293";
            newRow[phoneNumber] = null;
            Debitors.Rows.Add(newRow);

            newRow = Debitors.NewRow();
            newRow[id] = Guid.NewGuid();
            newRow[name] = "Vasya";
            newRow[postIndex] = "65464";
            newRow[phoneNumber] = "4654123";
            Debitors.Rows.Add(newRow);

            newRow = Debitors.NewRow();
            newRow[id] = Guid.NewGuid();
            newRow[name] = "Vova";
            newRow[postIndex] = "54593";
            newRow[phoneNumber] = "654621";
            Debitors.Rows.Add(newRow);

            newRow = Debitors.NewRow();
            newRow[id] = Guid.NewGuid();
            newRow[name] = "Masha";
            newRow[postIndex] = "54293";
            newRow[phoneNumber] = "6456";
            Debitors.Rows.Add(newRow);

            dataView = new DataView(Debitors, "","Name DESC", DataViewRowState.Added);
           // dataView.FindRows("Name like '%" + tbx_Search.Text.Trim().ToString() + "%'");


           


        }

        private void CreateCreditsTable()
        {
            Credits = new DataTable("Credits");

            DataColumn column = new DataColumn("ID", typeof(Guid));
            column.Caption = "Credit ID";
            column.AllowDBNull = false;
            column.Unique = true;
            Credits.Columns.Add(column);

            column = new DataColumn("DebitorID", typeof(Guid));
            column.Caption = "Debitor's ID";
            column.AllowDBNull = false;
            column.Unique = true;
            Credits.Columns.Add(column);

            column = new DataColumn("Amount", typeof(int));
            column.Caption = "Credit amount";
            column.AllowDBNull = false;
            Credits.Columns.Add(column);

            column = new DataColumn("Balance", typeof(decimal));
            column.Caption = "Credit balance";
            column.AllowDBNull = false;
            Credits.Columns.Add(column);

            column = new DataColumn("OpenDate", typeof(DateTime));
            column.Caption = "Credit open date";
            column.AllowDBNull = false;
            Credits.Columns.Add(column);

        }

        private void btn_acceptChanges_Click(object sender, EventArgs e)
        {
            Debitors.AcceptChanges();
            Credits.AcceptChanges();
            Payments.AcceptChanges();
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                ((DataGridView)sender).CurrentCell = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];
            }
        }

        private void cms_deleteRow_MouseClick(object sender, MouseEventArgs e)
        {
            Debitors.Rows[((DataGridView)sender).CurrentRow.Index].Delete();
        }

        private void btn_saveXML_Click(object sender, EventArgs e)
        {
            BankSystem.WriteXml("BankSystem.xml");
            BankSystem.WriteXmlSchema("BankSystem.xsd");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //dataView = new DataView(Debitors);
            //dataView.FindRows( "Name like '%" + tbx_Search.Text.Trim().ToString() + "%'");
            

            //dgv_Debitors.DataSource = dataView;




        }
        

        private void btn_bind_Click(object sender, EventArgs e)
        {
            dgv_Debitors.DataSource = BankSystem.Tables[0];
            dgv_Credits.DataSource = Credits;
            dgv_Payments.DataSource = Payments;
        }
    }
}
