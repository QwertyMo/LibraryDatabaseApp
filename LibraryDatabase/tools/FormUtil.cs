using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LibraryDatabase.tools {
    class FormUtil {
        public static void loadImgToBox(Image imgBox, String uri) {
            imgBox.Source = new BitmapImage(new Uri(uri));
        }
    }
}
