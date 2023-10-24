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
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //��ʑJ�ځ[contact_saveButton
            //Form1��\��
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            //form2.Show();
            ScreenTransitionTo(panel6);
            form2.Show();
            panel6.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            public void ConvertDataTableToCsv(
                DataTable dt, string csvPath, bool writeHeader)
            {

                //CSV�t�@�C���ɏ������ނƂ��Ɏg��Encoding
                System.Text.Encoding enc =
                System.Text.Encoding.GetEncoding("Shift_JIS");

                //�������ރt�@�C�����J��
                System.IO.StreamWriter sr =
                new System.IO.StreamWriter(csvPath, false, enc);

                int colCount = dt.Columns.Count;
                int lastColIndex = colCount - 1;
                //�w�b�_����������
                if (writeHeader)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        //�w�b�_�̎擾
                        string field = dt.Columns[i].Caption;
                        //"�ň͂�
                        field = EncloseDoubleQuotesIfNeed(field);
                        //�t�B�[���h����������
                        sr.Write(field);
                        //�J���}����������
                        if (lastColIndex > i)
                        {
                            sr.Write(',');
                        }
                    }
                    //���s����
                    sr.Write("\r\n");
                }
                //���R�[�h����������
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        //�t�B�[���h�̎擾
                        string field = row[i].ToString();
                        //"�ň͂�
                        field = EncloseDoubleQuotesIfNeed(field);
                        //�t�B�[���h����������
                        sr.Write(field);
                        //�J���}����������
                        if (lastColIndex > i)
                        {
                            sr.Write(',');
                        }
                    }
                    //���s����
                    sr.Write("\r\n");
                }

                //����
                sr.Close();
            }


        }
    



        private void SearchButton_Click(object sender, EventArgs e)
        {
            //�����Ƀ{�^���N���b�N���̏������L�ڂ���B
            // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
            //if (���������{�b�N�X����̏ꍇ           
            //���X�g��S�\������
            //���͂��󂩔��f����
            //���͂���̏ꍇ
            //UserControl2.Visibile = false;

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
            else
            {
                //textBox1.Text = Select();
                DBaccesser dbA = new DBaccesser();
                DataTable dt = dbA.GetData($"SELECT * FROM contacts WHERE NAME LIKE '%{textBox1.Text}%'");
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
            form2 = new UserControl2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            panel6.Controls.Add(form2);
            ScreenTransitionTo(dataGridView1);


        }

        private void ScreenTransitionTo(Control control)
        {
            control.BringToFront();
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

        private void StatusText_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}