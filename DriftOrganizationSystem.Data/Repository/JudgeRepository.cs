using DriftOrganizationSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data.Repository
{
    public class JudgeRepository
    {
        public void AddJudge(Judge entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Judges.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditJudge(Judge entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Judges.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeleteJudge(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var judge = _db.Judges.Where(x => x.Judge_ID == id).FirstOrDefault();
                _db.Judges.Remove(judge);
                _db.SaveChanges();
            }
        }

        public List<Judge> GetJudges() 
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Judges.ToList();
            }
        }

        public Judge GetById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Judges.Where(x => x.Judge_ID == id).FirstOrDefault();
            }
        }

        public List<Judge> GetEventOrganizators(uint event_id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var eventJudges = _db.Judges.FromSql($"SELECT Judges.Judge_ID as 'Judge_ID', Judges.Surname as 'Surname', Judges.Name as 'Name', Judges.FatherName as 'FatherName' FROM Judges INNER JOIN EventJudges ON Judges.Judge_ID = EventJudges.JudgesJudge_ID INNER JOIN dbo.[Events] ON dbo.[Events].Event_ID = EventJudges.EventsEvent_ID WHERE Event_ID = {event_id}").ToList();
                return eventJudges;
            }
        }
    }
}
