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

namespace LibraryDatabase {
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl {
        private List<ButtonData> buttons = new List<ButtonData>();
        private MainWindow controller;
        public MainControl(MainWindow controller) {
            InitializeComponent();
            this.controller = controller;

            Staff user = controller.getMySQLUtill().getUser(controller.getID());

            mTextBoxUser.Text = user.PATRONYMIC + " " + user.NAME[0] + "." + user.SURNAME[0] + ".";
            mProfileImage.ImageSource = user.IMG;
            mTextBoxDate.Text += user.EMPLOYMENT_DATE.Split(' ')[0];
            mTextBoxRole.Text += user.POSITION;

            buttons.Add(new ButtonData() {
                name = "Библиотечный фонд",
                description = "Просмотр имеющихся в библиотечном фонде книг, а так же управление этими книгами",
                img = "/recources/baseline_library_books_black_18dp.png",
                id = 0
            });
            buttons.Add(new ButtonData() {
                name = "Читатели",
                description = "Просмотр информации по читателям, а так же управление ими",
                img = "/recources/baseline_users_black_18dp.png",
                id = 1
            });
            /*
            buttons.Add(new ButtonData() {
                name = "Выдача книг",
                description = "Выдача книг читателю",
                img = "/recources/baseline_book_out_black_18dp.png",
                id = 2
            });
            buttons.Add(new ButtonData() {
                name = "Возврат книг",
                description = "Возврат книг читателя",
                img = "/recources/baseline_book_in_black_18dp.png",
                id = 3
            });
            buttons.Add(new ButtonData() {
                name = "Штрафы",
                description = "Просмотр штрафов читателей, а так же их выдача и погашение",
                img = "/recources/baseline_policy_black_18dp.png",
                id = 4
            });
            */
            mItemControlTaskList.ItemsSource = buttons;
        }

        private void mItemControlTaskList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            switch(buttons.ElementAt(mItemControlTaskList.SelectedIndex).id) {
                case 0:
                    controller.mPanelWindow.Children.Clear();
                    controller.mPanelWindow.Children.Add(new LibraryStockControl(controller));
                    break;
            }
           
        }

        private void mButtonChangeUser_Click(object sender, RoutedEventArgs e) {
            controller.Close();
            new AuthWindow().Show();
        }
    }


    public class ButtonData {
        public string name { get; set; }
        public string description { get; set; }
        public string img { get; set; }
        public int id { get; set; }
    }
}

