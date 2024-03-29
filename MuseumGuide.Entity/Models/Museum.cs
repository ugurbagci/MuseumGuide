﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MuseumGuide.Entity.Models
{
    public class Museum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<Photo> Photos { get; set; }
    }
}
