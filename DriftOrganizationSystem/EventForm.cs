using DriftOrganizationSystem.Domain.Entity;
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
    public partial class EventForm : Form
    {
        private uint eventId;
        private string mode;

        RegistrationService registrationService = new RegistrationService();
        EventService eventService = new EventService();
        
        private List<Judge> _localJudges = new List<Judge>();
        private List<Registration> _localRegistrations = new List<Registration>();
        private List<Organizator> _localOrganizators = new List<Organizator>();
        private List<Sponsor> _localSponsors = new List<Sponsor>();

        public List<RegistrationViewModel> registrationViewModels;
        public List<OrganizatorViewModel> organizatorViewModels;
        public List<SponsorViewModel> sponsorViewModels;
        public List<JudgeViewModel> judgeViewModels;

        public EventForm(uint Event_ID, string mode)
        {
            InitializeComponent();
            eventId = Event_ID;
            this.mode = mode;
        }

        private void LoadEventTables()
        {
            var judges = eventService.GetEventJudges(eventId);
            var organizators = eventService.GetEventOrganizators(eventId);
            var sponsors = eventService.GetEventSponsors(eventId);
            var registrations = eventService.GetRegistrationsByEventId(eventId);

            _localJudges = judges;
            _localRegistrations = registrations;
            _localOrganizators = organizators;
            _localSponsors = sponsors;

            judgeViewModels = new List<JudgeViewModel>();
            organizatorViewModels = new List<OrganizatorViewModel>();
            sponsorViewModels = new List<SponsorViewModel>();
            registrationViewModels = new List<RegistrationViewModel>();

            foreach (var item in judges)
            {
                JudgeViewModel model = new JudgeViewModel();
                model.Judge_ID = item.Judge_ID;
                model.Name = item.Name;
                model.Surname = item.Surname;
                model.FatherName = item.FatherName;
                judgeViewModels.Add(model);
            }

            foreach (var item in organizators)
            {
                OrganizatorViewModel model = new OrganizatorViewModel();
                model.Organizator_ID = item.Organizator_ID;
                model.Name = item.Name;
                model.Surname = item.Surname;
                model.FatherName = item.FatherName;
                model.Position = item.Position;
                organizatorViewModels.Add(model);
            }

            foreach (var item in sponsors)
            {
                SponsorViewModel model = new SponsorViewModel();
                model.Sponsor_ID = item.Sponsor_ID;
                model.SponsorName = item.SponsorName;
                model.ContactFace = item.ContactFace;
                sponsorViewModels.Add(model);
            }

            foreach (var item in registrations)
            {
                RegistrationViewModel model = new RegistrationViewModel();
                model.Pilot_Id = item.Pilot_ID;
                var pilot = registrationService.GetPilotById(item.Pilot_ID);
                model.FIO = pilot.Surname + " " + pilot.Name + " " + pilot.Fathername;
                model.Mark = item.Mark;
                model.Place = item.Place;
                registrationViewModels.Add(model);
            }

            PilotDataGrid.DataSource = registrationViewModels;
            PilotDataGrid.Columns[0].Visible = false;
            SponsorDataGrid.DataSource = sponsorViewModels;
            SponsorDataGrid.Columns[0].Visible = false;
            JudgeDataGrid.DataSource = judgeViewModels;
            JudgeDataGrid.Columns[0].Visible = false;
            OrganizatorDataGrid.DataSource = organizatorViewModels;
            OrganizatorDataGrid.Columns[0].Visible = false;
        }

        private void LoadEventBasics()
        {
            var _event = eventService.GetEventViewModelById(eventId);
            EventNameBox.Text = _event.Event_Name;
            EventDateBox.Value = _event.Event_Date;
            EventPlaceBox.Text = _event.Place;
        }

        private void UpdateRegistrations()
        {
            registrationViewModels = new List<RegistrationViewModel>();
            foreach (var item in _localRegistrations)
            {
                RegistrationViewModel model = new RegistrationViewModel();
                model.Pilot_Id = item.Pilot_ID;
                var pilot = registrationService.GetPilotById(item.Pilot_ID);
                model.FIO = pilot.Surname + " " + pilot.Name + " " + pilot.Fathername;
                model.Mark = item.Mark;
                model.Place = item.Place;
                registrationViewModels.Add(model);
            }
            PilotDataGrid.DataSource = registrationViewModels;
            PilotDataGrid.Columns[0].Visible = false;
        }

        private void UpdateJudges()
        {
            judgeViewModels = new List<JudgeViewModel>();
            foreach (var item in _localJudges)
            {
                JudgeViewModel model = new JudgeViewModel();
                model.Judge_ID = item.Judge_ID;
                model.Name = item.Name;
                model.Surname = item.Surname;
                model.FatherName = item.FatherName;
                judgeViewModels.Add(model);
            }
            JudgeDataGrid.DataSource = judgeViewModels;
            JudgeDataGrid.Columns[0].Visible = false;
        }

        private void UpdateOrganizators()
        {
            organizatorViewModels = new List<OrganizatorViewModel>();
            foreach (var item in _localOrganizators)
            {
                OrganizatorViewModel model = new OrganizatorViewModel();
                model.Organizator_ID = item.Organizator_ID;
                model.Name = item.Name;
                model.Surname = item.Surname;
                model.FatherName = item.FatherName;
                model.Position = item.Position;
                organizatorViewModels.Add(model);
            }
            OrganizatorDataGrid.DataSource = organizatorViewModels;
            OrganizatorDataGrid.Columns[0].Visible = false;
        }

        private void UpdateSponsors()
        {
            sponsorViewModels = new List<SponsorViewModel>();
            foreach (var item in _localSponsors)
            {
                SponsorViewModel model = new SponsorViewModel();
                model.Sponsor_ID = item.Sponsor_ID;
                model.SponsorName = item.SponsorName;
                model.ContactFace = item.ContactFace;
                sponsorViewModels.Add(model);
            }
            SponsorDataGrid.DataSource = sponsorViewModels;
            SponsorDataGrid.Columns[0].Visible = false;
        }

        private void AddEvent()
        {
            var Event = new EventViewModel();
            Event.Event_Date = EventDateBox.Value;
            Event.Event_Name = EventNameBox.Text;
            Event.Place = EventPlaceBox.Text;
            Event.Judges = _localJudges;
            Event.Organizators = _localOrganizators;
            Event.Registrations = _localRegistrations;
            Event.Sponsors = _localSponsors;
            eventService.Create(Event);
            this.DialogResult = DialogResult.OK;
        }

        private void UpdateEvent()
        {
            var Event = new EventViewModel();
            Event.Event_ID = eventId;
            Event.Event_Date = EventDateBox.Value;
            Event.Event_Name = EventNameBox.Text;
            Event.Place = EventPlaceBox.Text;
            Event.Judges = _localJudges;
            Event.Organizators = _localOrganizators;
            Event.Registrations = _localRegistrations;
            Event.Sponsors = _localSponsors;
            eventService.Update(Event);
            this.DialogResult = DialogResult.OK;
        }

        private void AddOrganizator()
        {
            OrganizatorForm OF = new OrganizatorForm("add", 0);
            if (OF.ShowDialog() == DialogResult.OK)
            {
                _localOrganizators.Add(OF.organizator);
                UpdateOrganizators();
                OF.Close();
            }
        }

        private void AddRegistration()
        {
            RegistrationForm RF = new RegistrationForm("add", eventId);
            if (RF.ShowDialog() == DialogResult.OK)
            {
                if (!_localRegistrations.Any(x => x.Pilot_ID == RF.Registration.Pilot_ID))
                {
                    _localRegistrations.Add(RF.Registration);
                    UpdateRegistrations();
                    RF.Close();
                }
                else
                {
                    MessageBox.Show("Данный пилот уже зарегистрирован!");
                    RF.DialogResult = DialogResult.No;
                }
            }
        }

        private void AddSponsor()
        {
            SponsorForm SF = new SponsorForm(0, "add");
            if (SF.ShowDialog() == DialogResult.OK)
            {
                _localSponsors.Add(SF.sponsor);
                UpdateSponsors();
                SF.Close();
            }
        }

        private void AddJudge()
        {
            JudgeForm JF = new JudgeForm(0, "add");
            if (JF.ShowDialog() == DialogResult.OK)
            {
                _localJudges.Add(JF.judge);
                UpdateJudges();
                JF.Close();
            }
        }

        private void DeleteOrganizator()
        {
            try
            {
                Organizator organizator = new Organizator();
                organizator.Organizator_ID = Convert.ToUInt32(OrganizatorDataGrid.SelectedRows[0].Cells[0].Value);
                organizator.Surname = OrganizatorDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                organizator.Name = OrganizatorDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                organizator.FatherName = OrganizatorDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                _localOrganizators.Remove(organizator);
            }
            catch
            {
                MessageBox.Show("Список организаторов пуст");
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                AddEvent();
            }
            if(mode == "edit")
            {
                //eventService.ClearEventData(eventId);
                UpdateEvent();
            }
        }

        private void OrganizatorAddButton_Click(object sender, EventArgs e)
        {
            AddOrganizator();
            UpdateOrganizators();
        }

        private void OrganizatorDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteOrganizator();
            UpdateOrganizators();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                LoadEventBasics();
                LoadEventTables();
            }
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SponsorAddButton_Click(object sender, EventArgs e)
        {
            AddSponsor();
            UpdateSponsors();
        }

        private void SponsorDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _localSponsors.RemoveAll(x => x.Sponsor_ID == Convert.ToUInt32(SponsorDataGrid.SelectedRows[0].Cells[0].Value));
            }
            catch
            {
                MessageBox.Show("Список пилотов пуст");
            }
            UpdateSponsors();
        }

        private void JudgeAddButton_Click(object sender, EventArgs e)
        {
            AddJudge();
            UpdateJudges();
        }

        private void JudgeDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _localJudges.RemoveAll(x => x.Judge_ID == Convert.ToUInt32(JudgeDataGrid.SelectedRows[0].Cells[0].Value));
            }
            catch
            {
                MessageBox.Show("Список пилотов пуст");
            }
            UpdateJudges();
        }

        private void PilotAddButton_Click(object sender, EventArgs e)
        {
            AddRegistration();
            UpdateRegistrations();
        }

        private void PilotDeleteButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                _localRegistrations.RemoveAll(x => x.Pilot_ID == Convert.ToUInt32(PilotDataGrid.SelectedRows[0].Cells[0].Value));
            }
            catch
            {
                MessageBox.Show("Список пилотов пуст");
            }
            UpdateRegistrations();
        }
    }
}
