using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Marks
    {
        [Key]
        public int MarkId {  get; set; }
        public int Tamil {  get; set; }
        public int English {  get; set; }
        public int Math {  get; set; }
        public int Science {  get; set; }
        public int Social {  get; set; }
        public int studentId { get; set; }
        public StudentDetails StudentDetails { get; set; }
    }
}
