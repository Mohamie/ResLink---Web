using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class EventRepository
    {
        private ResLinkDatabase db = null;
        protected static EventRepository instance;

        static EventRepository()
        {
            instance = new EventRepository();
        }

        protected EventRepository()
        {
            db = new ResLinkDatabase();
        }


        public static IEnumerable<Event> GetEvent()
        {
            return instance.db.GetItems<Event>();
        }

        public static Event GetEventById(string id)
        {
            return instance.db.GetItem<Event>(id);
        }

        public static void SaveEvent(Event item)
        {
            instance.db.SaveItem<Event>(item);
        }

        public static void DeleteEvent(string objectId)
        {
            instance.db.DeleteItem<Event>(objectId);
        }
    }
}
