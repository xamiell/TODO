using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace TODO.Model
{
    public class ItemTask
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public bool IsCompleted { get; set; }
        public string Color { get; set; }
    }
}
