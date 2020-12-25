using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LibraryDatabase.model {
    public class Book {
        public int BOOK_ID { get; set; }
        public int COPY_ID { get; set; }

        public string GENRE { get; set; }
        public string SUBJECT { get; set; }
        public string TYPE { get; set; }
        public string NAME { get; set; }
        public string PUBLISHING_HOUSE { get; set; }

        public List<String> AUTHORS { get; set; }

        public int YEAR { get; set; }
        public int PRICE { get; set; }
        public int PAGES { get; set; }

        public BitmapImage IMG { get; set; }
        public string AVAILABLE { get; set; }

        public Book(int COPY_ID, int BOOK_ID, string PUBLISHING_HOUSE, int YEAR, int PAGES, int PRICE, string GENRE, string SUBJECT, string TYPE, string NAME, string IMG, string AVAILABLE) {
            this.COPY_ID = COPY_ID;
            this.BOOK_ID = BOOK_ID;
            this.PUBLISHING_HOUSE = PUBLISHING_HOUSE;
            this.YEAR = YEAR;
            this.PAGES = PAGES;
            this.PRICE = PRICE;
            this.GENRE = GENRE;
            this.SUBJECT = SUBJECT;
            this.TYPE = TYPE;
            this.NAME = NAME;
            if(IMG.Equals("")) this.IMG = new BitmapImage(new Uri("https://i.ibb.co/svDkXNL/non-book.png"));
            else this.IMG = new BitmapImage(new Uri(IMG));
            this.AVAILABLE = AVAILABLE;
        }
    }
}
