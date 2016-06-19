using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingMasters
{
    public partial class BankSystem : Form
    {
        public BankSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.bankSystemDataSet.Payments);
            // TODO: This line of code loads data into the 'bankSystemDataSet.Credits' table. You can move, or remove it, as needed.
            this.creditsTableAdapter.Fill(this.bankSystemDataSet.Credits);
            // TODO: This line of code loads data into the 'bankSystemDataSet.Debitors' table. You can move, or remove it, as needed.
            this.debitorsTableAdapter.Fill(this.bankSystemDataSet.Debitors);
            // TODO: This line of code loads data into the 'bankSystemDataSet.Payments' table. You can move, or remove it, as needed.
          

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            paymentsTableAdapter.Update(bankSystemDataSet.Payments);
            creditsTableAdapter.Update(bankSystemDataSet.Credits);
            debitorsTableAdapter.Update(bankSystemDataSet.Debitors);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DataRowCollection debToDel = bankSystemDataSet.Debitors.Rows;
            DataRow delDeb = debToDel.Find(dgvDebitors.CurrentRow.Cells[0].Value);

            DataRow[] creditsToDel = delDeb.GetChildRows(bankSystemDataSet.Relations[0]);
            foreach (var credit in creditsToDel)
            {
                DataRow[] paymentsToDel = credit.GetChildRows(bankSystemDataSet.Relations[1]);
                foreach (var payment in paymentsToDel)
                {
                    payment.Delete();
                }
                credit.Delete();
            }
            delDeb.Delete();
                 
        }
    }
}
