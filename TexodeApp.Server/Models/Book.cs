using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TexodeApp.Server.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Base64Image { get; set; } = string.Empty;
    }
}
