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
using System.Windows.Shapes;
using System.IO;
using KURSOVOI.Model;


namespace KURSOVOI.View
{
    /// <summary>
    /// Логика взаимодействия для ProductInfo.xaml
    /// </summary>
     [Serializable]
    public partial class ProductInfo : Window
    {
        public ProductInfo()
        {
            InitializeComponent();          
        }
    
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
         
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            CustomerInfo user = new CustomerInfo();
            user.Show();
            this.Close();
        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            return;
        }

        private void Declaration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
