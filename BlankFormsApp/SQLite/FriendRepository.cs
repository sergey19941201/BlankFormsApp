using System;
using System.Collections.Generic;
using BlankFormsApp.SQLite.Tables;
using SQLite;

namespace BlankFormsApp.SQLite
{
    [Obsolete]
    public class FriendRepository
    {
        SQLiteConnection database;
        static readonly object locker = new object();
        
        public FriendRepository(string databasePath)
        {
            lock (locker)
            {
                if (database == null)
                {
                    database = new SQLiteConnection(databasePath);
                    database.CreateTable<Friend>();
                }
            }
        }
        public IEnumerable<Friend> GetItems()
        {
            lock (locker)
            {
                return database.Table<Friend>().ToList();
            }
        }
        public Friend GetItem(int id)
        {
            lock (locker)
            {
                return database.Get<Friend>(id);
            }
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Friend>(id);
            }
        }
        public int SaveItem(Friend item)
        {
            lock (locker)
            {
                if (item.Id != 0)
                {
                    database.Update(item);
                    return item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }
    }
}