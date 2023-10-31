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
            DeleteButton = new Button();
            panelMain = new Panel();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(480, 16);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(68, 23);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "検索";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            SearchButton.Enter += TextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(688, 40);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(57, 30);
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
            panel3.Location = new Point(154, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 70);
            panel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.ForeColor = Color.Peru;
            panel5.Location = new Point(6, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(638, 363);
            panel5.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 48);
            label4.Name = "label4";
            label4.Size = new Size(162, 15);
            label4.TabIndex = 12;
            label4.Text = "※メール,memoは検索できません";
            // 
            // Tellabel
            // 
            Tellabel.AutoSize = true;
            Tellabel.BackColor = SystemColors.ButtonFace;
            Tellabel.Location = new Point(3, 3);
            Tellabel.Name = "Tellabel";
            Tellabel.Size = new Size(43, 15);
            Tellabel.TabIndex = 11;
            Tellabel.Text = "電話帳";
            Tellabel.Click += Tellabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 15);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 10;
            label3.Text = "・連絡先管理";
            label3.Click += Label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 218);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 69);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 14;
            label7.Click += Label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 324);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 16;
            // 
            // ExportButton
            // 
            ExportButton.BackColor = SystemColors.GradientInactiveCaption;
            ExportButton.Location = new Point(0, 43);
            ExportButton.Margin = new Padding(2, 2, 2, 2);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(160, 24);
            ExportButton.TabIndex = 9;
            ExportButton.Text = "連絡先エクスポート";
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.BackColor = SystemColors.GradientInactiveCaption;
            ImportButton.Location = new Point(0, 69);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(160, 24);
            ImportButton.TabIndex = 18;
            ImportButton.Text = "連絡先インポート";
            ImportButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Location = new Point(336, 187);
            label5.Name = "label5";
            label5.Size = new Size(1, 23);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 24);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 0;
            label2.Text = "連絡先管理アプリ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 70);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(ImportButton);
            panel2.Controls.Add(ExportButton);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 556);
            panel2.TabIndex = 21;
            panel2.Paint += Panel2_Paint_1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(DeleteButton);
            panel4.Controls.Add(Tellabel);
            panel4.Location = new Point(160, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(739, 21);
            panel4.TabIndex = 22;
            // 
            // DeleteButton
            // 
            DeleteButton.ForeColor = Color.Black;
            DeleteButton.Location = new Point(127, 0);
            DeleteButton.Margin = new Padding(2, 2, 2, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(78, 21);
            DeleteButton.TabIndex = 19;
            DeleteButton.Text = "削除";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.MistyRose;
            panelMain.Location = new Point(160, 91);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(742, 536);
            panelMain.TabIndex = 24;
            panelMain.Visible = false;
            panelMain.Paint += Panel6_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(160, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 533);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick_2;
            // 
            // Top
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 623);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(panelMain);
            ForeColor = Color.Black;
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
        private Panel panelMain;
        private DataGridView dataGridView1;
        private Button DeleteButton;
    }
}