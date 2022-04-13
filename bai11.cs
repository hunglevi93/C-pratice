// //Dem so lan xuat hien cua ky tu trong chuoi

// using System;
// using System.Collections.Generic;

// namespace C__Pratice
// {
//     class bai10
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap chuoi: ");
//             string myString = Console.ReadLine();
//             //xoa khoang trang chuoi
//             myString.Replace(" ", string.Empty);
            
//             while(myString.Length > 0)
//             {
//                 Console.Write(myString[0] + ": ");
//                 int count = 0;
//                 for(int i = 0; i < myString.Length; i++)
//                 {
//                     count ++;
//                 }
//                 Console.WriteLine(count);

//                 //Preplace lai tat ca cac vi tri co gia tri myString[0]
//                 myString = myString.Replace(myString[0].ToString(), string.Empty);
//             }
            
//             Console.ReadKey();
//         }
//     }
// }