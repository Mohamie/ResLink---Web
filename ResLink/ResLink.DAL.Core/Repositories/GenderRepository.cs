using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class GenderRepository
    {

        private ResLinkDatabase db = null;
        protected static GenderRepository instance;

        static GenderRepository()
        {
            instance = new GenderRepository();
        }

        protected GenderRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<Gender>> GetGender()
        {
            return await instance.db.GetItems<Gender>();
        }

        public static async Task<Gender> GetGenderById(string id)
        {
            return await instance.db.GetItem<Gender>(id);
        }

        public static async Task<Gender> SaveGender(Gender item)
        {
            return await instance.db.SaveItem<Gender>(item);
        }

        public static async Task DeleteGender(string objectId)
        {
            await instance.db.DeleteItem<Gender>(objectId);
        }

    }
}
