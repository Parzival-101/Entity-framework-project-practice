using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkConsoleApp
{
 public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleasedDate { get; set; }
        [Column("GenreId")]
        public Genre Genres { get; set; }
        public Classification Level { get; set; }
        public IList<Tag> Tags { get; set; }
    }
    public enum Classification
        :byte
    {
        Silver =1,
        Gold = 2,
        Platinum =3
    }
    public class Tag
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Video Videos { get; set; }
    }
}
