using System;
using static System.Console;
public class SqrtFinder
{
    public static void Main()
    {
        string numStr;
        double sqrt = -1;
        double number = -1;
        try
        {
            Write("Enter a number to find its square root==");
            numStr = ReadLine();
            number = Convert.ToDouble(numStr);
            if (number < 0)
                throw new ApplicationException("Number canot be negative.");
            sqrt = Math.Sqrt(number);
        }
        catch (FormatException e)

        {
            WriteLine("Error, you did not enter a number:" + e.Message);
            sqrt = 0;
            number = 0;

            WriteLine("The square root of {0} is {1},number,sqrt");
        }
        catch (ApplicationException e)
        {
            WriteLine(e.Message);
            sqrt = 0;
            number = 0;

        }
        finally
        {
            WriteLine("The square root of {0} is {1}",number,sqrt);
       
        }
        
        }
    }

