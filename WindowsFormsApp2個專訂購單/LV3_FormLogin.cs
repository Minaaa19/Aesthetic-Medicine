using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2個專訂購單
{
    public partial class LV3_FormLogin : Form
    {
        public LV3_FormLogin()
        {
            InitializeComponent();
        }

        private void LV3_FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Aesthetic Medicine";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            string str帳號, str密碼 = "";
            str帳號 = txt帳號.Text.Trim();
            str密碼 = txt密碼.Text.Trim();

            if((str帳號 != "") && (str密碼 != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select top 1 * from Customers where Email = @Email and Password = @Password";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                
                int intId = 0;
                Int32.TryParse(str帳號, out intId);
                cmd.Parameters.AddWithValue("@Email", str帳號);
                cmd.Parameters.AddWithValue("@Password", str密碼);

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read() == true)
                {
                    GlobalVar.is登入成功 = true;
                    GlobalVar.使用者名稱 = reader["Name"].ToString();
                    GlobalVar.使用者id = intId;
                    GlobalVar.使用者等級 = reader["LevelName"].ToString();
                    GlobalVar.使用者點數 = Convert.ToInt32(reader["Points"]);
                }
                else
                {
                    GlobalVar.is登入成功= false;
                    GlobalVar.使用者名稱 = "";
                    GlobalVar.使用者id = 0;
                    GlobalVar.使用者名稱 = "";
                    GlobalVar.使用者等級 = "";
                    GlobalVar.使用者點數 = 0;
    }
                if (GlobalVar.is登入成功 == true)
                {
                    Close();
    
                }
                else
                {
                    MessageBox.Show("登入失敗!! 請重新輸入");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("帳號密碼皆必填");
            }

        }

        private void btn創建帳戶_Click(object sender, EventArgs e)
        {
            LV3_FormSignup myFormSignup = new LV3_FormSignup();
            myFormSignup.ShowDialog();
            this.Close();
        }
    }
}
