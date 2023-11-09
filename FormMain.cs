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
using System.Collections.ObjectModel;
using System.Windows;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.IO;


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
            DataGridViewButtonColumn column1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn column2 = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "編集";
            column1.Name = "更新";
            column2.Name = "キャンセル";
            //全てのボタンに"編集と表示する
            column.UseColumnTextForButtonValue = true;
            column1.UseColumnTextForButtonValue = true;
            column2.UseColumnTextForButtonValue = true;
            column.Text = "編集";
            column1.Text = "更新";
            column2.Text = "キャンセル";
            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "名前";
            dataGridView1.Columns[2].HeaderText = "電話番号";
            dataGridView1.Columns[3].HeaderText = "メール";
            dataGridView1.Columns[4].HeaderText = "メモ欄";
            //DataGridViewに追加する
            dataGridView1.Columns.Add(column);
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }
            //dgv.Rows[e.RowIndex].ReadOnly = false;
            
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

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string selectedPath = "";

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                // 初期選択フォルダーが設定できる①
                //dialog.SelectedPath = @"C:\User\";
                // ファイル名を指定、取得する②
                dialog.Description = @"ForOutput.csv";

                // 新しくフォルダを作成を許可する②
                dialog.ShowNewFolderButton = true;

                // ダイアログを表示する。
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // 選択されたフォルダを取得する
                    selectedPath = dialog.SelectedPath;

                    MessageBox.Show(string.Format("{0}が選択されました", selectedPath));
                }
                else
                {
                    // キャンセルの場合は何もしない
                }
                string msg = "";


                // データがなければ処理を抜ける
                if (dataGridView1.RowCount <= 0)
                {
                    msg = "出力データがありません。";
                    MessageBox.Show(msg, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //// 確認「はい」でなければ処理を抜ける
                //msg = "CSVファイルを出力します。" + "\n" + "宜しいですか？";
                //MessageBox.Show(msg, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result != DialogResult.Yes)
                //{
                //    return;
                //}
                //UTF8の上書きモードでファイルを開く
                using (StreamWriter sw = new StreamWriter(selectedPath + @"ForOutput.csv", false, System.Text.Encoding.UTF8))
                {
                    // ワーク文字列言
                    string s = "";

                    //CountIndex = dataGridView1.Columns["編集"].Index; 

                    // ヘッダー出力
                    // 行ループ
                    for (int iCol = 0; iCol < dataGridView1.Columns["編集"].Index; iCol++)
                    {
                        
                        // ヘッダーの値を取得する
                        String sCell = dataGridView1.Columns[iCol].HeaderCell.Value.ToString();

                        // 2列目以降ならワーク文字列に「,」を追加する
                        if (iCol > 0)
                        {
                            s += ",";
                        }

                        // ワーク文字列にセルの値を追加する
                        s += quoteCommaCheck(sCell);

                    }
                    // ワーク文字列をファイルに出力する
                    sw.WriteLine(s);


                    // データ出力
                    // 行ループ
                    for (int iRow = 0; iRow < dataGridView1.Rows.Count; iRow++)
                    {
                        // ワーク文字初期化
                        s = "";

                        // 列ループ
                        for (int iCol = 0; iCol < dataGridView1.Columns["編集"].Index; iCol++)
                        {
                            // セルの値を取得する
                            String sCell = dataGridView1[iCol, iRow].Value.ToString();

                            // 2列目以降ならワーク文字列に「,」を追加する
                            if (iCol > 0)
                            {
                                s += ",";
                            }

                            // ワーク文字列にセルの値を追加する
                            s += quoteCommaCheck(sCell);

                        }
                        // ワーク文字列をファイルに出力する
                        sw.WriteLine(s);
                    
                    }
                    msg = "CSV出力が完了しました。";
                    MessageBox.Show(msg, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }
        /// <summary>
        /// カンマ区切りを文字列とみなす
        /// </summary>
        /// <param name="sCell"></param>
        /// <returns></returns>
        private string quoteCommaCheck(string sCell)
        {
            const string QUOTE = @""""; // 「"」
            const string COMMA = @",";  // 「,」

            // OR検索用文字列
            string[] a = new string[] { QUOTE, COMMA };

            // セルの値に「”」か「,」が含まれていないか判定する
            if (a.Any(sCell.Contains))
            {
                // 「"」を「"」で囲む
                sCell = sCell.Replace(QUOTE, QUOTE + QUOTE);

                // セルの値を「"」で囲む
                sCell = QUOTE + sCell + QUOTE;
            }
            return sCell;
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

        private void Tellabel_Click(object sender, EventArgs e)
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


                // SQL文をセットする
                string query = String.Format(@"DELETE FROM contacts WHERE ID = @ID");
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
            if (dgv.Columns[e.ColumnIndex].Name == "編集")
            {
                //編集ボタンが押された行を編集可能にする
                dgv.Rows[e.RowIndex].ReadOnly = false;
                //行単位で選択をする
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //ヘッダーを含まないすべてのセルの背景色を黄色にする
                dgv.RowsDefaultCellStyle.BackColor = Color.Yellow;
                //セルスタイルを変更する
                //dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                //dgv[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;

                //TODO:datagridview全非表示のため、クリックしたcolumnButton(編集)を非表示にする
               
                //ボタン非表示
                dgv.Columns[5].Visible = false;
                dgv.Columns[6].Visible = true;
                dgv.Columns[7].Visible = true;

            }

            //"Button"列ならば、ボタンがクリックされた
            else if (dgv.Columns[e.ColumnIndex].Name == "更新")
            {
                //各セルの値を取得する
                //dataGridView dgv = SelectedCells(0).RowIndex;
                dgv.Columns[5].Visible = true;

                dgv.Rows[e.RowIndex].ReadOnly = true;
                //for (int i = 0; i < dataGridView1.RowCount; i++)
                //{
                //    dataGridView1.Rows[i].ReadOnly = true;
                //}
                //// 接続文字列を指定してデータベースを指定
                SqlConnection con = new("Data Source=DSP417; Initial Catalog=test_take; uid=sql_takemiya; pwd=sql_takemiya");
                // データ更新のSQL
                DBaccesser.UpdateData();

                string query = String.Format(@"UPDATE contacts SET Mail= 'komadatai0111@gmail.com'  WHERE ID = '1055'");
                //string query = String.Format(@"UPDATE contacts SET NAME= '堀江'  WHERE ID = '1057'");
                try
                {
                    // コマンドを取得する
                    using (SqlCommand cmd = con.CreateCommand())
                    {

                        // コネクションをオープンする
                        con.Open();

                        //// データ更新のSQLを実行します
                        cmd.CommandText = query;
                        //cmd.Parameters.Add(new SqlParameter("@ID", sqlDbType.Int, 4, "ID");
                        //cmd.Parameters.Add(new SqlParameter("@NAME", sqlDbType.NVarChar, 50, "NAME");
                        //var result = cmd.ExecuteNonQuery();
                        //レコードを削除するためのSQL文を作成
                        //string Delete_SQL = "delete from contacts where NAME = '武宮勇貴'";

                        //すでにあるMySQLコマンドのSQL文を差し替え
                        //cmd.CommandText = Delete_SQL;
                        //ShowAllContacts();
                        // DBから連絡先データを持ってくる
                        //ContactsTable dt = DBaccesser.GetData();
                        dt = DBaccesser.GetData();
                        dataGridView1.DataSource = dt;
                        
                    }
                }
                // 例外が発生した場合
                catch (SqlException ex)
                {
                    // 例外の内容を表示します。
                    Console.WriteLine(ex);
                }
            }

            else if (dgv.Columns[e.ColumnIndex].Name == "キャンセル")
            {
                dgv.Columns[5].Visible = true;
                dgv.Rows[e.RowIndex].ReadOnly = true;

                //for (int i = 0; i < dataGridView1.RowCount; i++)
                //{
                //    dataGridView1.Rows[i].ReadOnly = true;
                //}
            }

        }


        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    DataGridView dgv = (DataGridView)sender;
        //    //編集できるか判断する
        //    if (dgv.Columns[e.ColumnIndex].Name == "Column1" &&
        //        !(bool)dgv["Column2", e.RowIndex].Value)
        //    {
        //        //編集できないようにする
        //        e.Cancel = true;
        //    }

        //}
    }

}

