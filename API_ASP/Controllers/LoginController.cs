using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.SqlServer;
namespace API_ASP.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public string Login(string username, string password)
        {
            try
            {
                var connectingstring = string.Format(@"Data Source=LAPTOP-VC5IF5QK\MSSQLSERVER33;Initial Catalog=User_Pass;Integrated Security=True;");
                using (var connect = new SqlConnection(connectingstring))
                {
                    if(connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }
                    using (var sqlCon = connect.CreateCommand())
                    {
                        sqlCon.CommandTimeout = 60;
                        sqlCon.CommandText = @"select 1 from USER_LIST where username=@username and password=@password";
                        sqlCon.CommandType = CommandType.Text;
                        sqlCon.Parameters.Add(new SqlParameter("@username", username));
                        sqlCon.Parameters.Add(new SqlParameter("@password", password));
                        var result = Convert.ToString(sqlCon.ExecuteScalar());
                        sqlCon.Parameters.Clear();
                        if(result == "1")
                        {
                            return "Success";
                        }
                        else
                        {
                            return "Ten nguoi dung hoac mat khau khong dung";
                        }

                    }
                }

            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
