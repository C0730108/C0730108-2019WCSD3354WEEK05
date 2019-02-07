using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730108
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
        class TestQuestion2
        {
            public int myFavouriteVariables = 0;
            public void PlayingWithForLoops()
            {
                // Write a for loop to Add 10 numbers
                for(; MyMethod();)
                {
                    if(myFavouriteVariables>10)
                    {
                        Console.WriteLine("i am so out of here");
                        break;

                    }
                    Console.WriteLine("oh no I have to go through this stupid loop again");

                }
            }
            public bool MyMethod()
            {
                myFavouriteVariables++;
                return true;
            }
        }

    }
    }

