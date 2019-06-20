using MuseumGuide.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuseumGuide.DTO
{
    public class MuseumForDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Photo> Photos { get; set; }
    }
}
