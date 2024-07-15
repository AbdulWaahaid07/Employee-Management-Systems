using Zonah_Employees.Models;
using Zonah_Employees.ViewModels.BaseClass;

namespace Zonah_Employees.ViewModels
{
    public class ListWorkViewModel :  ViewModelBase
    {
        // TODO Leave calculation


        public string EMid => _dailyWorkList.pro2.EMid.ToString();
        public string EmployeeName => _dailyWorkList.pro1.EmployeeName;
        public string Leave => "Yet to be decided";
        public string Date => _dailyWorkList.pro2.Date;
        public string LoginTime => _dailyWorkList.pro2.LoginTime;
        public string LogoutTime => _dailyWorkList.pro2.LogoutTime;


        private readonly EmployeeatWorkModel _dailyWorkList;

        public ListWorkViewModel(EmployeeatWorkModel dailyWorkList)
        {
            _dailyWorkList = dailyWorkList;
        }
    }
}
