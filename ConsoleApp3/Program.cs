using ConsoleApp3;
using System;

class Program
{
    static void FirstTask()
    {
        
        
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];


        for (int i = 0; i < n; i++)
        {
            nums[i] = i + 1;
        }

        for (int i = n-1; i != -1; i--)
        {
            Console.WriteLine(nums[i]);
        }
    }

    static void SecondTask()
    {

        int n = int.Parse(Console.ReadLine());
        int[][] nums = new int[n][];

        for (int i = 0; i < n; i++)
        {
            nums[i] = new int[n];
        }

        for(int i=0; i < n; i++)
        {
            nums[0][i] = 1;
        }

        int x = n;
        for (int i = 1; i < n; i++)
        {
            for (int j=0; j < x; j++)
            {
                nums[i][j] = 1;


            }
            x--;
        }

        for(int i=0; i<n; i++)
        {
            for(int j=0; j<n/2; j++)
            {
                int k = nums[i][j];
                nums[i][j] = nums[i][n - (j + 1)];
                nums[i][n-(j + 1)] = k; 
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n ; j++)
            {
                Console.Write(nums[i][j]);

            }
            Console.WriteLine();
        }
    }

    static void ThirdTask()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] nums = new int[n][];
        for (int i = 0; i < n; i++)
        {
            nums[i] = new int[n];
        }
        int k = 1, I = 0, J = 0;
        int Up=0, Down=0, Left=0, Right=0;
        while (k <= n * n)
        {
            nums[I][J] = k;
            if (I == Up && J < n - Right - 1) { J++; }
            else if (I < n - Down - 1 && J == n - Right - 1) { I++; }
            else if (I == n - Down - 1 && J > Left) { J--; }
            else { I--; }

            if (I == Up + 1 && J == Left && Left != n - Right - 1) 
            {
                Up++;
                Down++;
                Right++;
                Left++;
            }
            k++;
         
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(nums[i][j]);

            }
            Console.WriteLine();
        }
    }

    static void FourTask()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[][] nums = new int[n][];
        for (int i = 0; i < n; i++)
        {
            nums[i] = new int[m];
        }
        int k = 1, I = 0, J = 0;
        int Up = 0, Down = 0, Left = 0, Right = 0;
        while (k <= n * m)
        {
            nums[I][J] = k;
            if (I == Up && J < m - Right - 1) { J++; }
            else if (I < n - Down - 1 && J == m - Right - 1) { I++; }
            else if (I == n - Down - 1 && J > Left) { J--; }
            else { I--; }

            if (I == Up + 1 && J == Left && Left != m - Right - 1)
            {
                Up++;
                Down++;
                Right++;
                Left++;
            }
            k++;

        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(nums[i][j]);

            }
            Console.WriteLine();
        }
    }

    static void FiveTask()
    {
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse (Console.ReadLine());
        Console.WriteLine("Введите Divide или Degree или Root");
        string input = Console.ReadLine();

        Enum.TryParse(input, out Operation j);
        
        
        double DoOperation(Operation op, int a, int b)
        {
            double k = 0;
            double result = op switch
            {
                Operation.Divide => k = a / b,
                Operation.Degree => k= Math.Pow(a, b),
                Operation.Root=> k=Math.Sqrt(a)
            };
            return k;
        }

        Console.WriteLine(DoOperation(j, a, b));
    }
    enum Operation
    {
        Divide,
        Degree,
        Root
    }
    
    static void PrintDevices(List<Device> D)
    {
        foreach(var device in D)
        {
            device.print();
            Console.WriteLine();
        }
    }
    static void SixTask()
    {
        List<Device> devices = new List<Device>();

        devices.Add(new Device("Philips", "h-123"));
        devices.Add(new Device("Honor", "Magicbook"));
        devices.Add(new Device("Lenovo", "Vivobook"));

        

        devices.Add(new PersonalComputer("Dell", "hfh32", 12, 33));
        devices.Add(new PersonalComputer("HP", "rtrt", 16, 128));
        devices.Add(new PersonalComputer("Xiaomi", "MI-2", 16, 512));

        PrintDevices(devices);
    }


    static void Main(string[] args)
    {
        string input;
        do
        {

            //FirstTask();
            //SecondTask();
            //ThirdTask();
            //FourTask();
            //FiveTask();
            SixTask();
            Console.WriteLine("Для выхода нажмите q, для продолжения любую другую клавишу");
            input = Console.ReadLine();
        } while (input != "q");
        

    }

}

