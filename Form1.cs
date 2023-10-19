using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Data;
using contacts_management_app.contactClass;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
//using System.Text.RegularExpressions;
using contacts_management_app.Class;

namespace contacts_management_app
{
    public partial class Top : Form
    {
        private Form form2;

        public Top()

        {
            //最初のcommit
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 12;//テキストボックスの最大文字数を設定する
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //画面遷移ーcontact_saveButton
            //Form1を表示
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            form2.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            //ここにボタンクリック時の処理を記載する。
            // ボタンがクリックされたときに呼び出されるメソッド
            //if (条件検索ボックスが空の場合           
            //リストを全表示する
            //入力が空か判断する
            //入力が空の場合
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                //  連絡先全件表示
                ShowAllContacts();
            }
            //else if(条件2)数字取得で
            //入力が電話番号かどうか
            //電話番号の場合は
            // 電話番号で連絡先検索

            else if (Regex.IsMatch(textBox1.Text, @"^[0-9]+$"))
            {
                //DBから連絡先データを持ってくる
                DBaccesser dbA = new DBaccesser();
                DataTable dt = dbA.GetData($"SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'");
                dataGridView1.DataSource = dt;
            }

            //入力が文字列のみ場合は
            //　名前で連絡先検索
            //else それ以外で
            else (String.Contains(textBox1.Text(""))
            { 
                DBaccesser dbA = new DBaccesser();
                DataTable dt = dbA.GetData($"SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'");
                dataGridView1.DataSource = dt;
            }

        }
        private bool isInputEmpty(TextBox inputTextboxt)
        {
            return inputTextboxt.Text == "";
        }
        private void ShowAllContacts()
        {
            //DBから連絡先データを持ってくる
            DBaccesser dbA = new DBaccesser();
            DataTable dt = dbA.GetData();
            dataGridView1.DataSource = dt;

            //tableにbindする

            //return 

            // データを追加
            //ContactList contactlist = new ContactList();
            // dataGridView1.DataSource = contactlist.Data;

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "TEL";
            dataGridView1.Columns[3].HeaderText = "MAIL";
            dataGridView1.Columns[4].HeaderText = "MEMO";

        }
        public static class RegexUtils
        {
            /// <summary>
            /// 指定された文字列が電話番号かどうかを返します
            /// </summary>
            public static bool IsPhoneNumber(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return false;
                }
                return Regex.IsMatch(input, @"^[0-9]+$");
            }
        }
        //class PhoneFormatter
        //{
        //public static string FormatPhNumber(string phoneNum, string phoneFormat)
        //{
        // if (phoneFormat == "")
        //{
        //phoneFormat = "#########";
        //}
        //Regex regex = new Regex(@"[^\d]");
        //phoneNum = regex.Replace(phoneNum, "");
        // if (phoneNum.Length > 0)
        //{
        // phoneNum = Convert.ToInt64(phoneNum).ToString(phoneFormat);
        // }
        // return phoneNum;
        //}

        //}

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Top_Load(object sender, EventArgs e)
        {
            ShowAllContacts();
            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            panel6.Controls.Add(form2);

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tellabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}