using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.SqlServer;
using System.Transactions;
using System.Security.Cryptography;
using System.Text;
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
                        string pass_encrpyt = encrypt(password);
                        sqlCon.Parameters.Add(new SqlParameter("@username", username));
                        sqlCon.Parameters.Add(new SqlParameter("@password", pass_encrpyt)); 
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
        public string encrypt(string pass)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            ASCIIEncoding encode = new ASCIIEncoding();
            encrypt = md5.ComputeHash(encode.GetBytes(pass));
            StringBuilder encryptdata = new StringBuilder();
            for(int i=0;i< encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString("x3"));
            }
            return encryptdata.ToString();
        }
        [HttpPost]
        public string Register([FromBody]DataTable new_user)
        {
            try
            {
                if(new_user == null || new_user.Columns.Count == 0)
                {   
                    return "Du lieu khong duoc trong";
                }
                var connectingstring = string.Format(@"Data Source=LAPTOP-VC5IF5QK\MSSQLSERVER33;Initial Catalog=User_Pass;Integrated Security=True;");
                using (var tran = new TransactionScope(TransactionScopeOption.Required, new TimeSpan(0, 0, 15, 0)))
                {
                    using (var connect = new SqlConnection(connectingstring))
                    {
                        if (connect.State == ConnectionState.Closed)
                        {
                            connect.Open();
                        }
                        using (var sqlCon = connect.CreateCommand())
                        {
                            string pass_encrypt = encrypt(Convert.ToString(new_user.Rows[0]["Password"]));
                            sqlCon.CommandTimeout = 6000;
                            sqlCon.CommandText = @"Tinder_Clone_Login_Register";
                            sqlCon.CommandType = CommandType.StoredProcedure;
                            sqlCon.Parameters.AddWithValue("@userName", new_user.Rows[0]["UserName"]);
                            sqlCon.Parameters.AddWithValue("@pass", pass_encrypt);
                            sqlCon.Parameters.AddWithValue("@fullName", new_user.Rows[0]["FullName"]);
                            sqlCon.Parameters.AddWithValue("@gender", new_user.Rows[0]["Gender"]);
                            var result = Convert.ToString(sqlCon.ExecuteScalar());
                            sqlCon.Parameters.Clear();
                            if (result == "")
                            {
                                tran.Complete();
                                return "Success";
                            }
                            else
                            {
                                return result;
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
    }
}
