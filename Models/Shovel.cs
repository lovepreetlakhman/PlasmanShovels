using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasmanShovels.Models
{
    public class Shovel
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Usage { get; set; }
        public string Material { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Type { get; set; }    
        public string Weight { get; set; }
        public string Rating { get; set; }
    }
}
