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
using System.Drawing.Text;
using System.Security.AccessControl;
using static System.Net.WebRequestMethods;
using System.Reflection;

namespace contacts_management_app
{
    public partial class Top : Form
    {

        private object ultaraGridExcelExpter1;
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
        private void datagridviewclmVisible()
        {
            dataGridView1.Columns["編集"].Visible = true;
            dataGridView1.Columns["更新"].Visible = false;
            dataGridView1.Columns["キャンセル"].Visible = false;
        }
        private void datagridviewreadOnly()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }

        }
   



        /// <summary>
        /// dataGridView1に連絡先データをバインド
        /// </summary>
        public void ShowAllContacts()
        {

            // DBから連絡先データを持ってくる
            //ContactsTable dt = DBaccesser.GetData();
            this.dt = DBaccesser.GetData();
            dataGridView1.DataSource = this.dt;


            datagridviewclmVisible();

            datagridviewreadOnly();


        }
        private void datagridviewFirstconfig()
        {
            // DBから連絡先データを持ってくる
            //ContactsTable dt = DBaccesser.GetData();
            dt = DBaccesser.GetData();
            dataGridView1.DataSource = dt;
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
            dataGridView1.Columns["更新"].Visible = false;
            dataGridView1.Columns["キャンセル"].Visible = false;

            datagridviewreadOnly();
         
        }
        

        /// <summary>
        /// トップ画面表示後に連絡先データを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Top_Load(object sender, EventArgs e)
        {
            

            //dataGridView1に連絡先データをバインド
           
            datagridviewFirstconfig();
            ScreenTransitionTo(dataGridView1);
            dataGridView1.AutoGenerateColumns = false;
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

            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                // 初期選択フォルダーが設定できる�@
                //保存先の初期値
                
                // ファイル名を指定、取得する�A
                dlg.Description = @"ForOutput.csv";

                // 新しくフォルダを作成を許可する�A
                dlg.ShowNewFolderButton = true;

                // ダイアログを表示する。
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // 選択されたフォルダを取得する
                    selectedPath = dlg.SelectedPath;

                    MessageBox.Show(string.Format("{0}が選択されました", selectedPath));
                }
                else
                {
                    return;
                }
                string msg = "";


                // データがなければ処理を抜ける
                if (dataGridView1.RowCount <= 0)
                {
                    msg = "出力データがありません。";
                    MessageBox.Show(msg, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                

                //UTF8の上書きモードでファイルを開く
                using (StreamWriter sw = new StreamWriter(selectedPath + @"\ForOutput.csv", false, System.Text.Encoding.UTF8))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this. dt = DBaccesser.GetData(excuteQuery);

            dataGridView1.DataSource = dt;

            datagridviewclmVisible();

            datagridviewreadOnly();


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



                // 接続文字列
                SqlConnection con = new("Data Source=DSP417; Initial Catalog=test_take; uid=sql_takemiya; pwd=ty21133202");


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
      
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

            DataGridView dgv = (DataGridView)sender;
        


            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "編集")
            {
                //セルスタイルを変更する
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                dgv[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;

                //行単位で選択をする
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //ヘッダーを含まないすべてのセルの背景色を黄色にする
                //dgv.RowsDefaultCellStyle.BackColor = Color.Yellow;

                //ボタン非表示
                //[5]編集[6]更新[7]キャンセル
                dataGridView1.Columns["編集"].Visible = false;
                dataGridView1.Columns["更新"].Visible = true;
                dataGridView1.Columns["キャンセル"].Visible = true;
                //編集ボタンが押された行を編集可能にする
                dgv.Rows[e.RowIndex].ReadOnly = false;


            }

            //"Button"列ならば、ボタンがクリックされた
            else if (dgv.Columns[e.ColumnIndex].Name == "更新")
            {
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                dgv[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;


                // GridViewの選択行の値を変数に入れる
                string NAME = (string)dataGridView1.CurrentRow.Cells[1].Value;
                string TEL = (string)dataGridView1.CurrentRow.Cells[2].Value;
                string Mail = (string)dataGridView1.CurrentRow.Cells[3].Value;
                string Memo = (string)dataGridView1.CurrentRow.Cells[4].Value;
                int ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                //string name = "武宮さんタスク：選択されているGridViewのNAMEの値をnameに入れる";
                //string tel = "武宮さんタスク：選択されているGridViewのTELの値をtelに入れる";
                //string mail = "武宮さんタスク：選択されているGridViewのMailの値をmailに入れる";
                //string memo = "武宮さんタスク：選択されているGridViewのMEMOの値をmemoに入れる";
                //int id = 0;         // "武宮さんタスク：選択されているGridViewのIDの値をidに入れる ";

                // データ更新のSQL
                DBaccesser da = new DBaccesser();
                da.UpdateData(NAME, TEL, Mail, Memo, ID);

                string query = String.Format(@"UPDATE contacts SET NAME=@NAME,TEL=@TEL,Mail=@Mail,Memo=@Memo WHERE ID=@ID");
                //string query = String.Format(@"UPDATE contacts SET NAME= '堀江'  WHERE ID = '1057'")

                dt = DBaccesser.GetData();
                dataGridView1.DataSource = dt;



                datagridviewclmVisible();
                //dgv.Rows[e.RowIndex].ReadOnly = true;
                datagridviewreadOnly();
            }

            else if (dgv.Columns[e.ColumnIndex].Name == "キャンセル")
            {
                datagridviewclmVisible();
                dgv.Rows[e.RowIndex].ReadOnly = true;


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

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //ヘッダー以外のセル
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                //セルスタイルを元に戻す
                //セルスタイルを削除するなら、nullを設定してもよい
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;
                dgv[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Empty;


            }
        }
    }

}

