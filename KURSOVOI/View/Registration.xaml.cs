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
using System.Net;
using System.Net.Mail;
using KURSOVOI.Model;



namespace KURSOVOI.View
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
  
        ModelEntitiess db;
        public IQueryable<autorization> user;

        public Registration()
        {

            InitializeComponent();
            db = new ModelEntitiess();
            List<autorization> auto = db.autorization.ToList();

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Autorization auto = new Autorization();
            auto.Show();
            this.Close();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db = new ModelEntitiess();
            
                autorization auto = new autorization();
                auto.login = Login.Text;
                auto.password = HashPassword.MD5Hash(Password.Password);
                bool validUsername = ValidateText.Validate(auto.login);
                bool validPwd = ValidateText.Validate(auto.password);
                if (!(validUsername && validPwd))
                {
                    MessageBox.Show("Please, use latin alphabet.");
                    return;
                }

                autorization user = db.autorization.Where(u => u.login == Login.Text).SingleOrDefault();
                if(user!=null)
                {
                    MessageBox.Show("User already exists!");
                    return;
                }
                db.autorization.Add(auto);
                db.SaveChanges();
                MessageBox.Show("client was added");


            }
            catch (Exception ex)
            {
                MessageBox.Show("error"+ex.Message);

            }
          
        }

    }
}
