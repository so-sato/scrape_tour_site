namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_resultCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cityName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_url = new System.Windows.Forms.RadioButton();
            this.rdo_txt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.siteList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(65, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(806, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(884, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(15, 293);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(881, 321);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "取得件数：";
            // 
            // lbl_resultCount
            // 
            this.lbl_resultCount.AutoSize = true;
            this.lbl_resultCount.Location = new System.Drawing.Point(70, 274);
            this.lbl_resultCount.Name = "lbl_resultCount";
            this.lbl_resultCount.Size = new System.Drawing.Size(23, 12);
            this.lbl_resultCount.TabIndex = 7;
            this.lbl_resultCount.Text = "0件";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_count);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cityName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "追加設定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "※数値のみ入力してください（件/軒のケースがあるため）";
            // 
            // txt_count
            // 
            this.txt_count.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_count.Location = new System.Drawing.Point(53, 68);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(203, 19);
            this.txt_count.TabIndex = 4;
            this.txt_count.Leave += new System.EventHandler(this.txt_count_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "分母数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(507, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "※TripAdvisor(レストラン)の場合、都市名と分母数を入力（例：xx位：[都市名]のレストラン[分母数]件中）";
            // 
            // txt_cityName
            // 
            this.txt_cityName.Location = new System.Drawing.Point(53, 42);
            this.txt_cityName.Name = "txt_cityName";
            this.txt_cityName.Size = new System.Drawing.Size(203, 19);
            this.txt_cityName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "都市名";
            // 
            // rdo_url
            // 
            this.rdo_url.AutoSize = true;
            this.rdo_url.Checked = true;
            this.rdo_url.Location = new System.Drawing.Point(7, 23);
            this.rdo_url.Name = "rdo_url";
            this.rdo_url.Size = new System.Drawing.Size(45, 16);
            this.rdo_url.TabIndex = 8;
            this.rdo_url.TabStop = true;
            this.rdo_url.Text = "URL";
            this.rdo_url.UseVisualStyleBackColor = true;
            this.rdo_url.CheckedChanged += new System.EventHandler(this.rdo_url_CheckedChanged);
            // 
            // rdo_txt
            // 
            this.rdo_txt.AutoSize = true;
            this.rdo_txt.Location = new System.Drawing.Point(6, 55);
            this.rdo_txt.Name = "rdo_txt";
            this.rdo_txt.Size = new System.Drawing.Size(53, 16);
            this.rdo_txt.TabIndex = 9;
            this.rdo_txt.Text = "HTML";
            this.rdo_txt.UseVisualStyleBackColor = true;
            this.rdo_txt.CheckedChanged += new System.EventHandler(this.rdo_txt_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.siteList);
            this.groupBox2.Controls.Add(this.rdo_txt);
            this.groupBox2.Controls.Add(this.rdo_url);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解析方法";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(216, 51);
            this.textBox3.MaxLength = 999999999;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(655, 39);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // siteList
            // 
            this.siteList.FormattingEnabled = true;
            this.siteList.Items.AddRange(new object[] {
            "foursquare",
            "Tripadvisor(観光)"});
            this.siteList.Location = new System.Drawing.Point(65, 53);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(145, 20);
            this.siteList.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 626);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_resultCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ScraperTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_resultCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cityName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdo_url;
        private System.Windows.Forms.RadioButton rdo_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox siteList;
        private System.Windows.Forms.TextBox textBox3;
    }
}

