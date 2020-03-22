using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Models
{
        // An example of how to implement a simple data class for storing data for each note.
        class Note
        {
                public string Filename { get; set; }
                public string Text { get; set; }

                public DateTime Date { get; set; }
        }
}
