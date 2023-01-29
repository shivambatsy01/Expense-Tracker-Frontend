namespace ExpenseTrackerFrontend.Models.AddData
{
    public class CreateExpense
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfExpense { get; set; }
        public string Remarks { get; set; }
        public int CategoryId { get; set; }
    }
}
