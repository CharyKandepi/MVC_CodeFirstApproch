using Microsoft.EntityFrameworkCore;
using MVC_CodeFirstApproch.Models;

using Microsoft.Identity.Client;


namespace MVC_CodeFirstApproch.EFMVCORMDB
{
    public class ORMCLASSFORDB: DbContext
    {
       public ORMCLASSFORDB()
        { 
        
        }
        public ORMCLASSFORDB(DbContextOptions<ORMCLASSFORDB> options) : base(options) 
        {

        }
        

        public DbSet <StudentInformation> StudentInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            StudentInformation student = new StudentInformation();
            student.Id = 1;
            student.Name = "John Doe";
            student.Age = 20;
            student.DOB = new DateOnly(2003, 5, 15);
            student.Address = "123 Main St, Cityville";
            student.Gender = "Male";

            StudentInformation student2 = new StudentInformation();
            student2.Id = 2;
            student2.Name = "Jane Smith";
            student2.Age = 22;
            student2.DOB = new DateOnly(2001, 8, 10);
            student2.Address = "456 Elm St, Townsville";
            student2.Gender = "Female";

            List<StudentInformation> stdlist = new List<StudentInformation>();
            stdlist.Add(student);
            stdlist.Add(student2);

            modelBuilder.Entity<MVC_CodeFirstApproch.Models.StudentInformation>().HasData(stdlist);

            

        }
    }
}
