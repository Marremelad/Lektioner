﻿namespace Lektioner;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = new int[5];
        try
        {
            Console.WriteLine(myArray[4]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {

            Console.WriteLine("End, Hello man!");

        }
        Console.WriteLine("Bug fix branch");
    }

}