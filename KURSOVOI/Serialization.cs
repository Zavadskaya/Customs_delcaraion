using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using KURSOVOI.View;
using KURSOVOI.Model;
using System.Windows;

namespace KURSOVOI
{
    [Serializable]
    class Serialization
    {
       public List<declaration> search_result = new List<declaration>();
       SaveFileDialog saveFileDialog = new SaveFileDialog();
        public void Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog.FileName = "search.xml";
                this.saveFileDialog.ShowDialog();

                if (search_result.Count != 0)
                {
                    using (FileStream fs = new FileStream(this.saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<declaration>));
                        xmlSerializer.Serialize(fs, search_result);
                    }
                }
                else
                {
                    MessageBox.Show("Пусто");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        internal void Save_Click()
        {
            throw new NotImplementedException();
        }
    }

}
