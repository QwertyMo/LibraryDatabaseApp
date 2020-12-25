using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LibraryDatabase.model {
    public class Staff {
        public int STAFF_ID { get; set; }

        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string PATRONYMIC { get; set; }

        public string BIRTHDAY { get; set; }
        public string EMPLOYMENT_DATE { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string POSITION { get; set; }
        public BitmapImage IMG { get; set; }

        public Staff(int STAFF_ID, string NAME, string SURNAME, string PATRONYMIC, string BIRTHDAY, string EMPLOYMENT_DATE, string PHONE, string ADDRESS, string POSITION, string IMG) {
            this.STAFF_ID = STAFF_ID;
            this.NAME = NAME;
            this.SURNAME = SURNAME;
            this.PATRONYMIC = PATRONYMIC;
            this.BIRTHDAY = BIRTHDAY;
            this.EMPLOYMENT_DATE = EMPLOYMENT_DATE;
            this.PHONE = PHONE;
            this.ADDRESS = ADDRESS;
            this.POSITION = POSITION;
            if(IMG.Equals("")) this.IMG = new BitmapImage(new Uri("https://i.ibb.co/0t5ZDgS/7.png"));
            else this.IMG = new BitmapImage(new Uri(IMG));
        }
    }
}
