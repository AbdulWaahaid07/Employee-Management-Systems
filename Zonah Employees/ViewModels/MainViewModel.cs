using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zonah_Employees.ViewModels.BaseClass;

namespace Zonah_Employees.ViewModels
{
    public class MainViewModel
    {
        //public EmployeeDetailViewModel _employeeDetailViewModel { get; }

        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(ViewModelBase currentViewModel)
        {
            CurrentViewModel = currentViewModel;
        }
    }
}
