using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyEntity;
namespace DoAn
{
    public partial class Register_Interface : Form
    {
        public Register_Interface()
        {
            InitializeComponent();
        }

        private void Button_R_Click(object sender, EventArgs e)
        {
            try
            {
                if (user_N.Text == string.Empty)
                {
                    MessageBox.Show("Ten nguoi dung khong duoc bo trong");
                    return;
                }
                if (full_N.Text == string.Empty)
                {
                    MessageBox.Show("Khong duoc bo trong ten");
                    return;
                }
                if (pass.Text == string.Empty)
                {
                    MessageBox.Show("Khong duoc bo trong mat khau");
                    return;
                }
                if (pass_2.Text == string.Empty)
                {
                    MessageBox.Show("Khong duoc bo trong mat khau");
                    return;
                }
                if (pass.Text != pass_2.Text)
                {
                    MessageBox.Show("Vui long xac thuc mat khau lai");
                    return;
                }
                if(Gender_select.SelectedIndex==-1)
                {
                    MessageBox.Show("VUi long chon gioi tinh");
                    return;
                }
                var new_user = new DataTable();
                new_user.Columns.Add("UserName", typeof(string));
                new_user.Columns.Add("Password", typeof(string));
                new_user.Columns.Add("FullName", typeof(string));
                new_user.Columns.Add("Gender", typeof(string));
                var row = new_user.NewRow();
                row[0] = user_N.Text;
                row[1] = pass.Text;
                row[2] = full_N.Text;
                row[3] = Gender_select.SelectedIndex;
                new_user.Rows.Add(row);
                HttpClient http = new HttpClient();
                http.Timeout = new TimeSpan(0, 0, 0, 15);
                using(var respone = http.PostAsJsonAsync("https://localhost:44370/Login/Register",new_user))
                {
                    var result = Convert.ToString(JsonConvert.DeserializeObject(respone.Result.Content.ReadAsStringAsync().Result,typeof(string)));
                    if(result == string.Empty)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                        return;
                    }
                    MessageBox.Show(result, @"System message");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
