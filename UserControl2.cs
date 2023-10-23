using contacts_management_app.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Collections.Generic;

namespace contacts_management_app
{
    public partial class UserControl2 : Form
    {
        public UserControl2()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }


        enum StrKind
        {
            mix, //全角半角混在
            full, //全角のみ
            half //半角のみ
        };

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        { 
            string query = String.Format("INSERT INTO [contacts] ( NAME, TEL, MAIL, MEMO ) VALUES ( '{0}','{1}','{2}','{3}' );", NAMEtextBox.Text, TELtextBox, MAILtextBox, MEMOtextBox);
            
            using (SqlConnection con = new SqlConnection("Data Source=ServerName; Initial Catalog=DatabaseName; uid=UserName; pwd=Password"))
            {
                try
                {
                    //データベースの接続
                    con.Open();

                    using (var transaction = con.BeginTransaction())
                    using (var command = new SqlCommand() { Connection = con, Transaction = transaction })
                    {
                        try
                        {
                           // コマンドのセット
                            command.CommandText = query;
                            //コマンドの実行
                            command.ExecuteNonQuery();
                            //コミット
                            transaction.Commit();
                        }
                        catch
                        {
                            //ロールバック
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                finally
                {
                    // データベースの接続終了
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
            //string text = MAILtextBox.Text;
            // 空白の場合はそのまま
            //if (text.Length == 0)
            return;

            // ひらがなと空白のみ
            //Regex rx = new Regex(@"^[^@\s]+[@]([^.\s]+[.]){1,}[^.\s]+$");
            //if (!rx.IsMatch(text))
            {
                //this.errorProvider1.SetError(MAILtextBox, "正しくないメールアドレスの形式です");
                // e.Cancel = true;

            }
        }
        private void MAILtextBox_Validated(object sender, EventArgs e)
        {
            // 検証済みの場合はエラーをクリアする
            //this.errorProvider1.SetError(MAILtextBox, null);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
