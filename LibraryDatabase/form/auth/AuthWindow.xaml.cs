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

namespace LibraryDatabase {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window {
        MySQLUtil mySql;
        public AuthWindow() {
            InitializeComponent();
            mySql = new MySQLUtil();
        }

        private void mGridTitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            this.DragMove();
        }

        private void mButtonClose_Click(object sender, RoutedEventArgs e) {
            mySql.closeConnection();
            Application.Current.Shutdown();
        }

        private void mButtonCollapse_Click(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        private void mButtonLogin_Click(object sender, RoutedEventArgs e) {
            if(!mySql.isUserFired(mTextBoxLogin.Text)) {
                if(mySql.checkPass(mTextBoxLogin.Text, mTextBoxPassword.Password)) {
                    mySql.closeConnection();
                    new MainWindow(mTextBoxLogin.Text).Show();
                    this.Close();
                }else mTextBoxError.Text = "Неверный логин или пароль";
            } else mTextBoxError.Text = "Сотрудник с данным идентификатором уволен";   
        }
}
    }
