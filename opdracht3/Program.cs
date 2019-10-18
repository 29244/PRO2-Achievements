using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string s;
            Console.WriteLine("-------Enter Your Name-----!");
            s = Console.ReadLine();

            Console.Clear();

            string d;
            Console.WriteLine("Where do you come from?");
            d = Console.ReadLine();

            Console.Clear();

            string q;
            Console.WriteLine("What is your zip code?");
            q = Console.ReadLine();

            Console.Clear();

            string t;
            Console.WriteLine("How old are you?");
            t = Console.ReadLine();

            Console.Clear();

            string w;
            Console.WriteLine("Some personal questions, What is your favorite hobby?");
            w = Console.ReadLine();

            Console.Clear();

            string b;
            Console.WriteLine("Do you have more hobby's or favorite activities besides that?");
            b = Console.ReadLine();

            Console.Clear();

            string h;
            Console.WriteLine("What color do your eyes have?");
            Console.WriteLine("(Only write down your color, nothing else)");
            h = Console.ReadLine();

            Console.Clear();

            string j;
            Console.Write("How tall are you?");
            j = Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Hi There, nice to meet you {0}", s);
            
            Console.WriteLine("I see that your zip code is also {0}", q);
            
            Console.WriteLine("So your favorite hobby is {0}", w);
            
            Console.WriteLine("And your favorite activity/second hobby is {0}", b);

            Console.WriteLine("You're pretty tall with a length of {0}", j);

            Console.WriteLine("Also, {0} eyes are really good looking", h);

        }
    }
}
