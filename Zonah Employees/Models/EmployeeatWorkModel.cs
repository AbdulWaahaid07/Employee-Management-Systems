using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zonah_Employees.Models
{
    public class EmployeeatWorkModel
    {
        public EmployeeModel pro1 { get; set; }
        public WorkModel pro2 { get; set; }

        public EmployeeatWorkModel(EmployeeModel pro1, WorkModel pro2)
        {
            this.pro1 = pro1;
            this.pro2 = pro2;
        }
    }
}
