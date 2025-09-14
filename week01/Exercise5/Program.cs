using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome (){
            Console.WriteLine("Welcome to the Program!");
        };

        static string PromptUserName (){
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            return name;
        };

        static int PromptUserNumber (){

            Console.WriteLine("Please enter your favorite number:");
            string response = Console.ReadLine();
            int favoriteNumber = int.Parse(response);

            return favoriteNumber;
        };

        static int SquareNumber(int favoriteNumber){
            
            int squareNumber = favoriteNumber * favoriteNumber;

            return squareNumber;
        };

        static void DisplayResult (string name, int favoriteNumber){

            Console.WriteLine($"{name}, the square of your number is {favoriteNumber}");
        };

        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName,squareNumber);
    }
}