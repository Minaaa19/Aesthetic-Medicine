using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2個專訂購單
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        List<TreatmentItem> list顯示中的療程 = new List<TreatmentItem>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'aesthetic_MedicineDataSet.Treatment' 資料表。您可以視需要進行移動或移除。
            this.treatmentTableAdapter.Fill(this.aesthetic_MedicineDataSet.Treatment);


            scsb.DataSource = @".";
            scsb.InitialCatalog = "Aesthetic Medicine";
            scsb.IntegratedSecurity = true;

            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            List<string> 商品分類清單 = 抓取資料庫分類();//呼叫方法拿到清單
            listbox商品分類.DataSource = 商品分類清單;//一次性把整包 List 丟給 DataSource，用了這行就絕對不能再寫 listbox.Items.Add()

            顯示商品資料("全部療程");

            combo排序.Items.Add("價格由低到高");
            combo排序.Items.Add("價格由高到低");
            combo排序.Items.Add("名稱排序");
            combo排序.SelectedIndex = 0;

            lbl請登入會員.Visible = true;
            btn登入2.Visible = true;

        }

        List<string> 抓取資料庫分類()
        {
            List<string> categories = new List<string>();
            categories.Add("全部療程");


            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            string strSQL = "SELECT Category_Name FROM Categories;";


            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string catName = reader["Category_Name"].ToString().Trim();

                if (catName != "全部療程")
                {
                    categories.Add(catName);

                }

            }
            reader.Close();
            con.Close();
            return categories;
        }





        private void listbox商品分類_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listbox商品分類.SelectedIndex != -1)
            {

                string selectedCategory = listbox商品分類.SelectedItem.ToString();//取得選中的分類文字


                顯示商品資料(selectedCategory);//呼叫寫好的顯示方法，把分類傳進去-->這樣顯示商品資料方法就會根據這個字串去跑 SQL 篩選
            }

        }


        void 顯示商品資料(string 分類名稱)
        {
            listView商品卡.Items.Clear();
            ImageList商品圖檔.Images.Clear();
            list顯示中的療程.Clear();

            listView商品卡.View = View.SmallIcon;
            ImageList商品圖檔.ImageSize = new Size(200, 200);
            listView商品卡.SmallImageList = ImageList商品圖檔;


            string strSQL = "";

            if (分類名稱 == "全部療程")
            {
                strSQL = "Select * from Treatment;";
            }

            else
            {
                strSQL = "select T.* from Treatment T join Categories C on T.T_categoryid = C.Category_Id where C.Category_Name = @Category_Name";//根據傳進來的商品分類去搜尋
            }

            //執行資料庫連線與讀取
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);

            if (分類名稱 != "全部療程")
            {
                cmd.Parameters.AddWithValue("@Category_Name", 分類名稱);//如果SQL 語法裡有@T_categoryid這種「預留位置」，就必須先透過cmd.Parameters.AddWithValue把實際的值（例如 "雷射類"）補上去
            }

            SqlDataReader reader = cmd.ExecuteReader();//在執行ExecuteReader()前，必須確保 SQL 指令已經完全準備好

            int count = 0;
            while (reader.Read())
            {//封裝物件
                TreatmentItem t = new TreatmentItem();
                t.Id = (int)reader["T_id"];
                t.Name = (string)reader["T_name"];
                t.Price = (reader["T_price"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["T_price"]);
                t.Totalsessions = (reader["T_totalsessions"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["T_totalsessions"]);
                t.Unitprice = (reader["T_unitprice"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["T_unitprice"]);

                list顯示中的療程.Add(t);//將這一「包」資料存進 List

                //處理圖片

                if (reader["T_image"] != DBNull.Value)
                {
                    string imageName = (string)reader["T_image"];
                    string 完整圖檔路徑 = Path.Combine(GlobalVar.ImgDir, imageName);

                    if (File.Exists(完整圖檔路徑))
                    {
                        using (FileStream fs = new FileStream(完整圖檔路徑, FileMode.Open, FileAccess.Read))
                        {
                            ImageList商品圖檔.Images.Add(Image.FromStream(fs));
                        }

                    }
                    else
                    {
                        // 如果路徑錯了，這裡會印出訊息
                        Console.WriteLine($"找不到圖片：{完整圖檔路徑}");
                    }
                }



                // 顯示在 ListView
                ListViewItem item = new ListViewItem();
                item.ImageIndex = count;
                item.Text = $"{t.Name}\r\r\rNT$ {t.Price:N0}";
                item.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                item.ForeColor = Color.FromArgb(37, 72, 85);
                item.Tag = t.Id; // 把 ID 藏在 Tag 裡，點擊時非常有用

                listView商品卡.Items.Add(item);
                count++;

            }

            reader.Close();
            con.Close();
        }


        private void listView商品卡_ItemActivate(object sender, EventArgs e)
        {
            LV1Form_ProductDetail myProductDetail = new LV1Form_ProductDetail();
            myProductDetail.loadId = (int)listView商品卡.SelectedItems[0].Tag;
            myProductDetail.ShowDialog();
            //form_ProductDetail加入諮詢按下後會跳回來繼續執行下面
            int count = GlobalVar.list諮詢清單.Count;
            lbl已選療程.Text = $"已選療程({count})";
        }




        private void btn搜尋_Click(object sender, EventArgs e)
        {
            重新載入資料();
        }


        private void btn確認諮詢_Click(object sender, EventArgs e)
        {
            if (GlobalVar.list諮詢清單.Count > 0)
            {
                LV myOrderConfirm = new LV();
                myOrderConfirm.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇療程");
            }

        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            LV3_FormLogin myFormLogin = new LV3_FormLogin();
            myFormLogin.ShowDialog();
        }

        void 顯示登入後畫面()
        {
            lbl會員姓名.Text = $"{GlobalVar.使用者名稱}";
     
            if (GlobalVar.is登入成功 == true)
            {
                lbl請登入會員.Visible = false;
                lbl會員資訊.Visible = true;
                lbl會員姓名.Visible = true;
                lbl會員等級.Visible = true;
                lbl會員點數.Visible = true;
                btn登出.Visible = true;

                lbl會員資訊.Text = "已登入會員";
                lbl會員姓名.Text = $"{GlobalVar.使用者名稱}";
                lbl會員等級.Text = $"{GlobalVar.使用者等級}";
                lbl會員點數.Text = $"點數:{GlobalVar.使用者點數}";
                btn登入.Text = "登出";
                btn登入2.Visible = false;
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            顯示登入後畫面();
        }

        private void btn登出_Click(object sender, EventArgs e)
        {   
            lbl請登入會員.Visible = true;
            lbl會員資訊.Visible = false;
            lbl會員姓名.Visible = false;
            lbl會員等級.Visible = false;
            lbl會員點數.Visible = false;
            btn登入.Text = "登入";
            btn登出.Visible = false;
            btn登入2.Visible = true;
        }

       void 重新載入資料()
        {
            string strPriceSort = "";
            
            if(combo排序.SelectedIndex != -1)
            {
                switch(combo排序.Text)
                {
                    case "價格由低到高":
                        strPriceSort = "T_price ASC";
                        break;
                    case "價格由高到低":
                        strPriceSort = "T_price DESC";
                        break;

                    case "名稱排序":
                        strPriceSort = "T_name ASC";
                        break;
                    default:
                        strPriceSort = "select * from Treatment";
                        break;
                }
            }
        }

        private void combo排序_SelectedIndexChanged(object sender, EventArgs e)
        {
            重新載入資料();
        }




        private void btn註冊_Click(object sender, EventArgs e)
        {
            LV3_FormSignup myFormSignup = new LV3_FormSignup();
            myFormSignup.ShowDialog();

        }

        private void btn登入2_Click(object sender, EventArgs e)
        {
            LV3_FormLogin myFormLogin = new LV3_FormLogin();
            myFormLogin.ShowDialog();
        }


    } 
    

}
