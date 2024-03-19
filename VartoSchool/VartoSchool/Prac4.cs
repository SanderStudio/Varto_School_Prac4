using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VartoSchool
{
    class Prac4
    {
        static void Main(string[] args)
        {
            //int[] myArray = new int[50];

            //for (int i = 0, j = 0; j < myArray.Length; i += 2, j++)
            //{
            //    myArray[j] = i;
            //    Console.WriteLine($"Element {j}: {i}");
            //}



            //bool ready = true;
            //while (ready)
            //{
            //    int numbers = 0;

            //    Console.WriteLine($"Enter array length between 24 and 50");
            //    if (!int.TryParse(Console.ReadLine(), out int x))
            //        Console.WriteLine($"Wrong munber!");
            //    else if (x < 24 || x > 50)
            //        Console.WriteLine($"Wrong munber!");
            //    else
            //    {
            //        int[] myArray = new int[x];

            //        Random random = new Random();

            //        for (int i = 0; i < myArray.Length; i++)
            //        {
            //            myArray[i] = random.Next(0, 101);
            //            if (myArray[i] % 2 == 0)
            //            {
            //                numbers++;
            //            }
            //        }
            //        Console.WriteLine($"Arrays include {numbers} pair numbers");

            //        Console.Write("Елементи масиву з парними значеннями: ");
            //        for (int i = 0; i < myArray.Length; i++)
            //        {
            //            if (myArray[i] % 2 == 0)
            //            {
            //                Console.Write(myArray[i] + " ");
            //            }
            //        }
            //        Console.WriteLine();


            //        Console.WriteLine($"Continue?");
            //        if (Console.ReadLine() == "y")
            //            ready = true;
            //        else
            //            ready = false;
            //    }
            //}

            //bool ready = true;
            //int numbers;
            //int letterNumbers;
            //while (ready)
            //{
            //    Console.WriteLine($"Enter your Text");
            //    string text = Console.ReadLine();
            //    string lowerText = text.ToLower();
            //    numbers = 0;
            //    letterNumbers = 0;

            //    Console.WriteLine($"Enter letter you want to find");
            //    string letter = Console.ReadLine();
            //    string letterLower = letter.ToLower();
            //    char lowerLetter = Convert.ToChar(letterLower);

            //    foreach (char item in lowerText)
            //    {
            //        if (item == lowerLetter)
            //        {
            //            letterNumbers++;
            //        }
            //        numbers++;
            //    }
            //    Console.WriteLine($"Text {text} include: {numbers} symbols");
            //    Console.WriteLine($"Found {letterNumbers} letters {letter} in {text}");

            //    Console.WriteLine($"Continue?");
            //    if (Console.ReadLine() == "y")
            //        ready = true;
            //    else
            //        ready = false;
            //}


            char[] alphabetArray = new char[26];

            for (int i = 0; i < alphabetArray.Length; i++)
            {
                alphabetArray[i] = (char)('a' + i);
            }

            Console.WriteLine("Символ\tПорядковий номер в ASCII");
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                Console.WriteLine(alphabetArray[j] + "\t" + (int)alphabetArray[j]);
            }
        }
    }
}
