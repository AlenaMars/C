/* Задача 20. Напишите программу которая принимает на вход координаты 2 точек
и находит расстояние между ними в 2d 
*/

int[] A = new int[2] {3, 6};
int[] B = new int[2] {7, 1};


int x = (int)Math.Pow(A[0]-B[0], 2);
int y = (int)Math.Pow(A[1]-B[1], 2);
double ans = Math.Sqrt(x+y);
ans  = Math.Round(ans, 2);
Console.Write($"{ans}");

