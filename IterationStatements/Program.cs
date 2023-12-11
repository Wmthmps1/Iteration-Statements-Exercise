namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void CountBy1()
        {
            for (int i = -1000; i < 1001; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountBy3()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckEquality(int firstInputInteger, int secondInputInteger)
        {
            string isEqualMessage = (firstInputInteger == secondInputInteger) ? "Numbers are equal." : "Numbers are not equal";
            Console.WriteLine(isEqualMessage);
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(){
            Console.WriteLine("Enter an integer to see if it's odd or even: ");
            int evenOrOddInt = int.Parse(Console.ReadLine());

            string evenOrOddMessage = ((evenOrOddInt % 2) == 0) ? "Number is Even." : "Number is Odd";
            Console.WriteLine(evenOrOddMessage);
        }


        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative()
        {
            Console.WriteLine("Enter an integer to see if it's positive or negative: ");
            int posOrNegInt = int.Parse(Console.ReadLine());

            if (posOrNegInt > 0)
            {
                Console.WriteLine("Integer is Positive");
            } else if(posOrNegInt < 0)
            {
                Console.WriteLine("Integer is Negative");
            } else //Zero
            {
                Console.WriteLine("Integer is zero.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void CanUserVote()
        {
            Console.WriteLine("Enter your age in numbers. Ex: 18, not eighteen");
            bool isInt = int.TryParse(Console.ReadLine(), out int userAge);

            while (isInt == false)
            {
                Console.WriteLine("Invalid Age, enter a valid age in integer form.");
                isInt = int.TryParse(Console.ReadLine(), out userAge);
            }


            string checkAge = (userAge >= 18) ? "You are old enough to vote!" : "You are not old enough to vote";
            Console.WriteLine(checkAge);

        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IsInRange()
        {
            Console.WriteLine("Enter an integer to see if it's between -10 and 10: ");
            int withinRange = int.Parse(Console.ReadLine());

            string withinRangeMessage = (withinRange < 11 && withinRange > -11)? "Number is within range." : "Number is not within range.";
            Console.WriteLine(withinRangeMessage);
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter an integer and I will give you the multiplication table(1-12) for it.");
            int userInt = int.Parse(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{userInt} * {i} = {userInt *  i}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            
            CountBy1();
            CountBy3();
            // Check Equality
            Console.WriteLine("Enter two integers to check equality: ");
            Console.WriteLine("Enter the first integer: ");
            int firstInputInteger = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int secondInputInteger = int.Parse(Console.ReadLine());
            CheckEquality(firstInputInteger, secondInputInteger);
            EvenOrOdd();
            PositiveOrNegative();
            CanUserVote();
            IsInRange();
            MultiplicationTable();



        }
    }
}
