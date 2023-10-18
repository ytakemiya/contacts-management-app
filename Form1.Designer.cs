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
            textBox2 = new TextBox();
            AddButton = new Button();
            textBox3 = new TextBox();
            panel1 = new Panel();
            ExportButton = new Button();
            ImportButton = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            // textBox2
            // 
            textBox2.Location = new Point(570, 75);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "※メール,memoは検索できません";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(824, 67);
            AddButton.Margin = new Padding(4, 5, 4, 5);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(81, 50);
            AddButton.TabIndex = 3;
            AddButton.Text = "追加";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 13);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 31);
            textBox3.TabIndex = 4;
            textBox3.Text = "・連絡先管理";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(ExportButton);
            panel1.Controls.Add(ImportButton);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(-3, 92);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 658);
            panel1.TabIndex = 8;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(3, 136);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(216, 34);
            ExportButton.TabIndex = 9;
            ExportButton.Text = "連絡先エクスポート";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(4, 85);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(215, 34);
            ImportButton.TabIndex = 8;
            ImportButton.Text = "連絡先インポート";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-3, -2);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 97);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 0;
            label2.Text = "連絡先管理アプリ";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(SearchButton);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(AddButton);
            panel3.Location = new Point(220, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(924, 117);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 11;
            label1.Text = "電話帳";
            // 
            // Top
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Top";
            Text = "Top";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button AddButton;
        private TextBox textBox3;
        private Button ImportButton;
        private Button ExportButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
    }
}