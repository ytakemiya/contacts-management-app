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
using contacts_management_app.Class;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using ContactsTable = System.Data.DataTable;
using System.Data.Common;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace contacts_management_app
{
    public partial class Top : Form
    {
        private object ultaraGridExcelExpter1;

        ContactsTable ContactsTable1;
        ContactsTable dt;


        public object ContactsTable { get; private set; }


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
            //ContactsTable dt = DBaccesser.GetData();
            dt = DBaccesser.GetData();
            dataGridView1.DataSource = dt;

            // データを追加
            // ContactList contactlist = new ContactList();
            // dataGridView1.DataSource = contactlist.Data;
            //DataGridViewButtonColumnの作成
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "Button";
            //全てのボタンに"編集と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = "編集";

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "名前";
            dataGridView1.Columns[2].HeaderText = "電話番号";
            dataGridView1.Columns[3].HeaderText = "メール";
            dataGridView1.Columns[4].HeaderText = "メモ欄";
            //DataGridViewに追加する
            dataGridView1.Columns.Add(column);
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

            ContactsTable = new ContactsTable();

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

        public static void ExportButton_Click(object sender, EventArgs e)
        {
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            //sawai
            //共通部分
            string commonSELECT = "SELECT * FROM contacts ";
            string addWHERE;

            //共通していない部分は条件分岐する
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                //  何も追加しない
                addWHERE = "";
            }
            else if (Regex.IsMatch(textBox1.Text, @"^[0-9]+$"))
            {
                addWHERE = $" WHERE TEL LIKE '%{textBox1.Text}%'";

            }
            else
            {
                addWHERE = $" WHERE NAME LIKE '%{textBox1.Text}%'";
            }

            string excuteQuery = commonSELECT + addWHERE;

            //  "SELECT * FROM contacts "
            //  "SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'")"
            //  "SELECT * FROM contacts WHERE NAME LIKE '%{textBox1.Text}%'""
            //SQL実行させる
            ContactsTable dt =
                    DBaccesser.GetData(excuteQuery);
            dataGridView1.DataSource = dt;

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
                //ContactsTable dt = 
                //    DBaccesser.GetData($"SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'");
                //dataGridView1.DataSource = dt;
            }

            //入力が文字列のみ場合は
            //　名前で連絡先検索
            //else それ以外で
            else
            {
                ////textBox1.Text = Select();
                //ContactsTable dt = DBaccesser.GetData($"SELECT * FROM contacts WHERE NAME LIKE '%{textBox1.Text}%'");
                //dataGridView1.DataSource = dt;
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

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            this.TopMost = true;
            panelMain.Controls.Remove(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            int selectedID = 0;
            //選択された行を削除する
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var strID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(strID, out var num))
                {
                    selectedID = num;
                }
                dt.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                //削除するかユーザーに確認する
                //if (MessageBox.Show("この行を削除しますか？",
                //    "削除の確認",
                //    MessageBoxButtons.OKCancel,
                //    MessageBoxIcon.Question) != DialogResult.OK)
                //{
                //    return;
                //}


                // 接続文字列
                SqlConnection con = new("Data Source=DSP417; Initial Catalog=test_take; uid=sql_takemiya; pwd=sql_takemiya");
                // データ削除のSQL

                // SQL文をセットする
                string query = String.Format(@"DELETE FROM contacts WHERE ID = @ID");
                // string query = String.Format(@"SELECT * FROM contacts");
                try
                {

                    // コネクションを取得する
                    //using (var conn = new SqlConnection())

                    // コマンドを取得する
                    using (SqlCommand cmd = con.CreateCommand())
                    {



                        // コネクションをオープンする
                        con.Open();



                        // データ削除のSQLを実行します。
                        cmd.CommandText = query;
                        var param = new SqlParameter("@ID", SqlDbType.Int);
                        param.Value = selectedID;
                        cmd.Parameters.Add(param);
                        var result = cmd.ExecuteNonQuery();
                        // 実行された結果が1行ではない場合
                        if (result != 1)
                        {
                            Console.WriteLine("データを削除できませんでした。");
                        }
                    }
                }
                // 例外が発生した場合
                catch (SqlException ex)
                {
                    // 例外の内容を表示します。
                    Console.WriteLine(ex);
                }





            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "Button")
            {
                MessageBox.Show(e.RowIndex.ToString() +
                    "行のボタンがクリックされました。");
            }
        }

        //private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    // 表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
        //    if (e.Control is DataGridViewTextBoxEditingControl)
        //    {
        //        DataGridView dgv = (DataGridView)sender;

        //        //編集のために表示されているコントロールを取得
        //        DataGridViewTextBoxEditingControl tb =
        //            (DataGridViewTextBoxEditingControl)e.Control;
        //        //次のようにしてもよい
        //        //TextBox tb = (TextBox)e.Control;

        //        //列によってIMEのモードを変更する
        //        if (dgv.CurrentCell.OwningColumn.Name == "Column1")
        //            tb.ImeMode = ImeMode.Disable;
        //        else
        //            tb.ImeMode = dgv.ImeMode;
        //    }
        
    }
}

