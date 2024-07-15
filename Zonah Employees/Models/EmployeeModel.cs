using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zonah_Employees.Models
{
    public class EmployeeModel
    {
        public int EmpID { get; set; }

        public string EmployeeName { get; set; }

        public string Branch { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string AlternateNumber { get; set; }
        
        //--------------------------------------------------
        public string ShiftStart { get; set; }

        public string ShiftEnd { get; set; }

        public string TotalTime { get; set; }

        public string ShiftType { get; set; }
        
        //--------------------------------------------------

        public bool Status { get; set; }

        public string Notes { get; set; }
        
        public int Leaves { get; set; }
        
        public int EmergencyLeaves { get; set; }


        public EmployeeModel(

            int empID, string employeeName, string branch, string position, 
            string email, string address, string phoneNumber, string alternateNumber,
            string shiftStart, string shiftEnd, string totalTime, string shiftType, bool status, 
            string notes, int leaves, int emergencyLeaves)
        {
            EmpID = empID;
            EmployeeName = employeeName;
            Branch = branch;
            Position = position;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            AlternateNumber = alternateNumber;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
            TotalTime = totalTime;
            ShiftType = shiftType;
            Status = status;
            Notes = notes;
            Leaves = leaves;
            EmergencyLeaves = emergencyLeaves;
        }
    }
}
