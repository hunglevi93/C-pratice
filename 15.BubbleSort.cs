// // Sap xep noi bot

// using System;

// namespace BubbleSort
// {
//     class BubbleSort
//     {
//         static void Main(string[] args)
//         {
//             int[] myArray = new int[10];
//             Random r = new Random();
//             int temp = 0;
//             for (int i = 0; i < 10; i++)
//             {
//                 myArray[i] = r.Next(0, 10);
//             }

//             for (int i = 0; i < 10; i++)
//             {
//                 for (int j = 0; j < 10; j++)
//                 {
//                     if (myArray[i] < myArray[j])
//                     {
//                         temp = myArray[i];
//                         myArray[i] = myArray[j];
//                         myArray[j] = temp;
//                     }
//                 }
//             }

//             foreach (int j in myArray)
//             {
//                 Console.Write(j);
//             }

//             Console.ReadKey();
//         }
//     }
// }
