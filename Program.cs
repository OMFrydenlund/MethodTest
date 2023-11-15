using System; //Get back to this later yes?

namespace MethodTest
{
    internal class Program
    {
        static void Main(string[] args) //execution of program begins here
        {
            int number = 4; // list of data to add into calculations
            decimal numberWithSmol = 6.40M;

            decimal result = sumOfTheAbove(number, numberWithSmol); //call the method along with provided values, store end result in "result"
            Console.WriteLine($"Num + NumSmol = {result}"); //console output
        }

        static decimal sumOfTheAbove(int number, decimal numberWithSmol) //takes the integer and the decimal as parameters and returns a decimal
        {
            decimal sum = number + numberWithSmol; //calc the sum of the int/decimal values and store in "sum"
            return sum;
        }
    }
}