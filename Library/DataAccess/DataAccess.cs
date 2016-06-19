using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using Provider;

namespace DataAccess
{
    public partial class DataAccess
    {
        LibraryDataSet libraryDataSet;
        Provider.Provider provider =new Provider.Provider();


        public DataAccess(SourceType dataType, string targetData)
        {
            libraryDataSet = provider.GetAllData(dataType, targetData);
        }
    }
}
