using KURSOVOI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Data;
using System.Data.Entity.SqlServer;
using System.Globalization;
using System.Collections.ObjectModel;

namespace KURSOVOI.View
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public string Names = " ";
        public string Job = " ";
        static public string Testtt;
        public static ModelEntitiess _context = new ModelEntitiess();
        public EFGenericRepository<product> genericRepository = new EFGenericRepository<product>(new ModelEntitiess());
        public EFGenericRepository<customer> genericRepositor = new EFGenericRepository<customer>(new ModelEntitiess());
        public EFGenericRepository<declaration> genericRepositort = new EFGenericRepository<declaration>(new ModelEntitiess());

        public object Customer { get; private set; }

        public AdminPage()
        {
            InitializeComponent();
            customer.AutoGeneratingColumn += customer_grid_AutoGeneratingColumn;
            TableSql.ItemsSource = genericRepository.Get();
            customer.ItemsSource = genericRepositor.Get();
            declare.ItemsSource = genericRepositort.Get();

        }

        private void customer_grid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "photo")
            {
                e.Cancel = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var item = sender as ListViewItem;
            //if (item != null && item.IsSelected)
            //{
            //    //Do your stuff
            //}
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Names = declaratorName.Text;
                Job = jobTitle.Text;
                bool validName = ValidateText.Validate(Names);
                bool validJob = ValidateText.Validate(Job);
                if (!(validName && validJob))
                {
                    MessageBox.Show("Please, use latin alphabet.");
                    return;
                }

                string stat = declaratorName.Text.ToString();
                string job = jobTitle.Text.ToString();

                var neew = _context.customer.Where(u => u.id_customer.ToString() == Testtt).SingleOrDefault();

                neew.declarator_name = stat;
                neew.jobTitle = job;

                _context.SaveChanges();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void Status_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string qwe = Test2.Text;

                declaration user = _context.declaration.Where(u => u.id_declaration.ToString() == qwe).SingleOrDefault();


                InfoDecloration.Testtt = user.id_declaration.ToString();
                InfoDecloration ID = new InfoDecloration();
                ID.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe" + ex.Message);
            }
        }

        private void Declarator_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string qs = id_cust.Text;
                customer user = _context.customer.Where(u => u.id_customer.ToString() == qs).SingleOrDefault();
                AdminPage.Testtt = user.id_customer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe" + ex.Message);
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DateTime selectedTime = (DateTime)Date.SelectedDate;
                var list = _context.declaration.Where(u => u.date.Equals(selectedTime));
                Count.Items.Clear();
                foreach (declaration temp in list)
                {
                    Count.Items.Add($"{temp.id_declaration.ToString()}\n{temp.date.ToString()}\n{temp.status.ToString()}\n{temp.id_customer.ToString()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe" + ex.Message);
            }
        }

        private void TableSql_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                product path = TableSql.SelectedItem as product;
                MessageBox.Show(" ID: " + path.id_product + "\n Name of product: " + path.productName + "\n Category: " + path.productCategory
                    + "\n Information: " + path.productInfo + "\n Price: " + path.unitPrice + "\n Company: " + path.productCampony);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe" + ex.Message);
            }
        }

        private void TableSql_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void customer_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                customer path = customer.SelectedItem as customer;
                MessageBox.Show("\n FirstName: " + path.customerFirstName + "\n SecondName: " + path.customerLastName
                    + "\n Date: " + path.birthDate + "\n Country: " + path.country + "\n City: " + path.city + "\n PostalCode: " + path.postalCode + "\n Sex: " + path.sex + "\n  PhoneNumber: " + path.phoneNumber + "\n State: " + path.state);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe" + ex.Message);
            }
        }

        private void customer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    

        public ObservableCollection<product> MyCollection { get; set; }

        private void Window_Activated(object sender, EventArgs e)
        {
            genericRepositor.Update(

        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //if i set the ItemsSource here, updating of the UI works
        //    dataGrid1.ItemsSource = MyCollection;
        //}
    }
}







