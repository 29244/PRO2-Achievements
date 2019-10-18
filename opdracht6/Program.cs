using System;

namespace opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string a;
            Console.WriteLine("Hi there, this is a simple quiz where the only answers you can give are 'yes' or 'no'.");
            Console.WriteLine("Please be kind enough to write down your name in the colum below");
            a = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Welcome to the quiz {0}!", a);
            Console.WriteLine("Are you ready to begin the quiz?");
            Console.ReadLine();

            Console.Clear();

            string b;
            Console.WriteLine("Question one: Are you liking your school so far?");
            b = Console.ReadLine();

            if (b == "yes" || b == "Yes")
            {
                Console.WriteLine("Im glad you're liking the place :D");
            }
            else if (b == "no" || b == "No")
            {
                Console.WriteLine("That's awful to hear, i hope it improves soon :(");
            }
            else if (b == "\n")
            {
                Console.WriteLine("Please give a valid input!!!");
            }
            Console.WriteLine("press any button to continue");
            Console.ReadKey(true);


            Console.Clear();

            string c;
            Console.WriteLine("Question two: Is the homework you're recieving possible to do in your free time?");
            c = Console.ReadLine();
            if (c == "yes" || c == "Yes")
            {
                Console.WriteLine("Good to hear, keep up the good work!");
            }
            else if (c == "no" || c == "No")
            {
                Console.WriteLine("Doesn't sound good. You either have too little time or you're not working enough.");
            }
            else if (c == "\n")
            {
                Console.WriteLine("Please give a valid input!!!");
            }
            Console.WriteLine("press any button to continue");
            Console.ReadKey(true);

            Console.Clear();

            string d;
            Console.WriteLine("Question three: Do you like the food from school?");
            d = Console.ReadLine();
            if (d == "yes" || d == "Yes")
            {
                Console.WriteLine("Sounds like you like it alot, wish i could try but im a program :/");
            }
            else if (d == "YES")
            {
                Console.WriteLine("FOOOOOOOOOOOOODDDDDDDD");
            }
            else if (d == "no" || d == "No")
            {
                Console.WriteLine("That sucks, maybe they'll bring new kind of food soon, for now enjoy that you bring with ya");
            }
            else if (d == "\n")
            {
                Console.WriteLine("Please give a valid input!!!");
            }
            Console.WriteLine("press any button to continue");
            Console.ReadKey(true);
            Console.Clear();

            if (b == "yes" && c == "yes")
            {
                Console.WriteLine("Your Answers were:");
                Console.WriteLine("A = Yes");
                Console.WriteLine("B = Yes");
                Console.WriteLine("C = No");
            }
            else if (b == "yes" && c == "yes" && d == "yes")
            {
                Console.WriteLine("A = Yes");
                Console.WriteLine("B = Yes");
                Console.WriteLine("C = Yes");
            }
            else if (c == "yes" && d == "yes")
            {
                Console.WriteLine("A = No");
                Console.WriteLine("B = Yes");
                Console.WriteLine("C = Yes");
            }
            else if (b == "yes" && d == "yes")
            {
                Console.WriteLine("A = Yes");
                Console.WriteLine("B = No");
                Console.WriteLine("C = Yes");
            }
            else if (b == "yes")
            {
                Console.WriteLine("A = Yes");
                Console.WriteLine("B = No");
                Console.WriteLine("C = No");
            }
            else if (c == "yes")
            {
                Console.WriteLine("A = No");
                Console.WriteLine("B = Yes");
                Console.WriteLine("C = No");
            }
            else if (d == "yes")
            {
                Console.WriteLine("A = No");
                Console.WriteLine("B = No");
                Console.WriteLine("C = Yes");
            }
            else if (b == "no" && c == "no" && d == "no")
            {
                Console.WriteLine("A = No");
                Console.WriteLine("B = No");
                Console.WriteLine("C = No");
            }
            else if (b == "yes" && d == "yes")
            {
                Console.WriteLine("A = Yes");
                Console.WriteLine("B = No");
                Console.WriteLine("C = Yes");
            }
        }
    }
} 