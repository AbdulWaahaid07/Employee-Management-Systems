using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zonah_Employees.Commands.BaseClass;
using Zonah_Employees.ViewModels;
using Zonah_Employees.Models;

namespace Zonah_Employees.Commands
{
    public class addupdateEmployeeCommand : CommandBase
    {
        private EmployeeDetailViewModel emp;

        public addupdateEmployeeCommand(EmployeeDetailViewModel employeeDetailViewModel)
        {
            this.emp = employeeDetailViewModel;
        }


        // TODO : Take care of the conversions (Datatype)
        public override void Execute(object? parameter)
        {
            var updatedEmp = new EmployeeModel(emp.EmployeeID, emp.EmployeeName, emp.Branch, emp.Position,
                emp.Email, emp.Address, emp.PhoneNumber, emp.AlternateNumber, emp.ShiftStart, emp.ShiftEnd,
                emp.TotalTime, emp.ShiftType, Convert.ToBoolean(emp.Status), emp.Notes, Convert.ToInt32(emp.Leaves), Convert.ToInt32(emp.EmergencyLeaves));
        }
    }
}
