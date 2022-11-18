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

namespace User_Class
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                FirstName = tbFirstName.Text,
                Surname = tbSurName.Text,
                Patronymic = tbPatronymic.Text,
                Birthday = tbBirthday.Text
            };

            tbInfo.Text = $"Имя: {tbFirstName.Text} \n Фамилия: {tbSurName.Text} \n Отчество: {tbPatronymic.Text} \n Дата рождения: {tbBirthday.Text}";
        }
    }
}
