using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
