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


namespace contacts_management_app
{
    public partial class Top : Form
    {

        private object ultaraGridExcelExpter1;

        ContactsTable ContactsTable1;
        ContactsTable dt;


        public object ContactsTable { get; private set; }


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
            //ContactsTable dt = DBaccesser.GetData();
            dt = DBaccesser.GetData();
            dataGridView1.DataSource = dt;


            // �f�[�^��ǉ�
            // ContactList contactlist = new ContactList();
            // dataGridView1.DataSource = contactlist.Data;
            //DataGridViewButtonColumn�̍쐬
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            DataGridViewButtonColumn column1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn column2 = new DataGridViewButtonColumn();
            //��̖��O��ݒ�
            column.Name = "�ҏW";
            column1.Name = "�X�V";
            column2.Name = "�L�����Z��";
            //�S�Ẵ{�^����"�ҏW�ƕ\������
            column.UseColumnTextForButtonValue = true;
            column1.UseColumnTextForButtonValue = true;
            column2.UseColumnTextForButtonValue = true;
            column.Text = "�ҏW";
            column1.Text = "�X�V";
            column2.Text = "�L�����Z��";
            // �J���������w��
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "���O";
            dataGridView1.Columns[2].HeaderText = "�d�b�ԍ�";
            dataGridView1.Columns[3].HeaderText = "���[��";
            dataGridView1.Columns[4].HeaderText = "������";
            //DataGridView�ɒǉ�����
            dataGridView1.Columns.Add(column);
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }
            //dgv.Rows[e.RowIndex].ReadOnly = false;
            
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

            ContactsTable = new ContactsTable();


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
            string selectedPath = "";

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                // �����I���t�H���_�[���ݒ�ł���@
                //dialog.SelectedPath = @"C:\User\";
                // �t�@�C�������w��A�擾����A
                dialog.Description = @"ForOutput.csv";

                // �V�����t�H���_���쐬��������A
                dialog.ShowNewFolderButton = true;

                // �_�C�A���O��\������B
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // �I�����ꂽ�t�H���_���擾����
                    selectedPath = dialog.SelectedPath;

