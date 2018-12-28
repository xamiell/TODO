using System;
using System.Collections.Generic;
using System.IO;

using SQLite;
using TODO.Model;

namespace SQLiteXamarin
{
    public class DatabaseManagement
    {
        private SQLiteConnection ItemDataBase;

        public DatabaseManagement()
        {
             if(ItemDataBase == null)
                ItemDataBase = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), $"{nameof(ItemDataBase)}.db"));

            ItemDataBase.CreateTable<ItemTask>();
        }

        public void SaveItem(ItemTask item) => ItemDataBase.Insert(item);

        public IEnumerable<ItemTask> QueryItem() => ItemDataBase.Table<ItemTask>();

        public void DeleteItem(int id) => ItemDataBase.Delete<ItemTask>(id);
    }
}
