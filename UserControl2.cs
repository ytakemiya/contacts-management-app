using contacts_management_app.Class;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
        //public object ErrorProvider1 { get; private set; }
        //public DataGridView DataGridView11 { get; }
        private Panel _parent;
        private Top _top;

        public UserControl2(Top myParent)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            bool Isfound = false;
            Control[] cs = myParent.Controls.Find("panelMain", Isfound);
            if (cs.Length > 0)
                _parent = ((Panel)cs[0]);
            _top = myParent;
        }


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

            try
            {
                //入力チェック
                if (string.IsNullOrEmpty(NAMEtextBox.Text))
                {
                    MessageBox.Show("名前を入力して下さい。");
                    NAMEtextBox.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(TELtextBox.Text))
                {
                    MessageBox.Show("電話番号を入力して下さい。");
                    TELtextBox.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(MAILtextBox.Text))
                {
                    MessageBox.Show("メールを入力して下さい。");
                    MAILtextBox.Focus();
                    return;
                }
                //データベースの接続
                con.Open();

                using var transaction = con.BeginTransaction();
                using var command = new SqlCommand() { Connection = con, Transaction = transaction };
                try
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    transaction.Commit();




                    _parent.Hide();
                    this.Close();
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
            //  連絡先全件表示
            _top.ShowAllContacts();



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

            _parent.Hide();
            this.Close();
            //panelMain.Show();
            //ScreenTransitionTo(panelMain);


            ////画面遷移
            ////ダイアログの戻り値をキャンセルに設定
            //this.DialogResult = DialogResult.Cancel;
            //Top f2 = new Top(); // 自フォームへの参照を渡す
            //Top Datagridview1 = new Top();
            //Datagridview1.Show(); // サブ・フォームを表示
        }

        private void DataGridView1(object sender, MouseEventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
