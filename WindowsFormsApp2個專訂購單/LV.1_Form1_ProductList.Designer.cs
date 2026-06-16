namespace WindowsFormsApp2個專訂購單
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aesthetic_MedicineDataSet = new WindowsFormsApp2個專訂購單.Aesthetic_MedicineDataSet();
            this.combo排序 = new System.Windows.Forms.ComboBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl已選療程 = new System.Windows.Forms.Label();
            this.btn確認諮詢 = new System.Windows.Forms.Button();
            this.listbox商品分類 = new System.Windows.Forms.ListBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new WindowsFormsApp2個專訂購單.Aesthetic_MedicineDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2個專訂購單.Aesthetic_MedicineDataSetTableAdapters.TableAdapterManager();
            this.listView商品卡 = new System.Windows.Forms.ListView();
            this.療程名稱 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.價格 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.btn登入 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treatmentTableAdapter = new WindowsFormsApp2個專訂購單.Aesthetic_MedicineDataSetTableAdapters.TreatmentTableAdapter();
            this.panel會員 = new System.Windows.Forms.Panel();
            this.btn登入2 = new System.Windows.Forms.Button();
            this.lbl請登入會員 = new System.Windows.Forms.Label();
            this.btn登出 = new System.Windows.Forms.Button();
            this.lbl會員點數 = new System.Windows.Forms.Label();
            this.lbl會員等級 = new System.Windows.Forms.Label();
            this.lbl會員姓名 = new System.Windows.Forms.Label();
            this.lbl會員資訊 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aesthetic_MedicineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel會員.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentBindingSource, "T_name", true));
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(14, 80);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(261, 29);
            this.txt搜尋關鍵字.TabIndex = 0;
            this.txt搜尋關鍵字.Text = "輸入療程關鍵字";
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.aesthetic_MedicineDataSet;
            // 
            // aesthetic_MedicineDataSet
            // 
            this.aesthetic_MedicineDataSet.DataSetName = "Aesthetic_MedicineDataSet";
            this.aesthetic_MedicineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combo排序
            // 
            this.combo排序.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo排序.FormattingEnabled = true;
            this.combo排序.Location = new System.Drawing.Point(302, 77);
            this.combo排序.Name = "combo排序";
            this.combo排序.Size = new System.Drawing.Size(233, 32);
            this.combo排序.TabIndex = 1;
            this.combo排序.SelectedIndexChanged += new System.EventHandler(this.combo排序_SelectedIndexChanged);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(552, 77);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(85, 33);
            this.btn搜尋.TabIndex = 2;
            this.btn搜尋.Text = "搜尋🔍";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(311, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Auréa  時 尚 醫 美 診 所";
            // 
            // lbl已選療程
            // 
            this.lbl已選療程.AutoSize = true;
            this.lbl已選療程.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl已選療程.Location = new System.Drawing.Point(660, 81);
            this.lbl已選療程.Name = "lbl已選療程";
            this.lbl已選療程.Size = new System.Drawing.Size(128, 26);
            this.lbl已選療程.TabIndex = 4;
            this.lbl已選療程.Text = "已選療程 (0)";
            // 
            // btn確認諮詢
            // 
            this.btn確認諮詢.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認諮詢.Location = new System.Drawing.Point(807, 78);
            this.btn確認諮詢.Name = "btn確認諮詢";
            this.btn確認諮詢.Size = new System.Drawing.Size(115, 33);
            this.btn確認諮詢.TabIndex = 5;
            this.btn確認諮詢.Text = "確認諮詢";
            this.btn確認諮詢.UseVisualStyleBackColor = true;
            this.btn確認諮詢.Click += new System.EventHandler(this.btn確認諮詢_Click);
            // 
            // listbox商品分類
            // 
            this.listbox商品分類.DataSource = this.categoriesBindingSource;
            this.listbox商品分類.DisplayMember = "Category_Name";
            this.listbox商品分類.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox商品分類.FormattingEnabled = true;
            this.listbox商品分類.ItemHeight = 24;
            this.listbox商品分類.Location = new System.Drawing.Point(14, 129);
            this.listbox商品分類.Name = "listbox商品分類";
            this.listbox商品分類.Size = new System.Drawing.Size(209, 316);
            this.listbox商品分類.TabIndex = 6;
            this.listbox商品分類.ValueMember = "Category_Id";
            this.listbox商品分類.SelectedIndexChanged += new System.EventHandler(this.listbox商品分類_SelectedIndexChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.aesthetic_MedicineDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.ConsultationDetailsTableAdapter = null;
            this.tableAdapterManager.ConsultationsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.TreatmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2個專訂購單.Aesthetic_MedicineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listView商品卡
            // 
            this.listView商品卡.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView商品卡.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView商品卡.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.療程名稱,
            this.價格});
            this.listView商品卡.HideSelection = false;
            this.listView商品卡.Location = new System.Drawing.Point(239, 127);
            this.listView商品卡.Name = "listView商品卡";
            this.listView商品卡.Size = new System.Drawing.Size(722, 532);
            this.listView商品卡.SmallImageList = this.ImageList商品圖檔;
            this.listView商品卡.TabIndex = 7;
            this.listView商品卡.UseCompatibleStateImageBehavior = false;
            this.listView商品卡.View = System.Windows.Forms.View.SmallIcon;
            this.listView商品卡.ItemActivate += new System.EventHandler(this.listView商品卡_ItemActivate);
            // 
            // 療程名稱
            // 
            this.療程名稱.Text = "療程名稱";
            this.療程名稱.Width = 150;
            // 
            // 價格
            // 
            this.價格.Text = "價格";
            this.價格.Width = 100;
            // 
            // ImageList商品圖檔
            // 
            this.ImageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.ImageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btn註冊);
            this.panel1.Controls.Add(this.btn登入);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 71);
            this.panel1.TabIndex = 8;
            // 
            // btn註冊
            // 
            this.btn註冊.BackColor = System.Drawing.SystemColors.Info;
            this.btn註冊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.Location = new System.Drawing.Point(871, 21);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(76, 35);
            this.btn註冊.TabIndex = 4;
            this.btn註冊.Text = "註冊";
            this.btn註冊.UseVisualStyleBackColor = false;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.SystemColors.Info;
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(789, 21);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(76, 35);
            this.btn登入.TabIndex = 4;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::WindowsFormsApp2個專訂購單.Properties.Resources.logo11;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // panel會員
            // 
            this.panel會員.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel會員.Controls.Add(this.btn登入2);
            this.panel會員.Controls.Add(this.lbl請登入會員);
            this.panel會員.Controls.Add(this.btn登出);
            this.panel會員.Controls.Add(this.lbl會員點數);
            this.panel會員.Controls.Add(this.lbl會員等級);
            this.panel會員.Controls.Add(this.lbl會員姓名);
            this.panel會員.Controls.Add(this.lbl會員資訊);
            this.panel會員.Location = new System.Drawing.Point(14, 451);
            this.panel會員.Name = "panel會員";
            this.panel會員.Size = new System.Drawing.Size(209, 208);
            this.panel會員.TabIndex = 9;
            // 
            // btn登入2
            // 
            this.btn登入2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入2.Location = new System.Drawing.Point(108, 160);
            this.btn登入2.Name = "btn登入2";
            this.btn登入2.Size = new System.Drawing.Size(80, 30);
            this.btn登入2.TabIndex = 3;
            this.btn登入2.Text = "登入";
            this.btn登入2.UseVisualStyleBackColor = true;
            this.btn登入2.Visible = false;
            this.btn登入2.Click += new System.EventHandler(this.btn登入2_Click);
            // 
            // lbl請登入會員
            // 
            this.lbl請登入會員.AutoSize = true;
            this.lbl請登入會員.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl請登入會員.Location = new System.Drawing.Point(42, 77);
            this.lbl請登入會員.Name = "lbl請登入會員";
            this.lbl請登入會員.Size = new System.Drawing.Size(117, 26);
            this.lbl請登入會員.TabIndex = 2;
            this.lbl請登入會員.Text = "請登入會員";
            this.lbl請登入會員.Visible = false;
            // 
            // btn登出
            // 
            this.btn登出.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(23, 159);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(80, 30);
            this.btn登出.TabIndex = 1;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = true;
            this.btn登出.Visible = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // lbl會員點數
            // 
            this.lbl會員點數.AutoSize = true;
            this.lbl會員點數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員點數.Location = new System.Drawing.Point(19, 103);
            this.lbl會員點數.Name = "lbl會員點數";
            this.lbl會員點數.Size = new System.Drawing.Size(78, 21);
            this.lbl會員點數.TabIndex = 0;
            this.lbl會員點數.Text = "會員點數:";
            this.lbl會員點數.Visible = false;
            // 
            // lbl會員等級
            // 
            this.lbl會員等級.AutoSize = true;
            this.lbl會員等級.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員等級.ForeColor = System.Drawing.Color.Green;
            this.lbl會員等級.Location = new System.Drawing.Point(19, 72);
            this.lbl會員等級.Name = "lbl會員等級";
            this.lbl會員等級.Size = new System.Drawing.Size(74, 21);
            this.lbl會員等級.TabIndex = 0;
            this.lbl會員等級.Text = "會員等級";
            this.lbl會員等級.Visible = false;
            // 
            // lbl會員姓名
            // 
            this.lbl會員姓名.AutoSize = true;
            this.lbl會員姓名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員姓名.Location = new System.Drawing.Point(19, 41);
            this.lbl會員姓名.Name = "lbl會員姓名";
            this.lbl會員姓名.Size = new System.Drawing.Size(74, 21);
            this.lbl會員姓名.TabIndex = 0;
            this.lbl會員姓名.Text = "會員姓名";
            this.lbl會員姓名.Visible = false;
            // 
            // lbl會員資訊
            // 
            this.lbl會員資訊.AutoSize = true;
            this.lbl會員資訊.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員資訊.Location = new System.Drawing.Point(19, 10);
            this.lbl會員資訊.Name = "lbl會員資訊";
            this.lbl會員資訊.Size = new System.Drawing.Size(60, 17);
            this.lbl會員資訊.TabIndex = 0;
            this.lbl會員資訊.Text = "會員資訊";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 673);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 71);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel會員);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView商品卡);
            this.Controls.Add(this.listbox商品分類);
            this.Controls.Add(this.btn確認諮詢);
            this.Controls.Add(this.lbl已選療程);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.combo排序);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Name = "Form1";
            this.Text = "療程瀏覽";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aesthetic_MedicineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel會員.ResumeLayout(false);
            this.panel會員.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.ComboBox combo排序;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl已選療程;
        private System.Windows.Forms.Button btn確認諮詢;
        private System.Windows.Forms.ListBox listbox商品分類;
        private Aesthetic_MedicineDataSet aesthetic_MedicineDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Aesthetic_MedicineDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private Aesthetic_MedicineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListView listView商品卡;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ImageList商品圖檔;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private Aesthetic_MedicineDataSetTableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.ColumnHeader 療程名稱;
        private System.Windows.Forms.ColumnHeader 價格;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.Panel panel會員;
        private System.Windows.Forms.Button btn登出;
        private System.Windows.Forms.Label lbl會員點數;
        private System.Windows.Forms.Label lbl會員等級;
        private System.Windows.Forms.Label lbl會員姓名;
        private System.Windows.Forms.Label lbl會員資訊;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl請登入會員;
        private System.Windows.Forms.Button btn登入2;
    }
}

