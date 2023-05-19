namespace DriftOrganizationSystem.View
{
    partial class AchievementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AchievementForm));
            Header = new Panel();
            HeaderLabel = new Label();
            label1 = new Label();
            NameBox = new TextBox();
            label2 = new Label();
            PlaceBox = new TextBox();
            label3 = new Label();
            CarBox = new TextBox();
            label4 = new Label();
            YearBox = new TextBox();
            label5 = new Label();
            PrizeBox = new TextBox();
            AcceptButton = new Button();
            CloseBtn = new Panel();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.MediumPurple;
            Header.Controls.Add(CloseBtn);
            Header.Controls.Add(HeaderLabel);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(410, 50);
            Header.TabIndex = 1;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(25, 13);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(147, 25);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Достижение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 75);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 6;
            label1.Text = "Наименование";
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(25, 99);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(360, 27);
            NameBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 129);
            label2.Name = "label2";
            label2.Size = new Size(159, 21);
            label2.TabIndex = 8;
            label2.Text = "Место проведения";
            // 
            // PlaceBox
            // 
            PlaceBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceBox.Location = new Point(25, 153);
            PlaceBox.Name = "PlaceBox";
            PlaceBox.Size = new Size(360, 27);
            PlaceBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 183);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 10;
            label3.Text = "Машина";
            // 
            // CarBox
            // 
            CarBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CarBox.Location = new Point(25, 207);
            CarBox.Name = "CarBox";
            CarBox.Size = new Size(360, 27);
            CarBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 237);
            label4.Name = "label4";
            label4.Size = new Size(36, 21);
            label4.TabIndex = 12;
            label4.Text = "Год";
            // 
            // YearBox
            // 
            YearBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            YearBox.Location = new Point(25, 261);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(360, 27);
            YearBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 291);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 14;
            label5.Text = "Призовое место";
            // 
            // PrizeBox
            // 
            PrizeBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeBox.Location = new Point(25, 315);
            PrizeBox.Name = "PrizeBox";
            PrizeBox.Size = new Size(360, 27);
            PrizeBox.TabIndex = 13;
            // 
            // AcceptButton
            // 
            AcceptButton.FlatStyle = FlatStyle.Popup;
            AcceptButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcceptButton.Location = new Point(25, 364);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(360, 55);
            AcceptButton.TabIndex = 15;
            AcceptButton.Text = "Принять";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.MediumPurple;
            CloseBtn.BackgroundImage = (Image)resources.GetObject("CloseBtn.BackgroundImage");
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Location = new Point(360, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(40, 40);
            CloseBtn.TabIndex = 3;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // AchievementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 450);
            Controls.Add(AcceptButton);
            Controls.Add(label5);
            Controls.Add(PrizeBox);
            Controls.Add(label4);
            Controls.Add(YearBox);
            Controls.Add(label3);
            Controls.Add(CarBox);
            Controls.Add(label2);
            Controls.Add(PlaceBox);
            Controls.Add(label1);
            Controls.Add(NameBox);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AchievementForm";
            Text = "AchievementForm";
            Load += AchievementForm_Load;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Header;
        private Label HeaderLabel;
        private Label label1;
        private TextBox NameBox;
        private Label label2;
        private TextBox PlaceBox;
        private Label label3;
        private TextBox CarBox;
        private Label label4;
        private TextBox YearBox;
        private Label label5;
        private TextBox PrizeBox;
        private Button AcceptButton;
        private Panel CloseBtn;
    }
}