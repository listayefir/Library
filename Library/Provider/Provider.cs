using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using CommonLibrary.LibraryDataSetTableAdapters;
using System.Data.SqlClient;
using System.Data;

namespace Provider
{
    public class Provider
    {
        LibraryDataSet libraryDataSet = new LibraryDataSet();

        SqlDataAdapter[] libraryDataAdapters;

        DataTable[] libraryTables;
        string[] tablesNames;

            SourceType getSourceType;
        string targetFile;

        public Provider()
        {

        }

        public LibraryDataSet GetAllData (SourceType sourceType, string targetFile)
        {
            this.getSourceType = sourceType;
            this.targetFile = targetFile;

            if (sourceType == SourceType.XML)
            {
                this.libraryDataSet.ReadXml(targetFile);
                return libraryDataSet;

            }

            this.libraryTables = new DataTable[]
            {
                this.libraryDataSet.Items,
                this.libraryDataSet.Authors,
                this.libraryDataSet.Books,
                this.libraryDataSet.Borrows,
                this.libraryDataSet.Copies,
                this.libraryDataSet.Magazines,
                this.libraryDataSet.Articles,
                this.libraryDataSet.ArticlesInMagazines,
                this.libraryDataSet.Users
            };
            this.tablesNames = new string[] { "Items", "Authors","Books","Borrows", "Copies",
                "Magazines", "Articles", "ArticlesInMagazines", "Users" };

            this.libraryDataAdapters = new SqlDataAdapter[tablesNames.Length];

            SqlConnection connection = new SqlConnection(targetFile);

            for (int i=0; i < tablesNames.Length; i++)
            {
                this.libraryDataAdapters[i] = new SqlDataAdapter("SELECT * FROM" + this.tablesNames[i], connection);

                SqlCommandBuilder commandBLD = new SqlCommandBuilder(libraryDataAdapters[i]);

            
            }
            for (int i = 0; i < libraryDataAdapters.Length; i++)
            {
                libraryDataAdapters[i].Fill(libraryTables[i]);
            }

            return libraryDataSet;


        }
       
        public void UpdateAllData(SourceType sourceType, string targetFile)
        {
            if (sourceType == SourceType.XML)
            {
                libraryDataSet.WriteXml(targetFile);
                return;
            }

            for(int i=0; i < libraryDataAdapters.Length; i++)
            {
                libraryDataAdapters[i].Update(libraryTables[i]);
            }
        }
       
    }
}
