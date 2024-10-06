
int n = int.Parse(Console.ReadLine());
int[][] nums = new int[n][];

for(int i=0; i < n; i++)
{
    nums[i] = new int[n];
}

for(int i=0; i<n; i++)
{
    for (int j=0; j<n; j++)
    {
        nums[i][j] = 1;
       
    }
}

for(int i=0; i<n; i++)
{
    for (int j=0; j < n-1; j++)
    {
        Console.Write(nums[i][j]);

    }
    Console.WriteLine(nums[i][n-1]);
}