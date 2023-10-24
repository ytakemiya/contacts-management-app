namespace contacts_management_app
{
    partial class Top
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchButton = new Button();
            textBox1 = new TextBox();
            AddButton = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            Tellabel = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            ExportButton = new Button();
            ImportButton = new Button();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(631, 27);
            SearchButton.Margin = new Padding(4, 5, 4, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(97, 38);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "検索";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            SearchButton.Enter += textBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 27);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 31);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(824, 55);
            AddButton.Margin = new Padding(4, 5, 4, 5);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(81, 50);
            AddButton.TabIndex = 3;
            AddButton.Text = "追加";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(SearchButton);
            panel3.Controls.Add(AddButton);
            panel3.Location = new Point(220, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(924, 117);
            panel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.ForeColor = Color.Peru;
            panel5.Location = new Point(9, 175);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(911, 605);
            panel5.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(248, 25);
            label4.TabIndex = 12;
            label4.Text = "※メール,memoは検索できません";
            // 
            // Tellabel
            // 
            Tellabel.AutoSize = true;
            Tellabel.BackColor = SystemColors.ButtonFace;
            Tellabel.Location = new Point(4, 5);
            Tellabel.Margin = new Padding(4, 0, 4, 0);
            Tellabel.Name = "Tellabel";
            Tellabel.Size = new Size(66, 25);
            Tellabel.TabIndex = 11;
            Tellabel.Text = "電話帳";
            Tellabel.Click += Tellabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 10;
            label3.Text = "・連絡先管理";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 363);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 115);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 14;
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(676, 540);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 16;
            // 
            // ExportButton
            // 
            ExportButton.BackColor = SystemColors.GradientInactiveCaption;
            ExportButton.Location = new Point(0, 72);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(229, 40);
            ExportButton.TabIndex = 9;
            ExportButton.Text = "連絡先エクスポート";
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.BackColor = SystemColors.GradientInactiveCaption;
            ImportButton.Location = new Point(0, 115);
            ImportButton.Margin = new Padding(4, 5, 4, 5);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(229, 40);
            ImportButton.TabIndex = 18;
            ImportButton.Text = "連絡先インポート";
            ImportButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Location = new Point(480, 312);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(1, 38);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 0;
            label2.Text = "連絡先管理アプリ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 117);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(ImportButton);
            panel2.Controls.Add(ExportButton);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 118);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 662);
            panel2.TabIndex = 21;
            panel2.Paint += panel2_Paint_1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(Tellabel);
            panel4.Location = new Point(229, 117);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(916, 35);
            panel4.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(229, 152);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(923, 618);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.AppWorkspace;
            panel6.Location = new Point(232, 152);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(916, 623);
            panel6.TabIndex = 24;
            panel6.Visible = false;
            panel6.Paint += panel6_Paint;
            // 
            // Top
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 773);
            Controls.Add(dataGridView1);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(panel3);
            ForeColor = Color.Black;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Top";
            Text = "Top";
            Load += Top_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox textBox1;
        private Button AddButton;
        private Panel panel3;
        private Label Tellabel;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Button ExportButton;
        private Button ImportButton;
        private Label label5;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Panel panel6;
    }
}