using KURSOVOI.Model;
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
using System.Security.Cryptography;
using System.Collections.ObjectModel;

namespace KURSOVOI.View
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        string username=" ";
        string pwd=" ";
        public ModelEntitiess db;
        public Autorization()
        {
            InitializeComponent();
            db = new ModelEntitiess();
            autorization user = new autorization();
            var userr = db.autorization.ToList();


        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db = new ModelEntitiess();
                username = login.Text;
                pwd = password.Password;
                bool validUsername = ValidateText.Validate(username);
                bool validPwd = ValidateText.Validate(pwd);
                if (!(validUsername && validPwd))
                {
                    MessageBox.Show("Please, use latin alphabet.");
                    return;
                }
                string HashPwd = HashPassword.MD5Hash(password.Password);
                autorization user = db.autorization.Where(u => u.login == login.Text && u.password == HashPwd).SingleOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Regestrate,please!");
                    return;
                }
                else
                {
                    if

                    (login.Text == "admin2" && password.Password == "admin3")
                    {
                        AdminPage admin = new AdminPage();
                        admin.Show();
                    }
                    else
                    {
                        MainWindow.UserID = user.id;
                        MainWindow main = new MainWindow();
                        main.Show();
                    }
                }
                this.Close();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Registration person = new Registration();
                person.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
      

        public ObservableCollection<string> OnLoadItems { get; private set; }
    }

 


}




