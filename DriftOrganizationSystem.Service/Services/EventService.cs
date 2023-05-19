using DriftOrganizationSystem.Data;
using DriftOrganizationSystem.Data.Repository;
using DriftOrganizationSystem.Domain.Entity;
using DriftOrganizationSystem.Domain.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Service.Services
{
    public class EventService
    {
        EventRepository eventRepository = new EventRepository();
        RegistrationRepository registrationRepository = new RegistrationRepository();
        OrganizatorRepository organizatorRepository = new OrganizatorRepository();
        SponsorRepository sponsorRepository = new SponsorRepository();
        JudgeRepository judgeRepository = new JudgeRepository();

        public void Create(EventViewModel model)
        {
            Event _event = new Event()
            {
                EventName = model.Event_Name,
                EventDate = model.Event_Date,
                Place = model.Place,
                Sponsors = model.Sponsors,
                Organizators = model.Organizators,
                Judges = model.Judges,
                Registrations = model.Registrations
            };
            eventRepository.AddEvent(_event);
        }

        public void Update(EventViewModel model)
        {
            Event _event = new Event()
            {
                Event_ID = model.Event_ID,
                EventName = model.Event_Name,
                EventDate = model.Event_Date,
                Place = model.Place,
                Sponsors = model.Sponsors,
                Organizators = model.Organizators,
                Judges = model.Judges,
                Registrations = model.Registrations
            };
            eventRepository.EditEvent(_event);
        }

        public List<EventViewModel> GetEvents()
        {
            List<EventViewModel> events = new List<EventViewModel>();

            foreach (var item in eventRepository.GetEvents())
            {
                EventViewModel model = new EventViewModel();
                model.Event_Name = item.EventName;
                model.Event_Date = item.EventDate;
                model.Place = item.Place;
                model.Event_ID = item.Event_ID;
                events.Add(model);
            }

            return events;
        }

        public EventViewModel GetEventViewModelById(uint id)
        {
            var _event = eventRepository.GetById(id);
            return _event;
        }

        public List<Organizator> GetEventOrganizators(uint event_id)
        {
            return organizatorRepository.GetEventOrganizators(event_id);
        }

        public List<Judge> GetEventJudges(uint event_id)
        {
            return judgeRepository.GetEventOrganizators(event_id);
        }

        public List<Sponsor> GetEventSponsors(uint event_id)
        {
            return sponsorRepository.GetEventSponsors(event_id);
        }

        public List<Registration> GetRegistrationsByEventId(uint event_id)
        {
            return registrationRepository.GetByEventId(event_id);
        }

        public void ClearEventData(uint event_id)
        {
            eventRepository.ClearAllForEvent(event_id);
        }
    }
}
