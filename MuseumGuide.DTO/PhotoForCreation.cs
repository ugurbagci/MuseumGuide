using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuseumGuide.DTO
{
    public class PhotoForCreation
    {
        public PhotoForCreation()
        {
            DateAdded = DateTime.Now;
        }

        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
    }
}
