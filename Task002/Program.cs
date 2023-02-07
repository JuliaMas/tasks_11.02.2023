//Написать программу, которая в двумерном массиве заменяет строки на столбцы, или сообщить, что это невозможно (в случае если матрица не квадратная)
void Fill(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i,j] = new Random().Next(1,10);
		}
	}
}
void Print(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i,j]} ");
		}
		Console.WriteLine();
	}
}
Console.Write("Введите количество строк n: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов m: ");
int m = int.Parse(Console.ReadLine() ?? "");

if(n != m) Console.WriteLine("Заменить строки на столбцы в данной матрице невозможно, т.к. она не является квадратной");
else
{
int[,] matrix = new int[n,m];
Fill(matrix);
Print(matrix);

	//Console.WriteLine();

int temp = 0;

for(int i = 0; i < matrix.GetLength(0); i++)
{
	for(int j = 0; j < matrix.GetLength(1); j++)
	{
		temp = matrix[i,j];
		matrix[i,j] = matrix[j,i];
		matrix[j,i] = temp;
	}
	//Print(matrix);
	//Console.WriteLine();
}
Console.WriteLine();
Print(matrix);
}
