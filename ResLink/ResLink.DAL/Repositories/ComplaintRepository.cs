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


        public static IEnumerable<Complaint> getComplaints()
        {
            return instance.db.GetItems<Complaint>();
        }

        public static Complaint GetComplaintById(string id)
        {
            return instance.db.GetItem<Complaint>(id);
        }

        public static void SaveComplaint(Complaint item)
        {
            instance.db.SaveItem<Complaint>(item);
        }

        public static void DeleteComplaint(string objectId)
        {
            instance.db.DeleteItem<Complaint>(objectId);
        }

    }
}
