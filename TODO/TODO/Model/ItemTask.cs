using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace TODO.Model
{
    [Table("Tasks")]
    public class ItemTask
    {
        [AutoIncrement, PrimaryKey, Column("id")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public bool IsCompleted { get; set; }
        public string Color { get; set; }
    }
}
