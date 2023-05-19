using DriftOrganizationSystem.Domain.Entity;

namespace DriftOrganizationSystem.View
{
    public partial class JudgeForm : Form
    {
        private uint _id;
        private string _mode;
        public Judge judge = new Judge();

        public JudgeForm(uint id, string mode)
        {
            InitializeComponent();
            _id = id;
            _mode = mode;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_mode == "add")
            {
                judge = new Judge();
                judge.Surname = SurnameBox.Text;
                judge.Name = NameBox.Text;
                judge.FatherName = textBox2.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                judge = new Judge();
                judge.Judge_ID = _id;
                judge.Surname = SurnameBox.Text;
                judge.Name = NameBox.Text;
                judge.FatherName = textBox2.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
