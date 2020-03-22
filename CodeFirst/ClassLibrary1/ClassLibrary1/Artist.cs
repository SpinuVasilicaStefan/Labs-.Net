using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public partial class Artist
    {
        public Artist()
        {
            this.Album = new HashSet<Album>();
        }
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Album> Album { get; set; }
    }
}
