using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This game is FizzBuzz, how high would you like me to count?");

            bool letsPlay = true;
            while(letsPlay)
            {
                letsPlay = false;
                int fizzbuzz_max = getFizzBuzzMax();
                playGame(fizzbuzz_max);
                Console.Write("Play again? (Y|N): ");
                string input = Console.ReadLine();
                if (input.ToUpper().Equals("Y"))
                {
                    letsPlay = true;
                }
            }
        }

        static int getFizzBuzzMax()
        {
            string input = "garbly goop";
            int fizzbuzz_max = -1;
            while (int.TryParse(input, out fizzbuzz_max) != true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
            }

            return fizzbuzz_max;
        }

        static void playGame(int max)
        {

            Console.WriteLine("Okay, lets do this shit");

            //Count from 1 to 100, call this 'i'
            //When i is a multiple of 3, say Fizz
            //When i is a multiple of 5, say Buzz
            //When i is a multiple of both, say FizzBuzz
            //Else, say i

            bool FizzCheck = false;
            bool BuzzCheck = false;
            int start_time = DateTime.Now.Second;
            for (int i = 1; i < max; i++)
            {
                FizzCheck = isMultiple(i, 3);
                BuzzCheck = isMultiple(i, 5);

                string output = "";
                if (FizzCheck) { output += "Fizz"; }
                if (BuzzCheck) { output += "Buzz"; }
                if (output == "")
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);

            }

            //TimeSpan t_after = new TimeSpan();
            int elapsed_time = DateTime.Now.Second - start_time;


            Console.WriteLine("\nPretty cool, eh? That only took me " + elapsed_time.ToString() + " seconds!");
        }

        static bool isMultiple(int number_in, int multiple_in)
        {
            if (number_in % multiple_in == 0)
            {
                return true;
            }
            return false;
        }
    }
}
