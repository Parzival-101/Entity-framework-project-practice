using System;
using System.Collections.Generic;

namespace EntityFrameworkConsoleApp
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public Genre Genres { get; set; }
    }
}
