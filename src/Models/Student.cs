namespace myWebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstMidName { get; set; } = null!;
        public DateTime EnrollmentDate { get; set; }

    }
}