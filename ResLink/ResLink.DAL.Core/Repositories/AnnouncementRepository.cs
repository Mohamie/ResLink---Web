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

            var user = await UserAccountRepository.GetRelations((await UserAccountRepository.GetCurrentlyLoggedAccount()).ObjectId);
            var loggedResidence = user.GetProperty("residence") as Residence;
            
            string whereClause = $"objectId in (Announcement[hc.student.studentAccount.residence.objectId = '{loggedResidence.objectId}'].objectId)";
            
            queryBuilder.SetWhereClause(whereClause);
            queryBuilder.SetPageSize(100).SetOffset(0);
            queryBuilder.AddRelated("hc");
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

        public static async Task<Announcement> SaveAnnouncement(Announcement item)
        {
            return await instance.db.SaveItem<Announcement>(item);
        }

        public static async Task DeleteAnnouncement( string objectId)
        {
            await instance.db.DeleteItem<Announcement>(objectId);
        }

        public static async Task SetRelation<Announcement>(Announcement parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Announcement>(parentObject, relationColumnName, children);
        }

       /* public static async Task LoadRelations()
        {
            LoadRelationsQueryBuilder<HouseCommittee> loadRelationsQueryBuilder = LoadRelationsQueryBuilder<HouseCommittee>.Create();
            loadRelationsQueryBuilder.
        }*/
    }
}
