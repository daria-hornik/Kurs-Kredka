using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab3
{
    class SignIn
    {
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString);

        public SqlCommand QuerySql{ get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public SignIn(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool SignInWarehouse()
        {
            int valueResault;
            bool isTrue = false;
            string query = "SELECT COUNT(UserName) From UserLogin Where UserName = @Username AND Password = @Password";


            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResault = (int) QuerySql.ExecuteScalar();

                if (valueResault >= 1)
                {
                    isTrue = true;
                }

                return isTrue;
            }
        }

    }
}

