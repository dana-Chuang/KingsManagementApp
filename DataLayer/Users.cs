namespace DataLayer
{
    public class Users
    {
        public int Id { get; set; }
        public int CompanyCodeId { get; set; }
        public string? EmployeeNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Status { get; set; }
        public string? Password { get; set; }
    }

}
