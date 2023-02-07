// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
int[,] matrix = new int[3,3];
Fill(matrix);
Print(matrix);
Console.WriteLine();

double[] sred = new double[matrix.GetLength(1)];
double sum = 0;

for(int j = 0; j < matrix.GetLength(1); j++)
{
	for(int i = 0; i < matrix.GetLength(0); i++)
	{
		sum = sum + matrix[i,j];
	}
	sred[j] = sum / matrix.GetLength(0);
	sum = 0;
}
for(int i = 0; i < sred.Length; i++)
{
	Console.Write($"{sred[i]} ");
}