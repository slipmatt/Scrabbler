using System;
using System.Collections.Generic;

namespace Scrabbler.Data
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public List<string> Words { get; set; }
        public int Points { get; set; }
    }
}
