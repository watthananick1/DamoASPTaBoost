namespace DamoASPTaBoost.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Department { get; set; }
        public string Detail { get; set; }
    }
}
