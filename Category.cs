using Microsoft.VisualBasic;

public class Category{
    // state
        public readonly string Name;
        // xxxxxxx I was getting an error becasue I didn't add the new List<Transaction>() at the end...
        // if you don't do that Transactions actually was never initialized to a List of transactions so that
        // is why I couldn't use the .add() method on it
        public readonly List<Transaction> Transactions = new List<Transaction>();

    // object constructor
        public Category(string name){
            Name = name;
        }

    // object functionality
        public void AddTransaction(Transaction transaction){
            Transactions.Add(transaction);
        }
}