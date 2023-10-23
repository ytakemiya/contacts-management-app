using contacts_management_app.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //DBから連絡先データを持ってくる
            //DBから連絡先データを持ってくる
            //DBaccesser dbA = new DBaccesser();
            //DataTable dt = dbA.GetData($"SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'");
            //dataGridView1.DataSource = dt;
            DBaccesser dbA = new DBaccesser();
            //DataTable dt = dbA.GetData($"INSERT INTO contacts(NAME, TEL, MAIL, MEMO) VALUES(NAME='徳永浩二', TEL=09023458765, MAIL=mamorniriu@gmail.com, MEMO='特になし'));
            dbA.GetData($"INSERT INTO contacts VALUES(5, '徳永浩二', '09023458765', 'mamo1376@gmail.com', '特になし')");

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
