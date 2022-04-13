// //  Kiểm tra một số có phải là số nguyên tố hay không trong C#
// using System;

// namespace bai_tap
// {
//     class bai3
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap vao mot so: ");
//             int a = int.Parse(Console.ReadLine());
//             bool isPrime = true;

//             for(int i = 2; i < a; i++)
//             {
//                 if(a % i == 0)
//                 {
//                     isPrime = false;
//                     break;
//                 }
//             }

//             if(isPrime)
//             {
//                 Console.Write($"{a} la so nguyen to");
//             }
//             else
//             {
//                 Console.Write($"{a} khong la so nguyen to");
//             }
//             Console.ReadKey();
//         }
//     }
// }
