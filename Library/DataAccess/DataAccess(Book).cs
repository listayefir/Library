using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using Provider;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public partial class DataAccess
    {
        public List<Book> GetAllBooks()
        {
            DataRowCollection searchedRows = libraryDataSet.Books.Rows;
            return AllBookInfo(searchedRows);


        }

        private List<Book> AllBookInfo(DataRowCollection searchedRows)
        {
            if (searchedRows == null || searchedRows.Count == 0)
                return null;

            List<Book> books = new List<Book>();

            foreach (LibraryDataSet.BooksRow bookRow in searchedRows)
            {
                var book = new Book();
                book.Isbn = bookRow.ISBN;

                if (bookRow.ItemsRow != null)
                {
                    book.ID = bookRow.ItemsRow.ID;
                    book.Name = bookRow.ItemsRow.Name;
                    book.Publisher = bookRow.ItemsRow.Publisher;
                    book.PublicationDate = bookRow.ItemsRow.DatePublished;
                }
                else
                {
                    throw new Exception("Cannot find this book in Items");
                }

                if (bookRow.AuthorsRow!= null)
                {
                    book.AuthorName = bookRow.AuthorsRow.Name;
                }
                else
                {
                    throw new Exception("Cannot find this book in Authors");
                }

                books.Add(book);

            }

            return books;


        }

    }
}
