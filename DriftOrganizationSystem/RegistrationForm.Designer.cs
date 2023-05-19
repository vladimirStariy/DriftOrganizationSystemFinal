namespace DriftOrganizationSystem.View
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.Header = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarkPlaceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PilotBox = new System.Windows.Forms.TextBox();
            this.SlcButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.MediumPurple;
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.HeaderLabel);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(395, 50);
            this.Header.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.CloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.BackgroundImage")));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Location = new System.Drawing.Point(345, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(25, 13);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(148, 25);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Регистрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Очки";
            // 
            // MarkPlaceBox
            // 
            this.MarkPlaceBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MarkPlaceBox.Location = new System.Drawing.Point(18, 139);
            this.MarkPlaceBox.Name = "MarkPlaceBox";
            this.MarkPlaceBox.Size = new System.Drawing.Size(360, 27);
            this.MarkPlaceBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Пилот";
            // 
            // PilotBox
            // 
            this.PilotBox.Enabled = false;
            this.PilotBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PilotBox.Location = new System.Drawing.Point(18, 86);
            this.PilotBox.Name = "PilotBox";
            this.PilotBox.Size = new System.Drawing.Size(313, 27);
            this.PilotBox.TabIndex = 11;
            // 
            // SlcButton
            // 
            this.SlcButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SlcButton.Location = new System.Drawing.Point(337, 86);
            this.SlcButton.Name = "SlcButton";
            this.SlcButton.Size = new System.Drawing.Size(41, 27);
            this.SlcButton.TabIndex = 18;
            this.SlcButton.Text = "...";
            this.SlcButton.UseVisualStyleBackColor = true;
            this.SlcButton.Click += new System.EventHandler(this.SlcButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Место";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(18, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 27);
            this.textBox1.TabIndex = 19;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(18, 249);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(360, 47);
            this.AcceptButton.TabIndex = 21;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 337);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SlcButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarkPlaceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PilotBox);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Header;
        private Panel CloseBtn;
        private Label HeaderLabel;
        private Label label3;
        private TextBox MarkPlaceBox;
        private Label label1;
        private TextBox PilotBox;
        private Button SlcButton;
        private Label label2;
        private TextBox textBox1;
        private Button AcceptButton;
    }
}