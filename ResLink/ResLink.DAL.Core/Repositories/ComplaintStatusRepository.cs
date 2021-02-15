using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class ComplaintStatusRepository
    {


        private ResLinkDatabase db = null;
        protected static ComplaintStatusRepository instance;

        static ComplaintStatusRepository()
        {
            instance = new ComplaintStatusRepository();
        }

        protected ComplaintStatusRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<ComplaintStatus>> GetComplaintStatus()
        {
            return await instance.db.GetItems<ComplaintStatus>();
        }

        public static async Task<ComplaintStatus> GetComplaintStatusById(string id)
        {
            return await instance.db.GetItem<ComplaintStatus>(id);
        }

        public static async Task<ComplaintStatus> SaveComplaintStatus(ComplaintStatus item)
        {
            return await instance.db.SaveItem<ComplaintStatus>(item);
        }

        public static async Task DeleteComplaintStatus(string objectId)
        {
            await instance.db.DeleteItem<ComplaintStatus>(objectId);
        }

    }
}
