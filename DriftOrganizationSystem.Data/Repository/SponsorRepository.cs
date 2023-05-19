using DriftOrganizationSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data.Repository
{
    public class SponsorRepository
    {
        public void AddSponsor(Sponsor entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Sponsors.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditSponsor(Sponsor entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Sponsors.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeleteSponsor(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var sponsor = _db.Sponsors.Where(x => x.Sponsor_ID == id).FirstOrDefault();
                _db.Sponsors.Remove(sponsor);
                _db.SaveChanges();
            }
        }

        public Sponsor GetById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Sponsors.Where(x => x.Sponsor_ID == id).FirstOrDefault();
            }
        }

        public List<Sponsor> GetEventSponsors(uint event_id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var eventOrganizators = _db.Sponsors.FromSql($"SELECT Sponsors.Sponsor_ID as 'Sponsor_ID', Sponsors.SponsorName as 'SponsorName', Sponsors.ContactFace as 'ContactFace' FROM Sponsors INNER JOIN EventSponsors ON Sponsors.Sponsor_ID = EventSponsors.SponsorsSponsor_ID INNER JOIN dbo.[Events] ON dbo.[Events].Event_ID = EventSponsors.EventsEvent_ID WHERE Event_ID = {event_id}").ToList();
                return eventOrganizators;
            }
        }
    }
}
