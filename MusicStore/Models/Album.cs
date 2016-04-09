using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MusicStore.Models
{
    //We do not want AlbumId for a album which is created by Form
    [Bind(Exclude = "AlbumId")]
    public class Album
    {
        // We don't want to show AlbumId field on form
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }

        //When user forgets selecting this field, there is a message "xxx is requried", xxx is DisplayName
        [DisplayName("Genre")]
        public int GenreId { get; set; }

        [DisplayName("Artist")]
        public int ArtistId { get; set; }

        [Required(ErrorMessage="An Album Title is requried")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is requried")]
        [Range(0.01, 100.00, ErrorMessage="Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }

        [DisplayName("Album Art URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }


        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}