using System;
namespace BasicProgramsLibrary
{
    public class MathOperations
    {

        public double SquareRoot()
        {
			System.Console.WriteLine("Enter the number you would like to find the square root for");
			double input = Convert.ToDouble(Console.ReadLine());

			System.Console.WriteLine("Enter the number of iterations you want for the square root approximation.");
			int numberOfIterations = Convert.ToInt32(Console.ReadLine());

            double value = input / 2;
            while(numberOfIterations-- > 0)
            {
                value = (value + (input / value)) / 2;
            }

            return value;
        }

		public bool IsPrimeInternal(int n)
		{
			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if ((n % i) == 0)
				{
					return false;
				}
			}

			return true;
		}

        public bool IsPrime()
        {
			System.Console.WriteLine("Enter the number you would like to check for being prime");
            int n = Convert.ToInt32(Console.ReadLine());
            return IsPrimeInternal(n);
        }

        public int GreatestPrimeFactor()
        {
			System.Console.WriteLine("Enter the number for which you would like to find the greatest prime factor");
			int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Given input is less than 2, and thus does not have any prime factors");
                return -1;
            }

            int greatestPrimeFactor = 2;


            for (int i = greatestPrimeFactor; i <= n; i++)
            {
                if ((n % i == 0) && IsPrimeInternal(i))
                {
                    greatestPrimeFactor = i;
                }
            }

            return greatestPrimeFactor;
        }

		public void PrintAllPrimesLessThanEqualTo()
		{
			System.Console.WriteLine("Enter the number upto which you want all the primes");
			int n = Convert.ToInt32(Console.ReadLine());

			if (n < 2)
			{
				Console.WriteLine(" Error: Given input is less than 2 which is the smallest prime number.");
			}

            int count = 0;
			int greatestPrimeFactor = 2;


			for (int i = greatestPrimeFactor; i <= n; i++)
			{
				if (IsPrimeInternal(i))
				{
                    count++;
					Console.WriteLine(i);
                }
			}
            Console.WriteLine($"Found a total of {count} prime numbers.");
        }
    }
}
