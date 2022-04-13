// //  Kiểm tra số đối xứng trong C#
// using System;

// namespace bai_tap
// {
//     class bai4
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap so: ");
//             int myNum = int.Parse(Console.ReadLine());

//             int du;
//             int soMoi = 0;
//             int soCuaToi = myNum;

//             while(myNum > 0)
//             {
//                 du = myNum % 10;
//                 myNum = myNum / 10;
//                 soMoi = soMoi * 10 + du;
//             }

//             if(soCuaToi == soMoi)
//             {
//                 Console.WriteLine($"{soCuaToi} la so doi xung");
//             }
//             else
//             {
//                 Console.WriteLine($"{soCuaToi} khong la so doi xung");
//             }
 
//             Console.ReadKey();
//         }
//     }
// }
