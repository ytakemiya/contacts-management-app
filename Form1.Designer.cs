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
            searchButton_Click = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addButton_Click = new Button();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton_Click
            // 
            searchButton_Click.Location = new Point(442, 16);
            searchButton_Click.Name = "searchButton_Click";
            searchButton_Click.Size = new Size(68, 23);
            searchButton_Click.TabIndex = 0;
            searchButton_Click.Text = "検索";
            searchButton_Click.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "name/telphone";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "※メール,memoは検索できません";
            // 
            // addButton_Click
            // 
            addButton_Click.Location = new Point(577, 40);
            addButton_Click.Name = "addButton_Click";
            addButton_Click.Size = new Size(57, 30);
            addButton_Click.TabIndex = 3;
            addButton_Click.Text = "追加";
            addButton_Click.UseVisualStyleBackColor = true;
            addButton_Click.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 8);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "・連絡先管理";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 23);
            textBox5.TabIndex = 6;
            textBox5.Text = "連絡先インポート";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(0, 75);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 23);
            textBox6.TabIndex = 7;
            textBox6.Text = "連絡先エクスポート";
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(-2, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 395);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-2, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 58);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(searchButton_Click);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(addButton_Click);
            panel3.Location = new Point(154, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(647, 70);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 73);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 11;
            label1.Text = "電話帳";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 20);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 0;
            label2.Text = "連絡先管理アプリ";
            // 
            // Top
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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

        private Button searchButton_Click;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addButton_Click;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
    }
}