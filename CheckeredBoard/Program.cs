using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaurabhGuptaRepliconCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = 5;
            int rows = 5;
            int width = 5;
            int height = 5;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        for (int l = 0; l < width; l++)
                        {
                            char charToPrint = (i + k) % 2 == 0 ? 'x' : 'o';
                            Console.Write(charToPrint);
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
