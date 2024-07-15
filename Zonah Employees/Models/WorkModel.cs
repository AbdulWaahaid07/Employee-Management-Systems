using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zonah_Employees.Models
{
    public class WorkModel
    {

        public int EMid { get; set; }
        public string LoginTime { get; set; }
        public string LogoutTime { get; set; }
        public string Date { get; set; }
        
        public WorkModel(int eMid, string loginTime, string logoutTime, string date)
        {
            EMid = eMid;
            LoginTime = loginTime;
            LogoutTime = logoutTime;
            Date = date;
        }


    }
}
