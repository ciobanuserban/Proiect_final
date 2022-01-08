using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_final.Models
{
    public class Song
    {
        public int ID { get; set; }
        [Display(Name = "Song Title")]
        public string Single { get; set; }
        public string Album { get; set; }
        [Column(TypeName = "decimal(8, 4)")]
        public decimal AlbumPrice { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int RecordLabelID { get; set; }
        public RecordLabel RecordLabel { get; set; }
        //navigation property
        public ICollection<SongGenre> SongGenres { get; set; }
    }
}
