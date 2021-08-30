using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnglishApp
{
    public class LessonRepository
    {
        SQLiteConnection database;

        public LessonRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
        }

        public IEnumerable<LessonTable> GetItems_LessonTable()
        {
            return database.Table<LessonTable>().ToList();
        }

        public IEnumerable<PracticeTable> GetItems_PracticeTable()
        {
            return database.Table<PracticeTable>().ToList();
        }

        public LessonTable GetItem_LessonTable(int id)
        {
            return database.Get<LessonTable>(id);
        }

        public IEnumerable<PracticeTable> GetItem_PracticeTable(int id_lesson)
        {
            return database.Query<PracticeTable>("SELECT * FROM Practice WHERE id_lesson = " + id_lesson.ToString());
        }
    }
}
