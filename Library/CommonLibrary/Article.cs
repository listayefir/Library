using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Article:Item
    {
        public Guid ID { get; set; }
        public string MagazineName { get; set; }
        public string MagazineNumber { get; set; }
        public string AuthorName { get; set; }
        public string Version { get; set; }


        Dictionary<string, string> ItemFields { get;set; }
        Dictionary<string, string> MagazineFields { get;  set;  }
        Dictionary<string, string> AuthorFields { get; set; }
        Dictionary<string, string> ArticleFields { get;  set; }

        public Article() { }
        public Article(string articleName, string publisher, DateTime publicationDate,
            string authorName, string version, string magazineName, 
            string magazineNumber):this (Guid.Empty, articleName,publisher,publicationDate,authorName,version,magazineName,magazineNumber)
        {

        }
        public Article(Guid id, string articleName, string publisher, DateTime publicationDate,
            string authorName, string version, string magazineName,
            string magazineNumber)
        {
            ID = id;
            Name = articleName;
            Publisher = publisher;
            PublicationDate = publicationDate;
            AuthorName = authorName;
            Version = version;
            MagazineName = magazineName;
            MagazineNumber = magazineNumber;

            ItemFields = new Dictionary<string, string>(3);
            ItemFields.Add("Name", Name);
            ItemFields.Add("Publisher", Publisher);
            ItemFields.Add("PublicationDate", PublicationDate.ToString());

            AuthorFields = new Dictionary<string, string>(1);
            AuthorFields.Add("Name", AuthorName);

            MagazineFields = new Dictionary<string, string>(2);
            MagazineFields.Add("Name", MagazineName);
            MagazineFields.Add("Number", MagazineNumber);

            ArticleFields = new Dictionary<string, string>(1);
            ArticleFields.Add("Version", Version);


        }

        

        
    }
}
