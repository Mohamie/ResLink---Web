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


        public static IEnumerable<Announcement> GetAnnouncements()
        {
            return instance.db.GetItems<Announcement>();
        }

        public static Announcement GetAnnouncementById(string id)
        {
            return instance.db.GetItem<Announcement>(id);
        }

        public static void SaveAnnouncement(Announcement item)
        {
            instance.db.SaveItem<Announcement>(item);
        }

        public static void DeleteAnnouncement( string objectId)
        {
            instance.db.DeleteItem<Announcement>(objectId);
        }

        
    }
}
