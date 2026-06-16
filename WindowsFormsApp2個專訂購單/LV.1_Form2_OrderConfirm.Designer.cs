namespace WindowsFormsApp2個專訂購單
{
    partial class LV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LV));
            this.groupBox性別 = new System.Windows.Forms.GroupBox();
            this.radio第三性 = new System.Windows.Forms.RadioButton();
            this.小姐 = new System.Windows.Forms.RadioButton();
            this.radio先生 = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo方便聯繫時段 = new System.Windows.Forms.ComboBox();
            this.chk個資 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn移除所選療程 = new System.Windows.Forms.Button();
            this.btn回上一步 = new System.Windows.Forms.Button();
            this.btn送出諮詢單 = new System.Windows.Forms.Button();
            this.btn下載諮詢單 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk服藥 = new System.Windows.Forms.CheckBox();
            this.chk過敏 = new System.Windows.Forms.CheckBox();
            this.chk慢性病 = new System.Windows.Forms.CheckBox();
            this.chk蟹足腫 = new System.Windows.Forms.CheckBox();
            this.chk懷孕 = new System.Windows.Forms.CheckBox();
            this.combo年齡 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv已選療程 = new System.Windows.Forms.DataGridView();
            this.療程名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.療程價格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.堂數 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.平均每堂單價 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt個資條款 = new System.Windows.Forms.TextBox();
            this.groupBox已選療程 = new System.Windows.Forms.GroupBox();
            this.lbl療程價格 = new System.Windows.Forms.Label();
            this.chk痘痘 = new System.Windows.Forms.CheckBox();
            this.chk斑點 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk其他 = new System.Windows.Forms.CheckBox();
            this.chk毛孔 = new System.Windows.Forms.CheckBox();
            this.chk鬆弛 = new System.Windows.Forms.CheckBox();
            this.chk細紋 = new System.Windows.Forms.CheckBox();
            this.groupBox性別.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv已選療程)).BeginInit();
            this.groupBox已選療程.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox性別
            // 
            this.groupBox性別.Controls.Add(this.radio第三性);
            this.groupBox性別.Controls.Add(this.小姐);
            this.groupBox性別.Controls.Add(this.radio先生);
            this.groupBox性別.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox性別.Location = new System.Drawing.Point(24, 165);
            this.groupBox性別.Name = "groupBox性別";
            this.groupBox性別.Size = new System.Drawing.Size(286, 71);
            this.groupBox性別.TabIndex = 23;
            this.groupBox性別.TabStop = false;
            this.groupBox性別.Text = "* 性別(必填)";
            // 
            // radio第三性
            // 
            this.radio第三性.AutoSize = true;
            this.radio第三性.Location = new System.Drawing.Point(189, 34);
            this.radio第三性.Name = "radio第三性";
            this.radio第三性.Size = new System.Drawing.Size(76, 25);
            this.radio第三性.TabIndex = 0;
            this.radio第三性.TabStop = true;
            this.radio第三性.Text = "第三性\r\n";
            this.radio第三性.UseVisualStyleBackColor = true;
            // 
            // 小姐
            // 
            this.小姐.AutoSize = true;
            this.小姐.Location = new System.Drawing.Point(103, 34);
            this.小姐.Name = "小姐";
            this.小姐.Size = new System.Drawing.Size(60, 25);
            this.小姐.TabIndex = 0;
            this.小姐.TabStop = true;
            this.小姐.Text = "小姐";
            this.小姐.UseVisualStyleBackColor = true;
            // 
            // radio先生
            // 
            this.radio先生.AutoSize = true;
            this.radio先生.Location = new System.Drawing.Point(22, 34);
            this.radio先生.Name = "radio先生";
            this.radio先生.Size = new System.Drawing.Size(60, 25);
            this.radio先生.TabIndex = 0;
            this.radio先生.TabStop = true;
            this.radio先生.Text = "先生\r\n";
            this.radio先生.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(675, 39);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 29);
            this.txtEmail.TabIndex = 20;
            // 
            // txt電話
            // 
            this.txt電話.Location = new System.Drawing.Point(375, 40);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(176, 29);
            this.txt電話.TabIndex = 21;
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(95, 40);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(176, 29);
            this.txt姓名.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(591, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(305, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "電話 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "姓名 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(394, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "諮 詢 單 確 認";
            // 
            // combo方便聯繫時段
            // 
            this.combo方便聯繫時段.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo方便聯繫時段.FormattingEnabled = true;
            this.combo方便聯繫時段.Location = new System.Drawing.Point(734, 194);
            this.combo方便聯繫時段.Name = "combo方便聯繫時段";
            this.combo方便聯繫時段.Size = new System.Drawing.Size(160, 27);
            this.combo方便聯繫時段.TabIndex = 24;
            // 
            // chk個資
            // 
            this.chk個資.AutoSize = true;
            this.chk個資.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk個資.Location = new System.Drawing.Point(31, 734);
            this.chk個資.Name = "chk個資";
            this.chk個資.Size = new System.Drawing.Size(373, 23);
            this.chk個資.TabIndex = 25;
            this.chk個資.Text = "我已詳閱個資條款，並同意醫師評估後可能調整療程\r\n";
            this.chk個資.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txt電話);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(24, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 89);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "* 基本資料(必填)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(585, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "* 方便聯繫時段 :";
            // 
            // btn移除所選療程
            // 
            this.btn移除所選療程.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選療程.Location = new System.Drawing.Point(53, 889);
            this.btn移除所選療程.Name = "btn移除所選療程";
            this.btn移除所選療程.Size = new System.Drawing.Size(130, 40);
            this.btn移除所選療程.TabIndex = 29;
            this.btn移除所選療程.Text = "移除所選療程";
            this.btn移除所選療程.UseVisualStyleBackColor = true;
            this.btn移除所選療程.Click += new System.EventHandler(this.btn移除所選療程_Click);
            // 
            // btn回上一步
            // 
            this.btn回上一步.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回上一步.Location = new System.Drawing.Point(269, 889);
            this.btn回上一步.Name = "btn回上一步";
            this.btn回上一步.Size = new System.Drawing.Size(130, 40);
            this.btn回上一步.TabIndex = 29;
            this.btn回上一步.Text = "回上一步";
            this.btn回上一步.UseVisualStyleBackColor = true;
            this.btn回上一步.Click += new System.EventHandler(this.btn回上一步_Click);
            // 
            // btn送出諮詢單
            // 
            this.btn送出諮詢單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出諮詢單.Location = new System.Drawing.Point(491, 889);
            this.btn送出諮詢單.Name = "btn送出諮詢單";
            this.btn送出諮詢單.Size = new System.Drawing.Size(130, 40);
            this.btn送出諮詢單.TabIndex = 29;
            this.btn送出諮詢單.Text = "送出諮詢單";
            this.btn送出諮詢單.UseVisualStyleBackColor = true;
            this.btn送出諮詢單.Click += new System.EventHandler(this.btn送出諮詢單_Click);
            // 
            // btn下載諮詢單
            // 
            this.btn下載諮詢單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下載諮詢單.Location = new System.Drawing.Point(710, 889);
            this.btn下載諮詢單.Name = "btn下載諮詢單";
            this.btn下載諮詢單.Size = new System.Drawing.Size(130, 40);
            this.btn下載諮詢單.TabIndex = 30;
            this.btn下載諮詢單.Text = "下載諮詢單";
            this.btn下載諮詢單.UseVisualStyleBackColor = true;
            this.btn下載諮詢單.Click += new System.EventHandler(this.btn下載諮詢單_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk服藥);
            this.groupBox3.Controls.Add(this.chk過敏);
            this.groupBox3.Controls.Add(this.chk慢性病);
            this.groupBox3.Controls.Add(this.chk蟹足腫);
            this.groupBox3.Controls.Add(this.chk懷孕);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(24, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(879, 115);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "健康狀況";
            // 
            // chk服藥
            // 
            this.chk服藥.AutoSize = true;
            this.chk服藥.Location = new System.Drawing.Point(611, 40);
            this.chk服藥.Name = "chk服藥";
            this.chk服藥.Size = new System.Drawing.Size(205, 25);
            this.chk服藥.TabIndex = 1;
            this.chk服藥.Text = "是否服用藥物（抗凝血）";
            this.chk服藥.UseVisualStyleBackColor = true;
            // 
            // chk過敏
            // 
            this.chk過敏.AutoSize = true;
            this.chk過敏.Location = new System.Drawing.Point(251, 76);
            this.chk過敏.Name = "chk過敏";
            this.chk過敏.Size = new System.Drawing.Size(125, 25);
            this.chk過敏.TabIndex = 1;
            this.chk過敏.Text = "是否有過敏史";
            this.chk過敏.UseVisualStyleBackColor = true;
            // 
            // chk慢性病
            // 
            this.chk慢性病.AutoSize = true;
            this.chk慢性病.Location = new System.Drawing.Point(250, 40);
            this.chk慢性病.Name = "chk慢性病";
            this.chk慢性病.Size = new System.Drawing.Size(269, 25);
            this.chk慢性病.TabIndex = 1;
            this.chk慢性病.Text = "是否有慢性病（糖尿病、高血壓）";
            this.chk慢性病.UseVisualStyleBackColor = true;
            // 
            // chk蟹足腫
            // 
            this.chk蟹足腫.AutoSize = true;
            this.chk蟹足腫.Location = new System.Drawing.Point(22, 76);
            this.chk蟹足腫.Name = "chk蟹足腫";
            this.chk蟹足腫.Size = new System.Drawing.Size(157, 25);
            this.chk蟹足腫.TabIndex = 1;
            this.chk蟹足腫.Text = "是否有蟹足腫體質";
            this.chk蟹足腫.UseVisualStyleBackColor = true;
            // 
            // chk懷孕
            // 
            this.chk懷孕.AutoSize = true;
            this.chk懷孕.Location = new System.Drawing.Point(22, 40);
            this.chk懷孕.Name = "chk懷孕";
            this.chk懷孕.Size = new System.Drawing.Size(140, 25);
            this.chk懷孕.TabIndex = 1;
            this.chk懷孕.Text = "是否懷孕 / 哺乳";
            this.chk懷孕.UseVisualStyleBackColor = true;
            // 
            // combo年齡
            // 
            this.combo年齡.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo年齡.FormattingEnabled = true;
            this.combo年齡.Location = new System.Drawing.Point(440, 195);
            this.combo年齡.Name = "combo年齡";
            this.combo年齡.Size = new System.Drawing.Size(129, 27);
            this.combo年齡.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(324, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "* 年齡區間 :";
            // 
            // dgv已選療程
            // 
            this.dgv已選療程.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv已選療程.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv已選療程.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.療程名稱,
            this.療程價格,
            this.堂數,
            this.平均每堂單價});
            this.dgv已選療程.Location = new System.Drawing.Point(7, 28);
            this.dgv已選療程.MultiSelect = false;
            this.dgv已選療程.Name = "dgv已選療程";
            this.dgv已選療程.RowTemplate.Height = 24;
            this.dgv已選療程.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv已選療程.Size = new System.Drawing.Size(863, 170);
            this.dgv已選療程.TabIndex = 33;
            this.dgv已選療程.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv已選療程_RowsAdded);
            this.dgv已選療程.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv已選療程_RowsRemoved);
            // 
            // 療程名稱
            // 
            this.療程名稱.DataPropertyName = "Name";
            this.療程名稱.HeaderText = "療程名稱";
            this.療程名稱.Name = "療程名稱";
            // 
            // 療程價格
            // 
            this.療程價格.DataPropertyName = "Price";
            this.療程價格.HeaderText = "療程價格";
            this.療程價格.Name = "療程價格";
            // 
            // 堂數
            // 
            this.堂數.DataPropertyName = "Totalsessions";
            this.堂數.HeaderText = "堂數";
            this.堂數.Name = "堂數";
            // 
            // 平均每堂單價
            // 
            this.平均每堂單價.DataPropertyName = "Unitprice";
            this.平均每堂單價.HeaderText = "平均每堂單價";
            this.平均每堂單價.Name = "平均每堂單價";
            // 
            // txt個資條款
            // 
            this.txt個資條款.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt個資條款.Location = new System.Drawing.Point(24, 763);
            this.txt個資條款.Multiline = true;
            this.txt個資條款.Name = "txt個資條款";
            this.txt個資條款.ReadOnly = true;
            this.txt個資條款.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt個資條款.Size = new System.Drawing.Size(655, 103);
            this.txt個資條款.TabIndex = 32;
            this.txt個資條款.Text = resources.GetString("txt個資條款.Text");
            // 
            // groupBox已選療程
            // 
            this.groupBox已選療程.Controls.Add(this.lbl療程價格);
            this.groupBox已選療程.Controls.Add(this.dgv已選療程);
            this.groupBox已選療程.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox已選療程.Location = new System.Drawing.Point(24, 473);
            this.groupBox已選療程.Name = "groupBox已選療程";
            this.groupBox已選療程.Size = new System.Drawing.Size(879, 255);
            this.groupBox已選療程.TabIndex = 34;
            this.groupBox已選療程.TabStop = false;
            this.groupBox已選療程.Text = "已選療程";
            // 
            // lbl療程價格
            // 
            this.lbl療程價格.AutoSize = true;
            this.lbl療程價格.Location = new System.Drawing.Point(658, 219);
            this.lbl療程價格.Name = "lbl療程價格";
            this.lbl療程價格.Size = new System.Drawing.Size(74, 21);
            this.lbl療程價格.TabIndex = 34;
            this.lbl療程價格.Text = "療程總價";
            // 
            // chk痘痘
            // 
            this.chk痘痘.AutoSize = true;
            this.chk痘痘.Location = new System.Drawing.Point(22, 31);
            this.chk痘痘.Name = "chk痘痘";
            this.chk痘痘.Size = new System.Drawing.Size(61, 25);
            this.chk痘痘.TabIndex = 1;
            this.chk痘痘.Text = "痘痘";
            this.chk痘痘.UseVisualStyleBackColor = true;
            // 
            // chk斑點
            // 
            this.chk斑點.AutoSize = true;
            this.chk斑點.Location = new System.Drawing.Point(134, 31);
            this.chk斑點.Name = "chk斑點";
            this.chk斑點.Size = new System.Drawing.Size(61, 25);
            this.chk斑點.TabIndex = 1;
            this.chk斑點.Text = "斑點";
            this.chk斑點.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk其他);
            this.groupBox4.Controls.Add(this.chk毛孔);
            this.groupBox4.Controls.Add(this.chk鬆弛);
            this.groupBox4.Controls.Add(this.chk細紋);
            this.groupBox4.Controls.Add(this.chk斑點);
            this.groupBox4.Controls.Add(this.chk痘痘);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(24, 392);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(879, 73);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "目前膚況";
            // 
            // chk其他
            // 
            this.chk其他.AutoSize = true;
            this.chk其他.Location = new System.Drawing.Point(567, 31);
            this.chk其他.Name = "chk其他";
            this.chk其他.Size = new System.Drawing.Size(61, 25);
            this.chk其他.TabIndex = 1;
            this.chk其他.Text = "其他";
            this.chk其他.UseVisualStyleBackColor = true;
            // 
            // chk毛孔
            // 
            this.chk毛孔.AutoSize = true;
            this.chk毛孔.Location = new System.Drawing.Point(467, 31);
            this.chk毛孔.Name = "chk毛孔";
            this.chk毛孔.Size = new System.Drawing.Size(61, 25);
            this.chk毛孔.TabIndex = 1;
            this.chk毛孔.Text = "毛孔";
            this.chk毛孔.UseVisualStyleBackColor = true;
            // 
            // chk鬆弛
            // 
            this.chk鬆弛.AutoSize = true;
            this.chk鬆弛.Location = new System.Drawing.Point(358, 31);
            this.chk鬆弛.Name = "chk鬆弛";
            this.chk鬆弛.Size = new System.Drawing.Size(61, 25);
            this.chk鬆弛.TabIndex = 1;
            this.chk鬆弛.Text = "鬆弛";
            this.chk鬆弛.UseVisualStyleBackColor = true;
            // 
            // chk細紋
            // 
            this.chk細紋.AutoSize = true;
            this.chk細紋.Location = new System.Drawing.Point(251, 31);
            this.chk細紋.Name = "chk細紋";
            this.chk細紋.Size = new System.Drawing.Size(61, 25);
            this.chk細紋.TabIndex = 1;
            this.chk細紋.Text = "細紋";
            this.chk細紋.UseVisualStyleBackColor = true;
            // 
            // LV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 965);
            this.Controls.Add(this.txt個資條款);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn下載諮詢單);
            this.Controls.Add(this.btn送出諮詢單);
            this.Controls.Add(this.btn回上一步);
            this.Controls.Add(this.btn移除所選療程);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.combo年齡);
            this.Controls.Add(this.chk個資);
            this.Controls.Add(this.combo方便聯繫時段);
            this.Controls.Add(this.groupBox性別);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox已選療程);
            this.Name = "LV";
            this.Text = "諮詢單確認";
            this.Load += new System.EventHandler(this.LV_Load);
            this.groupBox性別.ResumeLayout(false);
            this.groupBox性別.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv已選療程)).EndInit();
            this.groupBox已選療程.ResumeLayout(false);
            this.groupBox已選療程.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox性別;
        private System.Windows.Forms.RadioButton radio第三性;
        private System.Windows.Forms.RadioButton 小姐;
        private System.Windows.Forms.RadioButton radio先生;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo方便聯繫時段;
        private System.Windows.Forms.CheckBox chk個資;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn移除所選療程;
        private System.Windows.Forms.Button btn回上一步;
        private System.Windows.Forms.Button btn送出諮詢單;
        private System.Windows.Forms.Button btn下載諮詢單;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo年齡;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv已選療程;
        private System.Windows.Forms.DataGridViewTextBoxColumn 療程名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 療程價格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 堂數;
        private System.Windows.Forms.DataGridViewTextBoxColumn 平均每堂單價;
        private System.Windows.Forms.TextBox txt個資條款;
        private System.Windows.Forms.GroupBox groupBox已選療程;
        private System.Windows.Forms.Label lbl療程價格;
        private System.Windows.Forms.CheckBox chk慢性病;
        private System.Windows.Forms.CheckBox chk蟹足腫;
        private System.Windows.Forms.CheckBox chk懷孕;
        private System.Windows.Forms.CheckBox chk服藥;
        private System.Windows.Forms.CheckBox chk過敏;
        private System.Windows.Forms.CheckBox chk痘痘;
        private System.Windows.Forms.CheckBox chk斑點;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk鬆弛;
        private System.Windows.Forms.CheckBox chk細紋;
        private System.Windows.Forms.CheckBox chk其他;
        private System.Windows.Forms.CheckBox chk毛孔;
    }
}