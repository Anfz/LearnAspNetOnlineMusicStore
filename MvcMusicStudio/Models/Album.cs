using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStudio.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Display(Name = "Album Title")]
        public string Title { get; set; }

        public Artist Artist { get; set; }

        public virtual List<Review> Review { get; set; } 

        public virtual List<Track> Tracks { get; set; }


    }
}