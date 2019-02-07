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
        //a.PlayingWithForLoops();  

        var b = new birthday_party();
        b.setupPartyList();
       
            Console.WriteLine(b.printPartyList());
            Console.WriteLine(b.printPartyList_reverce());
        }
   }

    class TestQuestion2
    {
        public int myFavouriteVariables = 0;
        public void PlayingWithForLoops()
        {
            // Write a for loop to Add 10 numbers
            for (; MyMethod();)
            {
                if (myFavouriteVariables > 10)
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




    class dog
        {
            public dog(string name, string breed)
            {
                dog_name = name;
                dog_breed = breed;
                
            }
            public string dog_name;
            public string dog_breed;
        public dog next_dog;
        public dog prev_dog;
    }
        class birthday_party
        {
            public dog peanut;
            public dog fifi;
            public dog clarance;
            public dog giselle;
            public dog lulu;
            public dog roy;

            public dog head;
            public dog tail;
            public dog temporary;
            public void setupPartyList()
  
            {
                peanut = new dog("peanut", "Bichon");
                fifi = new dog("fifi", "Poodle");
                clarance = new dog("Clarance", "German Sheppard");
             lulu = new dog("Lulu", "Shitzu");
            giselle = new dog("Giselle", "Border Collie");
            roy = new dog("Roy", "Beagle");

                peanut.prev_dog = null;
                peanut.next_dog = fifi;
                fifi.prev_dog = peanut;
                fifi.next_dog = clarance;
                clarance.prev_dog = fifi;
                clarance.next_dog = roy;
            giselle.prev_dog = clarance;
            giselle.next_dog = lulu;
            lulu.prev_dog = fifi;
            lulu.next_dog = roy;
            roy.prev_dog = lulu;
                roy.next_dog = null;
                head = peanut;
                tail = roy;

            }
            public string printPartyList()
            {
                string inviteList = "*---";
                temporary = head;
                while (temporary.next_dog != null) ;
            
            {
                Console.WriteLine(temporary.next_dog.dog_name);
            inviteList+= temporary.dog_name + "*---*";
                temporary = temporary.next_dog;
             }
            inviteList += temporary.dog_name + "*---*";
            return inviteList;
            }




        public string printPartyList_reverce()
        {
            string inviteList = "*---";
            temporary = tail;
            while (temporary.prev_dog != null) ;

            {
                Console.WriteLine(temporary.prev_dog.dog_name);
                inviteList += temporary.dog_name + "*---*";
                temporary = temporary.prev_dog;
            }
            inviteList += temporary.dog_name + "*---*";
            return inviteList;
        }

    }
}

