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
    public class ComplaintRepository
    {
        private ResLinkDatabase db = null;
        protected static ComplaintRepository instance;

        private static DataQueryBuilder queryBuilder;

        static ComplaintRepository()
        {
            instance = new ComplaintRepository();
        }

        protected ComplaintRepository()
        {
            db = new ResLinkDatabase();
            queryBuilder = DataQueryBuilder.Create();
        }

       
        public static async Task<IEnumerable<Complaint>> getComplaints()
        {
            var user = await UserAccountRepository.GetRelations((await UserAccountRepository.GetCurrentlyLoggedAccount()).ObjectId);
            var loggedResidence = user.GetProperty("residence") as Residence;

            string whereClause = $"objectId in (Complaint[student.studentAccount.residence.objectId = '{loggedResidence.objectId}'].objectId)";

            queryBuilder.SetWhereClause(whereClause);
            queryBuilder.AddRelated("student");
            return await instance.db.GetItems<Complaint>(queryBuilder);
        }

        public static async Task<Complaint> GetComplaintById(string id)
        {
            queryBuilder.AddRelated("student");
            return await instance.db.GetItem<Complaint>(id, queryBuilder);
        }

        public static async Task SaveComplaint(Complaint item)
        {
           await instance.db.SaveItem<Complaint>(item);
        }

        public static async Task DeleteComplaint(string objectId)
        {
            await instance.db.DeleteItem<Complaint>(objectId);
        }

        public static async Task SetRelation<Complaint>(Complaint parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Complaint>(parentObject, relationColumnName, children);
        }

    }
}
