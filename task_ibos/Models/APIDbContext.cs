using Microsoft.EntityFrameworkCore;

namespace task_ibos.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<EmployeeAttendance>EmployeeAttendances { get; set; }
        
    }
}
