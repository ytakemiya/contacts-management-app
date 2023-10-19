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
            //form2.Show();
            form2.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
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

            //入力が空か判断する
            //入力が空の場合
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                //  連絡先全件表示
                ShowAllContacts();
            }



            //入力が電話番号かどうか
            //電話番号の場合は
            // 電話番号で連絡先検索

            else if (Regex.IsMatch(textBox1.Text, @"^[0-9]+$"))
            {

            }

            //入力が文字列のみ場合は
            //　名前で連絡先検索


        }
        private bool isInputEmpty(TextBox inputTextboxt)
        {
            return inputTextboxt.Text == "";
        }
        private void ShowAllContacts()
        {
            //DBから連絡先データを持ってくる


            //tableにbindする

            //return 

            // データを追加
            ContactList contactlist = new ContactList();
            dataGridView1.DataSource = contactlist.Data;

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "TEL";
            dataGridView1.Columns[3].HeaderText = "MAIL";
            dataGridView1.Columns[4].HeaderText = "MEMO";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Top_Load(object sender, EventArgs e)
        {
            //ShowAllContacts();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {





        }

    }

}