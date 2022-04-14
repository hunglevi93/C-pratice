// // xoa phan tu trung lap khoi

// using System;
// using System.Collections.Generic;

// namespace C__Pratice
// {
//     class DeleteSameElementArray
//     {
//         static void Main(string[] args)
//         {
//             int[] myArray = new int[10];
//             Random _r = new Random();
//             Console.Write("Array: ");
//             for(int i = 0; i < 10; i++)
//             {
//                 myArray[i] = _r.Next(0,10);
//                 Console.Write(myArray[i] + " ");
//             }
//             Console.WriteLine();

//             List<int> myList = new List<int> {};
//             for(int j = 0; j < 10; j++)
//             {
//                 myList.Add(myArray[j]);
//             }
//             for(int k = 0; k < myList.Count - 1; k++)
//             {
//                 int h = k + 1; 
//                 while(h < myList.Count)
//                 {
//                     myList.Remove(myList[h]);
//                     h ++;
//                 }
//             }

//             Console.Write("new Array: ");
//             foreach(int e in myList)
//             {
//                 Console.Write(e + " ");
//             }

//             Console.WriteLine();

//             Console.ReadKey();
//         }
//     }
// }
