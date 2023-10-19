namespace contacts_management_app
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CancelButton = new Button();
            SaveButton = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(0, 0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(136, 38);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "キャンセル";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(487, 0);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(127, 38);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Location = new Point(0, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 149);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 108);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 8;
            label3.Text = "メール 【半角英数字】 必須";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 66);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 3;
            label2.Text = "電話番号 【半角数字】 必須";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 7;
            label1.Text = "名前 【全角文字】 必須";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(171, 105);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(147, 23);
            textBox9.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(171, 58);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(147, 23);
            textBox8.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(171, 18);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(147, 23);
            textBox7.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 268);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 3;
            label4.Text = "（注）20文字未満まで";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Wheat;
            textBox1.Location = new Point(146, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Name = "Form2";
            Text = "連絡先追加";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button SaveButton;
        private Panel panel1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
    }
}