public class Transaction{
    // state
        public enum TransType {Income, Expense}
        public decimal Amount {get; set;}
        public string Description {get; set;}
        public DateTime Date {get; set;}

    // optional object constructor function
        public Transaction(enum transType, decimal amount, string description, DateTime date){
            TransType = transType;
            Amount = amount;
            Description = description;
            Date = date;
        }
    // transactions functionalities
        public void LogDetails(){
            Console.WriteLine($"Amount: {Amount:C}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Date: {Date:dd/MM/yyyy}");
            Console.WriteLine($"Type: {Type}");
        }
}