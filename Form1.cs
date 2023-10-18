using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace contacts_management_app
{
    public partial class Top : Form
    {
        public Top()
        {
            //最初のcommit
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.MaxLength = 12;//テキストボックスの最大文字数を設定する
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //画面遷移ーcontact_saveButton
            //Form1を表示
            Form f1 = new Form();
            f1.Visible = true;

            //画面を閉じる
            this.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //ここにボタンクリック時の処理を記載する。
            // ボタンがクリックされたときに呼び出されるメソッド
            //if (条件検索ボックスが空の場合)
            //リストを全表示する

            //else if(条件2)数字取得で

            //else それ以外で
        }

        private void textBox4_button_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}