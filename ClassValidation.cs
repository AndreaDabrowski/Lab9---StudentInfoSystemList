using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class ClassValidation
    {
        public static void VerifyAndReturnDetails()
        {
            string details;
            bool response = true;
            int userInputRow = VerifyFormat();
            while (response)
            {
               
                
                Console.WriteLine("That student #{0} is {1}.", userInputRow, Program.students[userInputRow]);

                Console.WriteLine("What would you like to learn about {0}? (hometown, favorite food or favorite color): ", Program.students[userInputRow]);
                details = Console.ReadLine();
                if (details.ToLower() == "hometown")
                {
                    Console.WriteLine("{0}'s hometown is {1}", Program.students[userInputRow], Program.hometown[userInputRow]);
                    Console.WriteLine("Would you like to learn something else about {0}? (y/n)", Program.students[userInputRow]);
                    response = YesOrNo();
                }
                else if (details.ToLower() == "favorite food")
                {
                    Console.WriteLine("{0}'s favorite food is {1}", Program.students[userInputRow], Program.favoriteFood[userInputRow]);
                    Console.WriteLine("Would you like to learn something else about {0}? (y/n)", Program.students[userInputRow]);
                    response = YesOrNo();
                }
            
                else if (details.ToLower() == "favorite color")
                {
                    Console.WriteLine("{0}'s favorite color is {1}", Program.students[userInputRow], Program.favoriteColor[userInputRow]);
                    Console.WriteLine("Would you like to learn something else about {0}? (y/n)", Program.students[userInputRow]);
                    response = YesOrNo();
                }
                else
                {
                    Console.WriteLine("That data does not exist. Try again? (y/n): ");
                    response = YesOrNo();
                }

            }            
        }
        //both verifies the format (handles the format exception) and that the user input integer is within the specified range
        public static int VerifyFormat()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Choose a class ID number between 1-{0}: ", Program.students.Count);
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0 && num < Program.students.Count)
                    {
                        return num;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Invalid Format: Input valid number (1-{0}: ", Program.students.Count);

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is incorrect range (1-{0}: ", Program.students.Count);
                }

            }
        }
        public static bool YesOrNo()
        {
            string response = Console.ReadLine();
            while (true)
            {
                
                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.Write("Invalid input, try (y/n): ");
                    response = Console.ReadLine().ToLower();
                }
            }

        }
        public static void AddNewNameAndInformation()
        {

            do
            {
                Console.WriteLine("What's the name of the new student? ");
                Program.students.Add(IsNameValid(Console.ReadLine()));
                Console.WriteLine("What is this student's hometown?");
                Program.hometown.Add(IsNameValid(Console.ReadLine()));
                Console.WriteLine("What is this student's favorite food? ");
                Program.favoriteFood.Add(IsNameValid(Console.ReadLine()));
                Console.WriteLine("What is this student's favorite color? ");
                Program.favoriteColor.Add(IsNameValid(Console.ReadLine()));
                int newListLength = Program.students.Count;
                Console.WriteLine("Thank you! {0}'s class ID number is now {1}. ", Program.students[newListLength - 1], (newListLength));
                Console.WriteLine("Add another student? (y/n)");

            }
            while (YesOrNo());
            
        }
        public static string IsNameValid(string info)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(info) || info.Length > 35)
                {
                    Console.WriteLine("That is not correct input, try again" );
                    
                }

                foreach (char item in info)
                {
                    if (!char.IsLetter(item))
                    {
                        Console.WriteLine("You must use alphabetical characters, try again ");
                        
                    }
                }

                return info;
            }

        }
        public static void AddOrLearn()
        {
            do
            {
                Console.WriteLine("type \"add\" to add a student or \"learn\" to learn about an existing student: ");
                string response = IsNameValid(Console.ReadLine());
                if (response.ToLower() == "add")
                {
                    AddNewNameAndInformation();
                }
                else if (response.ToLower() == "learn")
                {
                    VerifyAndReturnDetails();
                }
                else
                {
                    Console.WriteLine("That was not an option, try again? (y/n) ");

                }
            }
            while (YesOrNo());

                
            
        }
    }
}
