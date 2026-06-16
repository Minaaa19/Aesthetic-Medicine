using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp2個專訂購單.Form1;



namespace WindowsFormsApp2個專訂購單
{
    public class GlobalVar
    {
        public static string strDBConnectionString = "";
        public static string ImgDir = @"C:\Users\iSpan\Desktop\Mina works\0424個人小專-訂購單\Treatment圖檔";

        public static int 諮詢單總數量 = 0; //用來記錄加入了幾個療程
        public static List<TreatmentItem> list諮詢清單 = new List<TreatmentItem>();

        public static bool is登入成功 = false;
        public static int 使用者id = 0;
        public static string 使用者名稱 = "";
        public static string 使用者等級 = "";
        public static int 使用者點數 = 0; 
        public static int 使用者權限 = 0;
    }

    public class TreatmentItem //因為不能在class Form1 : Form裡面而且又不能在最開頭 只能到移form1最下來或獨立建一個類別
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Totalsessions { get; set; }
        public int Unitprice { get; set; }
    }


}
