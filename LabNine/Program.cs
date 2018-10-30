using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNine
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the nested student list with name and facts 
            List<List<string>> studentList = new List<List<string>>();
            // James - I think you are using this "null" entry as a means to handle the 0th index? you don't 
            // have to do that, you can just handle the index in your code later when validating information.
            studentList.Add(new List<string>
            { "null" });
            studentList.Add(new List<string>
            { "Susan James", "Arlington, VA", "apples", "yellow", "33" });
            studentList.Add(new List<string>
            { "George Walsh", "Macon, GA", "doughnuts", "gray", "4" });
            studentList.Add(new List<string>
            { "Jill Poole", "Kalamazoo, MI", "gum drops", "red", "2" });
            studentList.Add(new List<string>
            { "Henry Gannet", "Saginaw, MI", "candy bars", "blue", "9" });
            studentList.Add(new List<string>
            { "Betty Turner", "Rome, Italy", "potato chips", "orange", "11" });
            studentList.Add(new List<string>
            { "Sam Caan", "London, England", "hot dogs", "silver", "11" });
            studentList.Add(new List<string>
            { "Kristen Adams", "Paris, France", "hamburgers", "scarlet", "3" });
            studentList.Add(new List<string>
            { "Tim Door", "Moscow, Russia", "pizza", "purple", "21" });
            studentList.Add(new List<string>
            { "Cindy Loomis", "New York, NY", "nachos", "green", "55" });
            studentList.Add(new List<string>
            { "David Reed", "Boston, MA", "tacos", "yellow", "100" });
            studentList.Add(new List<string>
            { "Leslie June", "Seattle, WA", "pasta", "opal", "19" });
            studentList.Add(new List<string>
            { "Aaron Nash", "Cairo, Egypt", "crackers", "orange", "89" });
            studentList.Add(new List<string>
            { "Veronica Humphries", "Beijing, China", "cheese", "pink", "88" });
            studentList.Add(new List<string>
            { "Eric Cavatto", "Tokyo, Japan", "bon bons", "lilac", "5" });
            studentList.Add(new List<string>
            { "Mary Wojacaski", "Mexico City, Mexico", "ice cream", "green", "13" });
            studentList.Add(new List<string>
            { "Oscar Revel", "Vancouver, Canada", "blueberries", "red", "666" });
            studentList.Add(new List<string>
            { "Nancy Lapp", "Montreal, Canada", "soup", "navy", "77" });
            studentList.Add(new List<string>
            { "Chris Van Doore", "Toronto, Canada", "licorce", "blue", "101" });
            studentList.Add(new List<string>
            { "Erin Smith", "Los Angeles, CA", "chocolate cake", "violet", "3" });
            studentList.Add(new List<string>
            { "Tom Yelsnuth", "Dearborn, MI", "apple pie", "black", "10" });
          
            //Here is the repeat loop for main program 
            bool repeatMain = true;
            while (repeatMain)
            {
                var studentNumber = GetStudentNumber();
                Console.WriteLine($"The student you selected is " +
                    $"{studentList[studentNumber][0]}.");
                Console.WriteLine();
                var infoItem = 0;

                // James - I like this usage of a string.Empty, nice.
                string favoriteInfoInput = string.Empty;
                bool repeatInfo = true;

                /* Have user select the information they wish to know 
                    * and validate that input. Also set up loops for 
                    * user to repeat section if he or she wishes */
                 // James -  Consider putting this entire while loop in it's own method then returning the user input number.
                while (repeatInfo)
                {   bool repeat = true;
                    while (repeat)
                    {
                        // James - I really like the way you are handling this, pretty clever.  I would 
                        // consider using a switch statement instead, it will make this much easier to read.
                        favoriteInfoInput = FavoriteInfoInput();
                        if (favoriteInfoInput.Equals
                            ("Hometown", StringComparison.OrdinalIgnoreCase))
                        {
                            infoItem = 1;
                            favoriteInfoInput = "hometown";
                            repeat = false;
                        }
                        else if (favoriteInfoInput.Equals
                            ("favorite food", StringComparison.OrdinalIgnoreCase))
                        {
                            infoItem = 2;
                            favoriteInfoInput = "favorite food";
                            repeat = false;
                        }
                        else if (favoriteInfoInput.Equals
                            ("food", StringComparison.OrdinalIgnoreCase))
                        {
                            infoItem = 2;
                            favoriteInfoInput = "favorite food";
                            repeat = false;
                        }
                        else if (favoriteInfoInput.Equals
                            ("favorite color", StringComparison.OrdinalIgnoreCase))
                        {
                            infoItem = 3;
                            favoriteInfoInput = "favorite color";
                            repeat = false;
                        }
                        else if (favoriteInfoInput.Equals
                            ("color", StringComparison.OrdinalIgnoreCase))
                        {
                            favoriteInfoInput = "favorite color";
                            infoItem = 3;
                            repeat = false;
                        }
                        else if (favoriteInfoInput.Equals
                            ("favorite number", StringComparison.OrdinalIgnoreCase))
                        {
                            favoriteInfoInput = "favorite number";
                            infoItem = 4;
                            repeat = false;
                        }
                        else if (favoriteInfoInput.Equals
                            ("number", StringComparison.OrdinalIgnoreCase))
                        {
                            favoriteInfoInput = "favorite number";
                            infoItem = 4;
                            repeat = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that is not a valid input.");
                        }
                    }
                    //Section to put it all together here
                    // James - I see that you are getting used to accessing the Index of a list, good job!
                    // but as a programmer, you can completely handle if the user enters 0 instead ;)
                    Console.WriteLine($"{studentList[studentNumber][0]}'s " +
                        $"{favoriteInfoInput}: {studentList[studentNumber][infoItem]}");
                    Console.WriteLine();
                    Console.WriteLine($"Would you like to know " +
                        $"something else about {studentList[studentNumber][0]}?");

                    repeatInfo = ExitStudentFav();
                }
                    repeatMain = ExitProgram();
            }
            Console.WriteLine("Thank you, have a great day!");
            Console.ReadKey();
        }

        // James - I really like that this is in it's own seperate method, good stuff.
        public static int GetStudentNumber()
        {
            Console.WriteLine("Welcome to Ye Olde Computer School Student information portal!");
            Console.Write("Please enter a student number (1-20) : ");
            string numberInput = Console.ReadLine();
            Console.WriteLine();

            int studentNumber = 0;
            while (!int.TryParse(numberInput, out studentNumber) || studentNumber < 1 || studentNumber > 20)
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                Console.Write("Please enter a number between 1 and 20: ");
                numberInput = Console.ReadLine();
                Console.WriteLine();
            }
            return studentNumber;
        }
        public static string FavoriteInfoInput()
        {
            //START have user select the information they wish to know and validate that input


            string favoriteInfoInput = string.Empty;


            Console.WriteLine("What information would you " +
                    "like to know about this student? Please choose " +
                    "from one of the following: ");
                Console.Write("Hometown, favorite food, " +
                    "favorite color or favorite number: ");
                favoriteInfoInput = Console.ReadLine();
                Console.WriteLine();
                return favoriteInfoInput;

        }
        public static bool ExitStudentFav()
        {
            bool repeatInfo = true;
            Console.Write("Please type \"y\" to go again or any other key to return to student selection: ");
            var repeatInputA = Console.ReadLine();

            Console.WriteLine();
            if (!repeatInputA.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                repeatInfo = false;
            }
            return repeatInfo;
        }
        public static bool ExitProgram()
        {
            //start area to go again whole package
            bool repeatMain = true;
            Console.WriteLine("Would you like to learn about another student?");
            Console.Write("Please type \"y\" to go again or any other key to exit: ");
            string repeatInputB = Console.ReadLine();
            Console.WriteLine();
            if (!repeatInputB.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                repeatMain = false;
            }
            return repeatMain;   
        }
    }
}


