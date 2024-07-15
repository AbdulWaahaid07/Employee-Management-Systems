using DataAccessZonah.DataBaseAccess;
using DataAccessZonah.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessZonah.Data
{
    public class EmployeeData
    {

        private readonly IDataAccessSQL db;

        public EmployeeData(IDataAccessSQL _db)
        {
            db = _db;
        }

        public Task<IEnumerable<EmployeeModel>> getAllEmployees() =>  db.LoadData<EmployeeModel, dynamic>("X", new { });

        public async Task<EmployeeModel> getEmployee(int id) 
        {
           var result = await db.LoadData<EmployeeModel, dynamic>("X", new { id });
           return result.FirstOrDefault();
        }

        public Task saveEmployee(EmployeeModel employee) 
        {
            return db.SaveData("X",
                            new { 
                                    employee.EmployeeName,
                                    employee.Branch,
                                    employee.Position,
                                    employee.Address,
                                    employee.PhoneNumber,
                                    employee.AlternateNumber,
                                    employee.ShiftStart,
                                    employee.ShiftEnd,
                                    employee.ShiftType,
                                    employee.Status,
                                    employee.Notes,
                                    employee.Leaves
                                }
                        );
        }

        public Task saveShift(WorkModel work) 
        {
            return db.SaveData("X", work);
        }

        public Task updateEmployee(EmployeeModel employee) 
        {
            return db.SaveData("X", employee);
        }
        
        public Task updateShift(WorkModel work) 
        {
            return db.SaveData("X", work);
        }


        public Task deleteEmployee(EmployeeModel employee) => db.SaveData("X", new { employee.EmpID });
        
        
        public Task deleteShift(WorkModel work) => db.SaveData("X", new { work.EMid });
        




    }
}
