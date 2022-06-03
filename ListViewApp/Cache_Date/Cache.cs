using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ListViewApp.Model;

namespace ListViewApp.Cache_Date
{
    public class Cache
    {
        private SQLiteAsyncConnection conntection;
        private readonly string path;

        public Cache(string path)
        {
            this.path = path;
        }

        public async Task Init()
        {
            if (conntection != null)
            {
                return;
            }

            conntection = new SQLiteAsyncConnection(path);
            await conntection.CreateTableAsync<Individual_Chooses>();
        }

        public async Task<int> SaveCache(Individual_Chooses person)
        {
            await Init();

            return await conntection.InsertAsync(person);
        }

        public async Task<List<Individual_Chooses>> GetCache()
        {
            await Init();

            return await conntection.Table<Individual_Chooses>().ToListAsync();
        }

        public async void DeleteAllCache()
        {
            await Init();

            await conntection.DeleteAllAsync<Individual_Chooses>();
        }
    }
}
