using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class HouseCommitteeRepository
    {
        private ResLinkDatabase db = null;
        protected static HouseCommitteeRepository instance;

        static HouseCommitteeRepository()
        {
            instance = new HouseCommitteeRepository();
        }

        protected HouseCommitteeRepository()
        {
            db = new ResLinkDatabase();
        }

        public static async Task<IEnumerable<HouseCommittee>> GetHouseCommittee()
        {
            return await instance.db.GetItems<HouseCommittee>();
        }

        public static async Task<HouseCommittee> GetHouseCommitteeById(string id)
        {
            return await instance.db.GetItem<HouseCommittee>(id);
        }

        public static async Task<HouseCommittee> SaveHouseCommittee(HouseCommittee item)
        {
            return await instance.db.SaveItem<HouseCommittee>(item);
        }

        public static async Task DeleteHouseCommittee(string objectId)
        {
            await instance.db.DeleteItem<HouseCommittee>(objectId);
        }

        public async Task SetRelation<HouseCommittee>(HouseCommittee parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<HouseCommittee>(parentObject, relationColumnName, children);
        }
    }
}
