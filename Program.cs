Console.WriteLine("---------- Transaction Tracker ---------\n");

// The program runs and menu is available until the user exits
    var userInput = "k";
    var categoryList = new List<Category>();

    while(userInput != "d"){
        // This is basically the Transaction Tracker Class and can
        // have state like an array of category etc and it's own methods
        // then you can call one of it's methods to run the program

        Console.WriteLine("Menu:");
        Console.WriteLine("A - Add A Transaction");
        Console.WriteLine("B - Add A Category");
        Console.WriteLine("C - View Transaction Summary");
        Console.WriteLine("D - Close Transaction Tracker");
        Console.Write("Enter Your Selection: ");
        userInput = Console.ReadLine().ToLower();

        if(userInput == "a"){
            string tType;
            string category;
            decimal amount;

            Console.Write("Type A For Income Or B For Expense: ");
            string tTypeChoice = Console.ReadLine().ToLower();
            if(tTypeChoice == "a"){
                tType = "income";
            }else if(tTypeChoice == "b"){
                tType = "expense";
            }else{
                Console.WriteLine("You did not enter correct Information, your transaction will not be added.");
                tType = "kdjfdkf";
            }
            Console.WriteLine("");
            Console.WriteLine("Chose An Existing Category");
            foreach(Category curntCat in categoryList){
                Console.WriteLine($"- {curntCat.Name}");
            }
            Console.Write("Type In The Chosen Category Correctly: ");
            category = Console.ReadLine().ToLower();
            Console.WriteLine("");
            Console.WriteLine("Enter The Amount Below - Expense Must Be Negative");
            Console.Write("Enter The Amount: ");
            amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            var newTrans = new Transaction(tType, category, amount);
            foreach(Category curntCat in categoryList){
                if(curntCat.Name == category){
                    Console.WriteLine($"Transaction Type {newTrans.TType}, Category {newTrans.Category}, Amount {newTrans.Amount}, TimeStamp {newTrans.TimeStamp} Created");
                    curntCat.AddTransaction(newTrans);
                }
            }            
        }else if(userInput == "b"){
            Console.WriteLine("Your Existing Categories Are:");
            foreach(Category curntCat in categoryList){
                Console.WriteLine($"- {curntCat.Name}");
            }
            Console.WriteLine("");
            Console.Write("Enter A New Category Name: ");
            var newCatName = Console.ReadLine();
            if(newCatName != null){
                var newCatObj = new Category(newCatName);
                categoryList.Add(newCatObj);
                Console.WriteLine($"Category {newCatObj.Name} has been added");
            }
        }else if(userInput == "c"){
            Console.WriteLine("");
            Console.WriteLine("Here Is Your Transaction Summary By Category:");
            foreach(Category curntCat in categoryList){
                Console.WriteLine($"{curntCat.Name} Transactions:");
                var catTotal = 0m;
                foreach(Transaction curntTrans in curntCat.Transactions){
                    catTotal += curntTrans.Amount;
                    Console.WriteLine($"Transaction Type {curntTrans.TType}, Category {curntTrans.Category}, Amount {curntTrans.Amount}, TimeStamp {curntTrans.TimeStamp}");
                }
                Console.WriteLine($"Category Total: {catTotal}");
                            Console.WriteLine("");
            }
                        Console.WriteLine("");
        }
    }