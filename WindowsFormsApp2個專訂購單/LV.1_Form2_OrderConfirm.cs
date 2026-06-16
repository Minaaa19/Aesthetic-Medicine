using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApp2個專訂購單
{
    public partial class LV : Form
    {
        public LV()
        {
            InitializeComponent();
        }

        private void LV_Load(object sender, EventArgs e)
        {
            combo年齡.Items.Add("18 ~ 20 歲");
            combo年齡.Items.Add("21 ~ 30 歲");
            combo年齡.Items.Add("31 ~ 40 歲");
            combo年齡.Items.Add("41 ~ 50 歲");
            combo年齡.Items.Add("51 ~ 60 歲");
            combo年齡.Items.Add("60+ 歲");
            combo年齡.SelectedIndex = 1;

            combo方便聯繫時段.Items.Add("09:00 ~ 12:00");
            combo方便聯繫時段.Items.Add("12:00 ~ 15:00");
            combo方便聯繫時段.Items.Add("15:00 ~ 18:00");
            combo方便聯繫時段.Items.Add("18:00 ~ 21:00");
            combo方便聯繫時段.SelectedIndex = 0;


            dgv已選療程.AutoGenerateColumns = false; //1.防止它自動產生多餘的 ID, Name等欄位
            //2.綁定資料來源(指向 GlobalVar 的籃子)
            dgv已選療程.DataSource = new List<TreatmentItem>();//先重設
            if (GlobalVar.list諮詢清單 != null)
            {
                dgv已選療程.DataSource = GlobalVar.list諮詢清單;
            }

            Calculatetotal();
        }

      public void Calculatetotal()
        {
            decimal total = 0;

            foreach(DataGridViewRow row in dgv已選療程.Rows)
            {
                if (!row.IsNewRow && row.Cells["療程價格"].Value != null)
                {
                    decimal price = 0;
                    // 嘗試將儲存格內容轉為數字，避免因為格式問題當機
                    if (decimal.TryParse(row.Cells["療程價格"].Value.ToString(), out price))
                    {
                        total += price;
                    }

                }
            }
            lbl療程價格.Text = $"療程總價：NT${total:N0}";

        }








        private void btn移除所選療程_Click(object sender, EventArgs e)
        {
            if (dgv已選療程.SelectedRows.Count > 0)//1.檢查是否有選中橫列
            {
                int delidx = dgv已選療程.SelectedRows[0].Index;//2.取得選中橫列的索引值(Index)
                GlobalVar.list諮詢清單.RemoveAt(delidx);//3.刪除「本體」資料來源 (GlobalVar 裡的 List)
                dgv已選療程.DataSource = null; //4.重點：先斷開，再重新綁定資料來源
                dgv已選療程.DataSource = GlobalVar.list諮詢清單;
                
            }
            else
            {
                MessageBox.Show("請選擇您要移除的療程");
            }
        }

        private void btn回上一步_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn送出諮詢單_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != "") && (txtEmail.Text != "") )




            MessageBox.Show("已成功送出諮詢單，將有專人與您聯繫");

            MessageBox.Show("請勾選個資條款同意書");

        }

        private void btn下載諮詢單_Click(object sender, EventArgs e)
        {
            string str預設檔案輸出路徑 = @"C:\Users\iSpan\Desktop\Mina works\0424個人小專-訂購單\測試輸出的諮詢單";
            Random myRnd = new Random();
            int numRand = myRnd.Next(1000, 10000);
            string str檔名 = $"{DateTime.Now.ToString("yyMMddHHmmss")}{numRand.ToString()}{"每美診所諮詢單.txt"}";
            string str完整檔名路徑 = $"{str預設檔案輸出路徑}\\{str檔名}";
            Console.Write(str完整檔名路徑);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str預設檔案輸出路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "PDF檔|*.pdf";//過濾器，|顯示在對話框的下拉選單，*代表任意字串，.txt代表副檔名 ,*.pdf或這個檔名
            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            {//確認存檔 
                str完整檔名路徑 = sfd.FileName;
                Console.WriteLine(str完整檔名路徑);
            }
            else
            { //取消
                return;
            }



        }


        //不論是程式增加資料，還是手動去改表格裡的數字，總價都能「自動更新」
        private void dgv已選療程_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculatetotal();
        }

        private void dgv已選療程_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calculatetotal();
        }
    }
}
