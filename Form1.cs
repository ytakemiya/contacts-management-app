using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Data;
using contacts_management_app.contactClass;

namespace contacts_management_app
{
    public partial class Top : Form
    {
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
            Form f1 = new Form();
            f1.Visible = true;

            //��ʂ����
            this.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            //�����Ƀ{�^���N���b�N���̏������L�ڂ���B
            // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
            //if (���������{�b�N�X����̏ꍇ)

            //���X�g��S�\������

            //else if(����2)�����擾��

            //else ����ȊO��

            //���͂��󂩔��f����
            //���͂���̏ꍇ
            if (isInputEmpty(textBox1))
            {
                //  �A����S���\��
                ShowAllContacts();
            }



            //���͂��d�b�ԍ����ǂ���
            //�d�b�ԍ��̏ꍇ��
            // �d�b�ԍ��ŘA���挟��

            //���͂�������̂ݏꍇ��
            //�@���O�ŘA���挟��

        }
        private bool isInputEmpty(TextBox inputTextboxt)
        {
            return inputTextboxt.Text == "";
        }
        private void ShowAllContacts()
        {
            //DB����A����f�[�^�������Ă���


            //table��bind����

            //return 
        }

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
            // �f�[�^��ǉ�
            ContactList contactlist = new ContactList();
            dataGridView1.DataSource = contactlist.Data;

            // �J���������w��
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "TEL";
            dataGridView1.Columns[3].HeaderText = "MAIL";
            dataGridView1.Columns[4].HeaderText = "MEMO";
            //DataTable table = new DataTable("Table");

            // �J�������̒ǉ�
            //table.Columns.Add("ID");
            //table.Columns.Add("NAME");
            //table.Columns.Add("TEL");
            //table.Columns.Add("MAIL");
            //table.Columns.Add("MEMO");

            // Rows.Add���\�b�h���g���ăf�[�^��ǉ�
            //table.Rows.Add("1", "���{�E�M", "09092390645", "newchallenge3625@gmaail.com", "���ɂȂ�");
            //table.Rows.Add("2", "��ؓ�Y", "09023659876", "korin2543@gmail.com", "�����x��");
            //table.Rows.Add("3", "�����O�Y", "07056439745", "tokutoku0921@gmail.com", "�ے��㗝");
            //table.Rows.Add("4", "�O�r��O", "08043216674", "meizi0645@gmail.com", "�y���x��");

            //dataGridView1.DataSource = table;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {





        }


    }

}