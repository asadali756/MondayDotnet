namespace project.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public Student(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
