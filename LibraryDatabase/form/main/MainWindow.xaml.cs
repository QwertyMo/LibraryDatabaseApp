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
using System.Windows.Shapes;

namespace LibraryDatabase {
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private MySQLUtil mySQLUtil;
        private string id;

        public MainWindow(string id) {
            InitializeComponent();
            this.id = id;
            mySQLUtil = new MySQLUtil();
            mPanelWindow.Children.Add(new MainControl(this));
        }

        private void mGridTitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            this.DragMove();
        }

        private void mButtonClose_Click(object sender, RoutedEventArgs e) {
            mySQLUtil.closeConnection();
            Application.Current.Shutdown();
        }

        private void mButtonCollapse_Click(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        private void mButtonHome_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            mPanelWindow.Children.Clear();
            mPanelWindow.Children.Add(new MainControl(this));
        }

        public MySQLUtil getMySQLUtill() {
            return mySQLUtil;
        }

        public string getID() {
            return id;
        }
    }

}
