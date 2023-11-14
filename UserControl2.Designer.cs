namespace contacts_management_app
{
    partial class UserControl2
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
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            MEMOtextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            Namelabel = new Label();
            MAILtextBox = new TextBox();
            TELtextBox = new TextBox();
            NAMEtextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(0, 0);
            CancelButton.Margin = new Padding(4, 5, 4, 5);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(194, 63);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "キャンセル";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(696, 0);
            SaveButton.Margin = new Padding(4, 5, 4, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(181, 63);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MEMOtextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Namelabel);
            panel1.Controls.Add(MAILtextBox);
            panel1.Controls.Add(TELtextBox);
            panel1.Controls.Add(NAMEtextBox);
            panel1.Location = new Point(0, 193);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 557);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(386, 202);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 9;
            label6.Text = "必須";
            label6.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(386, 113);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 9;
            label5.Text = "必須";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(386, 42);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 9;
            label1.Text = "必須";
            // 
            // MEMOtextBox
            // 
            MEMOtextBox.BackColor = Color.White;
            MEMOtextBox.Location = new Point(206, 308);
            MEMOtextBox.Margin = new Padding(4, 5, 4, 5);
            MEMOtextBox.MaxLength = 20;
            MEMOtextBox.Name = "MEMOtextBox";
            MEMOtextBox.Size = new Size(435, 31);
            MEMOtextBox.TabIndex = 4;
            MEMOtextBox.TextChanged += MemoTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 50);
            label3.TabIndex = 8;
            label3.Text = "       メール\r\n【半角英数字】";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 253);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 50);
            label4.TabIndex = 3;
            label4.Text = "  　　　メモ帳\r\n（注）20文字未満まで";
            label4.Click += Label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 50);
            label2.TabIndex = 3;
            label2.Text = "    電話番号\r\n  【半角数字】 ";
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(34, 35);
            Namelabel.Margin = new Padding(4, 0, 4, 0);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(107, 50);
            Namelabel.TabIndex = 7;
            Namelabel.Text = "    名前\r\n【全角文字】 ";
            Namelabel.Click += label1_Click;
            // 
            // MAILtextBox
            // 
            MAILtextBox.Location = new Point(171, 198);
            MAILtextBox.Margin = new Padding(4, 5, 4, 5);
            MAILtextBox.MaxLength = 30;
            MAILtextBox.Name = "MAILtextBox";
            MAILtextBox.Size = new Size(208, 31);
            MAILtextBox.TabIndex = 6;
            MAILtextBox.TextChanged += MAILtextBox_TextChanged;
            // 
            // TELtextBox
            // 
            TELtextBox.ImeMode = ImeMode.Disable;
            TELtextBox.Location = new Point(171, 110);
            TELtextBox.Margin = new Padding(4, 5, 4, 5);
            TELtextBox.MaxLength = 11;
            TELtextBox.Name = "TELtextBox";
            TELtextBox.ShortcutsEnabled = false;
            TELtextBox.Size = new Size(208, 31);
            TELtextBox.TabIndex = 6;
            TELtextBox.TextChanged += TELtextBox_TextChanged;
            TELtextBox.KeyPress += TELtextBox_KeyPress;
            // 
            // NAMEtextBox
            // 
            NAMEtextBox.Location = new Point(171, 35);
            NAMEtextBox.Margin = new Padding(4, 5, 4, 5);
            NAMEtextBox.MaxLength = 15;
            NAMEtextBox.Name = "NAMEtextBox";
            NAMEtextBox.Size = new Size(208, 31);
            NAMEtextBox.TabIndex = 6;
            NAMEtextBox.TextChanged += NAMEtextBox_TextChanged;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 750);
            Controls.Add(panel1);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserControl2";
            Text = "連絡先追加";
            Load += UserControl2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelButton;
        private Button SaveButton;
        private Panel panel1;
        private TextBox MAILtextBox;
        private TextBox TELtextBox;
        private TextBox NAMEtextBox;
        private Label Namelabel;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox MEMOtextBox;
        private Label label1;
        private Label label5;
        private Label label6;
    }
}