using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Zonah_Employees.Commands;
using Zonah_Employees.ViewModels.BaseClass;

namespace Zonah_Employees.ViewModels
{
    public class EmployeeDetailViewModel : ViewModelBase
    {

        //public string Good { get; set; } = "Good";

        private int empID;

        public int EmployeeID
        {
            get { return empID; }
            set
            {
                empID = value;
                OnPropertyChanged(nameof(EmployeeID));
            }
        }

        private string empName;

        public string EmployeeName
        {
            get { return empName; }
            set
            {
                empName = value;
                OnPropertyChanged(nameof(EmployeeName));
            }
        }


        private string empBranch;

        public string Branch
        {
            get { return empBranch; }
            set
            {
                empBranch = value;
                OnPropertyChanged(nameof(Branch));
            }
        }


        private string empPosition;

        public string Position
        {
            get { return empPosition; }
            set
            {
                empPosition = value;
                OnPropertyChanged(nameof(Position));
            }
        }


        private string empEmail;

        public string Email
        {
            get { return empEmail; }
            set
            {
                empEmail = value;
                OnPropertyChanged(nameof(Email));
            }
        }


        private string empAddress;

        public string Address
        {
            get { return empAddress; }
            set
            {
                empAddress = value;
                OnPropertyChanged(nameof(Address));
            }
        }


        private string empPhoneNumber;

        public string PhoneNumber
        {
            get { return empPhoneNumber; }
            set
            {
                empPhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }


        private string empAlternateNumber;

        public string AlternateNumber
        {
            get { return empAlternateNumber; }
            set
            {
                empAlternateNumber = value;
                OnPropertyChanged(nameof(AlternateNumber));
            }
        }


        private string empShiftStart;

        public string ShiftStart
        {
            get { return empShiftStart; }
            set
            {
                empShiftStart = value;
                OnPropertyChanged(nameof(ShiftStart));
            }
        }


        private string empShiftEnd;

        public string ShiftEnd
        {
            get { return empShiftEnd; }
            set
            {
                empShiftEnd = value;
                OnPropertyChanged(nameof(ShiftEnd));
            }
        }


        private string empTotalTime;

        public string TotalTime
        {
            get { return empTotalTime; }
            set
            {
                empTotalTime = value;
                OnPropertyChanged(nameof(TotalTime));
            }
        }


        private string empShiftType;

        public string ShiftType
        {
            get { return empShiftType; }
            set
            {
                empShiftType = value;
                OnPropertyChanged(nameof(ShiftType));
            }
        }


        private string empStatus;

        public string Status
        {
            get { return empStatus; }
            set
            {
                empStatus = value;
                OnPropertyChanged(nameof(Status));
            }
        }


        private string empNotes;

        public string Notes
        {
            get { return empNotes; }
            set
            {
                empNotes = value;
                OnPropertyChanged(nameof(Notes));
            }
        }


        private string empLeaves;

        public string Leaves
        {
            get { return empLeaves; }
            set
            {
                empLeaves = value;
                OnPropertyChanged(nameof(Leaves));
            }
        }


        private string empEmergencyLeaves;

        public string EmergencyLeaves
        {
            get { return empEmergencyLeaves; }
            set
            {
                empEmergencyLeaves = value;
                OnPropertyChanged(nameof(EmergencyLeaves));
            }
        }


        private BitmapImage _imageSource;

        public BitmapImage ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }


        //private string myVar;

        //public string MyProperty
        //{
        //    get { return myVar; }
        //    set 
        //    {
        //        myVar = value;
        //        OnPropertyChanged(nameof(myVar));
        //    }
        //}


        private readonly ObservableCollection<ListWorkViewModel> _workingEmployee; /*= new ObservableCollection<ListWorkViewModel>();*/

        public IEnumerable<ListWorkViewModel> WorkingEmployee => _workingEmployee;





        // COMMANDS

        public ICommand AddEmployee { get; }

        public ICommand UpdateEmployee { get; }

        public ICommand DeleteEmployee { get; }

        public ICommand SaveChanges { get; }

        public ICommand CancelChanges { get; }

        public ICommand AddEmployeeImage { get; }

        public string GetImagePath()
        {
            return "~/Images/" + EmployeeID + ".jpg";
        }

        public EmployeeDetailViewModel()
        {
            //var t = new Zonah_Employees.Models.EmployeeatWorkModel();
            //t.pro2.EMid = 1;
            //t.pro1.EmployeeName = "Ayub";
            //t.pro2.LoginTime = "04:30 PM";
            //t.pro2.LogoutTime = "10:00 PM";
            //t.pro2.Date = "2/5/2024";

            //var r = new ListWorkViewModel(t);

            //_workingEmployee.Add(r);

            AddEmployee = new addupdateEmployeeCommand(this);

        }
    }
}
