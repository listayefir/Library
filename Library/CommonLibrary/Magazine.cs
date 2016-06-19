using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Magazine:Item
    {
        public Guid ID { get; set; }
        public string Number { get; set; }
        Dictionary<string, string> ItemFields { get; set; }
        Dictionary<string, string> MagazineFields { get; set; }
        public Magazine() { }
        public Magazine(string name, string publisher, DateTime publicationDate, 
            string number):this(Guid.Empty, name, publisher, publicationDate, number)
        {

        }

        public Magazine(Guid id, string name, string publisher, DateTime publicationDate,
            string number)
        {
            ID = id;
            Name = name;
            Publisher = publisher;
            PublicationDate = publicationDate;
            Number = number;


            ItemFields = new Dictionary<string, string>(3);
            ItemFields.Add("Name", Name);
            ItemFields.Add("Publisher", Publisher);
            ItemFields.Add("PublicationDate", PublicationDate.ToString());

            MagazineFields = new Dictionary<string, string>(1);
            MagazineFields.Add("Number", Number);

        }
    }
}
