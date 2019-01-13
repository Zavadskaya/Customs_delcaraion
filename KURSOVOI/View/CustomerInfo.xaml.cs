using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using System.Drawing;
using System.IO;
using Microsoft.Win32;
using System.Windows.Markup;
using KURSOVOI.Model;

namespace KURSOVOI.View
{
    /// <summary>
    /// Логика взаимодействия для CustomerInfo.xaml
    /// </summary>
     
    public partial class CustomerInfo : Window
    {


        public CustomerInfo()
        {
            InitializeComponent();
                
        }
 

        private void Declaration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private byte[] BitmapSourceToByteArray(BitmapSource image)
        {
            using (var stream = new MemoryStream())
            {
                var encoder = new PngBitmapEncoder(); 
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(stream);
                return stream.ToArray();
            }
        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {

            this.DialogResult = true;
            return;

        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
           OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter =
                "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;

            if (ofdPicture.ShowDialog() == true)
                photoImage.Source =
                    new BitmapImage(new Uri(ofdPicture.FileName));
                    

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // customerViewSource.Source = [универсальный источник данных]
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            CustomerInfo cust = new CustomerInfo();
            cust.Close();

        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            ProductInfo product = new ProductInfo();
            product.Show();
            this.Close();
        }
  


    }

}
