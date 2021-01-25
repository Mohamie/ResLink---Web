using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class ResidenceRepository
    {
        private ResLinkDatabase db = null;
        protected static ResidenceRepository instance;

        static ResidenceRepository()
        {
            instance = new ResidenceRepository();
        }

        protected ResidenceRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<Residence>> GetResidences()
        {
            return await instance.db.GetItems<Residence>();
        }

        public static async Task<Residence> GetResidenceById(string id)
        {
            return await instance.db.GetItem<Residence>(id);
        }

        public static async Task<Residence> SaveResidence(Residence item)
        {
            return await instance.db.SaveItem<Residence>(item);
        }

        public static async Task DeleteResidence(string objectId)
        {
            await instance.db.DeleteItem<Residence>(objectId);
        }


    }
}
