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

            string fullName = "fred" + " " + "Jones";
            DemoArithmetic ();
            DemoRelational ();
            DemoLogical ();
            DemoConditional ();
        }

        static void DemoArithmetic ()
        {
            int hours = 8;
            double payRate = 15.25;

            double totalPay = hours * payRate;

            double taxes = totalPay * 0.33;

            //Combination operators work
            hours += 8;

            totalPay = hours * payRate;
            double newTaxes = totalPay * 0.66;
        }

        static void DemoRelational ()
        {
            int grade = 75;
            int passingGrade = 60;

            bool isGreater = grade > passingGrade;
            bool isGreaterThanOrEqual = grade >= passingGrade;
            bool isLessThan = grade < passingGrade;
            bool isLessThanOrEqual = grade <= passingGrade;
            bool isEqual = grade == passingGrade;
            bool isNotEqual = grade != passingGrade;
        }

        static void DemoLogical ()
        {
            bool value1 = true;
            bool value2 = false;

            //Both left and right must be true
            bool logicalAnd = value1 && value2;

            //Either left or right must be true
            bool logicalOr = value1 || value2;

            //Negates the value
            bool logicalNot = !value1;
        }

        static void DemoConditional ()
        {
            int grade = 75;

            // C ? T : F
            // Evaluate C, if true then T is the value of the expression
            //otherwise F is
            bool isPassing = grade > 60 ? true : false;

            //Equivalent to what an if statement could do if it were an expression
            if (grade > 60)
                isPassing = true;
            else
                isPassing = false;
        }

        static void DemoArray ()
        {
            double[] payRates = new double[100];

            //50th element to 7.25
            payRates[49] = 7.25;

            //Read 89th element into temp variable
            double payRate = payRates[88];

            //Print out the 80th element
            Console.WriteLine (payRates[79]);

            //An empty array
            //bool[] isPassing = new bool[0];
            var isPassing = new bool[0];

            //Enumerating an array
            for (int index = 0; index < payRates.Length; ++index)
                Console.WriteLine (payRates[index]);

            //Type inferencing
            //string name = "Bob William Smith Jr III";
            var name = "Bob William Smith Jr III";
            //name = 20;            

            string[] nameParts = name.Split (' ');
        }

        //Don't do this outside lab 1
        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static bool hasSeen;
    }
}

        
   

