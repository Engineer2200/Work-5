// // int countt(int number)
// //     {
// //     int count = 0;   
// //     if (number != 0)
// //         {
// //         while (number > 0)
// //             { 
// //               count++;
// //               number = number/10;  
// //             } 
// //         }
// //         else {count = 1;}
// //         return count;
// //     }

// Console.Write("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int sum = 0;
// // int count = countt(number);
// for (int i = 0; i < arr.Length; i++)
//     {
//         sum = sum + number.ToString()[i];
//     }
//     Console.WriteLine(sum);
int[] a = textBox1.Text.Split(' ').
          Where(x => !string.IsNullOrWhiteSpace( x )).
          Select(x => int.Parse(x)).ToArray();