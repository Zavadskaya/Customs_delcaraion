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
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using KURSOVOI.Model;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace KURSOVOI.View

{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public string index = " ";
        public ModelEntitiess db = new ModelEntitiess();
        public EFGenericRepository<product> genericRepository = new EFGenericRepository<product>(new ModelEntitiess());
        public EFGenericRepository<customer> genericRepositor = new EFGenericRepository<customer>(new ModelEntitiess());
        public EFGenericRepository<declaration> genericRepositor1 = new EFGenericRepository<declaration>(new ModelEntitiess());
        public static int UserID;

        public object TableSql { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            autorization CustUser = db.autorization.Where(u => u.id == UserID).SingleOrDefault();
            List<declaration> dc = db.declaration.Where(u => u.id_customer == CustUser.id).ToList<declaration>();
            for (int i = 0; i < dc.Count; i++)
            {
                ListDeclar.Items.Add(dc[i].date.ToString());
            }
            
        }

       

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            /* TableSql.ItemsSource = null;
             TableSql.Items.Refresh();*/
        }



        private void CustomInfo_Click(object sender, RoutedEventArgs e)
        {
            /*
                        product pr = TableSql.SelectedItem as product;
                       if (MessageBoxResult.Yes == MessageBox.Show("Are u sure?", "Confirm", MessageBoxButton.YesNo))

                      {

                           db.product.Remove(pr);
                           db.SaveChanges();

                       }

                  if (MainWindow.TableSql.SelectedItems.Count > 0)
                  {
                      for (int i = 0; i < TableSql.SelectedItems.Count; i++)
                      {
                          product item = TableSql.SelectedItems[i] as product;
                          if (item != null)
                          {
                              genericRepository.Remove(item);
                          }
                          //db.Channels.Remove(channel);
                          //db.SaveChanges();
                          else
                          {
                              return;
                          }

                      }
                  }

                  MessageBox.Show("Объект удален");
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
              */
        }





        private void Customer_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                CustomerInfo pre = new CustomerInfo();

                if (pre.ShowDialog() == true)
                {

                    customer person = new customer();
                    person.customerLastName = pre.customerLastNameTextBox.Text;
                    person.customerFirstName = pre.customerFirstNameTextBox.Text;
                    ComboBoxItem personSex = (ComboBoxItem)pre.sexComboBox.SelectedItem;
                    person.sex = personSex.Content.ToString();
                    person.phoneNumber = pre.phoneNumberTextBox.Text;
                    person.birthDate = DateTime.Parse(s: pre.birthDateDatePicker.Text);
                    person.adress = pre.adressTextBox.Text;
                    person.city = pre.cityTextBox.Text;
                    person.state = pre.stateTextBox.Text;
                    person.postalCode = pre.postalCodeTextBox.Text;
                    ComboBoxItem personCountry = (ComboBoxItem)pre.countryComboBox.SelectedItem;
                    person.country = personCountry.Content.ToString();
                    person.photo = BitmapSourceToByteArray((BitmapSource)pre.photoImage.Source);



                    /* bool valid = ValidateText.ValidateCust(person.phoneNumber);
                     bool valid1 = ValidateText.ValidateCust(person.postalCode);
                     if (!(valid && valid1))
                     {
                         MessageBox.Show("Please, use numbers where phone number and postalcode!");
                         return;
                     }*/
                    genericRepositor.Create(person);
                    MessageBox.Show("New customer was added!");

                }


                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not written icons!" + ex.Message);
            }
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



        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CustomerInfo pre = new CustomerInfo();

                OpenFileDialog ofdPicture = new OpenFileDialog();
                ofdPicture.Filter =
                    "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
                ofdPicture.FilterIndex = 1;

                if (ofdPicture.ShowDialog() == true)
                    pre.photoImage.Source =
                        new BitmapImage(new Uri(ofdPicture.FileName));
            }
            catch(Exception ex)
            {
                MessageBox.Show("error"+ ex.Message);
            }

        }

        private void TableSql_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            System.Windows.Data.CollectionViewSource customerdeclarationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerdeclarationViewSource")));
      
        }

        private void statusTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                declaration number = new declaration();
                number.date = DateTime.Parse(dateDatePicker.Text);
                number.id_declaration = 0;
                number.id_customer = UserID;
                genericRepositor1.Create(number);
                MessageBox.Show("New declaration was added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            ProductInfo pre = new ProductInfo();

            if (pre.ShowDialog() == true)
            {
                product pr = new product();
                pr.productCategory = pre.productCategoryTextBox.Text;
                pr.productName = pre.productNameTextBox.Text;
                pr.productScale = pre.unitPriceTextBox.Text;
                pr.productInfo = pre.productInfoTextBox.Text;
                pr.productCampony = pre.productCamponyTextBox.Text;
                pr.unitPrice = pre.unitPriceTextBox.Text;

                genericRepository.Create(pr);



                MessageBox.Show("New product was added");
            }
            else
            {
                return;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow main = new MainWindow();
                main.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }

        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }


        /*  private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
          {

              Serialization ser = new Serialization();
              ser.Save_Click();


          }*/

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListDeclar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (ListDeclar.SelectedItem != null)
                {
                    DateTime val = Convert.ToDateTime(ListDeclar.SelectedItem.ToString());
                    Console.WriteLine(val);
                    var res = db.declaration.Where(d => d.date.Equals(val)).ToList();
                    foreach (declaration d in res)
                    {
                        List.Items.Add($"{d.id_declaration.ToString()}\n{d.id_customer.ToString()}\n{d.date.ToString()}");

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }




        }


        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UsE_TextChanged(object sender, TextChangedEventArgs e)
        {
           //string Login
           // {
           //     string value = "";
           //     using (ModelEntitiess bd = new ModelEntitiess())
           //     {

           //         var users = bd.autorization.Where(a => a.login == Login);
           //         foreach (var u in users)
           //         {
           //             value = u.login;
           //         }

           //     }
           //     return String.Format($"{value}");


           // }
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }
    }

}


        
    

