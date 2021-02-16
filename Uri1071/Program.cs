using System;

namespace Uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, maior, menor, impar;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            impar = 0;
            if(x>y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }

            for(int c=menor+1;c<maior;c++)
            {

                if(c%2!=0)
                {
                    impar =impar+c;
                }

            }

            Console.WriteLine(impar);

        }
    }
}
