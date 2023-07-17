namespace BankProject.Shared
{
    public class TransactionForProcessingDto
    {
        public Guid SenderAccountId { get; set; }
        public Guid ReceiverAccountId { get; set; }
        public double Amount { get; set; }
    }
}
