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
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace contacts_management_app
{
    public partial class Top : Form
    {      
        private object ultaraGridExcelExpter1;



        public object UltraGrid1 { get; private set; }

        public Top()
        {
            // 最初のcommit
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// dataGridView1に連絡先データをバインド
        /// </summary>
        public void ShowAllContacts()
        {
            // DBから連絡先データを持ってくる
            DataTable dt = DBaccesser.GetData();
            dataGridView1.DataSource = dt;

            // データを追加
            // ContactList contactlist = new ContactList();
            // dataGridView1.DataSource = contactlist.Data;

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "TEL";
            dataGridView1.Columns[3].HeaderText = "MAIL";
            dataGridView1.Columns[4].HeaderText = "MEMO";
        }

        /// <summary>
        /// トップ画面表示後に連絡先データを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Top_Load(object sender, EventArgs e)
        {
            // dataGridView1に連絡先データをバインド
            ShowAllContacts();
            ScreenTransitionTo(dataGridView1);
        }

        /// <summary>
        /// 追加ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // UserControl2(追加画面)をpanel Main(画面遷移するパネル)に追加
            //form2 = new UserControl2
            UserControl2 userControl2 = new UserControl2(this)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            //userControl2.hoge();
            panelMain.Controls.Add(userControl2);
            

            // 追加画面表示
            userControl2.Show();
            panelMain.Show();
            ScreenTransitionTo(panelMain);
        }

        /// <summary>
        /// コントロールを最前面へ移動
        /// </summary>
        /// <param name="control"></param>
        private static void ScreenTransitionTo(Control control)
        {
            control.BringToFront();
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
            //UserControl2.Visibile = false;

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
                DataTable dt = DBaccesser.GetData($"SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'");
                dataGridView1.DataSource = dt;
            }

            //入力が文字列のみ場合は
            //　名前で連絡先検索
            //else それ以外で
            else
            {
                //textBox1.Text = Select();
                DataTable dt = DBaccesser.GetData($"SELECT * FROM contacts WHERE NAME LIKE '%{textBox1.Text}%'");
                dataGridView1.DataSource = dt;
            }

        }

        private static bool IsInputEmpty(TextBox inputTextboxt)
        {
            return inputTextboxt.Text == "";
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


        private void TextBox4_button_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tellabel_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            this.TopMost = true;
            panelMain.Controls.Remove(this);
        }

        private void StatusText_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

