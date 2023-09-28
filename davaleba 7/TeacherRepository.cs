using davaleba_7.Data;
using davaleba_7.Models;
using System;
using System.Linq;

namespace davaleba_7
{
    public class TeacherRepository
    {
        private readonly SchoolDbContext _context;

        public TeacherRepository()
        {
            _context = new SchoolDbContext();
        }

        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            // Query the database to find teachers who teach a student named "George"
            var teachers = _context.Teachers
                .Where(t => t.Subject != null) // You can add additional filters if needed
                .Where(t => _context.Pupils.Any(p => p.FirstName == studentName && p.Class == t.Subject))
                .ToArray();

            return teachers;
        }
    }
}
