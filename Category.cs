using Microsoft.VisualBasic;

public class Category{
    // state
        public readonly string Name;
        private List<Transaction> Transactions;

    // object constructor
        public Category(string name){
            Name = name;
        }

    // object functionality
        public void AddTransaction(Transaction transaction){
            Transactions.Add(transaction);
        }
}