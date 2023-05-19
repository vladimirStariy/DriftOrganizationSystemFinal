using DriftOrganizationSystem.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriftOrganizationSystem.View
{
    public partial class OrganizatorForm : Form
    {
        private uint Organizator_ID;
        private string _mode;
        public Organizator organizator = new Organizator();

        public OrganizatorForm(string mode, uint id)
        {
            InitializeComponent();
            Organizator_ID = id;
            _mode = mode;
        }

        private void AcceptButton_Click_1(object sender, EventArgs e)
        {
            if (_mode == "add")
            {
                organizator = new Organizator();
                organizator.Surname = SurnameBox.Text;
                organizator.Name = NameBox.Text;
                organizator.FatherName = textBox2.Text;
                organizator.Position = PositionBox.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                organizator = new Organizator();
                organizator.Organizator_ID = Organizator_ID;
                organizator.Surname = SurnameBox.Text;
                organizator.Name = NameBox.Text;
                organizator.FatherName = textBox2.Text;
                organizator.Position = PositionBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
