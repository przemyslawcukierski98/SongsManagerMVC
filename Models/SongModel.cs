﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Models
{
    public class SongModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Album { get; set; }
        public int Length { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
    }
}
