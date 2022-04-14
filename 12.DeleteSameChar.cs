// // tach cac ki tu trung trong chuoi

// using System;
// using System.Collections.Generic;

// namespace C__Pratice
// {
//     class DeleteSameChar
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap chuoi: ");
//             string myString = Console.ReadLine();
//             string newString = string.Empty;

//             for(int i = 0; i < myString.Length; i++)
//             {
//                 if(!newString.Contains(myString[i]))
//                 {
//                     newString += myString[i];
//                 }
//                 else
//                 {
//                     for(int j = 0; j < newString.Length; j++)
//                     {
//                         if(newString[j] == myString[i])
//                         {
//                             newString = newString.Replace(newString[j].ToString(), string.Empty);
//                         }
//                     }
//                 }
//             }
//             Console.WriteLine(newString);
            
//             Console.ReadKey();
//         }
//     }
// }
