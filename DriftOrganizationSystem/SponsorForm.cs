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
    public partial class SponsorForm : Form
    {
        private uint _id;
        private string _mode;
        public Sponsor sponsor = new Sponsor();

        public SponsorForm(uint id, string mode)
        {
            InitializeComponent();
            _id = id;
            _mode = mode;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_mode == "add")
            {
                sponsor = new Sponsor();
                sponsor.SponsorName = ContactFaceBox.Text;
                sponsor.ContactFace = ContactFaceBox.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                sponsor = new Sponsor();
                sponsor.Sponsor_ID = _id;
                sponsor.SponsorName = ContactFaceBox.Text;
                sponsor.ContactFace = ContactFaceBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CloseBtn_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
