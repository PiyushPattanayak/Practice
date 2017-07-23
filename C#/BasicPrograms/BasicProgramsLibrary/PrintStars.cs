using System;
namespace BasicProgramsLibrary
{
    public class PrintStars
    {
        public void PrintSolidAndHollowBoxes()
        {
            Console.WriteLine("Enter the length of the box");
            int length = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Enter the width of the box");
			int width = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i ++)
            {
				Console.Write(new String('*', width)+ " ");
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == length-1 || j == 0 || j == width-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
