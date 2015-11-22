using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStudio.Models
{
    public class Track
    {
        public int TrackID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}