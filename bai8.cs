// //tinh tong cac chu so
// using System;
// using System.Collections.Generic;

// namespace C_BasicPratice
// {
//     class 8
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("nhap so: ");
//             int myNum = int.Parse(Console.ReadLine());
//             int surplus;
//             int sum = 0;
//             List<int> myList = new List<int>{};
//             while(myNum > 0)
//             {
//                 surplus = myNum % 10;
//                 myList.Add(surplus);
//                 myNum = myNum / 10;
//             }
//             for(int i = 0; i < myList.Count; i++)
//             {
//                 sum += myList[i];
//             }
//             Console.WriteLine(sum);

//             Console.ReadKey();
//         }
//     }
// }
