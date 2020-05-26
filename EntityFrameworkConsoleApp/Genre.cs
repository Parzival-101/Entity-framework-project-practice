using System.Collections.Generic;

namespace EntityFrameworkConsoleApp
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }
    }
}
