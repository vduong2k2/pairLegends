﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Database
{
    public class Match
    {
        public string PLUserId { get; set; }
        public User PLUser { get; set; }
        public DateTime BeginAt { get; set; }
        public DateTime EndAt { get; set; }
        public int Tiles { get; set; }
        public int TilesDone { get; set; }
        public int Champs { get; set; }
    }
}
