//using System;
//using System.Collections.Generic;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace VartoSchool
//{

//    //enum MonthName
//    //{
//    //    January = 1,
//    //    February,
//    //    March,
//    //    Aplril,
//    //    May,
//    //    June,
//    //    July,
//    //    August,
//    //    September,
//    //    October,
//    //    November,
//    //    December
//    //}
//    //class Prac3
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        bool ready = true;
//    //        while(ready)
//    //        {
//    //            Console.WriteLine($"Enter month number");

//    //            if (!int.TryParse(Console.ReadLine(), out int x))
//    //                Console.WriteLine($"Wrong munber!");

//    //            if(x>0 && x<13)
//    //            {
//    //                MonthName selectedMonth;
//    //                selectedMonth = (MonthName)x;

//    //                Console.WriteLine(selectedMonth);
//    //            }
//    //            else
//    //                Console.WriteLine($"Wrong munber!");

//    //            Console.WriteLine($"Continue?");
//    //            if(Console.ReadLine() == "y")
//    //                ready = true;
//    //            else
//    //                ready = false;
//    //        }
//    //    }
//    //}

//    enum DayName
//    {
//        Monday = 1,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }
//    class Prac3
//    {
//        static void Main(string[] args)
//        {
//            bool ready = true;
//            while (ready)
//            {
//                Console.WriteLine($"Enter day number");

//                if (!int.TryParse(Console.ReadLine(), out int x))
//                    Console.WriteLine($"Wrong munber!");

//                if (x > 0 && x < 8)
//                {
//                    DayName selectedDay;
//                    selectedDay = (DayName)x;

//                    Console.WriteLine(selectedDay);
//                }
//                else
//                    Console.WriteLine($"Wrong munber!");

//                Console.WriteLine($"Continue?");
//                if (Console.ReadLine() == "y")
//                    ready = true;
//                else
//                    ready = false;
//            }
//        }
//    }
//}
