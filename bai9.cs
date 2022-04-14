// // chuyen so thap phan sang nhi phan

// // neu 1 so abc duoc viet duoi dang so thap phan co cong thuc abc = a*10^2 + b*10^1 + c*10^0
// // thi viet duoi dang nhi phan se la (x)*2^n + (x)*2^(n-1) + ... +(x)*2^0
// // voi x = 0 hoac x = 1.

// //vi vay neu chieu theo thap phan, (abc % 10) la chu so cuoi cung thi (abc % 2) se la so cuoi cung trong nhi phan
// //tiep tuc chia 2 den khi abc = abc / 2 = 1;

// using System;
// using System.Collections.Generic;

// namespace C_BasicPratice
// {
//     class bai9
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("nhap so: ");
//             int myNum = int.Parse(Console.ReadLine());
//             List<string> myList = new List<string>{};
//             int surplus;
//             string mystringNum;
//             string myBitNum = "";
            
//             while(myNum >= 1)
//             {
//                 surplus = myNum % 2;
//                 mystringNum = surplus.ToString();
//                 myList.Add(mystringNum);
//                 myNum = myNum / 2;
//             }
//             for(int i = myList.Count - 1; i >= 0; i--)
//             {
//                 myBitNum += myList[i];
//             }
//             Console.WriteLine(myBitNum);

//             Console.ReadKey();
//         }
//     }
// }
