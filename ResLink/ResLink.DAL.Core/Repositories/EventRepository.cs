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


        public static async Task<IEnumerable<Event>> GetEvents()
        {
            return await instance.db.GetItems<Event>();
        }

        public static async Task<Event> GetEventById(string id)
        {
            return await instance.db.GetItem<Event>(id);
        }

        public static async Task SaveEvent(Event item)
        {
            await instance.db.SaveItem<Event>(item);
        }

        public static async Task DeleteEvent(string objectId)
        {
           await instance.db.DeleteItem<Event>(objectId);
        }

        public async Task SetRelation<Event>(Event parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Event>(parentObject, relationColumnName, children);
        }
    }
}
