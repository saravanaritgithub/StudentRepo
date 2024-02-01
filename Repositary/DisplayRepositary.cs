using ConsoleToDB.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositary
{
    public class DisplayRepositary: IDisplayServices
    {
        private readonly DataContext _context;
        public DisplayRepositary(DataContext context)
        {
            _context = context;
        }
        public async Task<Display> GetDisplaysById(int Id)
        {
            return await _context.Display.FirstOrDefaultAsync(t => t.Id == Id);
        }
    }
}
