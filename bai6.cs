// // Kiem tra so Armstrong
// using System;
// using System.Collections.Generic;

// namespace bai_tap
// {
//     class bai6
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap so: ");
//             int myNum = int.Parse(Console.ReadLine());

//             //doi sang kieu double vi math.pow cho ra kq la pow
//             Double myDoubleNum = (Double)myNum;
//             List<int> myList = new List<int>{};
//             int surplus;
//             Double myNewDoubleNum = 0;
//             while(myNum > 0)
//             {
//                 surplus = myNum % 10;
//                 myList.Add(surplus);
//                 myNum = myNum / 10;
//             }
//             for(int i = 0; i < myList.Count; i++)
//             {
//                 myNewDoubleNum += Math.Pow(myList[i], myList.Count);            
//             }
//             if(myNewDoubleNum == myDoubleNum)
//             {
//                 Console.WriteLine($"{myDoubleNum} is Armstrong");
//             }
            
//             else
//             {
//                 Console.WriteLine($"{myDoubleNum} isn't Armstrong");
//             }
//             Console.ReadKey();
//         }
//     }
// }
