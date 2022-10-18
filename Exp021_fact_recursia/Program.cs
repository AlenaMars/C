
// //рекурсия это функция вызывающая саму себя

// double Factorial(int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// Console.WriteLine(Factorial(5)); //1* 2 * 3 // будет переполнение типа поэтому меняем на double

double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
 Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
