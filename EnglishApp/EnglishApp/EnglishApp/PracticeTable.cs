using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnglishApp
{
    [Table("Practice")]
    public class PracticeTable
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string sentence_en { get; set; }
        public string sentence_ru { get; set; }
        public int id_lesson { get; set; }
    }
}
