using LibraryDatabase.model;
using LibraryDatabase.tools;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LibraryDatabase {

    public partial class LibraryStockControl : UserControl {

        private MainWindow controller;

        public LibraryStockControl(MainWindow controller) {
            InitializeComponent();
            this.controller = controller;
            List<Book> list = controller.getMySQLUtill().getBooks(0,"",-1,"");
            mItemControlBooks.ItemsSource = list;

        }

        private void mItemControlBooks_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void mButtonSearch_Click(object sender, RoutedEventArgs e) {
            int f = 0;
            int a;
            if(mRadioHand.IsChecked == true) f = 1;
            else if(mRadioAvailable.IsChecked == true) f = 2;
            else if(mRadioLost.IsChecked == true) f = 3;
            List<Book> list = controller.getMySQLUtill().getBooks(f,mTextBoxName.Text,Int32.TryParse(mTextBoxID.Text,out a)?a:-1,"");
            mItemControlBooks.ItemsSource = list;
        }
    }
}
