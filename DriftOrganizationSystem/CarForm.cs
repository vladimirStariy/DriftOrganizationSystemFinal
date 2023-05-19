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
    public partial class CarForm : Form
    {
        uint pilotId;
        string mode;
        uint carId;
        CarService carService = new CarService();
        public CarForm(uint Pilot_ID, uint Car_ID, string mode)
        {
            InitializeComponent();
            pilotId = Pilot_ID;
            carId = Car_ID;
            this.mode = mode;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                CarViewModel model = new CarViewModel();
                model.Car_ID = carId;
                model.Pilot_ID = pilotId;
                model.Name = NameBox.Text;
                model.Engine = EngineBox.Text;
                model.Power = PowerBox.Text;
                model.FuelType = FuelBox.Text;
                model.Weight = Convert.ToDouble(WeightBox.Text);
                carService.Edit(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CarViewModel model = new CarViewModel();
                model.Pilot_ID = pilotId;
                model.Name = NameBox.Text;
                model.Engine = EngineBox.Text;
                model.Power = PowerBox.Text;
                model.FuelType = FuelBox.Text;
                model.Weight = Convert.ToDouble(WeightBox.Text);
                carService.Create(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                var car = carService.GetById(carId);
                NameBox.Text = car.Name;
                EngineBox.Text = car.EngineType;
                PowerBox.Text = car.Power;
                FuelBox.Text = car.FuelType;
                WeightBox.Text = car.Weight.ToString();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
