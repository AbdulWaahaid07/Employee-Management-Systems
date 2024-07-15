

namespace DataAccessZonah.Models
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
    }
}
