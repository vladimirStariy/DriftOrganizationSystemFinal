using DriftOrganizationSystem.Domain.Entity;
using DriftOrganizationSystem.Domain.Viewmodels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data.Repository
{
    public class EventRepository
    {
        public void AddEvent(Event entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Events.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditEvent(Event entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Events.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeleteEvent(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var _event = _db.Events.Where(x => x.Event_ID == id).FirstOrDefault();
                _db.Events.Remove(_event);
                _db.SaveChanges();
            }
        }

        //public Event GetById(uint id)
        //{
        //    using (DriftDbContext _db = new DriftDbContext())
        //    {
        //        var item = _db.Events.Where(x => x.Event_ID == id).FirstOrDefault();
        //        return item;
        //    }
        //}

        public EventViewModel GetById(uint id)
        {
            var eventVM = new EventViewModel();
            using (DriftDbContext _db = new DriftDbContext())
            {
                var item = _db.Events.Where(x => x.Event_ID == id).FirstOrDefault();
                eventVM.Judges = item.Judges.ToList();
                eventVM.Sponsors = item.Sponsors.ToList();
                eventVM.Registrations = item.Registrations.ToList();
                eventVM.Organizators = item.Organizators.ToList();
                eventVM.Event_Date = item.EventDate;
                eventVM.Event_Name = item.EventName;
                eventVM.Event_ID = item.Event_ID;
                eventVM.Place = item.Place;
            }
            return eventVM;
        }

        public List<Event> GetEvents()
        {
            var judge = new List<Judge>();
            using (DriftDbContext _db = new DriftDbContext())
            {
                var item = _db.Events.ToList();
                
                return item;
            }
        }

        public void ClearAllForEvent(uint event_id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Database.ExecuteSql($"DELETE FROM EventSponsors WHERE EventsEvent_ID = {event_id}; DELETE FROM EventOrganizators WHERE EventsEvent_ID = {event_id}; DELETE FROM EventJudges WHERE EventsEvent_ID = {event_id}; DELETE FROM Registrations WHERE Event_ID = {event_id}");
            }
        }
    }
}
