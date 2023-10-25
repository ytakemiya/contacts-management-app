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
            StatusStrip = new StatusStrip();
            StatusText = new ToolStripStatusLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MAILtextBox = new TextBox();
            TELtextBox = new TextBox();
            NAMEtextBox = new TextBox();
            label4 = new Label();
            MEMOtextBox = new TextBox();
            panel1.SuspendLayout();
            StatusStrip.SuspendLayout();
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
            panel1.Controls.Add(StatusStrip);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MAILtextBox);
            panel1.Controls.Add(TELtextBox);
            panel1.Controls.Add(NAMEtextBox);
            panel1.Location = new Point(0, 193);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 557);
            panel1.TabIndex = 2;
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(24, 24);
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusText });
            StatusStrip.Location = new Point(0, 525);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(877, 32);
            StatusStrip.TabIndex = 9;
            StatusStrip.Text = "StatusStrip";
            // 
            // StatusText
            // 
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(181, 25);
            StatusText.Text = "toolStripStatusLabel1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 8;
            label3.Text = "MAIL 【半角英数字】 必須";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 3;
            label2.Text = "TEL 【半角数字】 必須";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 7;
            label1.Text = "NAME 【全角文字】 必須";
            // 
            // MAILtextBox
            // 
            MAILtextBox.Location = new Point(244, 175);
            MAILtextBox.Margin = new Padding(4, 5, 4, 5);
            MAILtextBox.MaxLength = 30;
            MAILtextBox.Name = "MAILtextBox";
            MAILtextBox.Size = new Size(208, 31);
            MAILtextBox.TabIndex = 6;
            MAILtextBox.TextChanged += MAILtextBox_TextChanged;
            MAILtextBox.Validating += MAILtextBox_Validating;
            MAILtextBox.Validated += MAILtextBox_Validated;
            // 
            // TELtextBox
            // 
            TELtextBox.ImeMode = ImeMode.Disable;
            TELtextBox.Location = new Point(244, 97);
            TELtextBox.Margin = new Padding(4, 5, 4, 5);
            TELtextBox.MaxLength = 15;
            TELtextBox.Name = "TELtextBox";
            TELtextBox.ShortcutsEnabled = false;
            TELtextBox.Size = new Size(208, 31);
            TELtextBox.TabIndex = 6;
            TELtextBox.TextChanged += TELtextBox_TextChanged;
            TELtextBox.KeyPress += TELtextBox_KeyPress;
            // 
            // NAMEtextBox
            // 
            NAMEtextBox.Location = new Point(244, 35);
            NAMEtextBox.Margin = new Padding(4, 5, 4, 5);
            NAMEtextBox.MaxLength = 12;
            NAMEtextBox.Name = "NAMEtextBox";
            NAMEtextBox.Size = new Size(208, 31);
            NAMEtextBox.TabIndex = 6;
            NAMEtextBox.TextChanged += NAMEtextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 447);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 25);
            label4.TabIndex = 3;
            label4.Text = "（注）20文字未満まで";
            label4.Click += Label4_Click;
            // 
            // MEMOtextBox
            // 
            MEMOtextBox.BackColor = Color.Wheat;
            MEMOtextBox.Location = new Point(209, 477);
            MEMOtextBox.Margin = new Padding(4, 5, 4, 5);
            MEMOtextBox.Name = "MEMOtextBox";
            MEMOtextBox.Size = new Size(435, 31);
            MEMOtextBox.TabIndex = 4;
            MEMOtextBox.TextChanged += TextBox1_TextChanged;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 750);
            Controls.Add(MEMOtextBox);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserControl2";
            Text = "連絡先追加";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button SaveButton;
        private Panel panel1;
        private TextBox MAILtextBox;
        private TextBox TELtextBox;
        private TextBox NAMEtextBox;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox MEMOtextBox;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel StatusText;
    }
}