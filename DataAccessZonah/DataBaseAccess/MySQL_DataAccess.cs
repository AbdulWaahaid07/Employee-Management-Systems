using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DataAccessZonah.DataBaseAccess
{
    public class MySQL_DataAccess : IDataAccessSQL
    {
        private readonly IConfiguration config;

        private const string connectionstring = "myZonah";


        public MySQL_DataAccess(IConfiguration _config)
        {
            config = _config;
        }


        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameter, string connectionID = connectionstring)
        {
            using (IDbConnection connection = new MySqlConnection(config.GetConnectionString(connectionID)))
            {
                return await connection.QueryAsync<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task SaveData<T>(string storedProcedure, T parameter, string connectionID = connectionstring)
        {
            using (IDbConnection connection = new MySqlConnection(config.GetConnectionString(connectionID)))
            {
                await connection.ExecuteAsync(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
