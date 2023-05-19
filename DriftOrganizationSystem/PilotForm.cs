using DriftOrganizationSystem.Domain.Viewmodels;
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
    public partial class PilotForm : Form
    {
        PilotService pilotService = new PilotService();
        uint pilotId;
        string mode;
        public PilotForm(uint Pilot_ID, string mode)
        {
            InitializeComponent();
            pilotId = Pilot_ID;
            this.mode = mode;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                PilotViewModel pilotViewModel = new PilotViewModel();
                pilotViewModel.Pilot_ID = pilotId;
                pilotViewModel.Name = NameBox.Text;
                pilotViewModel.Surname = SurnameBox.Text;
                pilotViewModel.Fathername = FatherNameBox.Text;
                pilotViewModel.Age = Convert.ToInt32(AgeBox.Text);
                pilotService.Edit(pilotViewModel);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                PilotViewModel pilotViewModel = new PilotViewModel();
                pilotViewModel.Name = NameBox.Text;
                pilotViewModel.Surname = SurnameBox.Text;
                pilotViewModel.Fathername = FatherNameBox.Text;
                pilotViewModel.Age = Convert.ToInt32(AgeBox.Text);
                pilotService.Create(pilotViewModel);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PilotForm_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                var pilot = pilotService.GetById(pilotId);
                NameBox.Text = pilot.Name;
                SurnameBox.Text = pilot.Surname;
                FatherNameBox.Text = pilot.Fathername;
                AgeBox.Text = pilot.Age.ToString();
            }
        }
    }
}