                    MessageBox.Show(string.Format("{0}���I������܂���", selectedPath));
                }
                else
                {
                    // �L�����Z���̏ꍇ�͉������Ȃ�
                }
                string msg = "";


                // �f�[�^���Ȃ���Ώ����𔲂���
                if (dataGridView1.RowCount <= 0)
                {
                    msg = "�o�̓f�[�^������܂���B";
                    MessageBox.Show(msg, "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //// �m�F�u�͂��v�łȂ���Ώ����𔲂���
                //msg = "CSV�t�@�C�����o�͂��܂��B" + "\n" + "�X�����ł����H";
                //MessageBox.Show(msg, "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result != DialogResult.Yes)
                //{
                //    return;
                //}
                //UTF8�̏㏑�����[�h�Ńt�@�C�����J��
                using (StreamWriter sw = new StreamWriter(selectedPath + @"ForOutput.csv", false, System.Text.Encoding.UTF8))
                {
                    // ���[�N������
                    string s = "";

                    //CountIndex = dataGridView1.Columns["�ҏW"].Index; 

                    // �w�b�_�[�o��
                    // �s���[�v
                    for (int iCol = 0; iCol < dataGridView1.Columns["�ҏW"].Index; iCol++)
                    {
                        
                        // �w�b�_�[�̒l���擾����
                        String sCell = dataGridView1.Columns[iCol].HeaderCell.Value.ToString();

                        // 2��ڈȍ~�Ȃ烏�[�N������Ɂu,�v��ǉ�����
                        if (iCol > 0)
                        {
                            s += ",";
                        }

                        // ���[�N������ɃZ���̒l��ǉ�����
                        s += quoteCommaCheck(sCell);

                    }
                    // ���[�N��������t�@�C���ɏo�͂���
                    sw.WriteLine(s);


                    // �f�[�^�o��
                    // �s���[�v
                    for (int iRow = 0; iRow < dataGridView1.Rows.Count; iRow++)
                    {
                        // ���[�N����������
                        s = "";

                        // �񃋁[�v
                        for (int iCol = 0; iCol < dataGridView1.Columns["�ҏW"].Index; iCol++)
                        {
                            // �Z���̒l���擾����
                            String sCell = dataGridView1[iCol, iRow].Value.ToString();

                            // 2��ڈȍ~�Ȃ烏�[�N������Ɂu,�v��ǉ�����
                            if (iCol > 0)
                            {
                                s += ",";
                            }

                            // ���[�N������ɃZ���̒l��ǉ�����
                            s += quoteCommaCheck(sCell);

                        }
                        // ���[�N��������t�@�C���ɏo�͂���
                        sw.WriteLine(s);
                    
                    }
                    msg = "CSV�o�͂��������܂����B";
                    MessageBox.Show(msg, "���", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }
        /// <summary>
        /// �J���}��؂�𕶎���Ƃ݂Ȃ�
        /// </summary>
        /// <param name="sCell"></param>
        /// <returns></returns>
        private string quoteCommaCheck(string sCell)
        {
            const string QUOTE = @""""; // �u"�v
            const string COMMA = @",";  // �u,�v

            // OR�����p������
            string[] a = new string[] { QUOTE, COMMA };

            // �Z���̒l�Ɂu�h�v���u,�v���܂܂�Ă��Ȃ������肷��
            if (a.Any(sCell.Contains))
            {
                // �u"�v���u"�v�ň͂�
                sCell = sCell.Replace(QUOTE, QUOTE + QUOTE);

                // �Z���̒l���u"�v�ň͂�
                sCell = QUOTE + sCell + QUOTE;
            }
            return sCell;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //sawai
            //���ʕ���
            string commonSELECT = "SELECT * FROM contacts ";
            string addWHERE;

            //���ʂ��Ă��Ȃ������͏������򂷂�
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                //  �����ǉ����Ȃ�
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
            //SQL���s������
            ContactsTable dt =
                    DBaccesser.GetData(excuteQuery);
            dataGridView1.DataSource = dt;


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

        private void Tellabel_Click(object sender, EventArgs e)
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            int selectedID = 0;
            //�I�����ꂽ�s���폜����
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var strID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(strID, out var num))
                {
                    selectedID = num;
                }
                dt.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                //�폜���邩���[�U�[�Ɋm�F����
                //if (MessageBox.Show("���̍s���폜���܂����H",
                //    "�폜�̊m�F",
                //    MessageBoxButtons.OKCancel,
                //    MessageBoxIcon.Question) != DialogResult.OK)
                //{
                //    return;
                //}


                // �ڑ�������
                SqlConnection con = new("Data Source=DSP417; Initial Catalog=test_take; uid=sql_takemiya; pwd=sql_takemiya");


                // SQL�����Z�b�g����
                string query = String.Format(@"DELETE FROM contacts WHERE ID = @ID");
                try
                {

                    // �R�l�N�V�������擾����
                    //using (var conn = new SqlConnection())

                    // �R�}���h���擾����
                    using (SqlCommand cmd = con.CreateCommand())
                    {

                        // �R�l�N�V�������I�[�v������
                        con.Open();

                        // �f�[�^�폜��SQL�����s���܂��B
                        cmd.CommandText = query;
                        var param = new SqlParameter("@ID", SqlDbType.Int);
                        param.Value = selectedID;
                        cmd.Parameters.Add(param);
                        var result = cmd.ExecuteNonQuery();
                        // ���s���ꂽ���ʂ�1�s�ł͂Ȃ��ꍇ
                        if (result != 1)
                        {
                            Console.WriteLine("�f�[�^���폜�ł��܂���ł����B");
                        }
                    }
                }
                // ��O�����������ꍇ
                catch (SqlException ex)
                {
                    // ��O�̓��e��\�����܂��B
                    Console.WriteLine(ex);
                }


            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;

            //"Button"��Ȃ�΁A�{�^�����N���b�N���ꂽ
            if (dgv.Columns[e.ColumnIndex].Name == "�ҏW")
            {
                //�ҏW�{�^���������ꂽ�s��ҏW�\�ɂ���
                dgv.Rows[e.RowIndex].ReadOnly = false;
                //�s�P�ʂőI��������
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //�w�b�_�[���܂܂Ȃ����ׂẴZ���̔w�i�F�����F�ɂ���
                dgv.RowsDefaultCellStyle.BackColor = Color.Yellow;
                //�Z���X�^�C����ύX����
                //dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                //dgv[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;

                //TODO:datagridview�S��\���̂��߁A�N���b�N����columnButton(�ҏW)���\���ɂ���
               
                //�{�^����\��
                dgv.Columns[5].Visible = false;
                dgv.Columns[6].Visible = true;
                dgv.Columns[7].Visible = true;

            }

            //"Button"��Ȃ�΁A�{�^�����N���b�N���ꂽ
            else if (dgv.Columns[e.ColumnIndex].Name == "�X�V")
            {
                //�e�Z���̒l���擾����
                //dataGridView dgv = SelectedCells(0).RowIndex;
                dgv.Columns[5].Visible = true;

                dgv.Rows[e.RowIndex].ReadOnly = true;
                //for (int i = 0; i < dataGridView1.RowCount; i++)
                //{
                //    dataGridView1.Rows[i].ReadOnly = true;
                //}
                //// �ڑ���������w�肵�ăf�[�^�x�[�X���w��
                SqlConnection con = new("Data Source=DSP417; Initial Catalog=test_take; uid=sql_takemiya; pwd=sql_takemiya");
                // �f�[�^�X�V��SQL
                DBaccesser.UpdateData();

                string query = String.Format(@"UPDATE contacts SET Mail= 'komadatai0111@gmail.com'  WHERE ID = '1055'");
                //string query = String.Format(@"UPDATE contacts SET NAME= '�x�]'  WHERE ID = '1057'");
                try
                {
                    // �R�}���h���擾����
                    using (SqlCommand cmd = con.CreateCommand())
                    {

                        // �R�l�N�V�������I�[�v������
                        con.Open();

                        //// �f�[�^�X�V��SQL�����s���܂�
                        cmd.CommandText = query;
                        //cmd.Parameters.Add(new SqlParameter("@ID", sqlDbType.Int, 4, "ID");
                        //cmd.Parameters.Add(new SqlParameter("@NAME", sqlDbType.NVarChar, 50, "NAME");
                        //var result = cmd.ExecuteNonQuery();
                        //���R�[�h���폜���邽�߂�SQL�����쐬
                        //string Delete_SQL = "delete from contacts where NAME = '���{�E�M'";

                        //���łɂ���MySQL�R�}���h��SQL���������ւ�
                        //cmd.CommandText = Delete_SQL;
                        //ShowAllContacts();
                        // DB����A����f�[�^�������Ă���
                        //ContactsTable dt = DBaccesser.GetData();
                        dt = DBaccesser.GetData();
                        dataGridView1.DataSource = dt;
                        
                    }
                }
                // ��O�����������ꍇ
                catch (SqlException ex)
                {
                    // ��O�̓��e��\�����܂��B
                    Console.WriteLine(ex);
                }
            }

            else if (dgv.Columns[e.ColumnIndex].Name == "�L�����Z��")
            {
                dgv.Columns[5].Visible = true;
                dgv.Rows[e.RowIndex].ReadOnly = true;

                //for (int i = 0; i < dataGridView1.RowCount; i++)
                //{
                //    dataGridView1.Rows[i].ReadOnly = true;
                //}
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

        //private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    DataGridView dgv = (DataGridView)sender;
        //    //�ҏW�ł��邩���f����
        //    if (dgv.Columns[e.ColumnIndex].Name == "Column1" &&
        //        !(bool)dgv["Column2", e.RowIndex].Value)
        //    {
        //        //�ҏW�ł��Ȃ��悤�ɂ���
        //        e.Cancel = true;
        //    }

        //}
    }

}

