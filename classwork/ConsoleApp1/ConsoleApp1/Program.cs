using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( /*string[] args*/ )
        {
            //Movie data
            string title;
            int runLength;
            int releaseYear;
            string description;
            bool haveSeen;

            while (true)
            {

                char input = DisplayMenu ();
                if (input == 'A')
                    AddMovie ();
                else if (input == 'Q')
                    break;
            };
        }

        static void AddMovie ()
        {
            //Get title
            Console.Write("Title: ");
            string title = Console.ReadLine ();

            //Get description
            Console.Write ("Description: ");
            string description = Console.ReadLine ();

            //Get release year
            int releaseYear = ReadInt32 ("Release Year: ");



            //Get run length
            int runlength = ReadInt32 ("Run Legth (in minutes: ");


            //Get have seen
            bool haveSeen = ReadBoolean ("Have Seen? ");
            



        }


        static int ReadInt32 ( string message )
        {
            while (true)
            {


                Console.Write (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                //int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse(input, out int result))

                    return result;

                Console.Write ("Not a number");


            }
        }
        static bool ReadBoolean ( string message )
        {
            while (true)
            {


                Console.Write (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;

                Console.Write ("Not a boolean");
            }
        }




                static char DisplayMenu ()
        {
            do
            {

                Console.WriteLine ("A)dd Movie");
                Console.WriteLine ("Q)uit");

                String input = Console.ReadLine ();
                if (input == "A" || input == "a")
                {
                    return 'A';
                } else if (input == "Q" || input == "q")
                {
                    return 'Q';
                } else
                {
                    Console.WriteLine ("Invalid input");
                }

            } while (true);
        }
        static void dayOneStuff(){
            string name = "";

            //string if = ";

            //Definitely assigned
           //name = "bob";
            string name2;
            name2 = Console.ReadLine ();
            Console.WriteLine (name2);


            Console.WriteLine("Hello World!");
            //TODO: Fix this
            //Another block

            //yet another block

            int hours = 8;
            double payRate = 15.25;


            double totalPay = payRate * hours;

            string fullName = "fred" ;
        }
    }
}
