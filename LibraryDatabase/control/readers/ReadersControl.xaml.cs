using LibraryDatabase.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryDatabase.control.readers {
    /// <summary>
    /// Логика взаимодействия для ReadersControl.xaml
    /// </summary>
    

    public partial class ReadersControl : UserControl {
        private MainWindow controller;
        private List<Reader> list;
        public ReadersControl(MainWindow controller) {
            InitializeComponent();
            this.controller = controller;
            list = controller.getMySQLUtill().getReaders();
            mItemControlReaders.ItemsSource = list;
        }

        private void mItemControlReaders_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            controller.mPanelWindow.Children.Clear();
            controller.mPanelWindow.Children.Add(new ReaderControl(controller, list[mItemControlReaders.SelectedIndex]));
        }
    }
}
