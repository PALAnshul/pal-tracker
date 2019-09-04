using System.Collections.Generic;

namespace PalTracker
{
public interface ITimeEntryRepository
    {

    TimeEntry Create(TimeEntry timeEntry);
    TimeEntry Find(long  id);
    void Delete(long  id);
    IEnumerable<TimeEntry> List();
     TimeEntry Update(long Id,TimeEntry timeEntry);
     bool Contains(long Id);
    }
}