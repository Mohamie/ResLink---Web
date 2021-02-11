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
    public class AnnouncementRepository
    {
        private ResLinkDatabase db = null;
        protected static AnnouncementRepository instance;

        private static DataQueryBuilder queryBuilder;

        static AnnouncementRepository()
        {
            instance = new AnnouncementRepository();
        }

        protected AnnouncementRepository()
        {
            db = new ResLinkDatabase();
            queryBuilder = DataQueryBuilder.Create();
        }


        public static async Task<IEnumerable<Announcement>> GetAnnouncements()
        {
            queryBuilder.AddRelated("hc.student");
            queryBuilder.AddRelated("hc.hcRole");
            return await instance.db.GetItems<Announcement>(queryBuilder);
        }

        public static async Task<Announcement> GetAnnouncementById(string id)
        {
            queryBuilder.AddRelated("hc.student");
            queryBuilder.AddRelated("hc.hcRole");
            return await instance.db.GetItem<Announcement>(id, queryBuilder);
        }

        public static async Task SaveAnnouncement(Announcement item)
        {
            await instance.db.SaveItem<Announcement>(item);
        }

        public static async Task DeleteAnnouncement( string objectId)
        {
            await instance.db.DeleteItem<Announcement>(objectId);
        }

        public static async Task SetRelation<Announcement>(Announcement parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Announcement>(parentObject, relationColumnName, children);
        }
    }
}
