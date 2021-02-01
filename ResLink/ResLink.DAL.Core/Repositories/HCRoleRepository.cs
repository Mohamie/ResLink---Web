using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class HCRoleRepository
    {
        private ResLinkDatabase db = null;
        protected static HCRoleRepository instance;

        static HCRoleRepository()
        {
            instance = new HCRoleRepository();
        }

        protected HCRoleRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<HCRole>> GetHCRoles()
        {
            return await instance.db.GetItems<HCRole>();
        }

        public static async Task<HCRole> GetHCRoleById(string id)
        {
            return await instance.db.GetItem<HCRole>(id);
        }

        public static async Task SaveHCRole(HCRole item)
        {
            await instance.db.SaveItem<HCRole>(item);
        }

        public static async Task DeleteHCRole(string objectId)
        {
            await instance.db.DeleteItem<HCRole>(objectId);
        }

        public static async Task SetRelation<HCRole>(HCRole parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<HCRole>(parentObject, relationColumnName, children);
        }
    }
}

