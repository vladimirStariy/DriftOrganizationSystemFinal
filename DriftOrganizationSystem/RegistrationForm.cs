using DriftOrganizationSystem.Domain.Entity;
using DriftOrganizationSystem.Service.Services;
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
    public partial class RegistrationForm : Form
    {
        private RegistrationService registrationService = new RegistrationService();

        public Registration Registration = new Registration();

        public RegistrationForm(string mode, uint Event_id)
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(MarkPlaceBox.Text != "")
            {
                Registration.Mark = Convert.ToDouble(MarkPlaceBox.Text);
            }
            if(MarkPlaceBox.Text != "")
            {
                Registration.Place = Convert.ToInt32(textBox1.Text);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void SlcButton_Click(object sender, EventArgs e)
        {
            SelectorForm SF = new SelectorForm("pilot");
            if (SF.ShowDialog() == DialogResult.OK)
            {
                var pilot = registrationService.GetPilotById(SF.selId);
                PilotBox.Text = pilot.Surname + " " + pilot.Name + " " + pilot.Fathername;
                Registration.Pilot_ID = SF.selId;
                SF.Close();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
