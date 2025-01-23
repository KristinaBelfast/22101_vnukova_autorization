using _22101_vnukova_autorization.Model;
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

namespace _22101_vnukova_autorization
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            using (var context = new KRvnukovaEntities1())
            {
                var user = context.Polzovateli.Where(a => a.Login == login && a.Password == password).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Добро пожаловать! Ваша роль: " + user.roles.name);

                }
            }
        }
    }
}

































