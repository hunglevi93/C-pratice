// //dao nguoc 1 chuoi va 1 so trong C#
// using System;

// namespace bai_tap
// {
//     class bai5
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("nhap so: ");
//             int myNum = int.Parse(Console.ReadLine());

//             Console.Write("Nhap chuoi: ");
//             string myString = Console.ReadLine();

//             //lam viec voi so
//             int surplus;
//             int newNum = 0;
//             int subNum = myNum;
//             while(myNum > 0)
//             {
//                 surplus = myNum % 10;
//                 myNum = myNum / 10;
//                 newNum = newNum * 10 + surplus;
//             }
//             Console.WriteLine($"{newNum} la so dao nguoc cua {subNum}");

//             //lam viec voi chuoi
//             char[] myChar = myString.ToCharArray();
//             Array.Reverse(myChar);
//             char newChar = myChar[0];
//             string newString = newChar.ToString();
//             for(int i = 1; i < myChar.Length; i++)
//             {
//                 newString += (myChar[i]).ToString();
//             }
//             Console.WriteLine($"{newString} la dao nguoc cua {myString}");

//             Console.ReadKey();
//         }
//     }
// }
