namespace M2Task1GunelA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tasks tasks = new Tasks();

            ////***********1 - MAX MIN ARRAY******
            //int[] a = { 1, 2, 3, 4, 89, 1, 0, -7 };
            //int minOfArray, maxOfArray;

            //Tasks.GetMinMax(a, out maxOfArray, out minOfArray);
            //Console.WriteLine("Max= " + maxOfArray + "\nMin=" + minOfArray);


            //****** 2 - Average Double  type numbers

            double average = Tasks.AverageNumbers();
            Console.WriteLine(average);

            ////***********- 3- CALCULATE AGE IN DAYS - **********

            //Console.WriteLine("Dogum tarixi daxil edin (gun.ay.il): ");

            //DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("totaldays: " + Tasks.CalculateAgeInDays(birthDate));

            //Console.WriteLine(DateTime.Now.ToShortDateString());

            //// ******* 4 -GCD - *********
            ///
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Ebob({a},{b}) = {Tasks.FindEbob(a, b)}");

            //Console.WriteLine($"Ebob({a},{b}) = {Tasks.FindGcdEuclidian(a, b)}");



        }


    }

    internal class Tasks
    {
        // - Task 1
        public static void GetMinMax(int[] a, out int max, out int min)
        {
            max = a[0];
            min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }

                if (a[i] < min)
                {
                    min = a[i];
                }
            }
        }

        // - Task 2
        public static double AverageNumbers(params double[] a)
        {
            double sum = 0;
            if(a.Length==0)
            {
                return 0;
            }
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum / a.Length;
        }

        // - Task 3
        public static int CalculateAgeInDays(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan ts = currentDate - birthDate;

            return (int)ts.TotalDays;
        }

        // - Task 4
        public static int FindEbob(int a, int b)
        {
            int min = a; int max = b;
            if (b < a)
            {
                min = b;
                max = a;
            }
            int gcd = 1;
            for (int i = max; i > 0; i -= min)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
            return gcd;
        }

        // - Task 4.1
        public static void MinMaxOf2Numbers(int a, int b, out int max, out int min)
        {
            min = a; max = b;
            if (a > b)
            {
                max = a; 
                min = b;
            }
        }

        public static int FindGcdEuclidian(int a, int b)
        {
            int gcd = 1;
            MinMaxOf2Numbers(a, b, out int max1, out int min1);

            if (max1 % min1 == 0)
            {
                return min1;
            }
            while (gcd > 0)
            {
                gcd = max1 % min1;
                if (max1 % gcd == 0 && min1 % gcd == 0)
                {
                    break;
                }
            }
            return gcd;
        }

       
    }
}
