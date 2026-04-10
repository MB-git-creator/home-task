//Class task 1
// int fact(int n)
// {
//     if (n <= 1)
//     {
//         return 1;
//     }
//     return n*fact(n-1);
// }
// System.Console.WriteLine(fact(9))

//2

// System.Int32 number = System.Int32.Parse(System.Console.ReadLine());
// System.Int64 result = Fibonacci(number);
// System.Console.WriteLine(result);

// System.Int64 Fibonacci(System.Int32 n)
// {
//     if (n == 0)
//         return 0;
//     else if (n == 1)
//         return 1;
//     else
//         return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

//3
// int fact(int n)
// {
//     if (n <= 1)
//     {
//         return 1;
//     }
//     return n*fact(n-2);
// }
// System.Console.WriteLine(fact(9));

//home task 1
//1
// int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     Console.Write(i + " ");
// }

//2

// int n = int.Parse(Console.ReadLine());

// for (int i = n; i >= 1; i--)
// {
//     Console.Write(i + " ");
// }

//3
// int n = int.Parse(Console.ReadLine());

// int Sum(int num)
// {
//     if (num == 0)
//         return 0;
//     return num + Sum(num - 1);
// }

// int result = Sum(n);
// Console.WriteLine(result);

//4
// int num = int.Parse(Console.ReadLine());
// sum(num);

// void sum(int num)
// {
//     if (num < 10)
//     {
//         Console.Write(num + " ");
//         return;
//     }

//     sum(num / 10);
//     Console.Write(num % 10 + " ");
// }

//5
// int numb = int.Parse(Console.ReadLine());

// int sum(int num)
// {
//     if (num < 10)
//         return 1;
//     return 1 + sum(num / 10);
// }

// int digitsCount = sum(numb);
// Console.WriteLine(digitsCount);

//6
