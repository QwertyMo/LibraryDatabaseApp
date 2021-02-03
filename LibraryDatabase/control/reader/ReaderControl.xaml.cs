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
    /// Логика взаимодействия для ReaderControl.xaml
    /// </summary>
    public partial class ReaderControl : UserControl {

        private MainWindow controller;
        private Reader reader;
        public ReaderControl(MainWindow controller, Reader reader) {
            InitializeComponent();
            this.controller = controller;
            this.reader = reader;
            mTextBoxID.Text = reader.READER_ID.ToString();
            mTextBoxName.Text = reader.SURNAME + " " + reader.NAME + " " + reader.PATRONYMIC;
            mTextBoxPhone.Text = reader.PHONE;

            mChipForfeits.Visibility = reader.FORFEITS;
            mChipHands.Visibility = reader.BOOKS;
        }

        private void mButtonBack_Click(object sender, RoutedEventArgs e) {
            controller.mPanelWindow.Children.Clear();
            controller.mPanelWindow.Children.Add(new ReadersControl(controller));
        }
    }
}
