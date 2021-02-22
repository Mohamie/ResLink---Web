using BackendlessAPI.Persistence;
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

        private static DataQueryBuilder queryBuilder;

        static HouseCommitteeRepository()
        {
            instance = new HouseCommitteeRepository();
        }

        protected HouseCommitteeRepository()
        {
            db = new ResLinkDatabase();
            queryBuilder = DataQueryBuilder.Create();
        }

        public static async Task<IEnumerable<HouseCommittee>> GetHouseCommittee()
        {
            queryBuilder.AddRelated("student");
            queryBuilder.AddRelated("student.studentAccount");
            queryBuilder.AddRelated("student.studentAccount.residence");
            queryBuilder.AddRelated("hcRole");
            return await instance.db.GetItems<HouseCommittee>(queryBuilder);
        }

        internal static async Task<IEnumerable<HouseCommittee>> GetHouseCommitteeByClause(string whereClause)
        {
            queryBuilder.SetWhereClause(whereClause);
            queryBuilder.AddRelated("student");
            queryBuilder.AddRelated("student.gender");
            queryBuilder.AddRelated("student.studentAccount");
            queryBuilder.AddRelated("student.studentAccount.residence");
            queryBuilder.AddRelated("student.studentAccount.residence.residenceManager");
            queryBuilder.AddRelated("hcRole");
            return await instance.db.GetItems<HouseCommittee>(queryBuilder);
        }

        public static async Task<IEnumerable<HouseCommittee>> GetHouseCommittees()
        {
            var user = await UserAccountRepository.GetRelations((await UserAccountRepository.GetCurrentlyLoggedAccount()).ObjectId);
            var loggedResidence = user.GetProperty("residence") as Residence;

            string whereClause = $"objectId in (HouseCommittee[student.studentAccount.residence.objectId = '{loggedResidence.objectId}'].objectId)";

            queryBuilder.SetWhereClause(whereClause);
            queryBuilder.AddRelated("student");
            queryBuilder.AddRelated("student.studentAccount.residence");
            queryBuilder.AddRelated("student.studentAccount.residence.residenceManager");
            queryBuilder.AddRelated("hcRole");
            queryBuilder.AddRelated("student.gender");

            return await instance.db.GetItems<HouseCommittee>(queryBuilder);

        }

        public static async Task<HouseCommittee> SaveHouseCommittee(HouseCommittee item)
        {
            return await instance.db.SaveItem<HouseCommittee>(item);
        }

        public static async Task DeleteHouseCommittee(string objectId)
        {
            await instance.db.DeleteItem<HouseCommittee>(objectId);
        }

        public static async Task SetRelation<HouseCommittee>(HouseCommittee parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<HouseCommittee>(parentObject, relationColumnName, children);
        }
    }
}
