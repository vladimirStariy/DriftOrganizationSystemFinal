using DriftOrganizationSystem.Domain.Viewmodels;
using DriftOrganizationSystem.Service.Services;

namespace DriftOrganizationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PilotService pilotService = new PilotService();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            metroGrid1.DataSource = pilotService.GetPilots();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PilotViewModel model = new PilotViewModel();
            model.Name = "aaa";
            model.Surname = "bbb";
            model.Fathername = "ccc";
            model.Age = 10;
            pilotService.Create(model);
            //MessageBox.Show(response.Description.ToString());
        }
    }
}