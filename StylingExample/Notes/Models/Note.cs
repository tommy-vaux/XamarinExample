using System;
using SQLite;

namespace Notes.Models
{
        // An example of how to implement a simple data class for storing data for each note.
        public class Note
        {
                [PrimaryKey, AutoIncrement]
                public int ID { get; set; }
                public string Text { get; set; }
                public DateTime Date { get; set; }
        }
}
