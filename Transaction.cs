public class Transaction{
    // state
        public readonly string TType;
        public readonly string Category;
        public readonly decimal Amount;
        public readonly DateTime TimeStamp;

    // object constructor
        public Transaction(string tType, string category, decimal amount){
            // .Now is not a method it is the objects state
                TimeStamp = DateTime.Now;
            TType = tType.ToLower();
            Category = category;
            Amount = amount;
            // make sure that type is either expense or income
                if(TType != "income" && TType != "expense"){
                    throw new ArgumentException(nameof(TType), "Invalid transaction type. Must be Income or Expense");
                }
            // validate that trans type is in accordance with it's sign
                if(TType == "expense" && Amount >= 0){
                    throw new ArgumentOutOfRangeException(nameof(Amount), "Expense amount must be negative.");
                }else if(TType == "income" && Amount <= 0){
                    throw new ArgumentOutOfRangeException(nameof(Amount), "Income amount must be positive.");
                }
        }

    // object methods
        public void GutCheck(){
                        Console.WriteLine($"ttype is {TType}");
                        Console.WriteLine($"category is {Category}");
                        Console.WriteLine($"Amount is {Amount}");
                        Console.WriteLine($"timestap is {TimeStamp}");
        }
}