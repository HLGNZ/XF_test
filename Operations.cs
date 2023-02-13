using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XF_144310_AhmadAlhrthi
{
    public class Operations
    {
        readonly SQLiteAsyncConnection db;
        public Operations(string dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<NumberCode>().Wait();


        }

        public Task<NumberCode> GetUsersLoginAsync(string user, string pass)
        {
            return db.Table<NumberCode>().Where(i => i.Number == user && i.Code == pass).FirstOrDefaultAsync();

        }

        public Task<List<NumberCode>> GetUsersByName(string name)
        {
            return db.Table<NumberCode>().Where(i => i.Number == name).ToListAsync();
        }

        public Task<NumberCode> GetUsersByUser(string user_name)
        {
            return db.Table<NumberCode>().Where(i => i.Number == user_name).FirstOrDefaultAsync();
        }

        public Task<int> SaveUsersAsync(NumberCode numberCode)
        {
            if (numberCode.Id != 0)
            {
                return db.UpdateAsync(numberCode);
            }
            return db.InsertAsync(numberCode);
        }
       
        public Task<List<NumberCode>> Get4UsersByName(string name)
        {
            return db.Table<NumberCode>().Where(i => i.Number == name).ToListAsync();
        }
        public Task<List<NumberCode>> GetUsersAsync()
        {

            return db.Table<NumberCode>().ToListAsync();
        }
        public Task<int> DeleteNumberAsync(NumberCode numberCode)

        {

            return db.DeleteAsync(numberCode);

        }






    }
}