namespace RelevantPizza.Models
{
    public enum Roles
    {
        Driver
            , Insider
            , AssistantManager
            , Manager
            , Cashier
    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Roles Role { get; set; }
        public decimal Salary { get; set; }

    }
}
