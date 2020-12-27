using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendlessAPI;

namespace ResLink.DL
{
    public class ResLinkDatabase
    {
        public IEnumerable<T> GetItems<T>()
        {
            return Backendless.Data.Of<T>().Find();
        }

        public T GetItem<T>(string id)
        {
            return Backendless.Data.Of<T>().FindById(id);
        }

        public T SaveItem<T>( T item )
        {
            return Backendless.Data.Of<T>().Save(item);
        }

        public void DeleteItem<T>( string objectId)
        {
            Backendless.Data.Of<T>().Remove($"objectId = '{objectId}'");

        }
    }
}
