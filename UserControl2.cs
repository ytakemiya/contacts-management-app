using contacts_management_app.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Collections.Generic;

namespace contacts_management_app
{
    public partial class UserControl2 : Form
    {
        public Form form2;
        //public object ErrorProvider1 { get; private set; }
        //public DataGridView DataGridView11 { get; }

        public UserControl2()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        //public UserControl2(DataGridView dataGridView1)
        //{
        //    DataGridView11 = dataGridView1;
        //}

        enum StrKind
        {
            mix,    // 全角半角混在
            full,   // 全角のみ
            half    // 半角のみ
        };

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// コントロールを最前面へ移動
        /// </summary>
        /// <param name="control"></param>
        private static void ScreenTransitionTo(Control control)
        {
            control.BringToFront();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string query = String.Format("INSERT INTO [contacts] ( NAME, TEL, MAIL, MEMO ) VALUES ( '{0}','{1}','{2}','{3}' );", NAMEtextBox.Text, TELtextBox.Text, MAILtextBox.Text, MEMOtextBox.Text);
            // 接続文字列を指定してデータベースを指定
            //using (SqlConnection con = new SqlConnection("Data Source=DSP417; Initial Catalog=test_take; uid=sql_takemiya; pwd=sql_takemiya"))
            SqlConnection con = new("Data Source=DSP417; Initial Catalog=test_take; uid=sql_takemiya; pwd=sql_takemiya");
            {
                try
                {
                    //データベースの接続
                    con.Open();

                    using var transaction = con.BeginTransaction();
                    using var command = new SqlCommand() { Connection = con, Transaction = transaction };
                    try
                    {
                        // コマンドのセット
                        command.CommandText = query;
                        //コマンドの実行
                        command.ExecuteNonQuery();
                        //コミット
                        transaction.Commit();

                        MessageBox.Show("保存しますか？");

                        DialogResult result = MessageBox.Show("保存しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        Top Datagridviw1 = new Top();
                        Datagridviw1.Show(); // サブ・フォームを表示
                        if (result == DialogResult.Yes)
                        {
                            StatusText.Text = "保存しました"; //変更
                        }
                        else
                        {
                            StatusText.Text = "キャンセルしました"; //←変更
                        }
                    }
                    catch
                    {

                        //ロールバック
                        transaction.Rollback();
                        throw;
                    }
                }

                catch (SqlException sqlex)
                {
                    Console.WriteLine(sqlex.Message);
                    throw;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                finally
                {
                    con.Close();
                }

            }
        }


        private void NAMEtextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void TELtextBox_TextChanged(object sender, EventArgs e)
        {
            // 0-9のみ
            //TELtextBox = !new Regex.IsMatch("^[0-9]+$");
        }

        private void MAILtextBox_TextChanged(object sender, EventArgs e)
        {
            // 文字列の先頭から末尾までが、英数字のみとマッチするかを調べる。
            //return (Regex.IsMatch(Text, @"^[0-9a-zA-Z]+$"));

        }

        private void TELtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MAILtextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = MAILtextBox.Text;
            // 空白の場合はそのまま
            if (text.Length == 0)
                return;

            // ひらがなと空白のみ
            Regex rx = new(@"^[^@\s]+[@]([^.\s]+[.]){1,}[^.\s]+$");
            if (!rx.IsMatch(text))
            {

                // _ = ErrorProvider1.SetError(MAILtextBox, "正しくないメールアドレスの形式です");

                // e.Cancel = true;

            }
        }

        private void MAILtextBox_Validated(object sender, EventArgs e)
        {
            // 検証済みの場合はエラーをクリアする
            //this.errorProvider1.SetError(MAILtextBox, null);

        }

        /// <summary>
        /// キャンセルボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
             
            //sawaisawaisawai
            //ScreenTransitionTo(dataGridView1);

            ////画面遷移
            ////ダイアログの戻り値をキャンセルに設定
            //this.DialogResult = DialogResult.Cancel;
            //Top f2 = new Top(); // 自フォームへの参照を渡す
            Top Datagridviw1 = new Top();
            Datagridviw1.Show(); // サブ・フォームを表示
        }

        private void DataGridView1(object sender, MouseEventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
