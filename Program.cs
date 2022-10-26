/* Дополнительно:
1: https://pythontutor.ru/lessons/2d_arrays/problems/swap_columns/
Размерность массива и столбцы для замены выбрать самостоятельно
2: По данным числам n и m заполните двумерный массив размером
n×m числами от 1 до n×m “змейкой”, как показано в примере.
Вводятся два числа n и m. Чтобы сделать такой большой отступ можно
использовать \t.
1 2 3 4 5
6 7 8 9 10
11 12 13 14 15 */

int [,] Snake(int a, int b)
{
  int [,] snake = new int[a,b];
  snake[0,0] = 1;
  for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
        if (i > 0 && j == 0) snake[i,j] = snake[i-1,b-1] + 1;   
        if (j > 0) snake[i,j] = snake[i,j-1] + 1;
        }   
    }  
return snake;
}

Console.WriteLine();
Console.Write("Введите количество строк массива целых чисел ~Змейка~: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов массива целых чисел ~Змейка~: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int [,] aaa = Snake(m, n);
Print2Dim(aaa);

void Print2Dim(int [,] qqq)
{
System.Console.WriteLine();
int x = qqq.GetLength(0);
int y = qqq.GetLength(1);
System.Console.WriteLine($"Создан массив целых чисел ~Змейка~, размером {x} строк и {y} столбцов:");
System.Console.WriteLine();
for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write("{0}\t", qqq[i, j]);
        System.Console.WriteLine("");
    }
System.Console.WriteLine();
System.Console.WriteLine();

}