using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            Console.Write("input number box in first box : ");
            first = int.Parse(Console.ReadLine());
            int second;
            Console.Write("input number box in second box : ");
            second = int.Parse(Console.ReadLine());
            int third;
            Console.Write("input number box in third box : ");
            third = int.Parse(Console.ReadLine());
            int all = first + second + third;
            while (all > 0)
            {
                
                int Abox;
                Console.Write("Player A input Box number : ");
                Abox = int.Parse(Console.ReadLine());
                int Apick;
                Console.Write("input How many box Player A pick : ");
                Apick = int.Parse(Console.ReadLine());
                if (Abox == 1)
                {
                    if (Apick == 1)
                    {
                        first = first - 1;
                        all = all - 1;
                         if (all<=0)
                        {
                            Console.Write("Player B Win!");
                        }
                    }
                    if (Apick == 2)
                    {
                       first= first - 2;
                        all = all - 2;
                        if (all <= 0)
                        {
                            Console.Write("Player B Win!");
                        }
                    }
                }
                if (Abox == 2)
                {
                    if (Apick == 1)
                    {
                        second = second - 1;
                        all = all - 1;
                        if (all <= 0)
                        {
                            Console.Write("Player B Win!");
                        }
                    }
                    if (Apick == 2)
                    {
                        second = second - 2;
                        all = all - 2;
                        if (all <= 0)
                        {
                            Console.Write("Player B Win!");
                        }
                    }
                }
                if (Abox == 3)
                {
                    if (Apick == 1)
                    {
                        third = third - 1;
                        all = all - 1;
                        if (all <= 0)
                        {
                            Console.Write("Player B Win!");
                        }
                    }
                    if (Apick == 2)
                    {
                        third = third - 2;
                        all = all - 2;
                        if (all <= 0)
                        {
                            Console.Write("Player B Win!");
                        }
                    }
                }
                int Bbox;
                Console.Write("Player B input Box number : ");
                Bbox = int.Parse(Console.ReadLine());
                int Bpick;
                Console.Write("input How many box Player  pick : ");
                Bpick = int.Parse(Console.ReadLine());

                if (Bbox == 1)
                {
                    if (Bpick == 1)
                    {
                        first = first - 1;
                        all = all - 1;
                        if (all <= 0)
                        {
                            Console.Write("Player A Win!");
                        }
                    }
                    if (Bpick == 2)
                    {
                        first = first - 2;
                        all = all - 2;
                        if (all <= 0)
                        {
                            Console.Write("Player A Win!");
                        }
                    }
                }
                if (Bbox == 2)
                {
                    if (Bpick == 1)
                    {
                        second = second - 1;
                        all = all - 1;
                        if (all <= 0)
                        {
                            Console.Write("Player A Win!");
                        }
                    }
                    if (Bpick == 2)
                    {
                        second = second - 2;
                        all = all - 2;
                        if (all <= 0)
                        {
                            Console.Write("Player A Win!");
                        }
                    }
                }
                if (Bbox == 3)
                {
                    if (Bpick == 1)
                    {
                        third = third - 1;
                        all = all - 1;
                        if (all <= 0)
                        {
                            Console.Write("Player A Win!");
                        }
                    }
                    if (Bpick == 2)
                    {
                        third = third - 2;
                        all = all - 2;
                        if (all <= 0)
                        {
                            Console.Write("Player A Win!");
                        }
                    }
                }


            }
            Console.ReadLine();
        }
    }
}
