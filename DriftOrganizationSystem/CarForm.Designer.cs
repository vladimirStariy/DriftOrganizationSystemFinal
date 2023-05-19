namespace DriftOrganizationSystem.View
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            Header = new Panel();
            HeaderLabel = new Label();
            AcceptButton = new Button();
            NameBox = new TextBox();
            EngineBox = new TextBox();
            PowerBox = new TextBox();
            FuelBox = new TextBox();
            WeightBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            Header.TabIndex = 5;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(10, 13);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(104, 25);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Машина";
            // 
            // AcceptButton
            // 
            AcceptButton.FlatStyle = FlatStyle.Popup;
            AcceptButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcceptButton.Location = new Point(25, 357);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(360, 55);
            AcceptButton.TabIndex = 6;
            AcceptButton.Text = "Принять";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(25, 92);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(360, 27);
            NameBox.TabIndex = 7;
            // 
            // EngineBox
            // 
            EngineBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EngineBox.Location = new Point(25, 146);
            EngineBox.Name = "EngineBox";
            EngineBox.Size = new Size(360, 27);
            EngineBox.TabIndex = 8;
            // 
            // PowerBox
            // 
            PowerBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PowerBox.Location = new Point(25, 200);
            PowerBox.Name = "PowerBox";
            PowerBox.Size = new Size(360, 27);
            PowerBox.TabIndex = 9;
            // 
            // FuelBox
            // 
            FuelBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FuelBox.Location = new Point(25, 254);
            FuelBox.Name = "FuelBox";
            FuelBox.Size = new Size(360, 27);
            FuelBox.TabIndex = 10;
            // 
            // WeightBox
            // 
            WeightBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WeightBox.Location = new Point(25, 308);
            WeightBox.Name = "WeightBox";
            WeightBox.Size = new Size(360, 27);
            WeightBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 68);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 12;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 122);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 13;
            label2.Text = "Тип двигателя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 176);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 14;
            label3.Text = "Мощность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 230);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 15;
            label4.Text = "Тип топлива";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 284);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 16;
            label5.Text = "Вес";
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
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 424);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WeightBox);
            Controls.Add(FuelBox);
            Controls.Add(PowerBox);
            Controls.Add(EngineBox);
            Controls.Add(NameBox);
            Controls.Add(AcceptButton);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarForm";
            Text = "CarForm";
            Load += CarForm_Load;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Header;
        private Label HeaderLabel;
        private Button AcceptButton;
        private TextBox NameBox;
        private TextBox EngineBox;
        private TextBox PowerBox;
        private TextBox FuelBox;
        private TextBox WeightBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel CloseBtn;
    }
}