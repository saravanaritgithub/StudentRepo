using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class StudentDetails
    {
        public int Id { get; set; } = 1;
        [Key]
        public int Regno { get; set; } = 241001;
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string SchoolName { get; set; }
        public int Std { get; set; }
        public long Phno { get; set; }
    }
}
