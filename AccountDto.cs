namespace BankProject.Shared
{
    public class AccountDto
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public Guid UserId { get; set; }
        public double Balance { get; set; }
        public bool Active { get; set; }
        public string Type { get; set; }
    }
}
