System.Console.WriteLine("enter amount of rows");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("enter amount of columns");
int n = Convert.ToInt32(Console.ReadLine());

{
Random ran = new Random();
int[,] RandomNumbers = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        RandomNumbers[i, j] =  ran.Next(1, 5000);
        System.Console.WriteLine(RandomNumbers[i, j]);
    }
    
}
}