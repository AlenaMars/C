// int SumFor(int n)
// {
//  int result = 0;
//  for (int i = 1; i <= n; i++) result += i;
//  return result;
// }
// int SumRec(int n)
// {
//  if (n == 0) return 0;
//  else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55

// string NumbersFor(int a, int b)
// {
//  string result = String.Empty;
//  for (int i = a; i >= b; i--)
//  {
//  result += $"{i} ";
//  }
//  return result;
// }
// string NumbersRec(int a, int b)
// {
//  if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//  else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
// Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

int FactorialRec(int n)
{
 if (n == 1) return 1;
 else return n * FactorialRec(n - 1);
}
// Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800




