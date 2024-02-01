using ConsoleToDB.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repositary
{
    public class MarkDetailsRepositary: IMarkServices
    {
        private readonly DataContext _context;
        public MarkDetailsRepositary(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Marks>> GetMarks()
        {
            return await _context.Marks.ToListAsync();
        }
        public async Task<Marks> GetMarksById(int Id)
        {
            return await _context.Marks.FirstOrDefaultAsync(t => t.MarkId == Id);
        }
        public async Task<Marks> AddMarks(Marks marks)
        {
            var result = await _context.Marks.AddAsync(marks);
             await _context.SaveChangesAsync();
            await Reportcard(marks);
            return result.Entity;   
        }
        public async Task<Display> Reportcard(Marks marks)
        {
            Display display = new Display();
            display.MarkId=marks.MarkId;
            display.Marks = marks;
            var result = await _context.StudentDetails.FirstOrDefaultAsync(t => t.Regno == marks.studentId);
            display.StudentName=result.Name;
            display.TotalMarks = marks.Tamil + marks.Math+ marks.Science+marks.Social+ marks.English;
            display.Percentage = (marks.Tamil + marks.Math + marks.Science + marks.Social + marks.English) / 5; 
            if (marks.Tamil >= 40 && marks.Social >= 40 && marks.Science >= 40 && marks.English >= 40 && marks.Math >= 40)
            {
                if (display.TotalMarks >= 300 && display.TotalMarks<400)
                {
                    display.Grade = "First Class";
                }
                else if (display.TotalMarks >= 400 && display.TotalMarks<500)
                {
                    display.Grade = "Distinction";
                }
                else if (display.TotalMarks == 500)
                {
                    display.Grade = "StateFirst";
                }
            }
            else
            {
                display.Grade = "Fail";
            }
            var addReport = await _context.Display.AddAsync(display);
            await _context.SaveChangesAsync();
            return addReport.Entity;
        }
        public async Task<Marks> UpdateMarks(Marks marks)
        {
            var result = await _context.Marks.FirstOrDefaultAsync(t => t.MarkId == marks.MarkId);
            if (result != null)
            {
                result.MarkId = marks.MarkId;
                result.Tamil = marks.Tamil;
                result.English = marks.English;
                result.Math = marks.Math;
                result.Science = marks.Science;
                result.Social = marks.Social;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
