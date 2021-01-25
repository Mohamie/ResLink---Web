using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class ResidenceManagerRepository
    {
        private ResLinkDatabase db = null;
        protected static ResidenceManagerRepository instance;

        static ResidenceManagerRepository()
        {
            instance = new ResidenceManagerRepository();
        }

        protected ResidenceManagerRepository()
        {
            db = new ResLinkDatabase();
        }

        public static async Task<IEnumerable<ResidenceManager>> GetResidenceManager()
        {
            return await instance.db.GetItems<ResidenceManager>();
        }

        public static async Task<ResidenceManager> GetResidenceManagerById(string id)
        {
            return await instance.db.GetItem<ResidenceManager>(id);
        }

        public static async Task<ResidenceManager> SaveResidenceManager(ResidenceManager item)
        {
            return await instance.db.SaveItem<ResidenceManager>(item);
        }

        public static async Task DeleteResidenceManager(string objectId)
        {
            await instance.db.DeleteItem<ResidenceManager>(objectId);
        }
    }
}
