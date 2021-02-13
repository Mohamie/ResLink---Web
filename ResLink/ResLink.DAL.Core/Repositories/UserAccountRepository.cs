using BackendlessAPI;
using BackendlessAPI.Persistence;
using ResLink.BL.Models;
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

        DataQueryBuilder queryBuilder;

        static UserAccountRepository()
        {
            instance = new UserAccountRepository();
        }

        protected UserAccountRepository()
        {
            db = new ResLinkDatabase();
            queryBuilder = DataQueryBuilder.Create();
        }


        public static async Task<IEnumerable<BackendlessUser>> getBackendlessUsers()
        {
            return await instance.db.GetItems<BackendlessUser>();
        }

        public static async Task<BackendlessUser> GetBackendlessUserById(string id, IList<string> relations = null)
        {
            return await instance.db.GetItem<BackendlessUser>(id);
        }
       
        public static async Task<BackendlessUser> GetCurrentlyLoggedAccount()
        {
            return await GetRelations((Backendless.UserService.CurrentUser).ObjectId);
        }

        public static async Task<HouseCommittee> GetLoggedHouseCommittee()
        {
            string accountObjectId = (await GetCurrentlyLoggedAccount()).ObjectId;

            string whereClause = $"objectId in (HouseCommittee[student.studentAccount.objectId = '{accountObjectId}'].objectId)";

            List<HouseCommittee> hcList = await HouseCommitteeRepository.GetHouseCommitteeByClause(whereClause) as List<HouseCommittee>;

            return hcList[0];
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
