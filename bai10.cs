// //chuyen so nhi phan sang thap phan

// using System;
// using System.Collections.Generic;

// namespace C__Pratice
// {
//     class bai9
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap so nhi phan: ");
//             int myBinaryNum = int.Parse(Console.ReadLine());
//             List<int> myList = new List<int>{};
//             int surplus;
//             Double myDecimalNum = 0;

//             while(myBinaryNum > 0)
//             {
//                 surplus = myBinaryNum % 10;
//                 myList.Add(surplus);
//                 myBinaryNum /= 10;
//             }
//             for(int i = myList.Count - 1; i >= 0; i--)
//             {
//                 myDecimalNum += myList[i] * Math.Pow(2,i);
//             }

//             Console.WriteLine(myDecimalNum);

//             Console.ReadKey();
//         }
//     }
// }
