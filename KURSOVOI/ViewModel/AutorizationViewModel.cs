
using Mvvm.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data.Entity;
using KURSOVOI.Model;


namespace KURSOVOI.ViewModel
{

    class AutorizationViewModel
    {

        /*  public Model.Autorization Model { get; set; }


          public ICommand EnterCommand { get; set; }
          public ICommand RegistrationCommand { get; set; }
          public ICommand CloseCommand { get; set; }

          public AutorizationViewModel(Action closeAction)
          {
              Model = new Model.Autorization();
              EnterCommand = new DelegateCommand<object>(DoEnter);
              RegistrationCommand = new DelegateCommand(DoRegistration);
              CloseCommand = new DelegateCommand(closeAction);

          }
          private void DoEnter(object passBox)
          {
              Authorization user = null;

              Model.Password = RecognizePassword(passBox);

              if (!IsValidModel()) return;

              try
              {
                  db = new Model1();

                  user = db.autorization.FirstOrDefault(e => e.login.Equals(Model.Login) && e.password == Model.Password);

                  if (user == null)
                      throw new Exception("User not found");



              }
              catch (Exception e)
              {
                  MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
                  return;
              }

              var declarationWindow = new CustomerInfo();
              declarationWindow.Show();

              CloseCommand.Execute(this);
          }
          private string RecognizePassword(object passBox)
          {
              var box = passBox as PasswordBox;
              return box == null ? string.Empty : box.Password;
          }
          private bool IsValidModel()
          {
              var isValid = true;

              if (string.IsNullOrEmpty(Model.Login))
              {
                  MessageBox.Show("Please write login", "Error", MessageBoxButton.OK);
                  isValid = false;
              }
              if (string.IsNullOrEmpty(Model.Password))
              {
                  MessageBox.Show("Please write password", "Error", MessageBoxButton.OK);
                  isValid = false;
              }

              return isValid;
          }

          private void DoRegistration()
          {
              var registration = new Registration();
              registration.Show();
          }
      }
     */
    }
}



