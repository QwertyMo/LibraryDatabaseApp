using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryDatabase.model {
    public class Reader {
        public int READER_ID { get; set; }

        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string PATRONYMIC { get; set; }

        public string BIRTHDAY { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        /*
        public string WORK_PLACE {
            get {
                return WORK_PLACE.Equals("") ? "Нет" : WORK_PLACE;
            }
            set => WORK_PLACE = value;
            
        }
        public string STUDY_PLACE { 
            get { 
                return STUDY_PLACE.Equals("")?"Нет" : STUDY_PLACE;
            }
            set => STUDY_PLACE = value;
        }
        */
        public string STUDY_PLACE { get; set; }

        public string WORK_PLACE { get; set; }
        public bool HAS_FORFEITS { get; set; }
        public bool HAS_BOOKS { get; set; }

        public string USER { get {
                return SURNAME + " " + NAME + " " + PATRONYMIC;
            }}

        public Visibility FORFEITS {
            get {
                return HAS_FORFEITS ? Visibility.Visible : Visibility.Collapsed;
            }
        }
        public Visibility BOOKS {
            get {
                return HAS_BOOKS ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public Reader(int STAFF_ID, string NAME, string SURNAME, string PATRONYMIC, string BIRTHDAY,  string PHONE, string ADDRESS, string WORK_PLACE, string STUDY_PLACE, bool HAS_FORFEITS, bool HAS_BOOKS) {
            this.READER_ID = STAFF_ID;
            this.NAME = NAME;
            this.SURNAME = SURNAME;
            this.PATRONYMIC = PATRONYMIC;
            this.BIRTHDAY = BIRTHDAY.Split(' ')[0];
            this.PHONE = PHONE;
            this.ADDRESS = ADDRESS;
            this.WORK_PLACE = WORK_PLACE;
            this.STUDY_PLACE = STUDY_PLACE;
            this.HAS_FORFEITS = HAS_FORFEITS;
            this.HAS_BOOKS = HAS_BOOKS;
        }

    }
}
