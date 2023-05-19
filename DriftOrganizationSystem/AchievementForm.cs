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
    public partial class AchievementForm : Form
    {
        uint pilotId;
        string mode;
        uint achievementId;
        AchievementService achievementService = new AchievementService();

        public AchievementForm(uint Pilot_ID, uint Achievement_ID, string mode)
        {
            InitializeComponent();
            pilotId = Pilot_ID;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                AchievementViewModel model = new AchievementViewModel();
                model.Pilot_ID = pilotId;
                model.Achievement_ID = achievementId;
                model.Name = NameBox.Text;
                model.Place = PlaceBox.Text;
                model.Car = CarBox.Text;
                model.Year = YearBox.Text;
                model.Prize = PrizeBox.Text;
                achievementService.Edit(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                AchievementViewModel model = new AchievementViewModel();
                model.Pilot_ID = pilotId;
                model.Name = NameBox.Text;
                model.Place = PlaceBox.Text;
                model.Car = CarBox.Text;
                model.Year = YearBox.Text;
                model.Prize = PrizeBox.Text;
                achievementService.Create(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void AchievementForm_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                var model = achievementService.GetById(pilotId);
                NameBox.Text = model.Name;
                PlaceBox.Text = model.Place;
                CarBox.Text = model.Car;
                YearBox.Text = model.Year;
                PrizeBox.Text = model.Prize;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
