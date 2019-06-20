using System;
using System.Collections.Generic;
using System.Text;

namespace MuseumGuide.Entity.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordDate { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public virtual List<Museum> Museums { get; set; }
    }
}
