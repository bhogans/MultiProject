using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface IEventRepository
    {
        IEnumerable GetEvents();
        Event GetEventByID(int eventId);
        void InsertEvent(Event cleanEvent);
        void DeleteEvent(int eventId);
        void UpdateEvent(Event cleanEvent);
        void Save();
    }
}
