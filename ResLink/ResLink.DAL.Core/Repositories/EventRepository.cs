using BackendlessAPI.Persistence;
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

        private static DataQueryBuilder queryBuilder;

        static EventRepository()
        {
            instance = new EventRepository();
        }

        protected EventRepository()
        {
            db = new ResLinkDatabase();
            queryBuilder = DataQueryBuilder.Create();
        }


        public static async Task<IEnumerable<Event>> GetEvents()
        {
            queryBuilder.AddRelated("hc.student");
            queryBuilder.AddRelated("hc.hcRole");
            return await instance.db.GetItems<Event>(queryBuilder);
        }

        public static async Task<Event> GetEventById(string id)
        {
            queryBuilder.AddRelated("hc.student");
            queryBuilder.AddRelated("hc.hcRole");
            return await instance.db.GetItem<Event>(id, queryBuilder);
        }

        public static async Task SaveEvent(Event item)
        {
            await instance.db.SaveItem<Event>(item);
        }

        public static async Task DeleteEvent(string objectId)
        {
           await instance.db.DeleteItem<Event>(objectId);
        }

        public static async Task SetRelation<Event>(Event parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Event>(parentObject, relationColumnName, children);
        }
    }
}
