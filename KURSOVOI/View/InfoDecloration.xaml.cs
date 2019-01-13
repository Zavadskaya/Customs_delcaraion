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

namespace KURSOVOI.View
{
    /// <summary>
    /// Логика взаимодействия для InfoDecloration.xaml
    /// </summary>
    public partial class InfoDecloration : Window
    {
        static public string Testtt;
        public static ModelEntitiess _context = new ModelEntitiess();

        public InfoDecloration()
        {
            InitializeComponent();

            declaration user = _context.declaration.Where(u => u.id_declaration.ToString() == Testtt).SingleOrDefault();

        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string stat = Statuus.Text.ToString();
                var neew = _context.declaration.Where(u => u.id_declaration.ToString() == Testtt).SingleOrDefault();
                neew.status = stat;
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void Statuus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
