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

        static AnnouncementRepository()
        {
            instance = new AnnouncementRepository();
        }

        protected AnnouncementRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<Announcement>> GetAnnouncements()
        {
            return await instance.db.GetItems<Announcement>();
        }

        public static async Task<Announcement> GetAnnouncementById(string id)
        {
            return await instance.db.GetItem<Announcement>(id);
        }

        public static async Task SaveAnnouncement(Announcement item)
        {
            await instance.db.SaveItem<Announcement>(item);
        }

        public static async Task DeleteAnnouncement( string objectId)
        {
            await instance.db.DeleteItem<Announcement>(objectId);
        }

        public async Task SetRelation<Announcement>(Announcement parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Announcement>(parentObject, relationColumnName, children);
        }
    }
}
