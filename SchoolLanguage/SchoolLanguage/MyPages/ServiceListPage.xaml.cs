using SchoolLanguage.Components;
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

namespace SchoolLanguage.MyPages
{
    /// <summary>
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public ServiceListPage()
        {
            
            InitializeComponent();
            
            if (App.isAdmin == false)
            {
                AddBtn.Visibility = Visibility.Hidden;
            }
            var services = App.db.Service.ToList();
            foreach(var service in services)
            {
                ServiceWp.Children.Add(new ServiceUserControl(new Image(), service.Title, service.Cost, service.CostTime.ToString(), service.DiscountStr, service.CostVisibility));
            }
        }

    }
}
