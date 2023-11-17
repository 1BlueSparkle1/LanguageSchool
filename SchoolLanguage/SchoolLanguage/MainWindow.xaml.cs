using SchoolLanguage.MyPages;
using System;
using System.Collections.Generic;
using System.IO;
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
using SchoolLanguage.Components;

namespace SchoolLanguage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            navigation.mainWindow = this;
            
            navigation.NextPage(new PageComponent("Регистрация", new RegistrationPage()));   
            //var path = @"C:\Users\Acer\Desktop\РПМ\Сессия 1\";
            //foreach (var item in App.db.Service.ToArray())
            //{
            //    var fullPath = path + item.MainImagePath.Trim();
            //    var imageByte = File.ReadAllBytes(fullPath);
            //    item.MainImage = imageByte;
            //}
            //App.db.SaveChanges();
        }

        private void OffAdminBtn_Click(object sender, RoutedEventArgs e)
        {
            App.isAdmin = false;
            navigation.ClearHistory();
            navigation.NextPage(new PageComponent("Список услуг", new ServiceListPage()));
        }

        private void OnAdminBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "0000")
            {
                App.isAdmin = true;
                navigation.ClearHistory();
                navigation.NextPage(new PageComponent("Режим админа", new ServiceListPage()));
                PasswordPb.Clear();
            }
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            navigation.BackPage();
        }
    }
}
