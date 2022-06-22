using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Day64Self.Data.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Unicode(false)]
        [StringLength(500)]
        public string? Description { get; set; }
    }
}
