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
    public partial class SelectorForm : Form
    {
        public string _gridMode;
        PilotService pilotService = new PilotService();
        //OrganizatorService organizatorService = new OrganizatorService();
        //SponsorService sponsorService = new SponsorService();
        //JudgeService judgeService = new JudgeService(); 
        public uint selId;

        public SelectorForm(string GridMode)
        {
            InitializeComponent();
            _gridMode = GridMode;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            selId = Convert.ToUInt32(SelectorDataGrid.SelectedRows[0].Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            if(_gridMode == "pilot")
            {
                SelectorDataGrid.DataSource = pilotService.GetPilots();
            }
            else
            if(_gridMode == "organizator")
            {

            }
            else
            if(_gridMode == "sponsor")
            {

            }
            else
            if(_gridMode == "judge")
            {

            }
        }
    }
}
