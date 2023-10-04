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
            var path = @"C:\Users\Acer\Desktop\РПМ\Сессия 1\";
            foreach (var item in App.db.Service.ToArray())
            {
                var fullPath = path + item.MainImagePath.Trim();
                var imageByte = File.ReadAllBytes(fullPath);
                item.MainImage = imageByte;
            }
            App.db.SaveChanges();
        }
    }
}
