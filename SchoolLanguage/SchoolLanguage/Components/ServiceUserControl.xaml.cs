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
using SchoolLanguage.MyPages;

namespace SchoolLanguage.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceUserControl.xaml
    /// </summary>
    public partial class ServiceUserControl : UserControl
    {
        private Service service;
        public ServiceUserControl(Service _service)
        {
            InitializeComponent();
            service = _service;
            if (App.isAdmin == false)
            {
                EntryBtn.Visibility = Visibility.Hidden;
                CreateBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            //ServiceImg = new BitmapImage(new  MemoryStream(image));
            CostTb.Text = service.Cost.ToString("0");
            TitleTb.Text = service.Title;
            CostTimeTb.Text = service.CostTime;
            DiscountTb.Text = service.DiscountStr;
            CostTb.Visibility = service.CostVisibility;
            ServiceImg.Source = GetImageSource(service.MainImage);
            MainBorder.Background = service.DiscountBrush;
        }

        private BitmapImage GetImageSource(byte[] byteImage)
        {
            
            BitmapImage bitmapImage = new BitmapImage();
            try
            {
                if (service.MainImage != null)
                {
                    MemoryStream byteStream = new MemoryStream(byteImage);
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = byteStream;
                    bitmapImage.EndInit();
                }
                else 
                    bitmapImage = new BitmapImage(new Uri(@"\Resources\Безымянный.png", UriKind.Relative));
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return bitmapImage;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if(service.ClientService != null)
            {
                MessageBox.Show("Удаление запрещено");
            }
            else
            {
                App.db.Service.Remove(service);
                App.db.SaveChanges();
            }
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            navigation.NextPage(new PageComponent("Редактирование услуги", new AddEditServicePage(service)));
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            navigation.NextPage(new PageComponent("Запись на услугу", new ClientRecordPage(service)));
        }
    }
}
