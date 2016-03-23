using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleScramble
{
    class Program
    {

        Random rnd = new Random();
        static void Main(string[] args)
        {
            
            List<string> randomize = new List<string>();
            List<char> letters = new List<char>();
            List<int> current = new List<int>();
            
            while (true)
            {
                Console.Write("enter a word: ");
                String input = Console.ReadLine(); 
                //change letters from char to string see how that works out

                 for (int i = 0; i < input.Count(); i++)
                {
                // add word at i
                      letters.Add(input[i]);
                //letters.Add(i);
                }

                Random rnd = new Random();

                while (randomize.Count() < letters.Count())
                {

                    //Random rnp = new Random();
                    ///rnd.Next(0, letters.Count);
                    //rnp.Next(0, 1);
                    // change length to count
                    int length = letters.Count;
                    // length to count
                    int x = (rnd.Next(0, letters.Count));
                    //int position = rnd.Next(x);

                        while (current.Contains(x))
                        {
                            x = rnd.Next(0, letters.Count);
                        }                    
                           current.Add(x);                        

                    Console.WriteLine(" random x " + x );

                    // random number between 0 and 1 * 10 modded by count
                    //int position = rint(x);
                    // at to element at
                    char l = (char)letters.ElementAt(x);
                    randomize.Add(l.ToString());
                    //letters.RemoveRange(0, x);
                    
                }
                
                //change randomize to string b/c length wont work otherwise
                // but method only works with char strings
                // use count instead of length for strings
                for (int k = 0; k < current.Count(); k++)
                {
                    
                        // at to element at
                        Console.Write(randomize.ElementAt(k));
                    
                }
                Console.Write("\n" + "continue? (y/n) ");
                string cont;
                Console.Write(randomize.Count());
                cont = Console.ReadLine();
                Console.WriteLine(cont);

                if (cont == "y")
                {
                    letters.Clear();
                    randomize.Clear();

                }

            }
        }

    }
}
