using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //textBox1.MaxLength = 12;//�e�L�X�g�{�b�N�X�̍ő啶������ݒ肷��
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

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}