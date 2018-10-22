using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{

    class Program
    {
        public static List<string> students = new List<string> { "Steve", "Sean O", "Evan", "Heather", "Tony", "Johnathan", "Camille", "Jacky", "Rudy", "Clayton", "Mauricio", "Levi", "Nick", "Katie", "David", "Mace", "Ty", "Dan", "Cheri" };
        public static List<string> hometown = new List<string> { "Royal Oak", "Flint", "Farm", "East Point", "Somewhere in Georgia", "Warren", "Berlin", "Rochester", "Detroit", "Indiana", "Grand Rapids", "Seattle", "Washington D.C.", "Ferndale", "Bawston", "New York", "Oxford", "Key West", "Somewhere in the UP" };
        public static List<string> favoriteFood = new List<string> { "goldfish", "Steak", "Juniper Berries", "cranberries", "potato salad", "Hot Tacos", "Hot Pockets", "Cheetos", "Water", "Green beans", "diet coke", "pizza", "olive tacos", "corck pot chili", "planters peanut packs", "nothing that's made in other people's kitchens", "green grapes but not red grapes", "fried peas", "oranges" };
        public static List<string> favoriteColor = new List<string> { "green", "blue", "blue", "emerald green", "turquoise", "magenta", "lime green", "purple", "vomit green", "red", "gun metal gray", "orange", " red", "yellow", "beet red", "red", "orange", "pink", "black" };
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# .NET Class! ");
            bool cont = true;
            while (cont)
            {
                ClassValidation.VerifyAndReturnDetails();//calls method to verify correct input and then return details from each list based on response
                Console.Write("Would you like to learn about another student or add another student to the list? (y/n): ");
                cont = ClassValidation.YesOrNo();//verifies y or n
                if (cont)
                {
                    ClassValidation.AddOrLearn();//calls method to decide whether user would like to add a new student or learn about an existing student
                }
                else
                {
                    break;//breaks loop and ends program
                }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
