using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Zonah_Employees.ViewModels;
using Zonah_Employees.ViewModels.BaseClass;

namespace Zonah_Employees
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ViewModelBase vmb;

        public App() 
        {
            vmb = new EmployeeDetailViewModel();
        }
        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow = new MainWindow()
            {

                DataContext = new MainViewModel(vmb)
                
            };
            MainWindow.Show();


            base.OnStartup(e);
        }

    }
}
