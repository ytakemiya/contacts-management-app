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
            // �ŏ���commit
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// dataGridView1�ɘA����f�[�^���o�C���h
        /// </summary>
        public void ShowAllContacts()
        {
            // DB����A����f�[�^�������Ă���
            DataTable dt = DBaccesser.GetData();
            dataGridView1.DataSource = dt;

            // �f�[�^��ǉ�
            // ContactList contactlist = new ContactList();
            // dataGridView1.DataSource = contactlist.Data;

            // �J���������w��
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "TEL";
            dataGridView1.Columns[3].HeaderText = "MAIL";
            dataGridView1.Columns[4].HeaderText = "MEMO";
        }

        /// <summary>
        /// �g�b�v��ʕ\����ɘA����f�[�^��\������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Top_Load(object sender, EventArgs e)
        {
            // dataGridView1�ɘA����f�[�^���o�C���h
            ShowAllContacts();
            ScreenTransitionTo(dataGridView1);
        }

        /// <summary>
        /// �ǉ��{�^���N���b�N
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // UserControl2(�ǉ����)��panel Main(��ʑJ�ڂ���p�l��)�ɒǉ�
            //form2 = new UserControl2
            UserControl2 userControl2 = new UserControl2(this)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            //userControl2.hoge();
            panelMain.Controls.Add(userControl2);
            

            // �ǉ���ʕ\��
            userControl2.Show();
            panelMain.Show();
            ScreenTransitionTo(panelMain);
        }

        /// <summary>
        /// �R���g���[�����őO�ʂֈړ�
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
                DataTable dt = DBaccesser.GetData($"SELECT * FROM contacts WHERE TEL LIKE '%{textBox1.Text}%'");
                dataGridView1.DataSource = dt;
            }

            //���͂�������̂ݏꍇ��
            //�@���O�ŘA���挟��
            //else ����ȊO��
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

