using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    public class StudentContext : DbContext

    {
        public StudentContext (DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> tbl_Students { get; set; }
        public DbSet<Departmets> tbl_Departments { get; set; }
    }
}
