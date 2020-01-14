using System;
using System.Collections.Generic;

namespace Gradebook
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var book= new Book("Harshita Gradebook");
            book.AddGrade(86.1);
            book.AddGrade(85.7);
            book.grades.Add(101);
            var stats = book.GetStatistics();    //This will store the result object returned by the method with filed High, Low & Average.


            Console.WriteLine($"The result is {stats.Average:N1}");
            Console.WriteLine($"The maximum is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            
            // var x = 34.1;
            // var y= 10.3;
            // var result=(x+y);
            // System.Console.WriteLine(result);

            // double[] numbers; //declaration of array of numbers
            // var numbers=new double[] {12.7,10.3,6.11,4.1};
        //     var numbers=new [] {12.7,10.3,6.11,4.1};

        //     numbers[0]=12.4;   //won't allow to assign value to unassigned variables
        //     numbers[1]=10.7;
        //     numbers[2]=6.11;
        }
    }
}



            // var result=numbers[0];
            // result+=numbers[1];
            // result+=numbers[2];
             

            // foreach( var number in numbers)
           