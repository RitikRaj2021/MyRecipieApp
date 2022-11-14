using App1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App1.DoAsyncLazy;


namespace App1.Data
{
    internal class RecipieItemDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<RecipieItemDatabase> Instance =
            new AsyncLazy<RecipieItemDatabase>(async () =>
            {
                var new_Instance = new RecipieItemDatabase();
                try
                {
                    CreateTableResult the_Result = await Database.CreateTableAsync<RecipieItem>();
                }
                catch (Exception)
                {

                    throw;
                }
                return new_Instance;
            });

        //This is the connection to the database
        public RecipieItemDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<RecipieItem>> GetItemsAsync()
        {
            return Database.Table<RecipieItem>().ToListAsync();
        }
                
        public Task<RecipieItem> GetItemAsync(int newId)
        {
            return Database.Table<RecipieItem>().Where(i => i.ID == newId).FirstOrDefaultAsync();
        }

        //This is the Function to delete the new recepie 
        public Task<int> DeleteItemAsync(RecipieItem recipieItems)
        {
            return Database.DeleteAsync(recipieItems);
        }

        //This is the Function to save the  recepie 
        public Task<int> SaveItemAsync(RecipieItem itemRecipie)
        {
            if (itemRecipie.ID != 0)
            {
                //This updates the saved data in the database by seleting the data by the ID
                return Database.UpdateAsync(itemRecipie);
            }
            else
            {
                //This inserts the saved data in to the database
                return Database.InsertAsync(itemRecipie);
            }
        }

        
    }
}

