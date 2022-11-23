using Microsoft.EntityFrameworkCore;

namespace ListaStudenti.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions options):base(options)
        {


        }

        public DbSet<Student> Studenti { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 1,
                    Nume = "Sirbu Doina",
                    AnStudiu = 3,
                    Nota =  10,
                
                },
                new Student
                {
                    StudentID = 2,
                    Nume = "Moraru Eusebiu",
                    AnStudiu = 2,
                    Nota = 8,
      
                },
                new Student
                {
                    StudentID = 3,
                    Nume = "Popescu Ion",
                    AnStudiu = 1,
                    Nota = 9,
                 
                }
                ) ;
           
        }
    }
}
