using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string a;
            Console.WriteLine("Hi there, this is a computer system that will ask a few questions of you");
            Console.WriteLine("Please be kind enough to wrte down your name in the colum below");
            a = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Hi {0}, welcome to this quiz", a);
            Console.WriteLine("Are you ready to begin the quiz?");
            Console.ReadLine();

            Console.Clear();

            string b;
            Console.WriteLine("Question 1: In what year was the building from Media College build?"); 
            b = Console.ReadLine();

            Console.Clear();

            string c;
            Console.WriteLine("Question 2: What was the name of Media college before it became the school we know now?"); 
            c = Console.ReadLine();

            Console.Clear();

            string d;
            Console.WriteLine("Question 3: How long do Media College and all the other companies exsist in total when it comes to years?");
            d = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("All answers and correct answers");
            Console.WriteLine();
            Console.WriteLine("Question one answer: {0}", b);
            Console.WriteLine("Correct answer: 1913");
            Console.WriteLine();
            Console.WriteLine("Question two answer: {0}", c);
            Console.WriteLine("Correct answer: Grafisch Lyceum");
            Console.WriteLine();
            Console.WriteLine("Question three answer: {0}", d);
            Console.WriteLine("Correct answer: 101 years");





        }
    }
}
