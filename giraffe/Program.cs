using System;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(GetPow(2,4));
            
            // by putting comma inside bracket, we'll tell that we have 2d array
            // int[,] numberGrid = {
            //     { 1,2 },
            //     { 3,4 },
            //     { 5,6 }
            // };

            // Console.WriteLine(numberGrid[0,1]);

            try
            {
                Console.Write("Enter a Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            // we can have as many catch as we want for catch all specific error
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e){
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("Final will always run no matter what.");
            }
           

            Console.ReadLine();
        }

        static int GetPow (int baseNum, int powNum)
        {
            int result = 1;
                for(int i = 0; i < powNum; i++)
                {
                    result *= baseNum;
                }
            return result;

        }
    }
}
