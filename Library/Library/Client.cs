using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using CommonLibrary;

namespace Library
{
    public partial class Client : Form
    {
        DataAccess.DataAccess dataAccess;

        public Client()
        {
            InitializeComponent();
            
            LogIn logIn = new LogIn();

            if (logIn.ShowDialog() == DialogResult.OK)
            {
                dataAccess = new DataAccess.DataAccess(logIn.DBType, logIn.ConnectionParameters);

                List<Book> allBooks = dataAccess.GetAllBooks();
                dgvBooks.DataSource = allBooks;
            }
            //logIn.ShowDialog();
        }
    }
}
