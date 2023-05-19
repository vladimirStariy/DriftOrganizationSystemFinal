namespace DriftOrganizationSystem.View
{
    partial class PilotForm
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
            Header = new Panel();
            panel1 = new Panel();
            HeaderLabel = new Label();
            SurnameBox = new TextBox();
            NameBox = new TextBox();
            FatherNameBox = new TextBox();
            AgeBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AcceptBtn = new Button();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.MediumPurple;
            Header.Controls.Add(panel1);
            Header.Controls.Add(HeaderLabel);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(410, 50);
            Header.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(360, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(40, 40);
            panel1.TabIndex = 14;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(10, 13);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(74, 25);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Пилот";
            // 
            // SurnameBox
            // 
            SurnameBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameBox.Location = new Point(25, 91);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(360, 27);
            SurnameBox.TabIndex = 5;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(25, 145);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(359, 27);
            NameBox.TabIndex = 6;
            // 
            // FatherNameBox
            // 
            FatherNameBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FatherNameBox.Location = new Point(25, 199);
            FatherNameBox.Name = "FatherNameBox";
            FatherNameBox.Size = new Size(359, 27);
            FatherNameBox.TabIndex = 7;
            // 
            // AgeBox
            // 
            AgeBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgeBox.Location = new Point(26, 253);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(359, 27);
            AgeBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 67);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 9;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 121);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 10;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 175);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 11;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 229);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 12;
            label4.Text = "Возраст";
            // 
            // AcceptBtn
            // 
            AcceptBtn.FlatStyle = FlatStyle.Popup;
            AcceptBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcceptBtn.Location = new Point(26, 286);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(358, 58);
            AcceptBtn.TabIndex = 13;
            AcceptBtn.Text = "Принять";
            AcceptBtn.UseVisualStyleBackColor = true;
            AcceptBtn.Click += AcceptBtn_Click;
            // 
            // PilotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 368);
            Controls.Add(AcceptBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AgeBox);
            Controls.Add(FatherNameBox);
            Controls.Add(NameBox);
            Controls.Add(SurnameBox);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PilotForm";
            Text = "PilotForm";
            Load += PilotForm_Load;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Header;
        private Panel panel1;
        private Label HeaderLabel;
        private TextBox SurnameBox;
        private TextBox NameBox;
        private TextBox FatherNameBox;
        private TextBox AgeBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AcceptBtn;
    }
}