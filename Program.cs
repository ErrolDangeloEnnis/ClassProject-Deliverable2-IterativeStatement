using System;

namespace ClassProject_Deliverable2_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Author:Errol Ennis
             * Date:September 12, 2019
             * Description: Asks students to enter number between 1-100.
             */

            Console.WriteLine("Enter a number between 1-100");

            try
            {
                string input = Console.ReadLine();
                int value = int.Parse(input);

                if((value > 0) && (value < 101))
                {
                    while (value > 0)
                    {
                        Console.WriteLine("You have entered " + value.ToString());
                        Console.WriteLine("This is the current integer value in the loop: " + value.ToString());
                        value--;
                    }//end of while
                }//end of if

                else
                {
                    Console.WriteLine("Try entering a number between 1-100");
                }//end of else
                
            }//end of try

            catch
            {
                Console.WriteLine("Enter a valid integer");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }//end of catch
        }
    }
}
