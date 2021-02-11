using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class AlertSeverityRepository
    {
        private ResLinkDatabase db = null;
        protected static AlertSeverityRepository instance;

        static AlertSeverityRepository()
        {
            instance = new AlertSeverityRepository();
        }

        protected AlertSeverityRepository()
        {
            db = new ResLinkDatabase();
        }


        public static async Task<IEnumerable<AlertSeverity>> GetAlertSeverities()
        {
            return await instance.db.GetItems<AlertSeverity>();
        }

        public static async Task<AlertSeverity> GetAlertSeverityById(string id)
        {
            return await instance.db.GetItem<AlertSeverity>(id);
        }

        public static async Task SaveAlertSeverity(AlertSeverity item)
        {
            await instance.db.SaveItem<AlertSeverity>(item);
        }

        public static async Task DeleteAlertSeverity(string objectId)
        {
            await instance.db.DeleteItem<AlertSeverity>(objectId);
        }

        public static async Task SetRelation<AlertSeverity>(AlertSeverity parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<AlertSeverity>(parentObject, relationColumnName, children);
        }
    }
}
