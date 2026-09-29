using System;
using static System.Console;
public class SubscriptExceptionTest 
{
    public static void Main()
    {
        double[] array = { 2.6, 1.5, 7.7, 8.1, 4.5, 3.1, 7, 6.5, 10.9, 11.0 };
        string entry;
        try
        {

            while (true)
            {
                Write("Enter a subscript between (0-9), or Q/q to quit>");
                entry = ReadLine();

                if (entry.ToUpper() == "Q")
                    break;

                int index = Convert.ToInt32(entry);
                WriteLine("The number at position  {0} is {1}", index, array[index]);

            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("An error occured:" + e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Hey my friend !Why are you trying to be too smart ?Please enter a number or Q/q-simple!");
        }
    }
}
