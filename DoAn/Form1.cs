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

namespace DoAn
{
    public partial class Login_Interface : Form
    {
        public Login_Interface()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if(usernamet.Text==String.Empty)
                {
                    MessageBox.Show("Chua nhap ten nguoi dung");
                    return;
                }
                else if(passt.Text==String.Empty)
                {
                    MessageBox.Show("Chua nhap mat khau");
                    return;
                }
                var http = new HttpClient();
                http.Timeout = new TimeSpan(0, 0, 15, 0);
                using (var response = http.GetAsync(string.Format("https://localhost:44370/Login/Login?userName={0}&password={1}",usernamet.Text,passt.Text)))
                
                
                
                {
                     var result = JsonConvert.DeserializeObject(response.Result.Content.ReadAsStringAsync().Result,typeof(string));
                    string message= result.ToString();
                    MessageBox.Show(message);
                        
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Register_Interface();
            frm2.ShowDialog();
        }
    }
}
