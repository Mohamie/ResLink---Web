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
        public async Task<IEnumerable<T>> GetItems<T>()
        {
            return await Backendless.Data.Of<T>().FindAsync();
        }

        public async Task<T> GetItem<T>(string id)
        {
            return await Backendless.Data.Of<T>().FindByIdAsync(id);
        }

        public async Task<T> SaveItem<T>( T item )
        {
            return await Backendless.Data.Of<T>().SaveAsync(item);
        }

        public async Task DeleteItem<T>( string objectId)
        {
            await Backendless.Data.Of<T>().RemoveAsync($"objectId = '{objectId}'");
        }
    }
}
