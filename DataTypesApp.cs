using System;
namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int numOfApple = Convert.ToInt32(Console.ReadLine());

            //an "if" statements to correct the plurality of the word apple
            if (numOfApple == 1) //singular
            {
                Console.Write("Enter the total price of " + numOfApple + " apple: ");
                double totalPriceOfApple = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The total price of " + numOfApple + " apple is " + totalPriceOfApple);
                Console.WriteLine("The value of original price is " + totalPriceOfApple);

                int wholeNumPrice = (int) totalPriceOfApple; 
                // converts the total price that has decimal points into a whole number
                Console.WriteLine("The value of converted price is " + wholeNumPrice);
            }
            else if (numOfApple > 0) //plural
            {
                Console.Write("Enter the total price of " + numOfApple + " apples: ");
                double totalPriceOfApples = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The total price of " + numOfApple + " apples is " + totalPriceOfApples);
                Console.WriteLine("The value of original price is " + totalPriceOfApples);

                int wholeNumPrice = (int) totalPriceOfApples;
                Console.WriteLine("The value of converted price is " + wholeNumPrice);
            }
            else { // negative numbers or zero apple input
                Console.WriteLine("Unexpected input. Please try again.");
            }
             
        }
    }
} 
// made by January Toribio Jr.
