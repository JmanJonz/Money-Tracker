Console.WriteLine("---------- Transaction Tracker ---------\n");

// The program runs and menu is available until the user exits
    var userInput = "k";
    var categoryList = new List<Category>;

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

        }else if(userInput == "b"){
            console.Write("Enter A New Category Name: ");
            var newCatName = console.ReadLine();
            var newCatObj = new Category
        }else if(userInput == "c"){

        }
    }