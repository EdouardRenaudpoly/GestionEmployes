namespace GestionEmployes.Models
{
    public class Employee
    {
        public int Id { get; set; }  // Clé primaire pour la base de donnée SQL SERVER
        public string Name { get; set; } //VARCHAR
        public string? Department { get; set; } //VARCHAR
        public string? Email { get; set; } //VARCHAR
        public int Salary { get; set; } //VARCHAR
        public DateTime HireDate { get; set; } //DATE
    }
}
