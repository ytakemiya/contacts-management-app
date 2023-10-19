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
            //�ŏ���commit
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 12;//�e�L�X�g�{�b�N�X�̍ő啶������ݒ肷��
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //��ʑJ�ځ[contact_saveButton
            //Form1��\��
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            form2.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            //�����Ƀ{�^���N���b�N���̏������L�ڂ���B
            // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
            //if (���������{�b�N�X����̏ꍇ           
            //���X�g��S�\������
            //���͂��󂩔��f����
            //���͂���̏ꍇ
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                //  �A����S���\��
                ShowAllContacts();
            }
            //else if(����2)�����擾��
            //���͂��d�b�ԍ����ǂ���
            //�d�b�ԍ��̏ꍇ��
            // �d�b�ԍ��ŘA���挟��

            else if (Regex.IsMatch(textBox1.Text, @"^[0-9]+$"))
            {
                //DB����A����f�[�^�������Ă���
                DBaccesser dbA = new DBaccesser();
                DataTable dt = dbA.GetData($"SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'");
                dataGridView1.DataSource = dt;
            }

            //���͂�������̂ݏꍇ��
            //�@���O�ŘA���挟��
            //else ����ȊO��
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
            //DB����A����f�[�^�������Ă���
            DBaccesser dbA = new DBaccesser();
            DataTable dt = dbA.GetData();
            dataGridView1.DataSource = dt;

            //table��bind����

            //return 

            // �f�[�^��ǉ�
            //ContactList contactlist = new ContactList();
            // dataGridView1.DataSource = contactlist.Data;

            // �J���������w��
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "TEL";
            dataGridView1.Columns[3].HeaderText = "MAIL";
            dataGridView1.Columns[4].HeaderText = "MEMO";

        }
        public static class RegexUtils
        {
            /// <summary>
            /// �w�肳�ꂽ�����񂪓d�b�ԍ����ǂ�����Ԃ��܂�
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