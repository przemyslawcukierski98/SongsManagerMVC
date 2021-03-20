using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Models
{
    public class SongModel
    {
        public int Id { get; set; }
        [DisplayName("Tytuł utworu")]
        public string Title { get; set; }
        [DisplayName("Album")]
        public string Album { get; set; }
        [DisplayName("Długość")]
        public int Length { get; set; }
        [DisplayName("Artysta")]
        public string Artist { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
    }
}
