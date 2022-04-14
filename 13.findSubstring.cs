// // tim chuoi con cua chuoi da cho


// using System;

// namespace C__Pratice
// {
//     class findSubstring
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap chuoi: ");
//             string myString  = Console.ReadLine();
//             Console.WriteLine("Cac chuoi con la: ");

//             for(int i = 0; i < myString.Length; i++)
//             {   
//                 for(int j = 1; j <= myString.Length - i; j++)
//                 {
//                     if(i == 0 && j == myString.Length)
//                     {
//                         break;
//                     }
//                     Console.Write(myString.Substring(i, j) + " ");
//                 }
//             }


//             Console.ReadKey();
//         }
//     }
// }
