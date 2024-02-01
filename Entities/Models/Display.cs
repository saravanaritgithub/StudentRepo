using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Display
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int TotalMarks {  get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
        public int MarkId { get; set; }
        public Marks Marks { get; set; }
    }
}
