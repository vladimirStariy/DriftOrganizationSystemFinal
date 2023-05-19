using DriftOrganizationSystem.Domain.Entity;
using DriftOrganizationSystem.Service.Services;
using MetroFramework.Controls;
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
    public partial class MainForm : Form
    {
        PilotService pilotService = new PilotService();
        EventService eventService = new EventService();

        int checker = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PilotGrid.DataSource = pilotService.GetPilots();
            PilotGrid.Columns[0].Visible = false;

            metroGrid.DataSource = eventService.GetEvents();
            metroGrid.Columns[0].Visible = false;

            try
            {
                AutoGrid.DataSource = pilotService.GetPilotCars(Convert.ToInt32(PilotGrid.Rows[0].Cells[0].Value));
                AutoGrid.Columns[0].Visible = false;
                AutoGrid.Columns[1].Visible = false;

                AchievementGrid.DataSource = pilotService.GetPilotAchievements(Convert.ToInt32(PilotGrid.Rows[0].Cells[0].Value));
                AchievementGrid.Columns[0].Visible = false;
                AchievementGrid.Columns[1].Visible = false;

                checker = 1;
            }
            catch
            {

            }
        }

        private void PilotButton_Click(object sender, EventArgs e)
        {

        }

        private void PilotAddButton_Click(object sender, EventArgs e)
        {
            PilotForm PF = new PilotForm(0, "add");
            if(PF.ShowDialog() == DialogResult.OK)
            {
                PilotGrid.DataSource = pilotService.GetPilots();           
            }
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CarForm PF = new CarForm(Convert.ToUInt32(PilotGrid.SelectedRows[0].Cells[0].Value), 0, "add");
                if (PF.ShowDialog() == DialogResult.OK)
                {
                    AutoGrid.DataSource = pilotService.GetPilotCars(Convert.ToInt32(PilotGrid.SelectedRows[0].Cells[0].Value));
                    AutoGrid.Columns[0].Visible = false;
                    AutoGrid.Columns[1].Visible = false;
                    checker = 1;
                }
            }
            catch
            {
                MessageBox.Show("Выберите пилота");
            }
        }

        private void PilotGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (checker == 1)
                {
                    AutoGrid.DataSource = pilotService.GetPilotCars(Convert.ToInt32(PilotGrid.SelectedRows[0].Cells[0].Value));
                    AchievementGrid.DataSource = pilotService.GetPilotAchievements(Convert.ToInt32(PilotGrid.SelectedRows[0].Cells[0].Value));
                }
                    

            }
            catch
            {

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                AchievementForm AF = new AchievementForm(Convert.ToUInt32(PilotGrid.SelectedRows[0].Cells[0].Value), 0, "add");
                if (AF.ShowDialog() == DialogResult.OK)
                {
                    AchievementGrid.DataSource = pilotService.GetPilotAchievements(Convert.ToInt32(PilotGrid.SelectedRows[0].Cells[0].Value));
                    AutoGrid.Columns[0].Visible = false;
                    AutoGrid.Columns[1].Visible = false;
                    checker = 1;
                }
            }
            catch
            {
                MessageBox.Show("Выберите пилота");
            }
        }

        private void OrganizatorEditButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CarForm CF = new CarForm(Convert.ToUInt32(PilotGrid.SelectedRows[0].Cells[0].Value), Convert.ToUInt32(AutoGrid.SelectedRows[0].Cells[0].Value), "edit");
                if (CF.ShowDialog() == DialogResult.OK)
                {
                    AutoGrid.DataSource = pilotService.GetPilotCars(Convert.ToInt32(PilotGrid.SelectedRows[0].Cells[0].Value));
                    AutoGrid.Columns[0].Visible = false;
                    AutoGrid.Columns[1].Visible = false;
                    checker = 1;
                }
            }
            catch
            {
                MessageBox.Show("Выберите пилота");
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try 
            {
                EventForm EF = new EventForm(0, "add");
                if (EF.ShowDialog() == DialogResult.OK)
                {
                    metroGrid.DataSource = eventService.GetEvents();
                    metroGrid.Columns[0].Visible = false;
                }
            }
            catch
            {

            }

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            var model = eventService.GetEventViewModelById(Convert.ToUInt32(metroGrid.SelectedRows[0].Cells[0].Value));
            EventForm EF = new EventForm(Convert.ToUInt32(metroGrid.SelectedRows[0].Cells[0].Value), "edit");
            if (EF.ShowDialog() == DialogResult.OK)
            {
                metroGrid.DataSource = eventService.GetEvents();
                metroGrid.Columns[0].Visible = false;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            HeaderLabel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            Header.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
