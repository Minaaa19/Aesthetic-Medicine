using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2個專訂購單
{
    public partial class LV3_FormSignup : Form
    {
        public LV3_FormSignup()
        {
            InitializeComponent();
        }

        private void LV3_FormSignup_Load(object sender, EventArgs e)
        {   
            // TODO: 這行程式碼會將資料載入 'aesthetic_MedicineDataSet.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.aesthetic_MedicineDataSet.Customers);
            combo性別.Items.Add("先生");
            combo性別.Items.Add("小姐");
            combo性別.Items.Add("第三性");
            combo性別.SelectedIndex = 1;

            dtp生日.Value = new DateTime(1900, 1, 1, 0, 0, 0);
            customersBindingSource.AddNew();


        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != "") && (txt密碼.Text != "") && (combo性別.SelectedIndex != -1) && (chk同意條款.Checked))
            { 

                // 1. 取得目前正在新增的那一筆資料列
                DataRowView newRow = (DataRowView)customersBindingSource.Current;

                // 2. 手動填入點數預設值 (假設欄位名稱叫 Points)
                newRow["Points"] = 100;
                newRow["RegisterDate"] = DateTime.Now; //把現在時間塞進去

                customersBindingSource.EndEdit();
                customersTableAdapter.Update(aesthetic_MedicineDataSet.Customers);
                MessageBox.Show("新會員註冊成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("*為必填資料，需填寫完整");
            }
        }
    }
    }

