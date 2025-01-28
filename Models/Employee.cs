namespace GestionEmployes.Models
{
    public class Employee
    {
        public int Id { get; set; }  // Clé primaire pour la base de donnée SQL SERVER
        public string FirstName { get; set; } //VARCHAR
        public string LastName { get; set; } //VARCHAR
        public string Department { get; set; } //VARCHAR
        public string Email { get; set; } //VARCHAR
        public DateTime HireDate { get; set; } //DATE
    }
}
