namespace Demo
{
    internal class Program
    {
        /*example for Question 1

        void PassingByValueExOfQ1(int x)
         {
             x = 5; // Only modifies the copy, not the original variable
         }
      void PassingByRefExOfQ1(ref int x)
               {
                x = 10; 
               }


      */

        static int SumOfDigits(int n)
        {
            int sum = 0;
            int cn = 1;
            while (n > 0)
            {
                cn *= 10;
                sum += (n % 10) * cn;
                n /= 10;

            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
            
              Passing by Value:
            Description: A copy of the original value is passed to the method. The method works with this copy, not the original variable.
           Effect: Any changes made to the parameter inside the method do not affect the original variable outside the method.
              int num = 5;
              PassingByValueExOfQ1(num);
              Console.WriteLine(num);
           

              Passing by Reference:
               Description: Instead of a copy, a reference to the original variable is passed to the method. 
              The method works directly with the original variable.
               Effect: Any changes made to the parameter inside the method directly affect 
              the original variable outside the method.
            int num = 5;
          PassingByRefExOfQ1(ref num);
           Console.WriteLine(num);
           
            */
            #endregion
            #region 2-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.


            #endregion
            Console.WriteLine("Enter A Number");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(SumOfDigits(number));

           


        }
    }
}
