using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnglishApp
{
    [Table("Lessons")]
    public class LessonTable
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string text { get; set; }
    }
}
