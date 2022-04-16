// // Kiem tra so hoan hao
// // So hoan la so ma tong cac uoc cua no bang chinh no

// using System;

// namespace C__Pratice
// {
//     class PerfectNumber
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap so: ");
//             int myNum = int.Parse(Console.ReadLine());
//             int sum = 0;
//             for(int i = 1; i < myNum; i++)
//             {
//                 if(myNum % i == 0)
//                 {
//                     sum += i;
//                 }
//             }
//             if(sum == myNum)
//             {
//                 Console.WriteLine($"{myNum} is perfect number");
//             }
//             else
//             {
//                 Console.WriteLine($"{myNum} isn't perfect number");
//             }

//             Console.ReadKey();
//         }
//     }
// }
