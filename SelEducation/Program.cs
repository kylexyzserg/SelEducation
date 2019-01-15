using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SelEducation
{
    class Program
    {
        static void Main(string[] args)

        {
            ArrayDifference ArrDiff = new ArrayDifference();
            List<string> ArrayOne = new List<string> { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            List<string> ArrayTwo = new List<string> { "Dima", "Ivan", "Kate" };

            
           
            Console.WriteLine("Task 2");
            Console.WriteLine("The deference between array1 and array2 (case1)");
            ArrDiff.FindArrayDifferenceCollection(ArrayOne,ArrayTwo);
            Console.WriteLine("The deference between array1 and array2 (case2)");
            ArrDiff.FindArrayDifferenceWithoutCollection(ArrayOne, ArrayTwo);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Task 1");

            FileSearch fileSearch = new FileSearch();
            Console.WriteLine("Enter directory");
          string directoryStr = Console.ReadLine();

            Console.WriteLine("Enter file extension");
            string extension = Console.ReadLine();
            Console.WriteLine("Result:");
            fileSearch.FindLastFile(extension,directoryStr);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Task 3");
            TestCasePicker.SelectCases(@"D:\C#\FileFolder\1.txt",10);

            Console.ReadKey();





        }
    
    }
}
