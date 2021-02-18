using BackendlessAPI.Persistence;
using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class UserRoleRepository
    {
        private ResLinkDatabase db = null;
        protected static UserRoleRepository instance;

        static UserRoleRepository()
        {
            instance = new UserRoleRepository();
        }

        protected UserRoleRepository()
        {
            db = new ResLinkDatabase();
        }


        private static async Task<IEnumerable<UserRole>> GetUserRole(string role)
        {
            DataQueryBuilder queryBuilder = DataQueryBuilder.Create();
            queryBuilder.SetWhereClause($"roleId = '{role}'");

            return await instance.db.GetItems<UserRole>(queryBuilder);
        }

        public static async Task<UserRole> GetUserRoleById(string id)
        {
            return await instance.db.GetItem<UserRole>(id);
        }

        public static async Task<UserRole> GetManagerRole()
        {
            List<UserRole> role = (await GetUserRole("0") as List<UserRole>);

            return role[0];
        }
        
        public static async Task<UserRole> GetAdminRole()
        {
            List<UserRole> role = (await GetUserRole("1") as List<UserRole>);

            return role[0];
        }
        public static async Task<UserRole> GetRegularRole()
        {
            List<UserRole> role = (await GetUserRole("2") as List<UserRole>);

            return role[0];
        }

        public static async Task<UserRole> SaveUserRole(UserRole item)
        {
            return await instance.db.SaveItem<UserRole>(item);
        }

        public static async Task DeleteUserRole(string objectId)
        {
            await instance.db.DeleteItem<UserRole>(objectId);
        }

    }
}
