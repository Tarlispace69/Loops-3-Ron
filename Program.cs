namespace Loops_3_Ron
{
    internal class Program
    {
        //p. 158 ex. 34
        static void Main(string[] args)
        {
            int i = 0, number = 0, numberCopy = 0, digit = 0;

            //receiving user input
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Enter a digit: ");
            digit = int.Parse(Console.ReadLine());

            //checking if the digit is present in the number
            numberCopy = number;
            while (numberCopy > 0)
            {
                //if it is, printing number and quitting
                if (numberCopy % 10 == digit)
                {
                    Console.WriteLine(number);
                    return;
                }
                numberCopy /= 10;
            }

            //adding the digit and printing the number
            number *= 10;
            number += digit;
            Console.WriteLine(number);
        }
    }
}