namespace final_project.Models
{
    public class Employee: UserActivity
    {
        public int Id { get; set; }

        public string EmpNO { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullNeme => $"{FirstName} {MiddleName} {LastName}";

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Adress { get; set; }

        public string Department { get; set; }

        public int Designation { get; set; }


    }
}
