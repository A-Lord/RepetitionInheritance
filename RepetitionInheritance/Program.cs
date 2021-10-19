using System;
using RepetitionInheritance;
using System.Collections.Generic;

namespace RepetitionInheritance.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] testArray = new int[] { 7, 4, 10, 6, 9, 2 };
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i]);
            }
            ArrayModifier test = new IncrementModifier(testArray);
            var test2 = new IncrementModifier(testArray);
            Console.WriteLine();

            test.Modify();
            test.PrintIt();


            Console.WriteLine();
            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }

            //List<IComputation> computations = new List<IComputation>();
            //computations.Add(new AdditionComputation());
            //computations.Add(new SubtractionCompoutation());
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    string[] parts = input.Split(' ');
            //    foreach (var item in computations)
            //    {
            //        Console.WriteLine(item);
            //        if (item.CanCompute(parts[0]))
            //        {
            //            Console.WriteLine("gageaegeags");
            //            int[] unsortedArray = new int[parts.Length-1];
            //            for (int i = 0; i < unsortedArray.Length; i++)
            //            {
            //                unsortedArray[i] = int.Parse(parts[i+1]);
            //            }
            //            Console.WriteLine(item.Compute(unsortedArray));
            //        }
            //    }
            //}
        }
    }
}