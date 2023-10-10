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
using System.IO;

namespace SchoolLanguage.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceUserControl.xaml
    /// </summary>
    public partial class ServiceUserControl : UserControl
    {
        public ServiceUserControl(Image image, string title, decimal Cost, string costTime, string discount, Visibility costVisibility)
        {
            InitializeComponent();
            if (App.isAdmin == false)
            {
                CreateBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            //ServiceImg = new BitmapImage(new  MemoryStream(image));
            CostTb.Text = Cost.ToString("0");
            TitleTb.Text = title;
            CostTimeTb.Text = costTime;
            DiscountTb.Text = discount;
            CostTb.Visibility = costVisibility;

            
        }
    }
}
