namespace WindowsFormsApp2個專訂購單
{
    partial class LV1Form_ProductDetail
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
            this.pictureBox商品圖片 = new System.Windows.Forms.PictureBox();
            this.lbl療程名稱 = new System.Windows.Forms.Label();
            this.lbl療程價格 = new System.Windows.Forms.Label();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn加入諮詢單 = new System.Windows.Forms.Button();
            this.btn預約醫師 = new System.Windows.Forms.Button();
            this.lbl堂數 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.btn關閉 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖片)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox商品圖片
            // 
            this.pictureBox商品圖片.Location = new System.Drawing.Point(12, 109);
            this.pictureBox商品圖片.Name = "pictureBox商品圖片";
            this.pictureBox商品圖片.Size = new System.Drawing.Size(270, 260);
            this.pictureBox商品圖片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖片.TabIndex = 6;
            this.pictureBox商品圖片.TabStop = false;
            // 
            // lbl療程名稱
            // 
            this.lbl療程名稱.AutoSize = true;
            this.lbl療程名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl療程名稱.Location = new System.Drawing.Point(252, 32);
            this.lbl療程名稱.Name = "lbl療程名稱";
            this.lbl療程名稱.Size = new System.Drawing.Size(100, 24);
            this.lbl療程名稱.TabIndex = 7;
            this.lbl療程名稱.Text = "[療程名稱]";
            // 
            // lbl療程價格
            // 
            this.lbl療程價格.AutoSize = true;
            this.lbl療程價格.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl療程價格.Location = new System.Drawing.Point(301, 92);
            this.lbl療程價格.Name = "lbl療程價格";
            this.lbl療程價格.Size = new System.Drawing.Size(100, 24);
            this.lbl療程價格.TabIndex = 8;
            this.lbl療程價格.Text = "[療程價格]";
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(302, 208);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ReadOnly = true;
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(395, 161);
            this.txt商品描述.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(301, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "療程簡介";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(302, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "堂數:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(439, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "平均每堂單價:";
            // 
            // btn加入諮詢單
            // 
            this.btn加入諮詢單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入諮詢單.Location = new System.Drawing.Point(319, 399);
            this.btn加入諮詢單.Name = "btn加入諮詢單";
            this.btn加入諮詢單.Size = new System.Drawing.Size(157, 47);
            this.btn加入諮詢單.TabIndex = 12;
            this.btn加入諮詢單.Text = "加入諮詢單";
            this.btn加入諮詢單.UseVisualStyleBackColor = true;
            this.btn加入諮詢單.Click += new System.EventHandler(this.btn加入諮詢單_Click);
            // 
            // btn預約醫師
            // 
            this.btn預約醫師.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn預約醫師.Location = new System.Drawing.Point(40, 399);
            this.btn預約醫師.Name = "btn預約醫師";
            this.btn預約醫師.Size = new System.Drawing.Size(212, 47);
            this.btn預約醫師.TabIndex = 12;
            this.btn預約醫師.Text = "預約醫師(即將推出)";
            this.btn預約醫師.UseVisualStyleBackColor = true;
            // 
            // lbl堂數
            // 
            this.lbl堂數.AutoSize = true;
            this.lbl堂數.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl堂數.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl堂數.Location = new System.Drawing.Point(361, 142);
            this.lbl堂數.Name = "lbl堂數";
            this.lbl堂數.Size = new System.Drawing.Size(32, 24);
            this.lbl堂數.TabIndex = 11;
            this.lbl堂數.Text = "00";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(574, 142);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(76, 24);
            this.lbl單價.TabIndex = 11;
            this.lbl單價.Text = "000000";
            // 
            // btn關閉
            // 
            this.btn關閉.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.Location = new System.Drawing.Point(544, 399);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(123, 47);
            this.btn關閉.TabIndex = 13;
            this.btn關閉.Text = "關閉";
            this.btn關閉.UseVisualStyleBackColor = true;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // LV1Form_ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 487);
            this.Controls.Add(this.btn關閉);
            this.Controls.Add(this.btn預約醫師);
            this.Controls.Add(this.btn加入諮詢單);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.lbl堂數);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.lbl療程價格);
            this.Controls.Add(this.lbl療程名稱);
            this.Controls.Add(this.pictureBox商品圖片);
            this.Name = "LV1Form_ProductDetail";
            this.Text = "商品資訊";
            this.Load += new System.EventHandler(this.LV1Form_ProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖片)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox商品圖片;
        private System.Windows.Forms.Label lbl療程名稱;
        private System.Windows.Forms.Label lbl療程價格;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn加入諮詢單;
        private System.Windows.Forms.Button btn預約醫師;
        private System.Windows.Forms.Label lbl堂數;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Button btn關閉;
    }
}