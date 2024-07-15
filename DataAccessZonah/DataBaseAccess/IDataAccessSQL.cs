using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessZonah.DataBaseAccess
{
    public interface IDataAccessSQL
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameter, string connectionID = "Default");
        Task SaveData<T>(string storedProcedure, T parameter, string connectionID = "Default");
    }
}