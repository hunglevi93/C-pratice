// // Viết hoa ký tự viết thường và ngược lại

// using System;
// using System.Collections.Generic;

// namespace C__Pratice
// {
//     class ChangeCharStyle
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap chuoi: ");
//             string myString = Console.ReadLine();
//             List<string> myList = new List<string>{};

//             for(int i = 0; i < myString.Length ; i++)
//             {
//                 myList.Add(myString[i].ToString());
//                 if(isUpper(myList[i]))
//                 {
//                     myList[i] = myList[i].ToLower();
//                 }
//                 else
//                 {
//                     myList[i] = myList[i].ToUpper();
//                 }
//                 Console.Write(myList[i]);
//             }


//             static bool isUpper(string a)
//             {
//                 if(a.ToUpper() != a)
//                 {
//                     return false;

//                 }
//                 else
//                 {
//                     return true;  
//                 }      
//             }
            
//             Console.ReadKey();
//         }
//     }
// }
