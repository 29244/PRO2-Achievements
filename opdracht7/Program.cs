using System;

namespace wirwar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goedemorgen wie ben jij eigenlijk?");
            String name = Console.ReadLine();

            if (name == "Erwin")
            {
                Console.WriteLine("goedemorgen Erwin!"); 

            }
            else if (name == "Erik")
            {
                Console.WriteLine("goedemorgen Erik");
            }
            else if(name=="Alex")
            {
                Console.WriteLine("Goedemorgen Alex");
            }
            else
            {
             Console.WriteLine("Wat is je naam?");
            }
        }
    }
}
