using System.ComponentModel.DataAnnotations;

namespace MvcMusicStudio.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Required()]
        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}