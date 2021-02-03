using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LibraryDatabase.model {
    public class TakingHistory {
        public int READER_ID { get; set; }

        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string PATRONYMIC { get; set; }

        public int OPERATION_ID { get; set; }
        public int COPY_ID { get; set; }

        public string BOOK_NAME { get; set; }

        public BitmapImage IMG { get; set; }

        public string ISSUE_DATE { get; set; }
        public string ISSUED_BEFORE { get; set; }
        public string RETURN_DATE { get; set; }
    }
}
