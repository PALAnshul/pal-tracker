using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        private readonly IDictionary<long, TimeEntry> _timeEntries = new Dictionary<long, TimeEntry>();

        public TimeEntry Create(TimeEntry timeEntry)
        {
             var id = _timeEntries.Count + 1;
 
            timeEntry.Id = id;

            _timeEntries.Add(id, timeEntry);

            return timeEntry;
        }

        public TimeEntry Find(long id)
        {
          return _timeEntries[id];
        }

         public void Delete(long id)
        {
             _timeEntries.Remove(id);
        }

        // public List<TimeEntry> List()
        // {
        //     return _timeEntries.Values.ToList();
        // }

        public TimeEntry Update(long id,TimeEntry timeEntry)
        {
             timeEntry.Id = id;

            _timeEntries[id] = timeEntry;

            return timeEntry;
        }

          public bool Contains(long id)
        {
           return  _timeEntries.ContainsKey(id);
        }

        public IEnumerable<TimeEntry> List() => _timeEntries.Values.ToList();
    }
}