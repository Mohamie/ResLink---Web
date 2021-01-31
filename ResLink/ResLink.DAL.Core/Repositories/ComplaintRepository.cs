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

        static ComplaintRepository()
        {
            instance = new ComplaintRepository();
        }

        protected ComplaintRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<Complaint>> getComplaints()
        {
            return await instance.db.GetItems<Complaint>();
        }

        public static async Task<Complaint> GetComplaintById(string id)
        {
            return await instance.db.GetItem<Complaint>(id);
        }

        public static async Task SaveComplaint(Complaint item)
        {
           await instance.db.SaveItem<Complaint>(item);
        }

        public static async Task DeleteComplaint(string objectId)
        {
            await instance.db.DeleteItem<Complaint>(objectId);
        }

        public async Task SetRelation<Complaint>(Complaint parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Complaint>(parentObject, relationColumnName, children);
        }

    }
}
