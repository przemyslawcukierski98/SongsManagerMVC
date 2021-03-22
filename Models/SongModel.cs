using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Models
{
    [Table("Songs")]
    public class SongModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tytuł utworu")]
        [Required(ErrorMessage = "Pole tytułu jest wymagane")]
        [MaxLength(100)]
        public string Title { get; set; }
        [DisplayName("Album")]
        [Required(ErrorMessage = "Pole album jest wymagane")]
        [MaxLength(100)]
        public string Album { get; set; }
        [DisplayName("Długość")]
        [Required(ErrorMessage = "Pole długość jest wymagane")]
        public int Length { get; set; }
        [DisplayName("Artysta")]
        [Required(ErrorMessage = "Pole artysta jest wymagane")]
        [MaxLength(100)]
        public string Artist { get; set; }
        [DisplayName("Opis")]
        [Required(ErrorMessage = "Pole opis jest wymagane")]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
