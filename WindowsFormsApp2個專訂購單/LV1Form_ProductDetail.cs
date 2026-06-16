using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp2個專訂購單
{
    public partial class LV1Form_ProductDetail : Form
    {
        public int loadId = 0;//接收外部傳入的id
        string str修改後的商品圖檔名稱 = "";
        TreatmentItem 當前療程 = new TreatmentItem();//用來存等等加入諮詢抓到的資料


        public LV1Form_ProductDetail()
        {
            InitializeComponent();
        }

        private void LV1Form_ProductDetail_Load(object sender, EventArgs e)
        {
            顯示商品詳細資訊(loadId);
        }


        private string GetSafeString(object value, string defaultValue)
        {//處理一般欄位為null的方法

            return value == DBNull.Value ? defaultValue : value.ToString();       
        }


        private string GetSafePriceString (object value, string defaultValue)
        {//處理價格為null的方法，讓價格可以加上NT$和千分位逗號
            if (value == null || value == DBNull.Value) // 檢查是否為空值
            {
                return defaultValue;
            }
            
            if(int.TryParse(value.ToString(),out int price))
            {
                return $"NT${price:N0}";
            }

            return default;            
        }



        void 顯示商品詳細資訊(int myId)
        {
            if (myId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Treatment where T_id = @T_id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@T_id", myId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lbl療程名稱.Text = reader["T_name"].ToString();
                    lbl療程價格.Text = GetSafePriceString(reader["T_price"], "請來電洽詢價格");//價格為null的方法
                    lbl堂數.Text = GetSafeString(reader["T_totalsessions"], "須由醫師評估");
                    lbl單價.Text = GetSafePriceString(reader["T_unitprice"], "依現場評估");//價格為null的方法
                    txt商品描述.Text = GetSafeString(reader["T_description"],"請諮詢院方");


                    //同步存進「當前療程」物件裡(為FormProductOrder鋪路)
                    當前療程.Id = (int)reader["T_id"];
                    當前療程.Name = reader["T_name"].ToString();
                    當前療程.Price = (reader["T_price"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["T_price"]);//處理可能為 Null 的數值
                    當前療程.Totalsessions = (reader["T_totalsessions"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["T_totalsessions"]);
                    當前療程.Unitprice = (reader["T_unitprice"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["T_unitprice"]);


                    str修改後的商品圖檔名稱 = reader["T_image"].ToString();
                    string str完整圖檔路徑 = Path.Combine(GlobalVar.ImgDir, str修改後的商品圖檔名稱);

                    FileStream fs = File.OpenRead(str完整圖檔路徑);
                    pictureBox商品圖片.Image = Image.FromStream(fs);
                    fs.Close();
                    pictureBox商品圖片.Tag = str完整圖檔路徑;

                }

                reader.Close();
                con.Close();
            }
        }

       
        private void btn加入諮詢單_Click(object sender, EventArgs e)
        {
            //點擊時，直接把存好的「當前療程」，丟進全域清單
            GlobalVar.list諮詢清單.Add(當前療程);
            MessageBox.Show($"{當前療程.Name} 已成功加入諮詢單！", "加入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn關閉_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
