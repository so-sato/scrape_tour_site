using ScrapeTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button1.Text = "実行中";
            this.textBox2.Text = "";
            lbl_resultCount.Text = "0件";

            try
            {
                
                var scraper = BaseScraper.factory(this.textBox1.Text);
                if (scraper == null)
                {
                    MessageBox.Show("規定サイト以外のURLが入力されました。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // パラメタ初期化
                var param = new Dictionary<string, object>();
                param.Add("city_name", this.txt_cityName.Text);
                param.Add("city_count", this.txt_count.Text);

                var resultList = await scraper.execute(param);
                var errMsg = scraper.getErrMessage();
                var infMsg = scraper.getInfoMessage();
                if (errMsg.Length > 0)
                {
                    MessageBox.Show(errMsg,
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (infMsg.Length > 0)
                {
                    MessageBox.Show(infMsg,
                        "情報",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                lbl_resultCount.Text = resultList.Count.ToString() + "件";
                textBox2.Text = string.Join("\r\n", resultList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                this.button1.Enabled = true;
                this.button1.Text = "実行";
            }
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                textBox2.SelectAll();
        }

        private void txt_count_Leave(object sender, EventArgs e)
        {
            int numValue;
            if(Int32.TryParse(this.txt_count.Text, out numValue))
            {
                this.txt_count.Text = numValue.ToString("#,0");
            }
        }
    }
}
