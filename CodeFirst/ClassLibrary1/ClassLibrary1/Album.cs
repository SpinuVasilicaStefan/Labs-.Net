using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public partial class Album
    {   
        public Album()
        {
            this.Artist = new HashSet<Artist>();
        }

        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public virtual ICollection<Artist> Artist { get; set; }
    }
}
