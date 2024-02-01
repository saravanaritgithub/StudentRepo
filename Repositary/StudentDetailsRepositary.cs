using ConsoleToDB.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Repositary
{
    public class StudentDetailsRepositary : IStudentDetailsServices
    {
        private readonly DataContext _context;
        public StudentDetailsRepositary(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<StudentDetails>> GetStudentDetails()
        {
            return await _context.StudentDetails.ToListAsync();
        }
        public async Task<StudentDetails> GetStudentDetailsById(int Id)
        {
            return await _context.StudentDetails.FirstOrDefaultAsync(t => t.Regno == Id);
        }
        public async Task<StudentDetails> AddStudentDetails(StudentDetails studentDetails)
        {
            var result = await _context.StudentDetails.AddAsync(studentDetails);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<StudentDetails> UpdateStudentDetails(StudentDetails studentdetails)
        {
            var result = await _context.StudentDetails.FirstOrDefaultAsync(t => t.Regno == studentdetails.Regno);
            if (result != null)
            {
                result.Regno = studentdetails.Regno;
                result.Name = studentdetails.Name;
                result.DOB = studentdetails.DOB;
                result.SchoolName = studentdetails.SchoolName;
                result.Std = studentdetails.Std;
                result.Phno = studentdetails.Phno;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task DeleteStudentDetails(int id)
        {
            var result = await _context.StudentDetails
                            .FirstOrDefaultAsync(e => e.Regno == id);
            if (result != null)
            {
                _context.StudentDetails.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
    }
}