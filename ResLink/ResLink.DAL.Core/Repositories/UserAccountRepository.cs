using BackendlessAPI;
using BackendlessAPI.Persistence;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class UserAccountRepository
    {
        private ResLinkDatabase db = null;
        protected static UserAccountRepository instance;

        static UserAccountRepository()
        {
            instance = new UserAccountRepository();
        }

        protected UserAccountRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<BackendlessUser>> getBackendlessUsers()
        {
            return await instance.db.GetItems<BackendlessUser>();
        }

        public static async Task<BackendlessUser> GetBackendlessUserById(string id, IList<string> relations = null)
        {
            return await instance.db.GetItem<BackendlessUser>(id);
        }

        /*public static async Task SaveBackendlessUser(BackendlessUser item)
        {
            await instance.db.SaveItem<BackendlessUser>(item);
        }
*/
        public static async Task DeleteBackendlessUser(string objectId)
        {
            await instance.db.DeleteItem<BackendlessUser>(objectId);
        }

        public static async Task SetRelation<BackendlessUser>(BackendlessUser parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<BackendlessUser>(parentObject, relationColumnName, children);
        }

        public static async Task<BackendlessUser> GetRelations(string objectId)
        {
            IList<string> relations = new List<string>();
            relations.Add("residence");
            relations.Add("residence.residenceGender");

            return await Backendless.Data.Of<BackendlessUser>().FindByIdAsync(objectId, relations);
        }
    }
}
