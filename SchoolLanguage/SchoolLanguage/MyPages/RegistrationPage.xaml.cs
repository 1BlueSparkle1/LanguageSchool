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
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SchoolLanguage.MyPages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            //PhoneAttribute phoneAttribute = new PhoneAttribute();
            //EmailAddressAttribute emailAddressAttribute = new EmailAddressAttribute();


            Regex regex = new Regex(@"^(\+7|8)\s\d{3}\s\d{3}\s\d{2}\s\d{2}$");
            if (regex.IsMatch(PhoneTb.Text) )
            {
                MessageBox.Show("Верно");
            }
            else
            {
                MessageBox.Show("Неверно");
            }
            Regex regexEmail = new Regex(@"^\w\.\w@(mail.ru|gmail.com|yandex.ru)$");
            if (regexEmail.IsMatch(EmailTb.Text))
            {
                MessageBox.Show("Верная почта");
            }
            else
            {
                MessageBox.Show("Неверная почта");
            }







            //if (phoneAttribute.IsValid(PhoneTb.Text))
            //{
            //    MessageBox.Show("Верный формат номера");
            //}
            //else
            //{
            //    MessageBox.Show("Неверный формат номера");
            //}
            //if (emailAddressAttribute.IsValid(EmailTb.Text))
            //{
            //    MessageBox.Show("Верный формат почты");
            //}
            //else
            //{
            //    MessageBox.Show("Неверный формат почты");
            //}
        }
    }
}
