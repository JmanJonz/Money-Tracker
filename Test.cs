public class Test{
    // object state
        public int Age;

    // object constructor
        public Test(int age){
            Age = age;
        }
    // object functionality
        public void DisplayAge(){
            System.Console.WriteLine(Age);
        }

        public void MultiplyAgeBy(int by){
            Console.WriteLine(Age * by);
        }
}