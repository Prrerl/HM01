namespace ConsoleApp4
{
    class Program
    {
        private static Random rnd = new Random();

        static double[,] tsk1()
        {

            Console.WriteLine("Задачка один");
            Console.Write($"Введите количество столбцов ");
            string temp = Console.ReadLine();
            int m = Convert.ToInt32(temp);


            Console.Write($"Введите количество строк ");
            temp = Console.ReadLine();
            int n = Convert.ToInt32(temp);
            double[,] arr = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-1000, 1000) * 0.1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            return arr;
        }


        static void tsk2()
        {
            double[,] arr = tsk1();

            Console.WriteLine("\nЗадачка два");
            Console.Write($"Введите Номер столбца, начиная с единицы ");
            string temp = Console.ReadLine();
            int m = Convert.ToInt32(temp);

            Console.Write($"Введите номер строки,  начиная с единицы ");
            temp = Console.ReadLine();
            int n = Convert.ToInt32(temp);
            try
                Console.WriteLine(arr[n-1, m-1]+ "\n");
            }
            //Если ловим ошибку выхода за границы массива, работает код из catсh
            catch (Exception) { Console.WriteLine("Таких координат нет\n"); }

        }

        static void tsk3()
        {


            Console.WriteLine("Задачка три");
            Console.Write($"Введите количество столбцов ");
            string temp = Console.ReadLine();
            int m = Convert.ToInt32(temp);


            Console.Write($"Введите количество строк ");
            temp = Console.ReadLine();
            int n = Convert.ToInt32(temp);
            int[,] arr = new int[n, m];

  
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum;
            double arf;
            for (int j = 0; j < m; j++)
            {
                sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + arr[i, j];
                }
                arf= (double)sum/n;
                Console.WriteLine("Среднее арифметическое столбца" + j+": "+arf);
            }

            Console.Read();
        }

        static void Main(string[] args)
        {

            tsk2();
            tsk3();
                      
        }
    }
}
